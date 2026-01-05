using hciProject.Data;
using System;
using System.Windows.Forms;

namespace hciProject
{
    public partial class Frm_StudentDashboard : Form
    {
        public Frm_StudentDashboard()
        {
            InitializeComponent();
            // Ensure Load handler is attached in case designer doesn't wire it
            this.Load += Frm_StudentDashboard_Load;
        }

        private void Frm_StudentDashboard_Load(object sender, EventArgs e)
        {
            // Display the student's name stored in the session
            lblWelcome.Text = "Welcome " + ProgramSession.StudentName;
        }

        private void btnRegisterCourses_Click(object sender, EventArgs e)
        {
            this.Hide();

            Frm_CourseRegistration frm = new Frm_CourseRegistration();
            frm.ShowDialog();

            this.Show();
        }

        private void btnTranscript_Click(object sender, EventArgs e)
        {
            this.Hide();

            Frm_Transcript frm = new Frm_Transcript();
            frm.ShowDialog();

            this.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Frm_Login frm = new Frm_Login();
            frm.Show();
            this.Close();
        }

        private void Frm_StudentDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
