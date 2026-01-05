namespace hciProject
{
    partial class Frm_AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcome = new Label();
            btnManageStudents = new Button();
            btnGrading = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.Black;
            lblWelcome.Location = new Point(245, 29);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(234, 38);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome Admin";
            // 
            // btnManageStudents
            // 
            btnManageStudents.BackColor = Color.DarkSlateGray;
            btnManageStudents.ForeColor = SystemColors.Control;
            btnManageStudents.Location = new Point(301, 134);
            btnManageStudents.Margin = new Padding(4, 3, 4, 3);
            btnManageStudents.Name = "btnManageStudents";
            btnManageStudents.Size = new Size(376, 115);
            btnManageStudents.TabIndex = 1;
            btnManageStudents.Text = "Manage Students";
            btnManageStudents.UseVisualStyleBackColor = false;
            // 
            // btnGrading
            // 
            btnGrading.BackColor = Color.DarkSlateGray;
            btnGrading.ForeColor = SystemColors.Control;
            btnGrading.Location = new Point(301, 280);
            btnGrading.Margin = new Padding(4, 3, 4, 3);
            btnGrading.Name = "btnGrading";
            btnGrading.Size = new Size(376, 115);
            btnGrading.TabIndex = 2;
            btnGrading.Text = "Grading";
            btnGrading.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.ForeColor = Color.Red;
            btnLogout.Location = new Point(791, 453);
            btnLogout.Margin = new Padding(4, 3, 4, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(134, 47);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // Frm_AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 563);
            Controls.Add(btnLogout);
            Controls.Add(btnGrading);
            Controls.Add(btnManageStudents);
            Controls.Add(lblWelcome);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Frm_AdminDashboard";
            Text = "Admin Dashboard";
            FormClosed += Frm_AdminDashboard_FormClosed;
            Load += Frm_AdminDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnManageStudents;
        private Button btnGrading;
        private Button btnLogout;
    }
}