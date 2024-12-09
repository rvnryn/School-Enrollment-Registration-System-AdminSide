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

namespace CourseManagament
{
    public partial class FrmNew_Student_Application : Form
    {
        Color color_profile = ColorTranslator.FromHtml("#2C384A");
        SqlConnection conn = new SqlConnection("Data Source = ZERO; Initial Catalog = AdminDB; Integrated Security = true;");
        SqlDataAdapter adapterShow;
        DataTable DT = new DataTable();
        public FrmNew_Student_Application()
        {
            InitializeComponent();
            Top_Panel.BackColor = color_profile;
            Lbl_Student.ForeColor = color_profile;
            Btn_Approve.BackColor = color_profile;
            Btn_Approve.ForeColor = Color.White;
            Btn_Reject.BackColor = color_profile;
            Btn_Reject.ForeColor = Color.White;
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

        private void FrmNew_Student_Application_Load(object sender, EventArgs e)
        {
            adapterShow = new SqlDataAdapter("SELECT * FROM NEW_STUDENT_APPLICATION;", conn);
            adapterShow.Fill(DT);
            dataGridView_Student.DataSource = DT;
        }

        private void Btn_Approve_Click(object sender, EventArgs e)
        {

            if (dataGridView_Student.SelectedRows.Count > 0)
            {
                int applicationId = Convert.ToInt32(dataGridView_Student.SelectedRows[0].Cells["Application_ID"].Value);
                string firstName = dataGridView_Student.SelectedRows[0].Cells["First_Name"].Value.ToString();
                string middleName = dataGridView_Student.SelectedRows[0].Cells["Middle_Name"].Value.ToString();
                string lastName = dataGridView_Student.SelectedRows[0].Cells["Last_Name"].Value.ToString();
                string dateOfBirth = dataGridView_Student.SelectedRows[0].Cells["Date_Of_Birth"].Value.ToString();
                string gender = dataGridView_Student.SelectedRows[0].Cells["Gender"].Value.ToString();
                string nationality = dataGridView_Student.SelectedRows[0].Cells["Citizenship"].Value.ToString();
                string address = dataGridView_Student.SelectedRows[0].Cells["Current_Address"].Value.ToString();
                long contactNumber = Convert.ToInt64(dataGridView_Student.SelectedRows[0].Cells["Mobile_Number"].Value);
                string personalEmail = dataGridView_Student.SelectedRows[0].Cells["Email_Address"].Value.ToString();
                string schoolEmail = dataGridView_Student.SelectedRows[0].Cells["Email_Address"].Value.ToString();
                string GuardianFullName = dataGridView_Student.SelectedRows[0].Cells["Guardian_Name"].Value.ToString();
                long GuardianContactNumber = Convert.ToInt64(dataGridView_Student.SelectedRows[0].Cells["Guardian_MobileNo"].Value);
                string GuardianEmail = dataGridView_Student.SelectedRows[0].Cells["Guardian_Email_Address"].Value.ToString();
                string GuardianRelation = dataGridView_Student.SelectedRows[0].Cells["Guardian_Relationship"].Value.ToString();

                string connectionString = "Data Source=ZERO; Initial Catalog=AdminDB; Integrated Security=true;";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string insertQuery = @"
                        INSERT INTO Student_Info
                        (First_Name, Middle_Name, Last_Name, Date_Of_Birth, Gender, Nationality, Address, 
                         Contact_Number, Personal_Email, School_Email, Guardian_FullName, 
                         Guardian_Contact_Number, Guardian_Email, Guardian_Relationship)
                        VALUES
                        (@First_Name, @Middle_Name, @Last_Name, @Date_Of_Birth, @Gender, @Nationality, @Address, 
                         @Contact_Number, @Personal_Email, @School_Email, @Guardian_FullName, 
                         @Guardian_Contact_Number, @Guardian_Email, @Guardian_Relationship )";

                        SqlCommand cmd = new SqlCommand(insertQuery, conn);
                        cmd.Parameters.AddWithValue("@First_Name", firstName);
                        cmd.Parameters.AddWithValue("@Middle_Name", middleName);
                        cmd.Parameters.AddWithValue("@Last_Name", lastName);
                        cmd.Parameters.AddWithValue("@Date_Of_Birth", dateOfBirth);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Nationality", nationality);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Contact_Number", contactNumber);
                        cmd.Parameters.AddWithValue("@Personal_Email", personalEmail);
                        cmd.Parameters.AddWithValue("@School_Email", schoolEmail);
                        cmd.Parameters.AddWithValue("@Guardian_FullName", GuardianFullName);
                        cmd.Parameters.AddWithValue("@Guardian_Contact_Number", GuardianContactNumber);
                        cmd.Parameters.AddWithValue("@Guardian_Email", GuardianEmail);
                        cmd.Parameters.AddWithValue("@Guardian_Relationship", GuardianRelation);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    MessageBox.Show("Application Approved and Data Added to Student Info Database.");

                    //Delete Records
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string deleteQuery = "DELETE FROM NEW_STUDENT_APPLICATION WHERE Application_ID = @Application_ID";

                        SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                        deleteCmd.Parameters.AddWithValue("@Application_ID", applicationId);

                        conn.Open();
                        deleteCmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    dataGridView_Student.Rows.RemoveAt(dataGridView_Student.SelectedRows[0].Index);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a record to approve.");
            }
        }
        private void Btn_Reject_Click(object sender, EventArgs e)
        {
            long applicationId = Convert.ToInt64(dataGridView_Student.SelectedRows[0].Cells["Application_ID"].Value);

            DeleteApplication(applicationId);
        }
        private void DeleteApplication(long applicationId)
        {

            string deleteQuery = "DELETE FROM Student_Info WHERE Application_ID = @Application_ID";

            using (SqlConnection conn = new SqlConnection("Data Source = ZERO; Initial Catalog = AdminDB; Integrated Security = true;"))
            {
                SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                cmd.Parameters.AddWithValue("@Application_ID", applicationId);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Application Rejected and Removed from System.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
