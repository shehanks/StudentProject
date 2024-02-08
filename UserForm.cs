using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentProject
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_StudentRegistration_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var resistrationForm = new StudentRegistrationForm();
            resistrationForm.ShowDialog();
        }

        private void UserForm_Exit_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void UserForm_UserRegistration_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var resistrationForm = new UserRegistrationForm();
            resistrationForm.ShowDialog();
        }

        private void UserForm_Logout_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "LoginForm")
                    Application.OpenForms[i].Close();
            }

            Application.OpenForms[0].Show();
        }
    }
}
