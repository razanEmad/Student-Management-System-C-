namespace hciProject
{
    partial class Frm_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnLogin = new Button();
            lblUser = new Label();
            txtUser = new TextBox();
            lblUserError = new Label();
            lblPass = new Label();
            txtPass = new TextBox();
            lblPassError = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.Control;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkSlateGray;
            lblTitle.Location = new Point(241, 34);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(330, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Student Management System";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Green;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(429, 289);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(142, 45);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(247, 136);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(75, 20);
            lblUser.TabIndex = 2;
            lblUser.Text = "Username";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(328, 133);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(232, 27);
            txtUser.TabIndex = 3;
            // 
            // lblUserError
            // 
            lblUserError.AutoSize = true;
            lblUserError.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserError.ForeColor = Color.Red;
            lblUserError.Location = new Point(363, 163);
            lblUserError.Name = "lblUserError";
            lblUserError.Size = new Size(134, 17);
            lblUserError.TabIndex = 4;
            lblUserError.Text = "Username is required";
            lblUserError.Visible = false;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(247, 199);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(70, 20);
            lblPass.TabIndex = 5;
            lblPass.Text = "Password";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(328, 199);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(232, 27);
            txtPass.TabIndex = 7;
            // 
            // lblPassError
            // 
            lblPassError.AutoSize = true;
            lblPassError.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassError.ForeColor = Color.Red;
            lblPassError.Location = new Point(363, 229);
            lblPassError.Name = "lblPassError";
            lblPassError.Size = new Size(131, 17);
            lblPassError.TabIndex = 8;
            lblPassError.Text = "Password is required";
            lblPassError.Visible = false;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(241, 289);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(139, 45);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(lblPassError);
            Controls.Add(txtPass);
            Controls.Add(lblPass);
            Controls.Add(lblUserError);
            Controls.Add(txtUser);
            Controls.Add(lblUser);
            Controls.Add(btnLogin);
            Controls.Add(lblTitle);
            Name = "Frm_Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnLogin;
        private Label lblUser;
        private TextBox txtUser;
        private Label lblUserError;
        private Label lblPass;
        private TextBox txtPass;
        private Label lblPassError;
        private Button btnExit;
    }
}
