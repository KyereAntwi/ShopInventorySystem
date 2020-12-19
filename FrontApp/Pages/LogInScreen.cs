using FrontApp.Models;
using FrontApp.Services;
using System;
using System.Windows.Forms;

namespace FrontApp.Pages
{
    public partial class LogInScreen : Form
    {
        AccountRepository acr;
        public LogInScreen()
        {
            InitializeComponent();
            acr = new AccountRepository();
        }

        private void UsernameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            PasswordTxt.Enabled = true;
        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {
            LoginBtn.Enabled = true;
        }

        private void LogInScreen_Load(object sender, EventArgs e)
        {

            try
            {
                var response = acr.AllUsers();

                if (response.Count > 0)
                {
                    response.ForEach(item =>
                    {
                        UsernameCombo.Items.Add(item.Username);
                    });
                }
                else 
                {
                    ConnectionStatusStrip.Text = "Users empty | Create master!";
                    CreateMasterBtn.Visible = true;
                }
            }
            catch (Exception)
            {
                ConnectionStatusStrip.Text = "Problem encountered";
            }
        }

        private void CreateMasterBtn_Click(object sender, EventArgs e)
        {
            User master = new User()
            {
                Username = "MasterUser",
                Password = "MasterPassword",
                Role = "Administrator"
            };

            DialogResult result = MessageBox.Show("Are you sure you want ot create a Master user?", "Master User - SIS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) 
            {
                try
                {
                    var response = acr.CreateUser(master);
                    if (response == null)
                        MessageBox.Show("A problem occured trying to create Master, try again. If problem persist contact developers", "Master User - SIS", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    WelomePage welomePage = new WelomePage(master);
                    this.Hide();
                    welomePage.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"There was an error #{ex.Message.ToString()}", "Master User - SIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ConnectionStatusStrip.Text = $"System encountered  error";
                }
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            User user = new User() 
            {
                Username = UsernameCombo.Text,
                Password = PasswordTxt.Text
            };

            try
            {
                var response = acr.LogIn(user);

                if (response == null)
                {
                    MessageBox.Show($"Wrong credentials provided", "Master User - SIS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ConnectionStatusStrip.Text = $"Wrong credentials";
                }
                else 
                {
                    WelomePage welomePage = new WelomePage(response);
                    this.Hide();
                    welomePage.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was an error #{ex.Message.ToString()}", "Master User - SIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConnectionStatusStrip.Text = $"System encountered  error";
            }
        }

        private void LogInScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to completely close the application", "Master User - SIS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.ExitThread();
            else 
            {
                e.Cancel = true;
            }
        }
    }
}
