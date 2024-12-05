namespace CourseManagament
{
    partial class Frm_Courses
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
            this.Lbl_Courses = new System.Windows.Forms.Label();
            this.Lbl_AddProgram = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView_Courses = new System.Windows.Forms.DataGridView();
            this.Lbl_DeleteProgram = new System.Windows.Forms.Label();
            this.Dashboard_Panel = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Billing = new System.Windows.Forms.Label();
            this.Btn_Dashboard = new System.Windows.Forms.Label();
            this.Btn_Courses = new System.Windows.Forms.Label();
            this.Btn_Student = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Courses)).BeginInit();
            this.Dashboard_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Courses
            // 
            this.Lbl_Courses.AutoSize = true;
            this.Lbl_Courses.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Courses.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Lbl_Courses.Location = new System.Drawing.Point(241, 123);
            this.Lbl_Courses.Name = "Lbl_Courses";
            this.Lbl_Courses.Size = new System.Drawing.Size(123, 31);
            this.Lbl_Courses.TabIndex = 1;
            this.Lbl_Courses.Text = "Courses";
            // 
            // Lbl_AddProgram
            // 
            this.Lbl_AddProgram.AutoSize = true;
            this.Lbl_AddProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_AddProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AddProgram.Location = new System.Drawing.Point(348, 741);
            this.Lbl_AddProgram.Name = "Lbl_AddProgram";
            this.Lbl_AddProgram.Size = new System.Drawing.Size(62, 31);
            this.Lbl_AddProgram.TabIndex = 3;
            this.Lbl_AddProgram.Text = "Add";
            this.Lbl_AddProgram.Click += new System.EventHandler(this.Lbl_AddProgram_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1542, 102);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseManagament.Properties.Resources.STIpage;
            this.pictureBox1.Location = new System.Drawing.Point(64, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView_Courses
            // 
            this.dataGridView_Courses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Courses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Courses.Location = new System.Drawing.Point(347, 187);
            this.dataGridView_Courses.Name = "dataGridView_Courses";
            this.dataGridView_Courses.ReadOnly = true;
            this.dataGridView_Courses.Size = new System.Drawing.Size(1089, 526);
            this.dataGridView_Courses.TabIndex = 5;
            this.dataGridView_Courses.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Courses_CellDoubleClick);
            // 
            // Lbl_DeleteProgram
            // 
            this.Lbl_DeleteProgram.AutoSize = true;
            this.Lbl_DeleteProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_DeleteProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DeleteProgram.Location = new System.Drawing.Point(442, 741);
            this.Lbl_DeleteProgram.Name = "Lbl_DeleteProgram";
            this.Lbl_DeleteProgram.Size = new System.Drawing.Size(93, 31);
            this.Lbl_DeleteProgram.TabIndex = 7;
            this.Lbl_DeleteProgram.Text = "Delete";
            this.Lbl_DeleteProgram.Click += new System.EventHandler(this.Lbl_DeleteProgram_Click);
            // 
            // Dashboard_Panel
            // 
            this.Dashboard_Panel.Controls.Add(this.pictureBox6);
            this.Dashboard_Panel.Controls.Add(this.pictureBox5);
            this.Dashboard_Panel.Controls.Add(this.pictureBox4);
            this.Dashboard_Panel.Controls.Add(this.pictureBox3);
            this.Dashboard_Panel.Controls.Add(this.pictureBox2);
            this.Dashboard_Panel.Controls.Add(this.label3);
            this.Dashboard_Panel.Controls.Add(this.label4);
            this.Dashboard_Panel.Controls.Add(this.Btn_Billing);
            this.Dashboard_Panel.Controls.Add(this.Btn_Dashboard);
            this.Dashboard_Panel.Controls.Add(this.Btn_Courses);
            this.Dashboard_Panel.Controls.Add(this.Btn_Student);
            this.Dashboard_Panel.Location = new System.Drawing.Point(-5, 99);
            this.Dashboard_Panel.Name = "Dashboard_Panel";
            this.Dashboard_Panel.Size = new System.Drawing.Size(220, 741);
            this.Dashboard_Panel.TabIndex = 8;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CourseManagament.Properties.Resources.invoice;
            this.pictureBox6.Location = new System.Drawing.Point(17, 392);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(47, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CourseManagament.Properties.Resources.homework;
            this.pictureBox5.Location = new System.Drawing.Point(17, 340);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(47, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CourseManagament.Properties.Resources.students;
            this.pictureBox4.Location = new System.Drawing.Point(17, 291);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CourseManagament.Properties.Resources.dashboard_panel;
            this.pictureBox3.Location = new System.Drawing.Point(17, 237);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CourseManagament.Properties.Resources._123123;
            this.pictureBox2.Location = new System.Drawing.Point(57, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(79, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Admin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Jude Turaray";
            // 
            // Btn_Billing
            // 
            this.Btn_Billing.AutoSize = true;
            this.Btn_Billing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Billing.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Billing.ForeColor = System.Drawing.Color.White;
            this.Btn_Billing.Location = new System.Drawing.Point(71, 392);
            this.Btn_Billing.Name = "Btn_Billing";
            this.Btn_Billing.Size = new System.Drawing.Size(76, 25);
            this.Btn_Billing.TabIndex = 12;
            this.Btn_Billing.Text = "Billing";
            this.Btn_Billing.Click += new System.EventHandler(this.Btn_Billing_Click);
            // 
            // Btn_Dashboard
            // 
            this.Btn_Dashboard.AutoSize = true;
            this.Btn_Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Dashboard.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Dashboard.ForeColor = System.Drawing.Color.White;
            this.Btn_Dashboard.Location = new System.Drawing.Point(71, 237);
            this.Btn_Dashboard.Name = "Btn_Dashboard";
            this.Btn_Dashboard.Size = new System.Drawing.Size(126, 25);
            this.Btn_Dashboard.TabIndex = 9;
            this.Btn_Dashboard.Text = "Dashboard";
            this.Btn_Dashboard.Click += new System.EventHandler(this.Btn_Dashboard_Click);
            // 
            // Btn_Courses
            // 
            this.Btn_Courses.AutoSize = true;
            this.Btn_Courses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Courses.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Courses.ForeColor = System.Drawing.Color.White;
            this.Btn_Courses.Location = new System.Drawing.Point(71, 340);
            this.Btn_Courses.Name = "Btn_Courses";
            this.Btn_Courses.Size = new System.Drawing.Size(97, 25);
            this.Btn_Courses.TabIndex = 11;
            this.Btn_Courses.Text = "Courses";
            // 
            // Btn_Student
            // 
            this.Btn_Student.AutoSize = true;
            this.Btn_Student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Student.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Student.ForeColor = System.Drawing.Color.White;
            this.Btn_Student.Location = new System.Drawing.Point(71, 291);
            this.Btn_Student.Name = "Btn_Student";
            this.Btn_Student.Size = new System.Drawing.Size(105, 25);
            this.Btn_Student.TabIndex = 10;
            this.Btn_Student.Text = "Students";
            this.Btn_Student.Click += new System.EventHandler(this.Btn_Student_Click);
            // 
            // Frm_Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 832);
            this.Controls.Add(this.Dashboard_Panel);
            this.Controls.Add(this.Lbl_DeleteProgram);
            this.Controls.Add(this.dataGridView_Courses);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lbl_AddProgram);
            this.Controls.Add(this.Lbl_Courses);
            this.Name = "Frm_Courses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Courses)).EndInit();
            this.Dashboard_Panel.ResumeLayout(false);
            this.Dashboard_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Courses;
        private System.Windows.Forms.Label Lbl_AddProgram;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView_Courses;
        private System.Windows.Forms.Label Lbl_DeleteProgram;
        private System.Windows.Forms.Panel Dashboard_Panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Btn_Billing;
        private System.Windows.Forms.Label Btn_Dashboard;
        private System.Windows.Forms.Label Btn_Courses;
        private System.Windows.Forms.Label Btn_Student;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

