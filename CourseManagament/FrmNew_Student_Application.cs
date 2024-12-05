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
    public partial class FrmNew_Student_Application : Form
    {
        Color color_profile = ColorTranslator.FromHtml("#2C384A");
        public FrmNew_Student_Application()
        {
            InitializeComponent();
            Top_Panel.BackColor = color_profile;
            Lbl_Student.ForeColor = color_profile;
            Lbl_Approve.ForeColor = color_profile;
            Lbl_Reject.ForeColor = color_profile;
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
    }
}
