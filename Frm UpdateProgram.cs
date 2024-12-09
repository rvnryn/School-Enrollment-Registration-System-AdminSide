using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManagament
{
    public partial class Frm_UpdateProgram : Form
    {
        Color darkblue = ColorTranslator.FromHtml("#2C384A");
        Frm_Courses frm_Courses = new Frm_Courses();

        public int Program_Code { get; set; }
        public string Program_Name { get; set; }
        public string Program_Description { get; set; }
        public int Program_Capacity { get; set; }

        public double FirstYear_1stSem { get; set; }
        public double FirstYear_2ndSem { get; set; }
        public double SecondYear_1stSem { get; set; }
        public double SecondYear_2ndSem { get; set; }
        public double ThirdYear_1stSem { get; set; }
        public double ThirdYear_2ndSem { get; set; }
        public double FourthYear_1stSem { get; set; }
        public double FourthYear_2ndSem { get; set; }



        public Frm_UpdateProgram()
        {
            InitializeComponent();
            Top_Panel.BackColor = darkblue;
            Btn_Back.BackColor = darkblue;
            Btn_Back.ForeColor = Color.White;
            Btn_Submit.BackColor = darkblue;
            Btn_Submit.ForeColor = Color.White;

            this.Load += Frm_UpdateProgram_Load;
        }


        private bool UpdateProgram(int programCode, string programName, string programDescription, int programCapacity,
                           double firstYear1stSem, double firstYear2ndSem, double secondYear1stSem, double secondYear2ndSem,
                           double thirdYear1stSem, double thirdYear2ndSem, double fourthYear1stSem, double fourthYear2ndSem)
        {
            try
            {
                string query = @"
                UPDATE Program_Info 
                SET 
                Program_Code = @ProgramCode,
                Program_Name = @ProgramName,
                Program_Capacity = @Capacity,
                Program_Description = @Description,
                TuitionFee_1stYear_1stSem = @FirstYear1stSem,
                TuitionFee_1stYear_2ndSem = @FirstYear2ndSem,
                TuitionFee_2ndYear_1stSem = @SecondYear1stSem,
                TuitionFee_2ndYear_2ndSem = @SecondYear2ndSem,
                TuitionFee_3rdYear_1stSem = @ThirdYear1stSem,
                TuitionFee_3rdYear_2ndSem = @ThirdYear2ndSem,
                TuitionFee_4thYear_1stSem = @FourthYear1stSem,
                TuitionFee_4thYear_2ndSem = @FourthYear2ndSem
                WHERE Program_Code = @ProgramCode";

                using (SqlConnection conn = new SqlConnection("Data Source=ZERO; Initial Catalog=AdminDB; Integrated Security=true;"))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProgramCode", programCode);
                    cmd.Parameters.AddWithValue("@ProgramName", string.IsNullOrWhiteSpace(programName) ? DBNull.Value : (object)programName);
                    cmd.Parameters.AddWithValue("@Description", string.IsNullOrWhiteSpace(programDescription) ? DBNull.Value : (object)programDescription);
                    cmd.Parameters.AddWithValue("@Capacity", programCapacity > 0 ? (object)programCapacity : DBNull.Value);

                    cmd.Parameters.AddWithValue("@FirstYear1stSem", firstYear1stSem > 0 ? (object)firstYear1stSem : DBNull.Value);
                    cmd.Parameters.AddWithValue("@FirstYear2ndSem", firstYear2ndSem > 0 ? (object)firstYear2ndSem : DBNull.Value);
                    cmd.Parameters.AddWithValue("@SecondYear1stSem", secondYear1stSem > 0 ? (object)secondYear1stSem : DBNull.Value);
                    cmd.Parameters.AddWithValue("@SecondYear2ndSem", secondYear2ndSem > 0 ? (object)secondYear2ndSem : DBNull.Value);
                    cmd.Parameters.AddWithValue("@ThirdYear1stSem", thirdYear1stSem > 0 ? (object)thirdYear1stSem : DBNull.Value);
                    cmd.Parameters.AddWithValue("@ThirdYear2ndSem", thirdYear2ndSem > 0 ? (object)thirdYear2ndSem : DBNull.Value);
                    cmd.Parameters.AddWithValue("@FourthYear1stSem", fourthYear1stSem > 0 ? (object)fourthYear1stSem : DBNull.Value);
                    cmd.Parameters.AddWithValue("@FourthYear2ndSem", fourthYear2ndSem > 0 ? (object)fourthYear2ndSem : DBNull.Value);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("No matching program found to update.", "Info");
                    }

                    return rowsAffected >= 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
                return false;
            }
        }

        private void Frm_UpdateProgram_Load(object sender, EventArgs e)
        {
            txt_ProgramCode.Text = Program_Code.ToString();
            txt_ProgramName.Text = Program_Name;
            txt_ProgramCapacity.Text = Program_Capacity.ToString();
            richTextBox_ProgramDescription.Text = Program_Description;
            TxtBox_1stYear_1stSem.Text = FirstYear_1stSem.ToString();
            TxtBox_1stYear_2ndSem.Text = FirstYear_2ndSem.ToString();
            TxtBox_2ndYear_1stSem.Text = SecondYear_1stSem.ToString();
            TxtBox_2ndYear_2ndSem.Text = SecondYear_2ndSem.ToString();
            TxtBox_3rdYear_1stSem.Text = ThirdYear_1stSem.ToString();
            TxtBox_3rdYear_2ndSem.Text = ThirdYear_2ndSem.ToString();
            TxtBox_4thYear_1stSem.Text = FourthYear_1stSem.ToString();
            TxtBox_4thYear_2ndSem.Text = FourthYear_2ndSem.ToString();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Courses.ShowDialog();
            this.Close();
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {

            try
            {
                int programCode = Convert.ToInt32(txt_ProgramCode.Text);
                string programName = txt_ProgramName.Text;
                int programCapacity = Convert.ToInt32(txt_ProgramCapacity.Text);
                string programDescription = richTextBox_ProgramDescription.Text;

                double firstYear1stSem = Convert.ToDouble(TxtBox_1stYear_1stSem.Text);
                double firstYear2ndSem = Convert.ToDouble(TxtBox_1stYear_2ndSem.Text);

                double secondYear1stSem = Convert.ToDouble(TxtBox_2ndYear_1stSem.Text);
                double secondYear2ndSem = Convert.ToDouble(TxtBox_2ndYear_2ndSem.Text);

                double thirdYear1stSem = Convert.ToDouble(TxtBox_3rdYear_1stSem.Text);
                double thirdYear2ndSem = Convert.ToDouble(TxtBox_3rdYear_2ndSem.Text);

                double fourthYear1stSem = Convert.ToDouble(TxtBox_4thYear_1stSem.Text);
                double fourthYear2ndSem = Convert.ToDouble(TxtBox_4thYear_2ndSem.Text);

                if (!Required() || !ValidateFields())
                {
                    MessageBox.Show("Please fill in all the required fields correctly.");
                    return;
                }

                bool success = UpdateProgram(programCode, programName, programDescription, programCapacity,
                                             firstYear1stSem, firstYear2ndSem, secondYear1stSem, secondYear2ndSem,
                                             thirdYear1stSem, thirdYear2ndSem, fourthYear1stSem, fourthYear2ndSem);

                if (success)
                {
                    MessageBox.Show("Program updated successfully!", "Success");
                    this.Hide();
                    frm_Courses.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error");
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

            Regex lettersOnlyRegex = new Regex(@"^[a-zA-Z\s]+$");

            Regex numbersOnlyRegex = new Regex(@"^[1-9]\d*$");

            string errorMessage = "";

            if (!lettersOnlyRegex.IsMatch(txt_ProgramName.Text))
            {
                txt_ProgramName.ForeColor = Color.Red;
                txt_ProgramName.BackColor = Color.LightCoral;

                errorMessage += "- Program Name is invalid. It must contain only letters and spaces.\n";
                isValid = false;
            }
            else
            {
                txt_ProgramName.ForeColor = SystemColors.WindowText;
                txt_ProgramName.BackColor = SystemColors.Window;
            }

            List<TextBox> programFields = new List<TextBox>
            {
                txt_ProgramCode, txt_ProgramCapacity
            };

            foreach (var textBox in programFields)
            {
                if (!numbersOnlyRegex.IsMatch(textBox.Text))
                {
                    textBox.ForeColor = Color.Red;
                    textBox.BackColor = Color.LightCoral;

                    errorMessage += $"- {textBox.Name} is invalid. It must be a positive number greater than 0.\n";
                    isValid = false;
                }
                else
                {
                    textBox.ForeColor = SystemColors.WindowText;
                    textBox.BackColor = SystemColors.Window;
                }
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

                    errorMessage += $"- {textBox.Name} is invalid. It must be a positive number greater than 0.\n";
                    isValid = false;
                }
                else
                {
                    textBox.ForeColor = SystemColors.WindowText;
                    textBox.BackColor = SystemColors.Window;
                }
            }

            if (!isValid)
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
