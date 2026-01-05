using System;
using System.Data;
using System.Windows.Forms;
using hciProject.Data;

namespace hciProject
{
    public partial class Frm_Transcript : Form
    {
        public Frm_Transcript()
        {
            InitializeComponent();
            LoadTranscript();
        }

        private void LoadTranscript()
        {
            try
            {
                DBHelper db = new DBHelper();
                int studentId = ProgramSession.StudentId;

                string sql = $@"
            SELECT 
                C.CourseID AS 'Code', 
                C.CourseName AS 'Subject', 
                E.AcademicYear AS 'Year', 
                E.Semester AS 'Semester', 
                C.CreditHours AS 'Credits', 
                E.CourseGrade AS 'Score'
            FROM Enrollments E
            INNER JOIN Courses C ON E.CourseID = C.CourseID
            WHERE E.StudentID = {studentId} AND E.CourseGrade IS NOT NULL";

                DataTable dt = db.ExecuteQuery(sql);
                dgvTranscript.DataSource = dt;

                // === الإضافات الجديدة هنا ===
                dgvTranscript.ReadOnly = true;              // ممنوع التعديل
                dgvTranscript.AllowUserToAddRows = false;   // إخفاء السطر الفاضي الأخير
                dgvTranscript.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                CalculateGPA(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transcript: " + ex.Message);
            }
        }
        // دالة تحويل الدرجة المئوية إلى نقاط (GPA Points)
        private double GetGPAPoints(double score)
        {
            if (score >= 96) return 4.00; // A+
            if (score >= 92) return 3.70; // A
            if (score >= 88) return 3.40; // A-
            if (score >= 84) return 3.20; // B+
            if (score >= 80) return 3.00; // B
            if (score >= 76) return 2.80; // B-
            if (score >= 72) return 2.60; // C+
            if (score >= 68) return 2.40; // C
            if (score >= 64) return 2.20; // C-
            if (score >= 60) return 2.00; // D+
            if (score >= 55) return 1.50; // D
            if (score >= 50) return 1.00; // D-
            return 0.00;                  // F
        }

        private void CalculateGPA(DataTable dt)
        {
            double totalPoints = 0;
            double totalHours = 0;

            foreach (DataRow row in dt.Rows)
            {
                // نتأكد إن البيانات مش فاضية
                if (row["Score"] != DBNull.Value && row["Credits"] != DBNull.Value)
                {
                    double score = Convert.ToDouble(row["Score"]);
                    int credits = Convert.ToInt32(row["Credits"]);

                    // نحسب النقاط بناءً على الدالة اللي فوق
                    double points = GetGPAPoints(score);

                    totalPoints += (points * credits);
                    totalHours += credits;
                }
            }

            if (totalHours > 0)
            {
                double gpa = totalPoints / totalHours;
                lblTotalGPA.Text = "Total GPA: " + gpa.ToString("0.00");
            }
            else
            {
                lblTotalGPA.Text = "Total GPA: 0.00";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // دالة فارغة لتجنب أخطاء التصميم
        }

        private void lblTotalGPA_Click(object sender, EventArgs e)
        {

        }
    }
}