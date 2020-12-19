
namespace FrontApp.Pages
{
    partial class UsersListPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersListPage));
            this.UsersListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DeleteUsersBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsersListView
            // 
            this.UsersListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Username,
            this.Role});
            this.UsersListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersListView.GridLines = true;
            this.UsersListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.UsersListView.HideSelection = false;
            this.UsersListView.Location = new System.Drawing.Point(12, 28);
            this.UsersListView.MultiSelect = false;
            this.UsersListView.Name = "UsersListView";
            this.UsersListView.Size = new System.Drawing.Size(596, 410);
            this.UsersListView.TabIndex = 0;
            this.UsersListView.UseCompatibleStateImageBehavior = false;
            this.UsersListView.View = System.Windows.Forms.View.Details;
            this.UsersListView.SelectedIndexChanged += new System.EventHandler(this.UsersListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 50;
            // 
            // Username
            // 
            this.Username.Text = "User\'s Username";
            this.Username.Width = 200;
            // 
            // Role
            // 
            this.Role.Text = "User\'s Role";
            this.Role.Width = 200;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteUsersBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(620, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // DeleteUsersBtn
            // 
            this.DeleteUsersBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.DeleteUsersBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteUsersBtn.Image")));
            this.DeleteUsersBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteUsersBtn.Name = "DeleteUsersBtn";
            this.DeleteUsersBtn.Size = new System.Drawing.Size(138, 22);
            this.DeleteUsersBtn.Text = "Delete Selected Users";
            this.DeleteUsersBtn.Visible = false;
            this.DeleteUsersBtn.Click += new System.EventHandler(this.DeleteUsersBtn_Click);
            // 
            // UsersListPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.UsersListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsersListPage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of Users Page";
            this.Load += new System.EventHandler(this.UsersListPage_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView UsersListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Role;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton DeleteUsersBtn;
    }
}