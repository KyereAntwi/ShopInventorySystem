using FrontApp.Models;
using FrontApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FrontApp.Pages
{
    public partial class UsersListPage : Form
    {
        List<User> Users;
        private readonly AccountRepository AR;

        public UsersListPage()
        {
            InitializeComponent();
            Users = new List<User>();
            AR = new AccountRepository();
        }

        private void UsersListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Users.Count > 0)
                DeleteUsersBtn.Visible = true;
        }

        private void UsersListPage_Load(object sender, EventArgs e)
        {
            try
            {
                var responseList = AR.AllUsers();

                if (responseList.Count > 0)
                    Users = responseList;
 
                Users.ForEach(user => 
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.SubItems.Add(user.Username);
                    listViewItem.SubItems.Add(user.Role);
                    UsersListView.Items.Add(listViewItem);
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void DeleteUsersBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete user?", "Users - SIS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) 
            {
                var items = UsersListView.SelectedItems;

                if (items.Count > 0)
                {
                    string username = items[0].SubItems[1].Text;

                    if (username.Contains("Master")) 
                    {
                        DialogResult masterResponse = MessageBox.Show("You are trying to remove the MasterUser. Are you sure you want to continue?", "Users List - SIS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (masterResponse == DialogResult.No) 
                        {
                            return;
                        }
                    }

                    var removeResponse = AR.RemoveUser(username);

                    if (removeResponse)
                    {
                        Users = Users.Where(user => user.Username != username).ToList();
                        UsersListView.Items.Remove(items[0]);
                        MessageBox.Show($"Deletion of ${username} operation was successful", "Users List - SIS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Make sure you have selected a user at the far left column to continue", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            DeleteUsersBtn.Visible = false;
        }
    }
}
