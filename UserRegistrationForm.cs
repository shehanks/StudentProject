using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentProject
{
    public partial class UserRegistrationForm : Form
    {
        public static string connectionString = Constants.connectionString;

        public UserRegistrationForm()
        {
            InitializeComponent();
        }

        private void ResetForm()
        {
            UserRegistration_Username_TextBox.ResetText();
            UserRegistration_Password_TextBox.ResetText();
        }

        private void UserRegistration_Logout_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "LoginForm")
                    Application.OpenForms[i].Close();
            }

            Application.OpenForms[0].Show();
        }

        private void UserRegistration_Exit_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var dialogResult = MessageBox.Show(
                "Are you sure, Do you really want to Exit...?",
                "Exit", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void UserRegistration_Register_Button_Click(object sender, EventArgs e)
        {
            var con = new SqlConnection();
            try
            {
                var query = @$"insert into UserLogin (username, [password])" +
                "values (@username, @password)";

                using (con = new SqlConnection(connectionString))
                {
                    con.Open();
                    var command = new SqlCommand(query, con)
                    {
                        CommandType = CommandType.Text
                    };

                    command.Parameters.AddWithValue("@username", UserRegistration_Username_TextBox.Text.Trim());
                    command.Parameters.AddWithValue("@password", UserRegistration_Password_TextBox.Text.Trim());

                    var reader = command.ExecuteNonQuery();
                    MessageBox.Show("User Added Succesfully", "Register User", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
