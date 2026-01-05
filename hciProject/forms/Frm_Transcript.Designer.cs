namespace hciProject
{
    partial class Frm_Transcript
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
            dgvTranscript = new DataGridView();
            lblTotalGPA = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTranscript).BeginInit();
            SuspendLayout();
            // 
            // dgvTranscript
            // 
            dgvTranscript.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTranscript.Location = new Point(12, 86);
            dgvTranscript.Name = "dgvTranscript";
            dgvTranscript.ReadOnly = true;
            dgvTranscript.RowHeadersWidth = 51;
            dgvTranscript.Size = new Size(776, 328);
            dgvTranscript.TabIndex = 0;
            dgvTranscript.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblTotalGPA
            // 
            lblTotalGPA.AutoSize = true;
            lblTotalGPA.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalGPA.Location = new Point(12, 30);
            lblTotalGPA.Name = "lblTotalGPA";
            lblTotalGPA.Size = new Size(124, 31);
            lblTotalGPA.TabIndex = 1;
            lblTotalGPA.Text = "Total GPA:";
            lblTotalGPA.Click += lblTotalGPA_Click;
            // 
            // Frm_Transcript
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(lblTotalGPA);
            Controls.Add(dgvTranscript);
            Name = "Frm_Transcript";
            Text = "Transcript";
            ((System.ComponentModel.ISupportInitialize)dgvTranscript).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTranscript;
        private Label lblTotalGPA;
    }
}