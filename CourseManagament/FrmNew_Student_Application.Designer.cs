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
            this.Lbl_Approve = new System.Windows.Forms.Label();
            this.Lbl_Reject = new System.Windows.Forms.Label();
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
            this.Lbl_Student.Size = new System.Drawing.Size(130, 31);
            this.Lbl_Student.TabIndex = 66;
            this.Lbl_Student.Text = "Students";
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
            // Lbl_Approve
            // 
            this.Lbl_Approve.AutoSize = true;
            this.Lbl_Approve.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Approve.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Lbl_Approve.Location = new System.Drawing.Point(464, 654);
            this.Lbl_Approve.Name = "Lbl_Approve";
            this.Lbl_Approve.Size = new System.Drawing.Size(122, 31);
            this.Lbl_Approve.TabIndex = 72;
            this.Lbl_Approve.Text = "Approve";
            // 
            // Lbl_Reject
            // 
            this.Lbl_Reject.AutoSize = true;
            this.Lbl_Reject.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Reject.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Lbl_Reject.Location = new System.Drawing.Point(866, 654);
            this.Lbl_Reject.Name = "Lbl_Reject";
            this.Lbl_Reject.Size = new System.Drawing.Size(98, 31);
            this.Lbl_Reject.TabIndex = 73;
            this.Lbl_Reject.Text = "Reject";
            // 
            // FrmNew_Student_Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 805);
            this.Controls.Add(this.Lbl_Reject);
            this.Controls.Add(this.Lbl_Approve);
            this.Controls.Add(this.Lbl_Student);
            this.Controls.Add(this.dataGridView_Student);
            this.Controls.Add(this.Top_Panel);
            this.Controls.Add(this.Btn_Back);
            this.Name = "FrmNew_Student_Application";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNew_Student_Application";
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
        private System.Windows.Forms.Label Lbl_Approve;
        private System.Windows.Forms.Label Lbl_Reject;
    }
}