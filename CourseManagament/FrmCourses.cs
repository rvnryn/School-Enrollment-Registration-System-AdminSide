using CourseManagament.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManagament
{
    public partial class Frm_Courses : Form
    {
        Color color = ColorTranslator.FromHtml("#0073bd");
        Color color_profile = ColorTranslator.FromHtml("#2C384A");

        SqlConnection conn = new SqlConnection("Data Source = ZERO; Initial Catalog = AdminDB; Integrated Security = true;");
        SqlDataAdapter adapterShow;
        DataTable DT = new DataTable();

        int index;


        public Frm_Courses()
        {
            InitializeComponent();
            
            panel1.BackColor = color;
            Lbl_AddProgram.ForeColor = color_profile;
            Lbl_DeleteProgram.ForeColor = color_profile;
            Dashboard_Panel.BackColor = color_profile;
            Lbl_Courses.ForeColor = color_profile;

            adapterShow = new SqlDataAdapter("SELECT * FROM Program_Info", conn);
            adapterShow.Fill(DT);
            dataGridView_Courses.DataSource = DT;

        }
        private void Btn_Dashboard_Click(object sender, EventArgs e)
        {
            Frm_Dashboard frm_Dashboard = new Frm_Dashboard();
            this.Hide();
            frm_Dashboard.ShowDialog();
            this.Close();
        }

        private void Btn_Student_Click(object sender, EventArgs e)
        {
            Frm_Student frm_Student = new Frm_Student();
            this.Hide();
            frm_Student.ShowDialog();
            this.Close();
        }

        private void Btn_Billing_Click(object sender, EventArgs e)
        {
            Frm_Billing frm_Billing = new Frm_Billing();
            this.Hide();
            frm_Billing.ShowDialog();
            this.Close();
        }
        private void dataGridView_Courses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = dataGridView_Courses.Rows[e.RowIndex];

                Frm_UpdateProgram frm_UpdateProgram = new Frm_UpdateProgram();

                frm_UpdateProgram.Program_Code = int.TryParse(row.Cells[0].Value?.ToString(), out var programcode) ? programcode : 0;
                frm_UpdateProgram.Program_Name = row.Cells[1].Value.ToString();
                frm_UpdateProgram.Program_Capacity = int.TryParse(row.Cells[2].Value?.ToString(), out var programcapacity) ? programcapacity : 0;
                frm_UpdateProgram.Program_Description = row.Cells[3].Value.ToString();

                frm_UpdateProgram.FirstYear_1stSem = double.TryParse(row.Cells[4].Value.ToString(), out var firsty1) ? firsty1 : 0.0;
                frm_UpdateProgram.FirstYear_2ndSem = double.TryParse(row.Cells[5].Value.ToString(), out var firsty2) ? firsty2 : 0.0;

                frm_UpdateProgram.SecondYear_1stSem = double.TryParse(row.Cells[6].Value.ToString(), out var secondy1) ? secondy1 : 0.0;
                frm_UpdateProgram.SecondYear_2ndSem = double.TryParse(row.Cells[7].Value.ToString(), out var secondy2) ? secondy2 : 0.0;

                frm_UpdateProgram.ThirdYear_1stSem = double.TryParse(row.Cells[8].Value.ToString(), out var thirdy1) ? thirdy1 : 0.0;
                frm_UpdateProgram.ThirdYear_2ndSem = double.TryParse(row.Cells[9].Value.ToString(), out var thirdy2) ? thirdy2 : 0.0;

                frm_UpdateProgram.FourthYear_1stSem = double.TryParse(row.Cells[10].Value.ToString(), out var fourthy1) ? fourthy1 : 0.0;
                frm_UpdateProgram.FourthYear_2ndSem = double.TryParse(row.Cells[11].Value.ToString(), out var fourthy2) ? fourthy2 : 0.0;

                this.Hide();
                frm_UpdateProgram.ShowDialog();
                this.Close();
            }
        }

        private void Lbl_DeleteProgram_Click(object sender, EventArgs e)
        {
            if (dataGridView_Courses.SelectedCells.Count > 0)
            {
                int index = dataGridView_Courses.CurrentCell.RowIndex;

                var Program_Code = dataGridView_Courses.Rows[index].Cells["Program_Code"].Value;

                var result = MessageBox.Show("Are you sure you want to delete this Course?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string deleteQuery = "DELETE FROM Program_Info WHERE Program_Code = @ProgramCode";
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@ProgramCode", Program_Code);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        dataGridView_Courses.Rows.RemoveAt(index);

                        adapterShow = new SqlDataAdapter("SELECT * FROM Program_Info", conn);
                        DT.Clear();
                        adapterShow.Fill(DT);
                        dataGridView_Courses.DataSource = DT;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting program: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a program to delete.");
            }
        }
    }
}
