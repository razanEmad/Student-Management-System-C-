using System;
using System.Windows.Forms;

namespace hciProject
{
    public partial class Frm_AdminDashboard : Form
    {
        public Frm_AdminDashboard()
        {
            InitializeComponent();
            btnManageStudents.Click += btnManageStudents_Click;
            btnGrading.Click += btnGrading_Click;
            btnLogout.Click += btnLogout_Click;
        }

        private void Frm_AdminDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome Admin";
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            this.Hide();

            Frm_ManageStudents f = new Frm_ManageStudents();
            f.ShowDialog();

            this.Show();
        }

        private void btnGrading_Click(object sender, EventArgs e)
        {
            this.Hide();

            Frm_Grading f = new Frm_Grading();
            f.ShowDialog();

            this.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Frm_Login f = new Frm_Login();
            f.Show();

            this.Close();
        }

        private void Frm_AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
