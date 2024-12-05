using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManagament
{
    public partial class Frm_EnrolledStudent : Form
    {
        Color color_profile = ColorTranslator.FromHtml("#2C384A");
        public Frm_EnrolledStudent()
        {
            InitializeComponent();
            Top_Panel.BackColor = color_profile;
            Lbl_Student.ForeColor = color_profile;
            Btn_Back.BackColor = color_profile;
            Btn_Back.ForeColor = Color.White;
            
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Frm_Student frm_Student = new Frm_Student();
            this.Hide();
            frm_Student.ShowDialog();
            this.Close();
        }

        private void Lbl_AddProgram_Click(object sender, EventArgs e)
        {
            Frm_Add_Student frm_Add_Student = new Frm_Add_Student();
            this.Hide();
            frm_Add_Student.ShowDialog();
            this.Close();
        }

        private void lbl_UpdateProgram_Click(object sender, EventArgs e)
        {
            Frm_Update_Student frm_Update_Student = new Frm_Update_Student();
            this.Hide();
            frm_Update_Student.ShowDialog();
            this.Close();
        }
    }
}
