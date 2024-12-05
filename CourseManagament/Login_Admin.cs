using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using CourseManagament;
namespace Login_Admin
{
    public partial class Frm_Login_Admin : Form
    {
        public Frm_Login_Admin()
        {
            InitializeComponent();

            Color color = ColorTranslator.FromHtml("#FFF301");
            this.BackColor = color;
            Btn_ShowPassword.BackgroundImage = Image.FromFile("C:\\Users\\Acsur\\Downloads\\show.png");
        }

        private void Btn_SignIn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection("Data Source = ZERO;Initial Catalog = AdminDB; Integrated Security = True;"))
            {
                sqlConnection.Open();

                string query = "SELECT Password FROM AdminAccount WHERE Email = @Email";
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@Email", TxtBox_AdminGmail.Text);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string selectingPassword = reader["Password"].ToString();
                            if (TxtBox_Password.Text == selectingPassword)
                            {
                                DialogResult result = MessageBox.Show("Login Successful!");
                                if (result == DialogResult.OK)
                                {
                                    TxtBox_AdminGmail.Clear();
                                    TxtBox_Password.Clear();
                                    
                                    Frm_Dashboard frm_Dashboard = new Frm_Dashboard();
                                    this.Hide();
                                    frm_Dashboard.ShowDialog();
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Password!");
                                TxtBox_Password.ForeColor = Color.Red;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Email does not exist!");
                            TxtBox_AdminGmail.ForeColor = Color.Red;
                        }
                    }
                }
            }

        }

        private void Btn_ShowPassword_Click(object sender, EventArgs e)
        {
            if (TxtBox_Password.UseSystemPasswordChar == true)
            {
                TxtBox_Password.UseSystemPasswordChar = false;
                Btn_ShowPassword.BackgroundImage = Image.FromFile("C:\\Users\\Acsur\\Downloads\\hide.png");
            }
            else
            {
                TxtBox_Password.UseSystemPasswordChar = true;
                Btn_ShowPassword.BackgroundImage = Image.FromFile("C:\\Users\\Acsur\\Downloads\\show.png");
            }
        }
    }
}
