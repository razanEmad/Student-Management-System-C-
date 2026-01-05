namespace hciProject
{
    partial class Frm_AddEditStudent
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
            lblName = new Label();
            txtName = new TextBox();
            lblNameError = new Label();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblAddressError = new Label();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblPhoneError = new Label();
            lblDepartment = new Label();
            cmbDepartment = new ComboBox();
            lblDepartmentError = new Label();
            lblLevel = new Label();
            cmbLevel = new ComboBox();
            lblLevelError = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblUsernameError = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblPasswordError = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(51, 53);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(170, 45);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(243, 31);
            txtName.TabIndex = 1;
            // 
            // lblNameError
            // 
            lblNameError.AutoSize = true;
            lblNameError.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNameError.ForeColor = Color.Red;
            lblNameError.Location = new Point(189, 83);
            lblNameError.Margin = new Padding(4, 0, 4, 0);
            lblNameError.Name = "lblNameError";
            lblNameError.Size = new Size(123, 20);
            lblNameError.TabIndex = 2;
            lblNameError.Text = "Name is required";
            lblNameError.Visible = false;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(51, 127);
            lblAddress.Margin = new Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(77, 25);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(170, 127);
            txtAddress.Margin = new Padding(4, 3, 4, 3);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(243, 31);
            txtAddress.TabIndex = 4;
            // 
            // lblAddressError
            // 
            lblAddressError.AutoSize = true;
            lblAddressError.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddressError.ForeColor = Color.Red;
            lblAddressError.Location = new Point(189, 163);
            lblAddressError.Margin = new Padding(4, 0, 4, 0);
            lblAddressError.Name = "lblAddressError";
            lblAddressError.Size = new Size(136, 20);
            lblAddressError.TabIndex = 5;
            lblAddressError.Text = "Address is required";
            lblAddressError.Visible = false;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(51, 212);
            lblPhone.Margin = new Padding(4, 0, 4, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(62, 25);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(170, 207);
            txtPhone.Margin = new Padding(4, 3, 4, 3);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(243, 31);
            txtPhone.TabIndex = 7;
            // 
            // lblPhoneError
            // 
            lblPhoneError.AutoSize = true;
            lblPhoneError.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneError.ForeColor = Color.Red;
            lblPhoneError.Location = new Point(189, 245);
            lblPhoneError.Margin = new Padding(4, 0, 4, 0);
            lblPhoneError.Name = "lblPhoneError";
            lblPhoneError.Size = new Size(124, 20);
            lblPhoneError.TabIndex = 8;
            lblPhoneError.Text = "Phone is required";
            lblPhoneError.Visible = false;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(51, 297);
            lblDepartment.Margin = new Padding(4, 0, 4, 0);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(107, 25);
            lblDepartment.TabIndex = 9;
            lblDepartment.Text = "Department";
            // 
            // cmbDepartment
            // 
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(163, 297);
            cmbDepartment.Margin = new Padding(4, 3, 4, 3);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(251, 33);
            cmbDepartment.TabIndex = 10;
            // 
            // lblDepartmentError
            // 
            lblDepartmentError.AutoSize = true;
            lblDepartmentError.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDepartmentError.ForeColor = Color.Red;
            lblDepartmentError.Location = new Point(170, 335);
            lblDepartmentError.Margin = new Padding(4, 0, 4, 0);
            lblDepartmentError.Name = "lblDepartmentError";
            lblDepartmentError.Size = new Size(163, 20);
            lblDepartmentError.TabIndex = 11;
            lblDepartmentError.Text = "Department is required";
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Location = new Point(51, 385);
            lblLevel.Margin = new Padding(4, 0, 4, 0);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(51, 25);
            lblLevel.TabIndex = 12;
            lblLevel.Text = "Level";
            // 
            // cmbLevel
            // 
            cmbLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLevel.FormattingEnabled = true;
            cmbLevel.Location = new Point(163, 385);
            cmbLevel.Margin = new Padding(4, 3, 4, 3);
            cmbLevel.Name = "cmbLevel";
            cmbLevel.Size = new Size(251, 33);
            cmbLevel.TabIndex = 13;
            // 
            // lblLevelError
            // 
            lblLevelError.AutoSize = true;
            lblLevelError.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLevelError.ForeColor = Color.Red;
            lblLevelError.Location = new Point(189, 423);
            lblLevelError.Margin = new Padding(4, 0, 4, 0);
            lblLevelError.Name = "lblLevelError";
            lblLevelError.Size = new Size(117, 20);
            lblLevelError.TabIndex = 14;
            lblLevelError.Text = "Level is required";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(484, 173);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 25);
            lblUsername.TabIndex = 15;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(597, 168);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(254, 31);
            txtUsername.TabIndex = 16;
            // 
            // lblUsernameError
            // 
            lblUsernameError.AutoSize = true;
            lblUsernameError.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsernameError.ForeColor = Color.Red;
            lblUsernameError.Location = new Point(610, 207);
            lblUsernameError.Margin = new Padding(4, 0, 4, 0);
            lblUsernameError.Name = "lblUsernameError";
            lblUsernameError.Size = new Size(149, 20);
            lblUsernameError.TabIndex = 17;
            lblUsernameError.Text = "Username is required";
            lblUsernameError.Visible = false;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(484, 248);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 18;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(597, 245);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(254, 31);
            txtPassword.TabIndex = 19;
            // 
            // lblPasswordError
            // 
            lblPasswordError.AutoSize = true;
            lblPasswordError.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPasswordError.ForeColor = Color.Red;
            lblPasswordError.Location = new Point(610, 283);
            lblPasswordError.Margin = new Padding(4, 0, 4, 0);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(144, 20);
            lblPasswordError.TabIndex = 20;
            lblPasswordError.Text = "Password is required";
            lblPasswordError.Visible = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Location = new Point(546, 397);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(127, 46);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(722, 397);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(127, 46);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // Frm_AddEditStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 563);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblPasswordError);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUsernameError);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblLevelError);
            Controls.Add(cmbLevel);
            Controls.Add(lblLevel);
            Controls.Add(lblDepartmentError);
            Controls.Add(cmbDepartment);
            Controls.Add(lblDepartment);
            Controls.Add(lblPhoneError);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(lblAddressError);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(lblNameError);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Frm_AddEditStudent";
            Text = "Add and Edit Student";
            Load += Frm_AddEditStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Label lblNameError;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblAddressError;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblPhoneError;
        private Label lblDepartment;
        private ComboBox cmbDepartment;
        private Label lblDepartmentError;
        private Label lblLevel;
        private ComboBox cmbLevel;
        private Label lblLevelError;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblUsernameError;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblPasswordError;
        private Button btnSave;
        private Button btnCancel;
    }
}