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
    public partial class Frm_Update_Student : Form
    {
        Color darkblue = ColorTranslator.FromHtml("#2C384A");
        public Frm_Update_Student()
        {
            InitializeComponent();
            Top_Panel.BackColor = darkblue;
            Btn_Back.BackColor = darkblue;
            Btn_Back.ForeColor = Color.White;
            Btn_Submit.BackColor = darkblue;
            Btn_Submit.ForeColor = Color.White;
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Frm_EnrolledStudent frm_EnrolledStudent = new Frm_EnrolledStudent();
            this.Hide();
            frm_EnrolledStudent.ShowDialog();
            this.Close();
        }
    }
}
