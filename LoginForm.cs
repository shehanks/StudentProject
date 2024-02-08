using Microsoft.Data.SqlClient;
using System.Data;

namespace StudentProject
{
    public partial class LoginForm : Form
    {
        public static string connectionString = Constants.connectionString;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Clear_Button_Click(object sender, EventArgs e)
        {
            LoginForm_Password_Textbox.Clear();
            LoginForm_Username_Textbox.Clear();
            LoginForm_Username_Textbox.Focus();
        }

        private void LoginForm_Exit_Button_Click(object sender, EventArgs e)
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

        private void LoginForm_Login_Button_Click(object sender, EventArgs e)
        {
            var con = new SqlConnection();
            var userName = LoginForm_Username_Textbox.Text;
            var password = LoginForm_Password_Textbox.Text;

            try
            {
                var query = @$"select top 1 * from UserLogin where username = '{userName}' and [password] = '{password}'";

                using (con = new SqlConnection(connectionString))
                {
                    con.Open();
                    var command = new SqlCommand(query, con)
                    {
                        CommandType = CommandType.Text
                    };

                    var reader = command.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        MessageBox.Show(
                            "Invalid login credentials, please check Username and Password and try again",
                            "Invalid login details",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        Hide();
                        var userForm = new UserForm();
                        userForm.Show();
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