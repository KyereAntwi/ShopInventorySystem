﻿
namespace FrontApp.CustomTemplates
{
    partial class ProudctReportTemplate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductReportLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ProductReportLB
            // 
            this.ProductReportLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductReportLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductReportLB.FormattingEnabled = true;
            this.ProductReportLB.HorizontalScrollbar = true;
            this.ProductReportLB.ItemHeight = 25;
            this.ProductReportLB.Location = new System.Drawing.Point(0, 0);
            this.ProductReportLB.Name = "ProductReportLB";
            this.ProductReportLB.Size = new System.Drawing.Size(780, 489);
            this.ProductReportLB.TabIndex = 0;
            // 
            // ProudctReportTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProductReportLB);
            this.Name = "ProudctReportTemplate";
            this.Size = new System.Drawing.Size(780, 489);
            this.Load += new System.EventHandler(this.ProudctReportTemplate_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ProductReportLB;
    }
}
