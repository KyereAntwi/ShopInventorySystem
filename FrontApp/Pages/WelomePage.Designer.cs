
namespace FrontApp.Pages
{
    partial class WelomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelomePage));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.ErrorMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createANewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bASKETSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemToBasketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCurrentBasketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.createABasketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.viewListOfProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryReportForTodayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryReportForAParticularDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DatedReportTxt = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.summaryReportOnAProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductReportTxt = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.reportOnSalesForAUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserSalesCombo = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.LoggedInUser = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.BasketTotal = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SearchProductTxt = new System.Windows.Forms.ToolStripTextBox();
            this.WelcomeTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BasketItemsList = new System.Windows.Forms.ListView();
            this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProudctName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitSelling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeItemFromBasketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.WelcomeTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar,
            this.ErrorMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(100, 16);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.Visible = false;
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(0, 17);
            this.ErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ErrorMessage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ErrorMessage.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.bASKETSToolStripMenuItem,
            this.pRODUCTSToolStripMenuItem,
            this.rEPORTSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllUsersToolStripMenuItem,
            this.createANewUserToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitApplicationToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fILEToolStripMenuItem.Text = "&FILE";
            // 
            // viewAllUsersToolStripMenuItem
            // 
            this.viewAllUsersToolStripMenuItem.Name = "viewAllUsersToolStripMenuItem";
            this.viewAllUsersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.viewAllUsersToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.viewAllUsersToolStripMenuItem.Text = "View all users";
            this.viewAllUsersToolStripMenuItem.Click += new System.EventHandler(this.viewAllUsersToolStripMenuItem_Click);
            // 
            // createANewUserToolStripMenuItem
            // 
            this.createANewUserToolStripMenuItem.Name = "createANewUserToolStripMenuItem";
            this.createANewUserToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.createANewUserToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.createANewUserToolStripMenuItem.Text = "Create a new user";
            this.createANewUserToolStripMenuItem.Click += new System.EventHandler(this.createANewUserToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(203, 6);
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.exitApplicationToolStripMenuItem.Text = "Exit application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // bASKETSToolStripMenuItem
            // 
            this.bASKETSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToBasketToolStripMenuItem,
            this.clearCurrentBasketToolStripMenuItem,
            this.toolStripMenuItem2,
            this.createABasketToolStripMenuItem});
            this.bASKETSToolStripMenuItem.Name = "bASKETSToolStripMenuItem";
            this.bASKETSToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.bASKETSToolStripMenuItem.Text = "&BASKETS";
            // 
            // addItemToBasketToolStripMenuItem
            // 
            this.addItemToBasketToolStripMenuItem.Name = "addItemToBasketToolStripMenuItem";
            this.addItemToBasketToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.addItemToBasketToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.addItemToBasketToolStripMenuItem.Text = "Add Item to basket";
            this.addItemToBasketToolStripMenuItem.Click += new System.EventHandler(this.addItemToBasketToolStripMenuItem_Click);
            // 
            // clearCurrentBasketToolStripMenuItem
            // 
            this.clearCurrentBasketToolStripMenuItem.Name = "clearCurrentBasketToolStripMenuItem";
            this.clearCurrentBasketToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.clearCurrentBasketToolStripMenuItem.Text = "Clear current basket";
            this.clearCurrentBasketToolStripMenuItem.Click += new System.EventHandler(this.clearCurrentBasketToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(204, 6);
            // 
            // createABasketToolStripMenuItem
            // 
            this.createABasketToolStripMenuItem.Name = "createABasketToolStripMenuItem";
            this.createABasketToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.createABasketToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.createABasketToolStripMenuItem.Text = "Process a basket";
            this.createABasketToolStripMenuItem.Click += new System.EventHandler(this.createABasketToolStripMenuItem_Click);
            // 
            // pRODUCTSToolStripMenuItem
            // 
            this.pRODUCTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAProductToolStripMenuItem,
            this.toolStripMenuItem3,
            this.viewListOfProductsToolStripMenuItem});
            this.pRODUCTSToolStripMenuItem.Name = "pRODUCTSToolStripMenuItem";
            this.pRODUCTSToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.pRODUCTSToolStripMenuItem.Text = "&PRODUCTS";
            // 
            // addAProductToolStripMenuItem
            // 
            this.addAProductToolStripMenuItem.Name = "addAProductToolStripMenuItem";
            this.addAProductToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.P)));
            this.addAProductToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.addAProductToolStripMenuItem.Text = "Add a product";
            this.addAProductToolStripMenuItem.Click += new System.EventHandler(this.addAProductToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(220, 6);
            // 
            // viewListOfProductsToolStripMenuItem
            // 
            this.viewListOfProductsToolStripMenuItem.Name = "viewListOfProductsToolStripMenuItem";
            this.viewListOfProductsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.viewListOfProductsToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.viewListOfProductsToolStripMenuItem.Text = "View list of products";
            this.viewListOfProductsToolStripMenuItem.Click += new System.EventHandler(this.viewListOfProductsToolStripMenuItem_Click);
            // 
            // rEPORTSToolStripMenuItem
            // 
            this.rEPORTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryReportForTodayToolStripMenuItem,
            this.summaryReportForAParticularDateToolStripMenuItem,
            this.toolStripMenuItem4,
            this.summaryReportOnAProductToolStripMenuItem,
            this.toolStripMenuItem6,
            this.reportOnSalesForAUserToolStripMenuItem});
            this.rEPORTSToolStripMenuItem.Name = "rEPORTSToolStripMenuItem";
            this.rEPORTSToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.rEPORTSToolStripMenuItem.Text = "&REPORTS";
            // 
            // summaryReportForTodayToolStripMenuItem
            // 
            this.summaryReportForTodayToolStripMenuItem.Name = "summaryReportForTodayToolStripMenuItem";
            this.summaryReportForTodayToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.summaryReportForTodayToolStripMenuItem.Text = "Summary report for today";
            this.summaryReportForTodayToolStripMenuItem.Click += new System.EventHandler(this.summaryReportForTodayToolStripMenuItem_Click);
            // 
            // summaryReportForAParticularDateToolStripMenuItem
            // 
            this.summaryReportForAParticularDateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DatedReportTxt});
            this.summaryReportForAParticularDateToolStripMenuItem.Name = "summaryReportForAParticularDateToolStripMenuItem";
            this.summaryReportForAParticularDateToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.summaryReportForAParticularDateToolStripMenuItem.Text = "Summary report for a particular date";
            // 
            // DatedReportTxt
            // 
            this.DatedReportTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DatedReportTxt.Name = "DatedReportTxt";
            this.DatedReportTxt.Size = new System.Drawing.Size(200, 23);
            this.DatedReportTxt.Text = "Enter date eg: 02/02/2020 ...";
            this.DatedReportTxt.DoubleClick += new System.EventHandler(this.DatedReportTxt_DoubleClick);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(263, 6);
            // 
            // summaryReportOnAProductToolStripMenuItem
            // 
            this.summaryReportOnAProductToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductReportTxt});
            this.summaryReportOnAProductToolStripMenuItem.Name = "summaryReportOnAProductToolStripMenuItem";
            this.summaryReportOnAProductToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.summaryReportOnAProductToolStripMenuItem.Text = "Summary report on a product";
            // 
            // ProductReportTxt
            // 
            this.ProductReportTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProductReportTxt.Name = "ProductReportTxt";
            this.ProductReportTxt.Size = new System.Drawing.Size(250, 23);
            this.ProductReportTxt.Text = "Enter the product Id and double click ..";
            this.ProductReportTxt.Click += new System.EventHandler(this.ProductReportTxt_Click);
            this.ProductReportTxt.DoubleClick += new System.EventHandler(this.ProductReportTxt_DoubleClick);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(263, 6);
            // 
            // reportOnSalesForAUserToolStripMenuItem
            // 
            this.reportOnSalesForAUserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserSalesCombo});
            this.reportOnSalesForAUserToolStripMenuItem.Name = "reportOnSalesForAUserToolStripMenuItem";
            this.reportOnSalesForAUserToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.reportOnSalesForAUserToolStripMenuItem.Text = "Report on sales for a user";
            // 
            // UserSalesCombo
            // 
            this.UserSalesCombo.Name = "UserSalesCombo";
            this.UserSalesCombo.Size = new System.Drawing.Size(200, 23);
            this.UserSalesCombo.SelectedIndexChanged += new System.EventHandler(this.UserSalesCombo_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoggedInUser,
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.BasketTotal,
            this.toolStripSeparator1,
            this.SearchProductTxt});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 33);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // LoggedInUser
            // 
            this.LoggedInUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.LoggedInUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LoggedInUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoggedInUser.Name = "LoggedInUser";
            this.LoggedInUser.Size = new System.Drawing.Size(104, 30);
            this.LoggedInUser.Text = "Welcome:";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(175, 30);
            this.toolStripLabel1.Text = "Basket Total Cost:";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(55, 30);
            this.toolStripLabel2.Text = "GHC";
            // 
            // BasketTotal
            // 
            this.BasketTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasketTotal.Name = "BasketTotal";
            this.BasketTotal.Size = new System.Drawing.Size(24, 30);
            this.BasketTotal.Text = "0";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // SearchProductTxt
            // 
            this.SearchProductTxt.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SearchProductTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchProductTxt.Name = "SearchProductTxt";
            this.SearchProductTxt.Size = new System.Drawing.Size(250, 33);
            this.SearchProductTxt.Text = "Search a product here ...";
            this.SearchProductTxt.ToolTipText = "Search for an existing product";
            this.SearchProductTxt.Enter += new System.EventHandler(this.SearchProductTxt_Enter);
            this.SearchProductTxt.DoubleClick += new System.EventHandler(this.SearchProductTxt_DoubleClick);
            // 
            // WelcomeTab
            // 
            this.WelcomeTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WelcomeTab.Controls.Add(this.tabPage1);
            this.WelcomeTab.Location = new System.Drawing.Point(12, 60);
            this.WelcomeTab.Name = "WelcomeTab";
            this.WelcomeTab.SelectedIndex = 0;
            this.WelcomeTab.Size = new System.Drawing.Size(776, 365);
            this.WelcomeTab.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BasketItemsList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "List of items in the current basket";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BasketItemsList
            // 
            this.BasketItemsList.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.BasketItemsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BasketItemsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Index,
            this.ProductId,
            this.ProudctName,
            this.Quantity,
            this.UnitSelling,
            this.Total});
            this.BasketItemsList.ContextMenuStrip = this.contextMenuStrip1;
            this.BasketItemsList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BasketItemsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BasketItemsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasketItemsList.FullRowSelect = true;
            this.BasketItemsList.GridLines = true;
            this.BasketItemsList.HideSelection = false;
            this.BasketItemsList.Location = new System.Drawing.Point(3, 3);
            this.BasketItemsList.MultiSelect = false;
            this.BasketItemsList.Name = "BasketItemsList";
            this.BasketItemsList.Size = new System.Drawing.Size(762, 333);
            this.BasketItemsList.TabIndex = 0;
            this.BasketItemsList.UseCompatibleStateImageBehavior = false;
            this.BasketItemsList.View = System.Windows.Forms.View.Details;
            this.BasketItemsList.SelectedIndexChanged += new System.EventHandler(this.BasketItemsList_SelectedIndexChanged);
            // 
            // Index
            // 
            this.Index.Width = 52;
            // 
            // ProductId
            // 
            this.ProductId.Text = "Proudct ID";
            this.ProductId.Width = 123;
            // 
            // ProudctName
            // 
            this.ProudctName.Text = "Name of Product";
            this.ProudctName.Width = 202;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Product Quantity";
            this.Quantity.Width = 63;
            // 
            // UnitSelling
            // 
            this.UnitSelling.Text = "Product Unit Selling Price";
            this.UnitSelling.Width = 128;
            // 
            // Total
            // 
            this.Total.Text = "Product Total Price";
            this.Total.Width = 210;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeItemFromBasketToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 26);
            // 
            // removeItemFromBasketToolStripMenuItem
            // 
            this.removeItemFromBasketToolStripMenuItem.Name = "removeItemFromBasketToolStripMenuItem";
            this.removeItemFromBasketToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.removeItemFromBasketToolStripMenuItem.Text = "Remove item from basket";
            this.removeItemFromBasketToolStripMenuItem.Click += new System.EventHandler(this.removeItemFromBasketToolStripMenuItem_Click);
            // 
            // WelomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FrontApp.Properties.Resources._240_F_114194381_QgG2vON3LwJmpBDWE2n0pmLBSpMbXwMn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WelcomeTab);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WelomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop Inventory System - Welcome Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WelomePage_FormClosing);
            this.Load += new System.EventHandler(this.WelomePage_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.WelcomeTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createANewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel ErrorMessage;
        private System.Windows.Forms.ToolStripMenuItem bASKETSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createABasketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItemToBasketToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem clearCurrentBasketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem viewListOfProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTSToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel LoggedInUser;
        private System.Windows.Forms.TabControl WelcomeTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView BasketItemsList;
        private System.Windows.Forms.ColumnHeader Index;
        private System.Windows.Forms.ColumnHeader ProductId;
        private System.Windows.Forms.ColumnHeader ProudctName;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader UnitSelling;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel BasketTotal;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox SearchProductTxt;
        private System.Windows.Forms.ToolStripMenuItem summaryReportForTodayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryReportForAParticularDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem summaryReportOnAProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeItemFromBasketToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox DatedReportTxt;
        private System.Windows.Forms.ToolStripMenuItem reportOnSalesForAUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox UserSalesCombo;
        private System.Windows.Forms.ToolStripTextBox ProductReportTxt;
    }
}