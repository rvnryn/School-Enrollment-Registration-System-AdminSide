namespace CourseManagament
{
    partial class Frm_EnrolledStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.Top_Panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_Student = new System.Windows.Forms.Label();
            this.dataGridView_Student = new System.Windows.Forms.DataGridView();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Top_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(533, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enrolled Student";
            // 
            // Top_Panel
            // 
            this.Top_Panel.BackColor = System.Drawing.Color.White;
            this.Top_Panel.Controls.Add(this.label1);
            this.Top_Panel.Controls.Add(this.pictureBox1);
            this.Top_Panel.Location = new System.Drawing.Point(0, -1);
            this.Top_Panel.Name = "Top_Panel";
            this.Top_Panel.Size = new System.Drawing.Size(1542, 102);
            this.Top_Panel.TabIndex = 58;
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
            // Lbl_Student
            // 
            this.Lbl_Student.AutoSize = true;
            this.Lbl_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Student.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Lbl_Student.Location = new System.Drawing.Point(91, 117);
            this.Lbl_Student.Name = "Lbl_Student";
            this.Lbl_Student.Size = new System.Drawing.Size(230, 31);
            this.Lbl_Student.TabIndex = 59;
            this.Lbl_Student.Text = "Enrolled Student";
            // 
            // dataGridView_Student
            // 
            this.dataGridView_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Student.Location = new System.Drawing.Point(197, 181);
            this.dataGridView_Student.Name = "dataGridView_Student";
            this.dataGridView_Student.Size = new System.Drawing.Size(1104, 453);
            this.dataGridView_Student.TabIndex = 61;
            this.dataGridView_Student.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Student_CellDoubleClick);
            // 
            // Btn_Back
            // 
            this.Btn_Back.BackColor = System.Drawing.Color.White;
            this.Btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Back.ForeColor = System.Drawing.Color.Black;
            this.Btn_Back.Location = new System.Drawing.Point(28, 752);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(105, 30);
            this.Btn_Back.TabIndex = 64;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = false;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.White;
            this.Btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.ForeColor = System.Drawing.Color.Black;
            this.Btn_Delete.Location = new System.Drawing.Point(198, 640);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(179, 38);
            this.Btn_Delete.TabIndex = 75;
            this.Btn_Delete.Text = "Delete Records";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Frm_EnrolledStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 805);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Lbl_Student);
            this.Controls.Add(this.dataGridView_Student);
            this.Controls.Add(this.Top_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_EnrolledStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_EnrolledStudent";
            this.Load += new System.EventHandler(this.Frm_EnrolledStudent_Load);
            this.Top_Panel.ResumeLayout(false);
            this.Top_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Top_Panel;
        private System.Windows.Forms.Label Lbl_Student;
        private System.Windows.Forms.DataGridView dataGridView_Student;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button Btn_Delete;
    }
}