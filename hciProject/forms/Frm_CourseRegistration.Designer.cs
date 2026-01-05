namespace hciProject
{
    partial class Frm_CourseRegistration
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
            lblYear = new Label();
            cmbYear = new ComboBox();
            lblSemester = new Label();
            cmbSemester = new ComboBox();
            dgvCourses = new DataGridView();
            btnConfirm = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            SuspendLayout();
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(253, 45);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(37, 20);
            lblYear.TabIndex = 0;
            lblYear.Text = "Year";
            // 
            // cmbYear
            // 
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new Point(348, 42);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(212, 28);
            cmbYear.TabIndex = 1;
            cmbYear.SelectedIndexChanged += cmbSemester_SelectedIndexChanged;
            // 
            // lblSemester
            // 
            lblSemester.AutoSize = true;
            lblSemester.Location = new Point(253, 115);
            lblSemester.Name = "lblSemester";
            lblSemester.Size = new Size(70, 20);
            lblSemester.TabIndex = 2;
            lblSemester.Text = "Semester";
            // 
            // cmbSemester
            // 
            cmbSemester.FormattingEnabled = true;
            cmbSemester.Items.AddRange(new object[] { "First", "Second" });
            cmbSemester.Location = new Point(348, 111);
            cmbSemester.Name = "cmbSemester";
            cmbSemester.Size = new Size(212, 28);
            cmbSemester.TabIndex = 3;
            cmbSemester.SelectedIndexChanged += cmbSemester_SelectedIndexChanged;
            // 
            // dgvCourses
            // 
            dgvCourses.AccessibleName = "";
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourses.Location = new Point(12, 166);
            dgvCourses.Name = "dgvCourses";
            dgvCourses.RowHeadersWidth = 51;
            dgvCourses.Size = new Size(776, 293);
            dgvCourses.TabIndex = 4;
            dgvCourses.CellContentClick += dgvAvailableCourses_CellContentClick;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Green;
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(303, 495);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(196, 58);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "Confirm Registration";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // Frm_CourseRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 584);
            Controls.Add(btnConfirm);
            Controls.Add(dgvCourses);
            Controls.Add(cmbSemester);
            Controls.Add(lblSemester);
            Controls.Add(cmbYear);
            Controls.Add(lblYear);
            Name = "Frm_CourseRegistration";
            Text = "Course Registration";
            Load += Frm_CourseRegistration_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblYear;
        private ComboBox cmbYear;
        private Label lblSemester;
        private ComboBox cmbSemester;
        private DataGridView dgvCourses;
        private Button btnConfirm;
    }
}