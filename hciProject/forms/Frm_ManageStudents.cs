using System;
using System.Data;
using System.Windows.Forms;
using hciProject.Data;

namespace hciProject
{
    public partial class Frm_ManageStudents : Form
    {
        public Frm_ManageStudents()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            DBHelper db = new DBHelper();
            string sql = @"SELECT S.StudentID, S.FullName, S.Department, S.CurrentLevel, U.Username 
                           FROM Students S 
                           LEFT JOIN Users U ON U.LinkedStudentID = S.StudentID";

            dgvStudents.DataSource = db.ExecuteQuery(sql);
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // زر إضافة (بيفتح الشاشة بـ ID = 0)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Frm_AddEditStudent f = new Frm_AddEditStudent(0);
            f.ShowDialog();
            LoadStudents(); // تحديث الجدول بعد ما يرجع
        }

        // زر تعديل (بيفتح الشاشة بـ ID الطالب المختار)
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                // نجيب رقم الطالب من الجدول
                int studentId = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["StudentID"].Value);

                // نبعته للشاشة
                Frm_AddEditStudent f = new Frm_AddEditStudent(studentId);
                f.ShowDialog();

                LoadStudents(); // تحديث بعد التعديل
            }
            else
            {
                MessageBox.Show("Please select a student first.");
            }
        }

        // زر حذف
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        int studentId = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["StudentID"].Value);
                        DBHelper db = new DBHelper();

                        // لازم نمسح بالترتيب عشان العلاقات (Foreign Keys)
                        // 1. نمسح اليوزر
                        db.ExecuteNonQuery($"DELETE FROM Users WHERE LinkedStudentID = {studentId}");
                        // 2. نمسح درجاته وتسجيلاته
                        db.ExecuteNonQuery($"DELETE FROM Enrollments WHERE StudentID = {studentId}");
                        // 3. نمسح الطالب نفسه
                        db.ExecuteNonQuery($"DELETE FROM Students WHERE StudentID = {studentId}");

                        MessageBox.Show("Deleted Successfully.");
                        LoadStudents();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student first.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DBHelper db = new DBHelper();
                string searchText = txtSearch.Text.Trim(); // النص اللي كتبته

                if (string.IsNullOrEmpty(searchText))
                {
                    LoadStudents();
                    return;
                }

                string sql = $@"SELECT S.StudentID, S.FullName, S.Department, S.CurrentLevel, U.Username 
                        FROM Students S 
                        LEFT JOIN Users U ON U.LinkedStudentID = S.StudentID
                        WHERE S.FullName LIKE '%{searchText}%' 
                           OR U.Username LIKE '%{searchText}%'";

                DataTable dt = db.ExecuteQuery(sql);
                dgvStudents.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching: " + ex.Message);
            }
        }
    }
}