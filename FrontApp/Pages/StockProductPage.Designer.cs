
namespace FrontApp.Pages
{
    partial class StockProductPage
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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.TotalQuantityTxt = new System.Windows.Forms.TextBox();
            this.UCPriceTxt = new System.Windows.Forms.TextBox();
            this.USPriceTxt = new System.Windows.Forms.TextBox();
            this.ExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.Location = new System.Drawing.Point(337, 233);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 0;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Location = new System.Drawing.Point(256, 233);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Stock";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // TotalQuantityTxt
            // 
            this.TotalQuantityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalQuantityTxt.Location = new System.Drawing.Point(12, 86);
            this.TotalQuantityTxt.Name = "TotalQuantityTxt";
            this.TotalQuantityTxt.Size = new System.Drawing.Size(400, 31);
            this.TotalQuantityTxt.TabIndex = 2;
            this.TotalQuantityTxt.Text = "Total quantiy ...";
            // 
            // UCPriceTxt
            // 
            this.UCPriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCPriceTxt.Location = new System.Drawing.Point(12, 12);
            this.UCPriceTxt.Name = "UCPriceTxt";
            this.UCPriceTxt.Size = new System.Drawing.Size(400, 31);
            this.UCPriceTxt.TabIndex = 3;
            this.UCPriceTxt.Text = "Unit cost price ...";
            // 
            // USPriceTxt
            // 
            this.USPriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USPriceTxt.Location = new System.Drawing.Point(12, 49);
            this.USPriceTxt.Name = "USPriceTxt";
            this.USPriceTxt.Size = new System.Drawing.Size(400, 31);
            this.USPriceTxt.TabIndex = 4;
            this.USPriceTxt.Text = "Unit selling price ...";
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.CustomFormat = "dd/MM/yyyy";
            this.ExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExpiryDate.Location = new System.Drawing.Point(12, 150);
            this.ExpiryDate.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.ExpiryDate.MinDate = new System.DateTime(2020, 12, 15, 0, 0, 0, 0);
            this.ExpiryDate.Name = "ExpiryDate";
            this.ExpiryDate.Size = new System.Drawing.Size(400, 31);
            this.ExpiryDate.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Expiration Date";
            // 
            // StockProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(427, 268);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExpiryDate);
            this.Controls.Add(this.USPriceTxt);
            this.Controls.Add(this.UCPriceTxt);
            this.Controls.Add(this.TotalQuantityTxt);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.CancelBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StockProductPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock a Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox TotalQuantityTxt;
        private System.Windows.Forms.TextBox UCPriceTxt;
        private System.Windows.Forms.TextBox USPriceTxt;
        private System.Windows.Forms.DateTimePicker ExpiryDate;
        private System.Windows.Forms.Label label1;
    }
}