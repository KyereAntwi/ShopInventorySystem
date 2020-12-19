
namespace FrontApp.Pages
{
    partial class AllProductsPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllProductsPage));
            this.AllProductsList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Manufactuerer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductsListContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewSelectedProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductsListContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllProductsList
            // 
            this.AllProductsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.ProductID,
            this.ProductName,
            this.Manufactuerer});
            this.AllProductsList.ContextMenuStrip = this.ProductsListContext;
            this.AllProductsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllProductsList.HideSelection = false;
            this.AllProductsList.Location = new System.Drawing.Point(0, 0);
            this.AllProductsList.Name = "AllProductsList";
            this.AllProductsList.Size = new System.Drawing.Size(800, 450);
            this.AllProductsList.TabIndex = 0;
            this.AllProductsList.UseCompatibleStateImageBehavior = false;
            this.AllProductsList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // ProductID
            // 
            this.ProductID.Text = "Product ID";
            this.ProductID.Width = 100;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Product Name";
            this.ProductName.Width = 200;
            // 
            // Manufactuerer
            // 
            this.Manufactuerer.Text = "Product Manufacturer";
            this.Manufactuerer.Width = 200;
            // 
            // ProductsListContext
            // 
            this.ProductsListContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSelectedProductToolStripMenuItem});
            this.ProductsListContext.Name = "ProductsListContext";
            this.ProductsListContext.Size = new System.Drawing.Size(191, 48);
            // 
            // viewSelectedProductToolStripMenuItem
            // 
            this.viewSelectedProductToolStripMenuItem.Name = "viewSelectedProductToolStripMenuItem";
            this.viewSelectedProductToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.viewSelectedProductToolStripMenuItem.Text = "View selected product";
            this.viewSelectedProductToolStripMenuItem.Click += new System.EventHandler(this.viewSelectedProductToolStripMenuItem_Click);
            // 
            // AllProductsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AllProductsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AllProductsPage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Products";
            this.Load += new System.EventHandler(this.AllProductsPage_Load);
            this.ProductsListContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView AllProductsList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader ProductID;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader Manufactuerer;
        private System.Windows.Forms.ContextMenuStrip ProductsListContext;
        private System.Windows.Forms.ToolStripMenuItem viewSelectedProductToolStripMenuItem;
    }
}