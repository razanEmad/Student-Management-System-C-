using System;
using System.Data;
using System.Windows.Forms;
using hciProject.Data; // تأكد إن المسار ده صح

namespace hciProject
{
    public partial class Frm_AddEditStudent : Form
    {
        // متغير عشان نعرف إحنا بنضيف (0) ولا بنعدل (رقم الطالب)
        public int CurrentStudentId = 0;

        public Frm_AddEditStudent()
        {
            InitializeComponent();
        }

        // كونستركتور إضافي عشان نقبل رقم الطالب في حالة التعديل
        public Frm_AddEditStudent(int studentId)
        {
            InitializeComponent();
            CurrentStudentId = studentId;
        }

        private void Frm_AddEditStudent_Load(object sender, EventArgs e)
        {
            // 1. تجهيز القوائم
            cmbDepartment.Items.Clear();
            cmbDepartment.Items.AddRange(new object[] { "CS", "IS", "AI", "IT", "MM", "SE", "BIO" });

            cmbLevel.Items.Clear();
            cmbLevel.Items.AddRange(new object[] { "1", "2", "3", "4" });

            // 2. لو الرقم أكبر من صفر، يبقى ده تعديل -> حمل البيانات
            if (CurrentStudentId > 0)
            {
                this.Text = "Edit Student";
                btnSave.Text = "Update";
                LoadStudentData();
            }
            else
            {
                // وضع إضافة جديد
                cmbDepartment.SelectedIndex = -1;
                cmbLevel.SelectedIndex = -1;

                // إخفاء رسائل الخطأ لو موجودة
                if (Controls.ContainsKey("lblDepartmentError")) Controls["lblDepartmentError"].Visible = false;
                if (Controls.ContainsKey("lblLevelError")) Controls["lblLevelError"].Visible = false;
            }
        }

        private void LoadStudentData()
        {
            try
            {
                DBHelper db = new DBHelper();
                // نجيب بيانات الطالب واليوزر
                string sql = $@"SELECT S.*, U.Username, U.PasswordHash 
                                FROM Students S 
                                LEFT JOIN Users U ON U.LinkedStudentID = S.StudentID 
                                WHERE S.StudentID = {CurrentStudentId}";

                DataTable dt = db.ExecuteQuery(sql);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtName.Text = row["FullName"].ToString();
                    txtAddress.Text = row["Address"].ToString();
                    txtPhone.Text = row["Phone"].ToString();

                    if (row["Department"] != DBNull.Value) cmbDepartment.Text = row["Department"].ToString();
                    if (row["CurrentLevel"] != DBNull.Value) cmbLevel.Text = row["CurrentLevel"].ToString();

                    if (row["Username"] != DBNull.Value) txtUsername.Text = row["Username"].ToString();
                    if (row["PasswordHash"] != DBNull.Value) txtPassword.Text = row["PasswordHash"].ToString();

                    // نقفل اليوزر نيم عشان ميتغيرش (اختياري)
                    txtUsername.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // التحقق من البيانات
            if (txtName.Text == "" || cmbDepartment.SelectedIndex == -1 || cmbLevel.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill Name, Department, and Level.");
                return;
            }

            try
            {
                DBHelper db = new DBHelper();
                // نستخدم الدالة المساعدة عشان نجيب رقم القسم
                int deptId = GetDeptId(cmbDepartment.Text);

                if (CurrentStudentId == 0)
                {
                    // === حالة الإضافة (INSERT) ===
                    // لاحظ استخدام @ قبل السترينج عشان نكتب على كذا سطر براحتنا
                    string insertStudent = $@"
                        INSERT INTO Students (FullName, Address, Phone, Department, CurrentLevel, DeptID) 
                        VALUES ('{txtName.Text}', '{txtAddress.Text}', '{txtPhone.Text}', '{cmbDepartment.Text}', {cmbLevel.Text}, {deptId});
                        SELECT SCOPE_IDENTITY();";

                    DataTable dt = db.ExecuteQuery(insertStudent);
                    if (dt.Rows.Count > 0)
                    {
                        int newId = Convert.ToInt32(dt.Rows[0][0]);
                        string insertUser = $"INSERT INTO Users (Username, PasswordHash, Role, LinkedStudentID) VALUES ('{txtUsername.Text}', '{txtPassword.Text}', 'Student', {newId})";
                        db.ExecuteNonQuery(insertUser);

                        MessageBox.Show("Student Added Successfully!");
                    }
                }
                else
                {
                    // === حالة التعديل (UPDATE) ===
                    string updateStudent = $@"
                        UPDATE Students 
                        SET FullName='{txtName.Text}', 
                            Address='{txtAddress.Text}', 
                            Phone='{txtPhone.Text}', 
                            Department='{cmbDepartment.Text}', 
                            CurrentLevel={cmbLevel.Text}, 
                            DeptID={deptId}
                        WHERE StudentID={CurrentStudentId}";

                    db.ExecuteNonQuery(updateStudent);

                    // تحديث الباسورد لو اتغيرت
                    string updateUser = $"UPDATE Users SET PasswordHash='{txtPassword.Text}' WHERE LinkedStudentID={CurrentStudentId}";
                    db.ExecuteNonQuery(updateUser);

                    MessageBox.Show("Student Updated Successfully!");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ✅ دي الدالة اللي كانت ناقصة عندك
        private int GetDeptId(string deptName)
        {
            switch (deptName)
            {
                case "CS": return 1;
                case "IS": return 2;
                case "AI": return 3;
                case "IT": return 4;
                case "MM": return 5;
                case "SE": return 6;
                case "BIO": return 7;
                default: return 1;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}