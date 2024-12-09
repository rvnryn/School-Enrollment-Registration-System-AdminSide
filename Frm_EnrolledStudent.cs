using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManagament
{
    public partial class Frm_EnrolledStudent : Form
    {
        Color color_profile = ColorTranslator.FromHtml("#2C384A");
        SqlConnection conn = new SqlConnection("Data Source = ZERO; Initial Catalog = AdminDB; Integrated Security = true;");
        SqlDataAdapter adapterShow;
        DataTable DT = new DataTable();
        int index;
        public Frm_EnrolledStudent()
        {
            InitializeComponent();
            Top_Panel.BackColor = color_profile;
            Lbl_Student.ForeColor = color_profile;
            Btn_Back.BackColor = color_profile;
            Btn_Back.ForeColor = Color.White;
            Btn_Delete.BackColor = color_profile;
            Btn_Delete.ForeColor = Color.White;
            
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Frm_Student frm_Student = new Frm_Student();
            this.Hide();
            frm_Student.ShowDialog();
            this.Close();
        }
        private void lbl_UpdateProgram_Click(object sender, EventArgs e)
        {
            Frm_Update_Student frm_Update_Student = new Frm_Update_Student();
            this.Hide();
            frm_Update_Student.ShowDialog();
            this.Close();
        }

        private void Frm_EnrolledStudent_Load(object sender, EventArgs e)
        {
            adapterShow = new SqlDataAdapter("SELECT * FROM Student_Info", conn);
            adapterShow.Fill(DT);
            dataGridView_Student.DataSource = DT;

            dataGridView_Student.DataSource = DT;

            foreach (DataGridViewRow row in dataGridView_Student.Rows)
            {
                if (!row.IsNewRow)
                {
                    string lastName = row.Cells["Last_Name"].Value.ToString(); 
                    string studentNumber = row.Cells["Student_Number"].Value.ToString();

                    string last6Digits = studentNumber.Length >= 6 ? studentNumber.Substring(studentNumber.Length - 6) : studentNumber;

                    string schoolEmail = $"{lastName.ToLower()}.{last6Digits}@ortigas-cainta.sti.edu.ph";

                    row.Cells["School_Email"].Value = schoolEmail;
                }
            }

        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            Frm_Update_Student frm_Update_Student = new Frm_Update_Student();
            this.Hide();
            frm_Update_Student.ShowDialog();
            this.Close();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_Student.SelectedCells.Count > 0)
            {
                int index = dataGridView_Student.CurrentCell.RowIndex;

                var Student_Number = dataGridView_Student.Rows[index].Cells["Student_Number"].Value;

                var result = MessageBox.Show("Are you sure you want to delete this Student?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string deleteQuery = "DELETE FROM Student_Info WHERE Student_Number = @Student_Number";
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@Student_Number", Student_Number);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        dataGridView_Student.Rows.RemoveAt(index);

                        adapterShow = new SqlDataAdapter("SELECT * FROM Student_Info", conn);
                        DT.Clear();
                        adapterShow.Fill(DT);
                        dataGridView_Student.DataSource = DT;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting program: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Student to delete.");
            }
        }

        private void dataGridView_Student_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = dataGridView_Student.Rows[e.RowIndex];

                Frm_Update_Student frm_UpdateStudent = new Frm_Update_Student();

                frm_UpdateStudent.Student_Number = long.TryParse(row.Cells[0].Value?.ToString(), out var Student_Number) ? Student_Number : 0;
                frm_UpdateStudent.Student_First_Name = row.Cells[1].Value.ToString();
                frm_UpdateStudent.Student_Middle_Name = row.Cells[2].Value.ToString();
                frm_UpdateStudent.Student_Last_Name = row.Cells[3].Value.ToString();

                frm_UpdateStudent.Date_Of_Birth = ((DateTime)row.Cells[4].Value).Date.ToShortDateString(); // MM-DD-YYYY

                frm_UpdateStudent.Gender = row.Cells[5].Value.ToString();
                frm_UpdateStudent.Nationality = row.Cells[6].Value.ToString();
                frm_UpdateStudent.Address = row.Cells[7].Value.ToString();

                frm_UpdateStudent.Student_Contact_Number = long.TryParse(row.Cells[8].Value?.ToString(), out var Student_Contact_Number) ? Student_Contact_Number : 0;
                frm_UpdateStudent.Personal_Email = row.Cells[9].Value.ToString();
                frm_UpdateStudent.School_Email = row.Cells[10].Value.ToString();

                frm_UpdateStudent.Guardian_FullName = row.Cells[11].Value.ToString();

                frm_UpdateStudent.Guardian_Contact_Number = long.TryParse(row.Cells[12].Value.ToString(), out var Guardian_Contact_Number) ? Guardian_Contact_Number : 0;

                frm_UpdateStudent.Guardian_Email = row.Cells[13].Value.ToString();
                frm_UpdateStudent.Guardian_Relationship = row.Cells[14].Value.ToString();


                this.Hide();
                frm_UpdateStudent.ShowDialog();
                this.Close();
            }
        }
    }
}
