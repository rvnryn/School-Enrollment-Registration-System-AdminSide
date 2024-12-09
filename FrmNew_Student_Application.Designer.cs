namespace CourseManagament
{
    partial class FrmNew_Student_Application
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
            this.Lbl_Student = new System.Windows.Forms.Label();
            this.dataGridView_Student = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Top_Panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Btn_Reject = new System.Windows.Forms.Button();
            this.Btn_Approve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Student)).BeginInit();
            this.Top_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Student
            // 
            this.Lbl_Student.AutoSize = true;
            this.Lbl_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Student.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Lbl_Student.Location = new System.Drawing.Point(92, 119);
            this.Lbl_Student.Name = "Lbl_Student";
            this.Lbl_Student.Size = new System.Drawing.Size(282, 31);
            this.Lbl_Student.TabIndex = 66;
            this.Lbl_Student.Text = "Student Applications";
            // 
            // dataGridView_Student
            // 
            this.dataGridView_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Student.Location = new System.Drawing.Point(188, 183);
            this.dataGridView_Student.Name = "dataGridView_Student";
            this.dataGridView_Student.Size = new System.Drawing.Size(1104, 453);
            this.dataGridView_Student.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(533, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Student Application";
            // 
            // Top_Panel
            // 
            this.Top_Panel.BackColor = System.Drawing.Color.White;
            this.Top_Panel.Controls.Add(this.label1);
            this.Top_Panel.Controls.Add(this.pictureBox1);
            this.Top_Panel.Location = new System.Drawing.Point(1, 1);
            this.Top_Panel.Name = "Top_Panel";
            this.Top_Panel.Size = new System.Drawing.Size(1542, 102);
            this.Top_Panel.TabIndex = 65;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseManagament.Properties.Resources.STIpage;
            this.pictureBox1.Location = new System.Drawing.Point(51, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Back
            // 
            this.Btn_Back.BackColor = System.Drawing.Color.White;
            this.Btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Back.ForeColor = System.Drawing.Color.Black;
            this.Btn_Back.Location = new System.Drawing.Point(29, 754);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(105, 30);
            this.Btn_Back.TabIndex = 71;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = false;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Btn_Reject
            // 
            this.Btn_Reject.BackColor = System.Drawing.Color.White;
            this.Btn_Reject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Reject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Reject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reject.ForeColor = System.Drawing.Color.Black;
            this.Btn_Reject.Location = new System.Drawing.Point(728, 652);
            this.Btn_Reject.Name = "Btn_Reject";
            this.Btn_Reject.Size = new System.Drawing.Size(239, 38);
            this.Btn_Reject.TabIndex = 73;
            this.Btn_Reject.Text = "Reject Application";
            this.Btn_Reject.UseVisualStyleBackColor = false;
            this.Btn_Reject.Click += new System.EventHandler(this.Btn_Reject_Click);
            // 
            // Btn_Approve
            // 
            this.Btn_Approve.BackColor = System.Drawing.Color.White;
            this.Btn_Approve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Approve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Approve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Approve.ForeColor = System.Drawing.Color.Black;
            this.Btn_Approve.Location = new System.Drawing.Point(483, 652);
            this.Btn_Approve.Name = "Btn_Approve";
            this.Btn_Approve.Size = new System.Drawing.Size(239, 38);
            this.Btn_Approve.TabIndex = 72;
            this.Btn_Approve.Text = "Approve Application";
            this.Btn_Approve.UseVisualStyleBackColor = false;
            this.Btn_Approve.Click += new System.EventHandler(this.Btn_Approve_Click);
            // 
            // FrmNew_Student_Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 805);
            this.Controls.Add(this.Btn_Reject);
            this.Controls.Add(this.Btn_Approve);
            this.Controls.Add(this.Lbl_Student);
            this.Controls.Add(this.dataGridView_Student);
            this.Controls.Add(this.Top_Panel);
            this.Controls.Add(this.Btn_Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmNew_Student_Application";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNew_Student_Application";
            this.Load += new System.EventHandler(this.FrmNew_Student_Application_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Student)).EndInit();
            this.Top_Panel.ResumeLayout(false);
            this.Top_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Student;
        private System.Windows.Forms.DataGridView dataGridView_Student;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Top_Panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button Btn_Reject;
        private System.Windows.Forms.Button Btn_Approve;
    }
}