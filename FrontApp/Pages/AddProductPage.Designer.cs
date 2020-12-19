
namespace FrontApp.Pages
{
    partial class AddProductPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductPage));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ProductAddedDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LoadImageBtn = new System.Windows.Forms.Button();
            this.ProductAvatarBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductIdTxt = new System.Windows.Forms.TextBox();
            this.ProductManufacturerTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductDescriptionTxt = new System.Windows.Forms.RichTextBox();
            this.ProductNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.StockLiveView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateAdded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitSelling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AverageExpiration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StockedBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SaveEditBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.StockBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CommitBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.NewStockBtn = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductAvatarBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(922, 477);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ProductAddedDate);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.ProductIdTxt);
            this.tabPage1.Controls.Add(this.ProductManufacturerTxt);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ProductDescriptionTxt);
            this.tabPage1.Controls.Add(this.ProductNameTxt);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(914, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Product Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ProductAddedDate
            // 
            this.ProductAddedDate.CustomFormat = "dd/MM/yyyy";
            this.ProductAddedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductAddedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ProductAddedDate.Location = new System.Drawing.Point(6, 403);
            this.ProductAddedDate.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.ProductAddedDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.ProductAddedDate.Name = "ProductAddedDate";
            this.ProductAddedDate.Size = new System.Drawing.Size(310, 31);
            this.ProductAddedDate.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.LoadImageBtn);
            this.groupBox2.Controls.Add(this.ProductAvatarBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(503, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 420);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Image (Preview)";
            // 
            // LoadImageBtn
            // 
            this.LoadImageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadImageBtn.Location = new System.Drawing.Point(6, 380);
            this.LoadImageBtn.Name = "LoadImageBtn";
            this.LoadImageBtn.Size = new System.Drawing.Size(393, 34);
            this.LoadImageBtn.TabIndex = 1;
            this.LoadImageBtn.Text = "Load Image";
            this.LoadImageBtn.UseVisualStyleBackColor = true;
            this.LoadImageBtn.Click += new System.EventHandler(this.LoadImageBtn_Click);
            // 
            // ProductAvatarBox
            // 
            this.ProductAvatarBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductAvatarBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ProductAvatarBox.Location = new System.Drawing.Point(6, 30);
            this.ProductAvatarBox.Name = "ProductAvatarBox";
            this.ProductAvatarBox.Size = new System.Drawing.Size(393, 344);
            this.ProductAvatarBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductAvatarBox.TabIndex = 0;
            this.ProductAvatarBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Added Date:";
            // 
            // ProductIdTxt
            // 
            this.ProductIdTxt.Enabled = false;
            this.ProductIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIdTxt.Location = new System.Drawing.Point(6, 39);
            this.ProductIdTxt.Name = "ProductIdTxt";
            this.ProductIdTxt.Size = new System.Drawing.Size(310, 31);
            this.ProductIdTxt.TabIndex = 11;
            // 
            // ProductManufacturerTxt
            // 
            this.ProductManufacturerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductManufacturerTxt.Location = new System.Drawing.Point(6, 330);
            this.ProductManufacturerTxt.Name = "ProductManufacturerTxt";
            this.ProductManufacturerTxt.Size = new System.Drawing.Size(310, 31);
            this.ProductManufacturerTxt.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Product Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Product Manufacturer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Product Name:";
            // 
            // ProductDescriptionTxt
            // 
            this.ProductDescriptionTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductDescriptionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDescriptionTxt.Location = new System.Drawing.Point(6, 193);
            this.ProductDescriptionTxt.Name = "ProductDescriptionTxt";
            this.ProductDescriptionTxt.Size = new System.Drawing.Size(310, 96);
            this.ProductDescriptionTxt.TabIndex = 15;
            this.ProductDescriptionTxt.Text = "";
            // 
            // ProductNameTxt
            // 
            this.ProductNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameTxt.Location = new System.Drawing.Point(6, 113);
            this.ProductNameTxt.Name = "ProductNameTxt";
            this.ProductNameTxt.Size = new System.Drawing.Size(310, 31);
            this.ProductNameTxt.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Product Description:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.StockLiveView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(914, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "List of Product Stocks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // StockLiveView
            // 
            this.StockLiveView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.DateAdded,
            this.UnitCost,
            this.UnitSelling,
            this.AverageExpiration,
            this.StockedBy,
            this.Quantity});
            this.StockLiveView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StockLiveView.GridLines = true;
            this.StockLiveView.HideSelection = false;
            this.StockLiveView.Location = new System.Drawing.Point(3, 3);
            this.StockLiveView.Name = "StockLiveView";
            this.StockLiveView.Size = new System.Drawing.Size(908, 445);
            this.StockLiveView.TabIndex = 0;
            this.StockLiveView.UseCompatibleStateImageBehavior = false;
            this.StockLiveView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // DateAdded
            // 
            this.DateAdded.Text = "Date Added";
            this.DateAdded.Width = 100;
            // 
            // UnitCost
            // 
            this.UnitCost.Text = "Unit Cost Price";
            this.UnitCost.Width = 150;
            // 
            // UnitSelling
            // 
            this.UnitSelling.Text = "Unit Selling Cost";
            this.UnitSelling.Width = 150;
            // 
            // AverageExpiration
            // 
            this.AverageExpiration.Text = "Expiration Date";
            this.AverageExpiration.Width = 150;
            // 
            // StockedBy
            // 
            this.StockedBy.Text = "Stocked By";
            this.StockedBy.Width = 100;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Total on shelf";
            this.Quantity.Width = 100;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveEditBtn,
            this.toolStripSeparator1,
            this.StockBtn,
            this.toolStripSeparator2,
            this.CommitBtn,
            this.toolStripSeparator3,
            this.NewStockBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(946, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SaveEditBtn
            // 
            this.SaveEditBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveEditBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveEditBtn.Image")));
            this.SaveEditBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveEditBtn.Name = "SaveEditBtn";
            this.SaveEditBtn.Size = new System.Drawing.Size(80, 22);
            this.SaveEditBtn.Text = "Save Product";
            this.SaveEditBtn.Click += new System.EventHandler(this.SaveEditBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // StockBtn
            // 
            this.StockBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StockBtn.Image = ((System.Drawing.Image)(resources.GetObject("StockBtn.Image")));
            this.StockBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StockBtn.Name = "StockBtn";
            this.StockBtn.Size = new System.Drawing.Size(85, 22);
            this.StockBtn.Text = "Stock Product";
            this.StockBtn.Click += new System.EventHandler(this.StockBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // CommitBtn
            // 
            this.CommitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CommitBtn.Image = ((System.Drawing.Image)(resources.GetObject("CommitBtn.Image")));
            this.CommitBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CommitBtn.Name = "CommitBtn";
            this.CommitBtn.Size = new System.Drawing.Size(127, 22);
            this.CommitBtn.Text = "Commit New Product";
            this.CommitBtn.Click += new System.EventHandler(this.CommitBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // NewStockBtn
            // 
            this.NewStockBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.NewStockBtn.Image = ((System.Drawing.Image)(resources.GetObject("NewStockBtn.Image")));
            this.NewStockBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewStockBtn.Name = "NewStockBtn";
            this.NewStockBtn.Size = new System.Drawing.Size(98, 22);
            this.NewStockBtn.Text = "Add a new stock";
            this.NewStockBtn.Visible = false;
            this.NewStockBtn.Click += new System.EventHandler(this.NewStockBtn_Click);
            // 
            // AddProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 517);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProductPage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add a new product - SIS";
            this.Load += new System.EventHandler(this.AddProductPage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductAvatarBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker ProductAddedDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button LoadImageBtn;
        private System.Windows.Forms.PictureBox ProductAvatarBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProductIdTxt;
        private System.Windows.Forms.TextBox ProductManufacturerTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox ProductDescriptionTxt;
        private System.Windows.Forms.TextBox ProductNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SaveEditBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton StockBtn;
        private System.Windows.Forms.ListView StockLiveView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader DateAdded;
        private System.Windows.Forms.ColumnHeader UnitCost;
        private System.Windows.Forms.ColumnHeader UnitSelling;
        private System.Windows.Forms.ColumnHeader AverageExpiration;
        private System.Windows.Forms.ColumnHeader StockedBy;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton CommitBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton NewStockBtn;
    }
}