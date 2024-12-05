using CourseManagament.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CourseManagament
{
    public partial class Frm_Dashboard : Form
    {
        Color color = ColorTranslator.FromHtml("#0073bd");
        Color color_profile = ColorTranslator.FromHtml("#2C384A");
        public Frm_Dashboard()
        {
            InitializeComponent();

            panel1.BackColor = color;
            Lbl_Students.ForeColor = color_profile;
            Lbl_Courses.ForeColor = color_profile;

            Student_Panel.BackColor = color_profile;
            Student_Panel.ForeColor = Color.White;

            Course_Panel.BackColor = color_profile;
            Course_Panel.ForeColor = Color.White;


            Dashboard_Panel.BackColor = color_profile;
            Lbl_DashBoard.ForeColor = color_profile;

        }

        private Timer _timer = new Timer();

        private void Frm_Dashboard_Load(object sender, EventArgs e)
        {
            _timer.Stop();
            _timer.Interval = 10;
            _timer.Tick += (s, args) =>
            {
                _timer.Stop();
                int courseCount = GetCourseCount();
                Lbl_NoOfCourses.Text = courseCount.ToString();
            };
            _timer.Start();
        }

        private int GetCourseCount()
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Program_Info";

                using (SqlConnection conn = new SqlConnection("Data Source=ZERO; Initial Catalog=AdminDB; Integrated Security=True;"))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        int courseCount = (int)cmd.ExecuteScalar();
                        return courseCount;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
                return 0;
            }
        }

        private void Btn_Student_Click(object sender, EventArgs e)
        {
            Frm_Student frm_Student = new Frm_Student();
            this.Hide();
            frm_Student.ShowDialog();
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
    }
}
