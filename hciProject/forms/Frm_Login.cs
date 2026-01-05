using System;
using System.Data;
using System.Windows.Forms;
using hciProject.Data;

namespace hciProject
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("من فضلك ادخل اسم المستخدم وكلمة السر");
                return;
            }

            try
            {
                DBHelper db = new DBHelper();
                // 1. الاستعلام الأول: هل المستخدم موجود في جدول Users؟
                string sql = $"SELECT * FROM Users WHERE Username = '{txtUser.Text}' AND PasswordHash = '{txtPass.Text}'";
                DataTable dtUser = db.ExecuteQuery(sql);

                if (dtUser.Rows.Count > 0)
                {
                    // المستخدم موجود.. تعال نسجل بياناته في السيشن
                    ProgramSession.UserId = Convert.ToInt32(dtUser.Rows[0]["UserID"]);
                    ProgramSession.Role = dtUser.Rows[0]["Role"].ToString();

                    if (ProgramSession.Role == "Student")
                    {
                        // === هنا الحل بتاعك ===

                        // أ) جبنا رقم الطالب من جدول اليوزرز
                        int linkedId = Convert.ToInt32(dtUser.Rows[0]["LinkedStudentID"]);
                        ProgramSession.StudentId = linkedId;

                        // ب) نعمل استعلام تاني سريع يروح جدول Students يجيب الاسم
                        string nameQuery = $"SELECT FullName FROM Students WHERE StudentID = {linkedId}";
                        DataTable dtStudent = db.ExecuteQuery(nameQuery);

                        if (dtStudent.Rows.Count > 0)
                        {
                            // ج) تخزين الاسم الحقيقي في السيشن
                            ProgramSession.StudentName = dtStudent.Rows[0]["FullName"].ToString();
                        }

                        // د) فتح الفورم (لاحظ الأقواس فاضية لأننا خنا الاسم في السيشن خلاص)
                        Frm_StudentDashboard frm = new Frm_StudentDashboard();
                        frm.Show();
                    }
                    else // Admin
                    {
                        Frm_AdminDashboard frm = new Frm_AdminDashboard();
                        frm.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("بيانات الدخول غير صحيحة");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء محاولة تسجيل الدخول: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
