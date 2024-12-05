using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CourseManagament.Resources
{
    public partial class Frm_Billing : Form
    {
        Color color = ColorTranslator.FromHtml("#0073bd");
        Color color_profile = ColorTranslator.FromHtml("#2C384A");

        SqlConnection conn = new SqlConnection("Data Source = ZERO; Initial Catalog = AdminDB; Integrated Security = true;");
        SqlDataAdapter adapterShow;
        DataTable DT = new DataTable();

        string sqlQuery = @"
                SELECT 
                Billing_id,
                Student_id,
                Total_Amount,
                Amount_ToPaid,
                CASE 
                    WHEN Payment_date IS NOT NULL THEN 'Paid'
                    WHEN Payment_date IS NULL AND CAST(Due_date AS DATE) < CAST(GETDATE() AS DATE) THEN 'Overdue'
                    WHEN Payment_date IS NULL AND CAST(Due_date AS DATE) >= CAST(GETDATE() AS DATE) THEN 'Pending'
                    ELSE 'Unknown Status'
                END AS Payment_Status,
                Due_date
            FROM Billing_Info;";


        public Frm_Billing()
        {
            InitializeComponent();

            panel1.BackColor = color;

            Dashboard_Panel.BackColor = color_profile;
            Lbl_Billing.ForeColor = color;
            
            adapterShow = new SqlDataAdapter(sqlQuery, conn);
            adapterShow.Fill(DT);
            dataGridView_Billing.DataSource = DT;
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

        private void Btn_Courses_Click(object sender, EventArgs e)
        {
            Frm_Courses frm_Courses = new Frm_Courses();
            this.Hide();
            frm_Courses.ShowDialog();
            this.Close();
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            int Student_Number;

            if (int.TryParse(Txt_StudentNumber.Text, out Student_Number))
            {
                try
                {
                    conn.Open();

                    SqlTransaction transaction = conn.BeginTransaction();

                    string querySelecting = @"
                    SELECT 
                        Billing_id,
                        Student_id,
                        Total_Amount,
                        Amount_ToPaid,
                        CASE 
                            WHEN Payment_date IS NOT NULL THEN 'Paid'
                            WHEN Payment_date IS NULL AND CAST(Due_date AS DATE) < CAST(GETDATE() AS DATE) THEN 'Overdue'
                            WHEN Payment_date IS NULL AND CAST(Due_date AS DATE) >= CAST(GETDATE() AS DATE) THEN 'Pending'
                            ELSE 'Unknown Status'
                        END AS Payment_Status,
                        FORMAT(Due_date, 'MM-dd-yyyy') AS Due_date
                    FROM Billing_Info 
                    WHERE Student_id = @StudentID;";



                    using (SqlCommand sqlCommand = new SqlCommand(querySelecting, conn, transaction))
                    {
                        sqlCommand.Parameters.AddWithValue("@StudentID", Student_Number);

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MessageBox.Show($"Billing ID: {reader["Billing_id"]}\n" +
                                                $"Student ID: {reader["Student_id"]}\n" +
                                                $"Total Amount: {reader["Total_Amount"]}\n" +
                                                $"Amount To Be Paid: {reader["Amount_ToPaid"]}\n" +
                                                $"Payment Status: {reader["Payment_Status"]}\n" +
                                                $"Due Date: {reader["Due_date"]}");
                            }
                        }
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Student Number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
