using System;
using System.Data;
using System.Windows.Forms;
using hciProject.Data; // عشان يشوف DBHelper

namespace hciProject
{
    public partial class Frm_Grading : Form
    {
        public Frm_Grading()
        {
            InitializeComponent();

            // هنجبر الدوال دي تشتغل هنا يدوياً بدل ما نعتمد على الـ Load Event
            SetupDataGridView();
            LoadStudentsCombo();
        }

        // 1. أول ما الصفحة تحمل، نجهز الجدول ونملأ قائمة الطلاب
        private void Frm_Grading_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadStudentsCombo(); // دالة جديدة لملء الطلاب من الداتا بيز
        }

        private void SetupDataGridView()
        {
            // هنخلي الجدول فاضي في الأول ومجهز
            dgvStudentCourses.Columns.Clear();
            dgvStudentCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudentCourses.AllowUserToAddRows = false;
        }

        // 2. دالة لجلب أسماء الطلاب من الداتا بيز
        private void LoadStudentsCombo()
        {
            try
            {
                DBHelper db = new DBHelper();
                // بنجيب الاسم والـ ID عشان لما نختار الاسم نعرف هو مين بالظبط
                string sql = "SELECT StudentID, FullName FROM Students";
                DataTable dt = db.ExecuteQuery(sql);
                       
                // ربط الكومبو بوكس بالداتا
                cmbSelectStudent.DataSource = dt;
                cmbSelectStudent.DisplayMember = "FullName"; // اللي هيظهر
                cmbSelectStudent.ValueMember = "StudentID";  // القيمة المخفية

                // نخلي الاختيار فاضي في الأول
                cmbSelectStudent.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message);
            }
        }

        // 3. لما نختار طالب، نعرض المواد اللي هو مسجلها
        private void cmbSelectStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            // لو مفيش حاجة مختارة أو الاختيار مش رقم، اخرج
            if (cmbSelectStudent.SelectedIndex == -1 || cmbSelectStudent.SelectedValue == null)
                return;

            // حماية عشان أول ما الفورم بتفتح الحدث ده بيشتغل لوحده
            int studentId;
            bool isNumber = int.TryParse(cmbSelectStudent.SelectedValue.ToString(), out studentId);
            if (!isNumber) return;

            LoadStudentCourses(studentId);
        }

        private void LoadStudentCourses(int studentId)
        {
            DBHelper db = new DBHelper();

            // جملة ذكية: بتجيب اسم المادة والدرجة الحالية، ورقم المادة (مخفي)
            // بنعمل JOIN بين جدول التسجيل (Enrollments) وجدول المواد (Courses)
            string sql = $@"SELECT 
                                C.CourseID, 
                                C.CourseName, 
                                E.CourseGrade 
                            FROM Enrollments E
                            JOIN Courses C ON E.CourseID = C.CourseID
                            WHERE E.StudentID = {studentId}";

            DataTable dt = db.ExecuteQuery(sql);
            dgvStudentCourses.DataSource = dt;

            // تظبيط شكل الجدول
            if (dgvStudentCourses.Columns.Contains("CourseID"))
                dgvStudentCourses.Columns["CourseID"].Visible = false; // نخفي الـ ID

            if (dgvStudentCourses.Columns.Contains("CourseName"))
            {
                dgvStudentCourses.Columns["CourseName"].ReadOnly = true; // نمنع تغيير اسم المادة
                dgvStudentCourses.Columns["CourseName"].HeaderText = "Subject";
            }

            if (dgvStudentCourses.Columns.Contains("CourseGrade"))
                dgvStudentCourses.Columns["CourseGrade"].HeaderText = "Grade (Enter here)";
        }

        // 4. زرار حفظ الدرجات
        private void btnSaveGrades_Click(object sender, EventArgs e)
        {
            if (cmbSelectStudent.SelectedValue == null) return;

            int studentId = Convert.ToInt32(cmbSelectStudent.SelectedValue);
            DBHelper db = new DBHelper();
            int count = 0;

            // نلف على سطر سطر في الجدول
            foreach (DataGridViewRow row in dgvStudentCourses.Rows)
            {
                // نتأكد إن السطر فيه بيانات
                if (row.Cells["CourseID"].Value != null)
                {
                    string courseId = row.Cells["CourseID"].Value.ToString();
                    string gradeValue = "NULL"; // القيمة الافتراضية

                    // لو الأدمن كتب درجة، نستخدمها
                    if (row.Cells["CourseGrade"].Value != null &&
                        !string.IsNullOrWhiteSpace(row.Cells["CourseGrade"].Value.ToString()))
                    {
                        gradeValue = row.Cells["CourseGrade"].Value.ToString();
                    }

                    // تحديث الدرجة في الداتا بيز
                    string sql = $@"UPDATE Enrollments 
                                    SET CourseGrade = {gradeValue} 
                                    WHERE StudentID = {studentId} AND CourseID = {courseId}";

                    db.ExecuteNonQuery(sql);
                    count++;
                }
            }

            MessageBox.Show($"Done! Grades saved/updated for {count} courses.");
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Grading_Load_1(object sender, EventArgs e)
        {

        }
    }
}