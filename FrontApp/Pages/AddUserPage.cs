using FrontApp.Models;
using FrontApp.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FrontApp.Pages
{
    public partial class AddUserPage : Form
    {
        List<string> ExistingUsernames;
        private readonly AccountRepository AR;
        public AddUserPage()
        {
            InitializeComponent();
            ExistingUsernames = new List<string>();
            AR = new AccountRepository();
        }

        private void ProceedBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTxt.Text) || string.IsNullOrWhiteSpace(PasswordTxt.Text) || string.IsNullOrWhiteSpace(RoleCB.Text))
                MessageBox.Show("Make sure all fields are filled correctly", "Add User - SIS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (ExistingUsernames.Contains(UsernameTxt.Text))
                MessageBox.Show("Username chosen already exist", "Add User - SIS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else 
            {
                User user = new User 
                {
                    Username = UsernameTxt.Text,
                    Password = PasswordTxt.Text,
                    Role = RoleCB.Text
                };

                try
                {
                    var response = AR.CreateUser(user);

                    if (response != null)
                        MessageBox.Show("User created successfully", "Add User - SIS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something went wrong #{ex.Message}", "Error - SIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally 
                {
                    this.Close();
                }
            }
        }

        private void AddUserPage_Load(object sender, EventArgs e)
        {
            ExistingUsernames = AR.AllUsernames();
        }
    }
}
