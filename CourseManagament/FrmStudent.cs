using CourseManagament.Resources;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseManagament
{

    public partial class Frm_Student : Form
    {
        Color color = ColorTranslator.FromHtml("#0073bd");
        Color color_profile = ColorTranslator.FromHtml("#2C384A");
        public Frm_Student()
        {
            InitializeComponent();

            panel1.BackColor = color;
            Dashboard_Panel.BackColor = color_profile;
            New_Student_Applicaton_Panel.BackColor = color_profile;
            Lbl_New_Student.ForeColor = Color.White;
            Enrolled_Student_panel.BackColor = color_profile;
            Lbl_Enrolled_Student.ForeColor = Color.White;
            Lbl_Student.ForeColor = color_profile;
        }

        private void Btn_Dashboard_Click(object sender, EventArgs e)
        {
            Frm_Dashboard frm_Dashboard = new Frm_Dashboard();
            this.Hide();
            frm_Dashboard.ShowDialog();
            this.Close();
        }

        private void Btn_Courses_Click(object sender, EventArgs e)
        {
            Frm_Courses frm_Courses = new Frm_Courses();
            this.Hide();
            frm_Courses.ShowDialog();
            this.Close();
        }

        private void Btn_Billing_Click(object sender, EventArgs e)
        {
            Frm_Billing frm_Billing = new Frm_Billing();
            this.Hide();
            frm_Billing.ShowDialog();
            this.Close();
        }

        private void Lbl_UpdateStudent_Click(object sender, EventArgs e)
        {
            Frm_Update_Student frm_Update_Student = new Frm_Update_Student(); 
            this.Hide();
            frm_Update_Student.ShowDialog();
            this.Close();
        }
        private void Enrolled_Student_panel_Click_1(object sender, EventArgs e)
        {
            Frm_EnrolledStudent frm_EnrolledStudent = new Frm_EnrolledStudent();
            this.Hide();
            frm_EnrolledStudent.ShowDialog();
            this.Close();
        }

        private void Lbl_New_Student_Click(object sender, EventArgs e)
        {
            FrmNew_Student_Application frmNew_Student_Application = new FrmNew_Student_Application();
            this.Hide();
            frmNew_Student_Application.ShowDialog();
            this.Close();
        }
    }
}
