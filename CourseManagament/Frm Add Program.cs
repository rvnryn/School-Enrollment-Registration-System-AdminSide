using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManagament
{
    public partial class Frm_AddProgram : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = ZERO; Initial Catalog = AdminDB; Integrated Security = true;");

        Regex NumbersOnlyRegex = new Regex(@"^\d+(\.\d+)?$");
        Regex lettersOnlyRegex = new Regex(@"^[a-zA-Z]+$");

        Color darkblue = ColorTranslator.FromHtml("#2C384A");

        int programCode = 0;
        int programCapacity = 0;
        double FirstYear_1stSem = 0;
        double FirstYear_2ndSem = 0;
        double SecondYear_1stSem = 0;
        double SecondYear_2ndSem = 0;
        double ThirdYear_1stSem = 0;
        double ThirdYear_2ndSem = 0;
        double FourthYear_1stSem = 0;
        double FourthYear_2ndSem = 0;

        public Frm_AddProgram()
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
            Frm_Courses frm_Courses = new Frm_Courses();
            this.Hide();
            frm_Courses.ShowDialog();
            this.Close();
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {

            if (!Required() || !ValidateFields())
            {
                MessageBox.Show("Please fill in all the required fields correctly.");
                return;
            }

            Courses courses = new Courses(programCode, txt_ProgramName.Text, programCapacity, richTextBox_ProgramDescription.Text,
                                          FirstYear_1stSem, FirstYear_2ndSem, SecondYear_1stSem, SecondYear_2ndSem,
                                          ThirdYear_1stSem, ThirdYear_2ndSem, FourthYear_1stSem, FourthYear_2ndSem);

            try
            {
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();

                SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM Program_Info WHERE Program_Code = @ProgramCode", conn);
                checkCommand.Transaction = transaction;
                checkCommand.Parameters.AddWithValue("@ProgramCode", courses.Program_Code);
                int existingRecordsCount = (int)checkCommand.ExecuteScalar();

                if (existingRecordsCount == 0)
                {
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO Program_Info (Program_Code, Program_Name, Program_Capacity, Program_Description, TuitionFee_1stYear_1stSem, TuitionFee_1stYear_2ndSem, TuitionFee_2ndYear_1stSem, TuitionFee_2ndYear_2ndSem, TuitionFee_3rdYear_1stSem, TuitionFee_3rdYear_2ndSem, TuitionFee_4thYear_1stSem, TuitionFee_4thYear_2ndSem) " +
                                                              "VALUES (@ProgramCode, @ProgramName, @ProgramCapacity, @ProgramDescription, @FirstYear_1stSem, @FirstYear_2ndSem, @SecondYear_1stSem, @SecondYear_2ndSem, @ThirdYear_1stSem, @ThirdYear_2ndSem, @FourthYear_1stSem, @FourthYear_2ndSem)", conn);
                    insertCommand.Transaction = transaction;

                    insertCommand.Parameters.AddWithValue("@ProgramCode", courses.Program_Code);
                    insertCommand.Parameters.AddWithValue("@ProgramName", courses.Program_Name);
                    insertCommand.Parameters.AddWithValue("@ProgramCapacity", courses.Program_Capacity);
                    insertCommand.Parameters.AddWithValue("@ProgramDescription", courses.Program_Description);
                    insertCommand.Parameters.AddWithValue("@FirstYear_1stSem", courses.FirstYear_1stSem);
                    insertCommand.Parameters.AddWithValue("@FirstYear_2ndSem", courses.FirstYear_2ndSem);
                    insertCommand.Parameters.AddWithValue("@SecondYear_1stSem", courses.SecondYear_1stSem);
                    insertCommand.Parameters.AddWithValue("@SecondYear_2ndSem", courses.SecondYear_2ndSem);
                    insertCommand.Parameters.AddWithValue("@ThirdYear_1stSem", courses.ThirdYear_1stSem);
                    insertCommand.Parameters.AddWithValue("@ThirdYear_2ndSem", courses.ThirdYear_2ndSem);
                    insertCommand.Parameters.AddWithValue("@FourthYear_1stSem", courses.FourthYear_1stSem);
                    insertCommand.Parameters.AddWithValue("@FourthYear_2ndSem", courses.FourthYear_2ndSem);

                    insertCommand.ExecuteNonQuery();

                    transaction.Commit();
                    DialogResult result = MessageBox.Show("Course added successfully!");
                    if(result == DialogResult.OK)
                    {
                        Frm_Courses frm_Courses = new Frm_Courses();
                        ClearAllTextBoxes();

                        this.Hide();
                        frm_Courses.ShowDialog();
                        this.Close();

                    }

                }
                else
                {
                    MessageBox.Show("Program already exists.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            finally
            {
                conn.Close();
            }
        }

        public bool Required()
        {
            if (string.IsNullOrWhiteSpace(txt_ProgramCode.Text) ||
                string.IsNullOrWhiteSpace(txt_ProgramName.Text) ||
                string.IsNullOrWhiteSpace(txt_ProgramCapacity.Text) ||
                string.IsNullOrWhiteSpace(richTextBox_ProgramDescription.Text) ||
                string.IsNullOrWhiteSpace(TxtBox_1stYear_1stSem.Text) ||
                string.IsNullOrWhiteSpace(TxtBox_1stYear_2ndSem.Text) ||
                string.IsNullOrWhiteSpace(TxtBox_2ndYear_1stSem.Text) ||
                string.IsNullOrWhiteSpace(TxtBox_2ndYear_2ndSem.Text) ||
                string.IsNullOrWhiteSpace(TxtBox_3rdYear_1stSem.Text) ||
                string.IsNullOrWhiteSpace(TxtBox_3rdYear_2ndSem.Text) ||
                string.IsNullOrWhiteSpace(TxtBox_4thYear_1stSem.Text) ||
                string.IsNullOrWhiteSpace(TxtBox_4thYear_2ndSem.Text))
            {
                HighlightEmptyFields();

                DialogResult result = MessageBox.Show("Courses Information is incomplete. Please fill in all fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    ResetFieldColors();
                }
                return false;
            }
            return true;
        }

        public void HighlightEmptyFields()
        {
            if (string.IsNullOrWhiteSpace(txt_ProgramCode.Text)) { txt_ProgramCode.BackColor = Color.Red; }
            if (string.IsNullOrWhiteSpace(txt_ProgramName.Text)) { txt_ProgramName.BackColor = Color.Red; }
            if (string.IsNullOrWhiteSpace(txt_ProgramCapacity.Text)) { txt_ProgramCapacity.BackColor = Color.Red; }
            if (string.IsNullOrWhiteSpace(richTextBox_ProgramDescription.Text)) { richTextBox_ProgramDescription.BackColor = Color.Red; }
            if (string.IsNullOrWhiteSpace(TxtBox_1stYear_1stSem.Text)) { TxtBox_1stYear_1stSem.BackColor = Color.Red; }
            if (string.IsNullOrWhiteSpace(TxtBox_1stYear_2ndSem.Text)) { TxtBox_1stYear_2ndSem.BackColor = Color.Red; }
            if (string.IsNullOrWhiteSpace(TxtBox_2ndYear_1stSem.Text)) { TxtBox_2ndYear_1stSem.BackColor = Color.Red; }
            if (string.IsNullOrWhiteSpace(TxtBox_2ndYear_2ndSem.Text)) { TxtBox_2ndYear_2ndSem.BackColor = Color.Red; }
            if (string.IsNullOrWhiteSpace(TxtBox_3rdYear_1stSem.Text)) { TxtBox_3rdYear_1stSem.BackColor = Color.Red; }
            if (string.IsNullOrWhiteSpace(TxtBox_3rdYear_2ndSem.Text)) { TxtBox_3rdYear_2ndSem.BackColor = Color.Red; }
            if (string.IsNullOrWhiteSpace(TxtBox_4thYear_1stSem.Text)) { TxtBox_4thYear_1stSem.BackColor = Color.Red; }
            if (string.IsNullOrWhiteSpace(TxtBox_4thYear_2ndSem.Text)) { TxtBox_4thYear_2ndSem.BackColor = Color.Red; }
        }

        public void ResetFieldColors()
        {
            txt_ProgramCode.BackColor = SystemColors.Window;
            txt_ProgramName.BackColor = SystemColors.Window;
            txt_ProgramCapacity.BackColor = SystemColors.Window;
            richTextBox_ProgramDescription.BackColor = SystemColors.Window;
            TxtBox_1stYear_1stSem.BackColor = SystemColors.Window;
            TxtBox_1stYear_2ndSem.BackColor = SystemColors.Window;
            TxtBox_2ndYear_1stSem.BackColor = SystemColors.Window;
            TxtBox_2ndYear_2ndSem.BackColor = SystemColors.Window;
            TxtBox_3rdYear_1stSem.BackColor = SystemColors.Window;
            TxtBox_3rdYear_2ndSem.BackColor = SystemColors.Window;
            TxtBox_4thYear_1stSem.BackColor = SystemColors.Window;
            TxtBox_4thYear_2ndSem.BackColor = SystemColors.Window;
        }


        public bool ValidateFields()
        {
            bool isValid = true;

            List<TextBox> textBoxes = new List<TextBox>
            {
                txt_ProgramCode, txt_ProgramName, txt_ProgramCapacity,
                TxtBox_1stYear_1stSem, TxtBox_1stYear_2ndSem,
                TxtBox_2ndYear_1stSem, TxtBox_2ndYear_2ndSem,
                TxtBox_3rdYear_1stSem, TxtBox_3rdYear_2ndSem,
                TxtBox_4thYear_1stSem, TxtBox_4thYear_2ndSem
            };

            Regex lettersOnlyRegex = new Regex(@"^[a-zA-Z\s]+$");
            Regex numbersOnlyRegex = new Regex(@"^\d+(\.\d+)?$");

            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.ForeColor = Color.Red;
                    textBox.BackColor = Color.LightCoral;
                    isValid = false;
                }
                else
                {
                    textBox.ForeColor = SystemColors.WindowText;
                    textBox.BackColor = SystemColors.Window;
                }
            }

            if (!lettersOnlyRegex.IsMatch(txt_ProgramName.Text))
            {
                txt_ProgramName.ForeColor = Color.Red;
                txt_ProgramName.BackColor = Color.LightCoral;
                isValid = false;
            }
            else
            {
                txt_ProgramName.ForeColor = SystemColors.WindowText;
                txt_ProgramName.BackColor = SystemColors.Window;
            }

            List<TextBox> yearSemesterFields = new List<TextBox>
            {
                TxtBox_1stYear_1stSem, TxtBox_1stYear_2ndSem,
                TxtBox_2ndYear_1stSem, TxtBox_2ndYear_2ndSem,
                TxtBox_3rdYear_1stSem, TxtBox_3rdYear_2ndSem,
                TxtBox_4thYear_1stSem, TxtBox_4thYear_2ndSem
            };

            foreach (var textBox in yearSemesterFields)
            {
                if (!numbersOnlyRegex.IsMatch(textBox.Text))
                {
                    textBox.ForeColor = Color.Red;
                    textBox.BackColor = Color.LightCoral;
                    isValid = false;
                }
                else
                {
                    textBox.ForeColor = SystemColors.WindowText;
                    textBox.BackColor = SystemColors.Window;
                }
            }

            return isValid;
        }


        public void ClearAllTextBoxes()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Clear();
                }
                if (control is RichTextBox)
                {
                    (control as RichTextBox).Clear();
                }
            }
        }

    }
}




