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
    public partial class Frm_Update_Student : Form
    {
        Color darkblue = ColorTranslator.FromHtml("#2C384A"); 
        Frm_EnrolledStudent student = new Frm_EnrolledStudent();

        public long Student_Number { get; set; }
        public string Student_First_Name { get; set; }
        public string Student_Middle_Name { get; set; }
        public string Student_Last_Name { get; set; }

        public string Date_Of_Birth { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string Address { get; set; }
        public long Student_Contact_Number { get; set; }
        public string Personal_Email { get; set; }
        public string School_Email { get; set; }
        public string Guardian_FullName { get; set; }
        public long Guardian_Contact_Number { get; set; }
        public string Guardian_Email { get; set; }
        public string Guardian_Relationship { get; set; }


        public Frm_Update_Student()
        {
            InitializeComponent();
            Top_Panel.BackColor = darkblue;
            Btn_Back.BackColor = darkblue;
            Btn_Back.ForeColor = Color.White;
            Btn_Submit.BackColor = darkblue;
            Btn_Submit.ForeColor = Color.White;
        }

        private bool UpdateStudent(long studentNumber, string firstName, string middleName, string lastName, string dateOfBirth, string gender, string nationality, string address, long contactNumber, string personalEmail, string schoolEmail, string guardianFullName, long guardianContactNumber, string guardianEmail, string GuardianRelationship)
        {
            string query = @"
            UPDATE Student_Info
            SET 
                First_Name = @FirstName,
                Middle_Name = @MiddleName,
                Last_Name = @LastName,
                Date_Of_Birth = @DateOfBirth,
                Gender = @Gender,
                Nationality = @Nationality,
                Address = @Address,
                Contact_Number = @ContactNumber,
                Personal_Email = @PersonalEmail,
                School_Email = @SchoolEmail,
                Guardian_FullName = @GuardianFullName,
                Guardian_Contact_Number = @GuardianContactNumber,
                Guardian_Email = @GuardianEmail,
                Guardian_Relationship = @GuardianRelationship
            WHERE 
                Student_Number = @StudentNumber";

            using (SqlConnection conn = new SqlConnection("Data Source=ZERO; Initial Catalog=AdminDB; Integrated Security=true;"))
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@StudentNumber", studentNumber);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@MiddleName", middleName ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@Nationality", nationality);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                    command.Parameters.AddWithValue("@PersonalEmail", personalEmail ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@SchoolEmail", schoolEmail ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@GuardianFullName", guardianFullName);
                    command.Parameters.AddWithValue("@GuardianContactNumber", guardianContactNumber);
                    command.Parameters.AddWithValue("@GuardianEmail", guardianEmail ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@GuardianRelationship", GuardianRelationship ?? (object)DBNull.Value);

                    try
                    {
                        conn.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occurred: {ex.Message}");
                        return false;
                    }
                }
            }
        }


        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Frm_EnrolledStudent frm_EnrolledStudent = new Frm_EnrolledStudent();
            this.Hide();
            frm_EnrolledStudent.ShowDialog();
            this.Close();
        }

        private void Frm_Update_Student_Load(object sender, EventArgs e)
        {
            Txt_StudentNumber.Text = Student_Number.ToString();
            TxtBox_StudentFname.Text = Student_First_Name;
            TxtBox_StudentMname.Text = Student_Middle_Name;
            TxtBox_StudentLname.Text = Student_Last_Name;
            TxtBox_DateOfBirth.Text = Date_Of_Birth;
            TxtBox_Gender.Text = Gender;
            TxtBox_Nationality.Text = Nationality;
            TxtBox_Address.Text = Address;
            TxtBox_ContactNum.Text = Student_Contact_Number.ToString();
            TxtBox_PersonalEmail.Text = Personal_Email;
            TxtBox_SchoolEmail.Text = School_Email;
            TxtBox_GuardianFname.Text = Guardian_FullName;
            TxtBox_GuardianContactNum.Text = Guardian_Contact_Number.ToString();
            TxtBox_GuardianEmail.Text = Guardian_Email;
            TxtBox_GuardianRelationship.Text = Guardian_Relationship;
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                long Student_Number = Convert.ToInt64(Txt_StudentNumber.Text);
                string Student_First_Name = TxtBox_StudentFname.Text;
                string Student_Middle_Name = TxtBox_StudentMname.Text;
                string Student_Last_Name = TxtBox_StudentLname.Text;
                string Date_Of_Birth = TxtBox_DateOfBirth.Text;
                string Gender = TxtBox_Gender.Text;
                string Nationality = TxtBox_Nationality.Text;
                string Address = TxtBox_Address.Text;
                long Student_Contact_Number = Convert.ToInt64(TxtBox_ContactNum.Text);
                string Personal_Email = TxtBox_PersonalEmail.Text;
                string School_Email = TxtBox_SchoolEmail.Text;
                string Guardian_FullName = TxtBox_GuardianFname.Text;
                long Guardian_Contact_Number = Convert.ToInt64(TxtBox_GuardianContactNum.Text);
                string Guardian_Email = TxtBox_GuardianEmail.Text;
                string Guardian_Relationship = TxtBox_GuardianRelationship.Text;

                if (!Required() || !ValidateFields())
                {
                    MessageBox.Show("Please fill in all the required fields correctly.");
                    return;
                }

                bool success = UpdateStudent(Student_Number, Student_First_Name, Student_Middle_Name, Student_Last_Name, Date_Of_Birth, Gender, Nationality, Address, Student_Contact_Number, Personal_Email, School_Email, Guardian_FullName, Guardian_Contact_Number, Guardian_Email, Guardian_Relationship);

                if (success)
                {
                    MessageBox.Show("Student Information updated successfully!", "Success");
                    this.Hide();
                    student.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update the Student Information. Please try again.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error");
            }
        }

        public bool Required()
        {
            if (string.IsNullOrWhiteSpace(Txt_StudentNumber.Text) ||
                string.IsNullOrWhiteSpace(TxtBox_StudentFname.Text) ||
                string.IsNullOrWhiteSpace(TxtBox_StudentMname.Text) ||
                string.IsNullOrWhiteSpace(TxtBox_StudentLname.Text) ||
                string.IsNullOrWhiteSpace(TxtBox_Gender.Text) ||
                string.IsNullOrWhiteSpace(TxtBox_Nationality.Text) ||
                string.IsNullOrWhiteSpace(TxtBox_Address.Text) ||
                string.IsNullOrWhiteSpace(TxtBox_ContactNum.Text) ||
                string.IsNullOrWhiteSpace(TxtBox_PersonalEmail.Text) ||
                string.IsNullOrWhiteSpace(TxtBox_SchoolEmail.Text) ||
                string.IsNullOrWhiteSpace(TxtBox_GuardianFname.Text) ||
                string.IsNullOrWhiteSpace(TxtBox_GuardianContactNum.Text) ||
                string.IsNullOrWhiteSpace(TxtBox_GuardianEmail.Text) ||
                string.IsNullOrWhiteSpace(TxtBox_GuardianRelationship.Text))
            {
                HighlightEmptyFields();

                DialogResult result = MessageBox.Show("Some required fields are empty. Please fill them in.", "Required Fields Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
            if (string.IsNullOrWhiteSpace(Txt_StudentNumber.Text)) { Txt_StudentNumber.BackColor = Color.Red; }
            if (string.IsNullOrWhiteSpace(TxtBox_StudentFname.Text)) { TxtBox_StudentFname.BackColor = Color.Red; }
            if (string.IsNullOrWhiteSpace(TxtBox_StudentMname.Text)) { TxtBox_StudentMname.BackColor = Color.Red; }
            if (string.IsNullOrWhiteSpace(TxtBox_StudentLname.Text)) { TxtBox_StudentLname.BackColor = Color.Red; }
            if (string.IsNullOrWhiteSpace(TxtBox_Gender.Text)) { TxtBox_Gender.BackColor = Color.Red; }
            if (string.IsNullOrWhiteSpace(TxtBox_Nationality.Text)) { TxtBox_Nationality.BackColor = Color.Red; }
            if (string.IsNullOrWhiteSpace(TxtBox_Address.Text)) { TxtBox_Address.BackColor = Color.Red; }
            if (string.IsNullOrWhiteSpace(TxtBox_ContactNum.Text)) { TxtBox_ContactNum.BackColor = Color.Red; }
            if (string.IsNullOrWhiteSpace(TxtBox_PersonalEmail.Text)) { TxtBox_PersonalEmail.BackColor = Color.Red; }
            if (string.IsNullOrWhiteSpace(TxtBox_SchoolEmail.Text)) { TxtBox_SchoolEmail.BackColor = Color.Red; }
            if (string.IsNullOrWhiteSpace(TxtBox_GuardianFname.Text)) { TxtBox_GuardianFname.BackColor = Color.Red; }
            if (string.IsNullOrWhiteSpace(TxtBox_GuardianContactNum.Text)) { TxtBox_GuardianContactNum.BackColor = Color.Red; }
            if (string.IsNullOrWhiteSpace(TxtBox_GuardianEmail.Text)) { TxtBox_GuardianEmail.BackColor = Color.Red; }
            if (string.IsNullOrWhiteSpace(TxtBox_GuardianRelationship.Text)) { TxtBox_GuardianRelationship.BackColor = Color.Red; }
        }
        public void ResetFieldColors()
        {
            Txt_StudentNumber.BackColor = SystemColors.Window;
            TxtBox_StudentFname.BackColor = SystemColors.Window;
            TxtBox_StudentMname.BackColor = SystemColors.Window;
            TxtBox_StudentLname.BackColor = SystemColors.Window;
            TxtBox_Gender.BackColor = SystemColors.Window;
            TxtBox_Nationality.BackColor = SystemColors.Window;
            TxtBox_Address.BackColor = SystemColors.Window;
            TxtBox_ContactNum.BackColor = SystemColors.Window;
            TxtBox_PersonalEmail.BackColor = SystemColors.Window;
            TxtBox_SchoolEmail.BackColor = SystemColors.Window;
            TxtBox_GuardianFname.BackColor = SystemColors.Window;
            TxtBox_GuardianContactNum.BackColor = SystemColors.Window;
            TxtBox_GuardianEmail.BackColor = SystemColors.Window;
            TxtBox_GuardianRelationship.BackColor = SystemColors.Window;
        }

        public bool ValidateFields()
        {
            bool isValid = true;
            string errorMessage = "";

            Regex lettersOnlyRegex = new Regex(@"^[a-zA-Z\s]+$");
            if (!lettersOnlyRegex.IsMatch(TxtBox_StudentFname.Text))
            {
                TxtBox_StudentFname.ForeColor = Color.Red;
                TxtBox_StudentFname.BackColor = Color.LightCoral;
                errorMessage += "- First Name is invalid. It must contain only letters.\n";
                isValid = false;
            }
            else
            {
                TxtBox_StudentFname.ForeColor = SystemColors.WindowText;
                TxtBox_StudentFname.BackColor = SystemColors.Window;
            }

            if (!lettersOnlyRegex.IsMatch(TxtBox_StudentLname.Text))
            {
                TxtBox_StudentLname.ForeColor = Color.Red;
                TxtBox_StudentLname.BackColor = Color.LightCoral;
                errorMessage += "- Last Name is invalid. It must contain only letters.\n";
                isValid = false;
            }
            else
            {
                TxtBox_StudentLname.ForeColor = SystemColors.WindowText;
                TxtBox_StudentLname.BackColor = SystemColors.Window;
            }

            // Validate email fields
            Regex emailRegex = new Regex(@"^[^@]+@[^@]+\.[^@]+$");
            if (!emailRegex.IsMatch(TxtBox_PersonalEmail.Text))
            {
                TxtBox_PersonalEmail.ForeColor = Color.Red;
                TxtBox_PersonalEmail.BackColor = Color.LightCoral;
                errorMessage += "- Personal Email is invalid.\n";
                isValid = false;
            }
            else
            {
                TxtBox_PersonalEmail.ForeColor = SystemColors.WindowText;
                TxtBox_PersonalEmail.BackColor = SystemColors.Window;
            }

            if (!emailRegex.IsMatch(TxtBox_SchoolEmail.Text))
            {
                TxtBox_SchoolEmail.ForeColor = Color.Red;
                TxtBox_SchoolEmail.BackColor = Color.LightCoral;
                errorMessage += "- School Email is invalid.\n";
                isValid = false;
            }
            else
            {
                TxtBox_SchoolEmail.ForeColor = SystemColors.WindowText;
                TxtBox_SchoolEmail.BackColor = SystemColors.Window;
            }

            // Validate contact numbers (must be a valid number)
            Regex numbersOnlyRegex = new Regex(@"^[1-9]\d*$");
            long contactNumber;
            if (!numbersOnlyRegex.IsMatch(TxtBox_ContactNum.Text) || !long.TryParse(TxtBox_ContactNum.Text, out contactNumber))
            {
                TxtBox_ContactNum.ForeColor = Color.Red;
                TxtBox_ContactNum.BackColor = Color.LightCoral;
                errorMessage += "- Contact Number is invalid.\n";
                isValid = false;
            }
            else
            {
                TxtBox_ContactNum.ForeColor = SystemColors.WindowText;
                TxtBox_ContactNum.BackColor = SystemColors.Window;
            }

            long guardianContactNumber;
            if (!numbersOnlyRegex.IsMatch(TxtBox_GuardianContactNum.Text) || !long.TryParse(TxtBox_GuardianContactNum.Text, out guardianContactNumber))
            {
                TxtBox_GuardianContactNum.ForeColor = Color.Red;
                TxtBox_GuardianContactNum.BackColor = Color.LightCoral;
                errorMessage += "- Guardian Contact Number is invalid.\n";
                isValid = false;
            }
            else
            {
                TxtBox_GuardianContactNum.ForeColor = SystemColors.WindowText;
                TxtBox_GuardianContactNum.BackColor = SystemColors.Window;
            }

            // If any validation failed, show the error message
            if (!isValid)
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return isValid;
        }


    }
}