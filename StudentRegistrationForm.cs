using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StudentProject
{
    public partial class StudentRegistrationForm : Form
    {
        public static string connectionString = Constants.connectionString;

        public StudentRegistrationForm()
        {
            InitializeComponent();
            LoadRegNoItems();
        }

        private void ResetForm()
        {
            RegistrationForm_RegNo_ComboBox.ResetText();
            RegistrationForm_FirstName_TextBox.ResetText();
            RegistrationForm_LastName_TextBox.ResetText();
            RegistrationForm_DateOfBirth_DateTimePicker.ResetText();
            RegistrationForm_GenderMale_RadioButton.Checked = true;
            RegistrationForm_Address_TextBox.ResetText();
            RegistrationForm_Email_TextBox.ResetText();
            RegistrationForm_MobilePhone_TextBox.ResetText();
            RegistrationForm_HomePhone_TextBox.ResetText();
            RegistrationForm_ParentName_TextBox.ResetText();
            RegistrationForm_NIC_TextBox.ResetText();
            RegistrationForm_ContactNumber_TextBox.ResetText();
        }

        private void SetCommandParameters(SqlCommand command)
        {
            int regNo = Convert.ToInt32(RegistrationForm_RegNo_ComboBox.Text.Trim());

            var firstName = RegistrationForm_FirstName_TextBox.Text.Trim();
            var lastName = RegistrationForm_LastName_TextBox.Text.Trim();
            var dateOfBirth = RegistrationForm_DateOfBirth_DateTimePicker.Text;

            var gender = RegistrationForm_GenderMale_RadioButton.Checked ?
                RegistrationForm_GenderMale_RadioButton.Text : RegistrationForm_GenderFemale_RadioButton.Text;

            /*
            if (RegistrationForm_GenderMale_RadioButton.Checked)
            {
                gender = RegistrationForm_GenderMale_RadioButton.Text;
            }
            else
            {
                gender = RegistrationForm_GenderFemale_RadioButton.Text;
            }
            */

            var address = RegistrationForm_Address_TextBox.Text.Trim();
            var email = RegistrationForm_Email_TextBox.Text.Trim();
            var mobilePhone = RegistrationForm_MobilePhone_TextBox.Text.Trim();
            var homePhone = RegistrationForm_HomePhone_TextBox.Text.Trim();

            var parentName = RegistrationForm_ParentName_TextBox.Text.Trim();
            var nic = RegistrationForm_NIC_TextBox.Text.Trim();
            var contactNumber = RegistrationForm_ContactNumber_TextBox.Text.Trim();

            command.Parameters.AddWithValue("@regNo", regNo);
            command.Parameters.AddWithValue("@firstName", !string.IsNullOrEmpty(firstName) ? firstName : DBNull.Value);
            command.Parameters.AddWithValue("@lastName", !string.IsNullOrEmpty(lastName) ? lastName : DBNull.Value);
            command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
            command.Parameters.AddWithValue("@gender", gender);
            command.Parameters.AddWithValue("@address", !string.IsNullOrEmpty(address) ? address : DBNull.Value);
            command.Parameters.AddWithValue("@email", !string.IsNullOrEmpty(email) ? email : DBNull.Value);
            command.Parameters.AddWithValue("@mobilePhone", !string.IsNullOrEmpty(mobilePhone) ? mobilePhone : DBNull.Value);
            command.Parameters.AddWithValue("@homePhone", !string.IsNullOrEmpty(homePhone) ? homePhone : DBNull.Value);
            command.Parameters.AddWithValue("@parentName", !string.IsNullOrEmpty(parentName) ? parentName : DBNull.Value);
            command.Parameters.AddWithValue("@nic", !string.IsNullOrEmpty(nic) ? nic : DBNull.Value);
            command.Parameters.AddWithValue("@contactNumber", !string.IsNullOrEmpty(contactNumber) ? contactNumber : DBNull.Value);
        }

        private void LoadRegNoItems()
        {
            var con = new SqlConnection();

            try
            {
                var query = @$"select RegNo from Registration";

                using (con = new SqlConnection(connectionString))
                {
                    con.Open();
                    var command = new SqlCommand(query, con)
                    {
                        CommandType = CommandType.Text
                    };

                    var reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            RegistrationForm_RegNo_ComboBox.Items.Add(reader["RegNo"].ToString());
                        }
                    }

                    reader.Close();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void RegistrationForm_Register_Button_Click(object sender, EventArgs e)
        {
            var con = new SqlConnection();
            try
            {
                var query = @$"insert into Registration (regNo, firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo)" +
                "values (@regNo, @firstName, @lastName, @dateOfBirth, @gender, @address, @email, @mobilePhone, @homePhone, @parentName, @nic, @contactNumber)";

                using (con = new SqlConnection(connectionString))
                {
                    con.Open();
                    var command = new SqlCommand(query, con)
                    {
                        CommandType = CommandType.Text
                    };
                    SetCommandParameters(command);

                    var reader = command.ExecuteNonQuery();
                    RegistrationForm_RegNo_ComboBox.Items.Add(RegistrationForm_RegNo_ComboBox.Text.Trim());
                    MessageBox.Show("Record Added Succesfully", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void RegistrationForm_Clear_Button_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void RegistrationForm_Exit_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var exitDialog = MessageBox.Show("Are you sure, Do you really want to exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitDialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void RegistrationForm_Logout_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "LoginForm")
                    Application.OpenForms[i].Close();
            }

            Application.OpenForms[0].Show();
        }

        private void RegistrationForm_RegNo_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var val = Convert.ToInt32(RegistrationForm_RegNo_ComboBox.Text);
            var con = new SqlConnection();

            try
            {
                var query = @$"select firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo from Registration where regNo = {val}";

                using (con = new SqlConnection(connectionString))
                {
                    con.Open();
                    var command = new SqlCommand(query, con)
                    {
                        CommandType = CommandType.Text
                    };

                    var reader = command.ExecuteReader();
                    if (reader.HasRows && reader.Read())
                    {
                        RegistrationForm_FirstName_TextBox.Text = reader["firstName"].ToString();
                        RegistrationForm_LastName_TextBox.Text = reader["lastName"].ToString();
                        RegistrationForm_DateOfBirth_DateTimePicker.Text = reader["dateOfBirth"].ToString();

                        if (reader["gender"].ToString() is "Male")
                        {
                            RegistrationForm_GenderMale_RadioButton.Checked = true;
                        }
                        else
                        {
                            RegistrationForm_GenderFemale_RadioButton.Checked = true;
                        }

                        RegistrationForm_Address_TextBox.Text = reader["address"].ToString();
                        RegistrationForm_Email_TextBox.Text = reader["email"].ToString();
                        RegistrationForm_MobilePhone_TextBox.Text = reader["mobilePhone"].ToString();
                        RegistrationForm_HomePhone_TextBox.Text = reader["homePhone"].ToString();
                        RegistrationForm_ParentName_TextBox.Text = reader["parentName"].ToString();
                        RegistrationForm_NIC_TextBox.Text = reader["nic"].ToString();
                        RegistrationForm_ContactNumber_TextBox.Text = reader["contactNo"].ToString();
                    }

                    reader.Close();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unexpected error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void RegistrationForm_Delete_Button_Click(object sender, EventArgs e)
        {
            var con = new SqlConnection();

            try
            {
                var regNo = Convert.ToInt32(RegistrationForm_RegNo_ComboBox.Text);
                var selQuery = @$"select regNo from Registration where regNo = {regNo}";
                var delQuery = @$"delete from Registration where regNo = {regNo}";

                using (con = new SqlConnection(connectionString))
                {
                    con.Open();
                    var selectCommand = new SqlCommand(selQuery, con)
                    {
                        CommandType = CommandType.Text
                    };

                    var reader = selectCommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        var deleteDialog = MessageBox.Show(
                            "Are you sure, Do you really want to Delete this Record...?",
                            "Delete",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (deleteDialog == DialogResult.Yes)
                        {
                            reader.Close();
                            var delCommand = new SqlCommand(delQuery, con)
                            {
                                CommandType = CommandType.Text
                            };
                            delCommand.ExecuteNonQuery();
                            MessageBox.Show("Record Deleted Succesfully", "Delete Student",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ResetForm();
                            RegistrationForm_RegNo_ComboBox.Items.Remove(regNo.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid record", "Delete Student",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    reader.Close();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void RegistrationForm_Update_Button_Click(object sender, EventArgs e)
        {
            var con = new SqlConnection();

            try
            {
                var regNo = Convert.ToInt32(RegistrationForm_RegNo_ComboBox.Text);
                var selQuery = @$"select regNo from Registration where regNo = {regNo}";
                var updateQuery = @$"update Registration set
                                firstName = @firstName, 
                                lastName = @lastName, 
                                dateOfBirth = @dateOfBirth, 
                                gender = @gender, 
                                address = @address, 
                                email = @email, 
                                mobilePhone = @mobilePhone, 
                                homePhone = @homePhone, 
                                parentName = @parentName, 
                                nic = @nic, 
                                contactNo = @contactNumber 
                                from Registration where regNo = @regNo";

                using (con = new SqlConnection(connectionString))
                {
                    con.Open();
                    var selectCommand = new SqlCommand(selQuery, con)
                    {
                        CommandType = CommandType.Text
                    };

                    var reader = selectCommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Close();
                        var updateCommand = new SqlCommand(updateQuery, con)
                        {
                            CommandType = CommandType.Text
                        };
                        SetCommandParameters(updateCommand);

                        updateCommand.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Succesfully", "Update Student",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Invalid record", "Update Student",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    reader.Close();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
