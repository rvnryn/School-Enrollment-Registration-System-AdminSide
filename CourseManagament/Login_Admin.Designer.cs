namespace Login_Admin
{
    partial class Frm_Login_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login_Admin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roundedPanel1 = new RoundedPanel();
            this.roundedPanel2 = new RoundedPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Lbl_Admin = new System.Windows.Forms.Label();
            this.Btn_ShowPassword = new System.Windows.Forms.Button();
            this.TxtBox_AdminGmail = new System.Windows.Forms.TextBox();
            this.Btn_SignIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBox_Password = new System.Windows.Forms.TextBox();
            this.Lbl_Password = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1209, 637);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.roundedPanel1.Controls.Add(this.roundedPanel2);
            this.roundedPanel1.Controls.Add(this.Btn_ShowPassword);
            this.roundedPanel1.Controls.Add(this.TxtBox_AdminGmail);
            this.roundedPanel1.Controls.Add(this.Btn_SignIn);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Controls.Add(this.TxtBox_Password);
            this.roundedPanel1.Controls.Add(this.Lbl_Password);
            this.roundedPanel1.CornerRadius = 2;
            this.roundedPanel1.Location = new System.Drawing.Point(420, 130);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(419, 362);
            this.roundedPanel1.TabIndex = 10;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.roundedPanel2.Controls.Add(this.pictureBox2);
            this.roundedPanel2.Controls.Add(this.Lbl_Admin);
            this.roundedPanel2.CornerRadius = 10;
            this.roundedPanel2.Location = new System.Drawing.Point(0, -10);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(426, 78);
            this.roundedPanel2.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(9, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Lbl_Admin
            // 
            this.Lbl_Admin.AutoSize = true;
            this.Lbl_Admin.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Admin.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Admin.ForeColor = System.Drawing.Color.White;
            this.Lbl_Admin.Location = new System.Drawing.Point(142, 25);
            this.Lbl_Admin.Name = "Lbl_Admin";
            this.Lbl_Admin.Size = new System.Drawing.Size(132, 38);
            this.Lbl_Admin.TabIndex = 2;
            this.Lbl_Admin.Text = "Admin";
            // 
            // Btn_ShowPassword
            // 
            this.Btn_ShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_ShowPassword.Location = new System.Drawing.Point(337, 204);
            this.Btn_ShowPassword.Name = "Btn_ShowPassword";
            this.Btn_ShowPassword.Size = new System.Drawing.Size(22, 24);
            this.Btn_ShowPassword.TabIndex = 9;
            this.Btn_ShowPassword.UseVisualStyleBackColor = true;
            this.Btn_ShowPassword.Click += new System.EventHandler(this.Btn_ShowPassword_Click);
            // 
            // TxtBox_AdminGmail
            // 
            this.TxtBox_AdminGmail.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_AdminGmail.Location = new System.Drawing.Point(81, 126);
            this.TxtBox_AdminGmail.Name = "TxtBox_AdminGmail";
            this.TxtBox_AdminGmail.Size = new System.Drawing.Size(250, 29);
            this.TxtBox_AdminGmail.TabIndex = 4;
            // 
            // Btn_SignIn
            // 
            this.Btn_SignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(70)))), ((int)(((byte)(39)))));
            this.Btn_SignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_SignIn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SignIn.ForeColor = System.Drawing.Color.White;
            this.Btn_SignIn.Location = new System.Drawing.Point(81, 270);
            this.Btn_SignIn.Name = "Btn_SignIn";
            this.Btn_SignIn.Size = new System.Drawing.Size(250, 34);
            this.Btn_SignIn.TabIndex = 8;
            this.Btn_SignIn.Text = "Sign In";
            this.Btn_SignIn.UseVisualStyleBackColor = false;
            this.Btn_SignIn.Click += new System.EventHandler(this.Btn_SignIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email";
            // 
            // TxtBox_Password
            // 
            this.TxtBox_Password.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Password.Location = new System.Drawing.Point(81, 200);
            this.TxtBox_Password.Name = "TxtBox_Password";
            this.TxtBox_Password.Size = new System.Drawing.Size(250, 29);
            this.TxtBox_Password.TabIndex = 7;
            this.TxtBox_Password.UseSystemPasswordChar = true;
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Password.Location = new System.Drawing.Point(78, 179);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(85, 18);
            this.Lbl_Password.TabIndex = 6;
            this.Lbl_Password.Text = "Password";
            // 
            // Frm_Login_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1206, 631);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Frm_Login_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtBox_AdminGmail;
        private System.Windows.Forms.Label Lbl_Admin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.TextBox TxtBox_Password;
        private System.Windows.Forms.Button Btn_SignIn;
        private System.Windows.Forms.Button Btn_ShowPassword;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RoundedPanel roundedPanel2;
    }
}

