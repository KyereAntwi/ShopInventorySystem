
namespace FrontApp.CustomTemplates
{
    partial class DailySummaryTemplate
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
            this.ReportListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ReportListBox
            // 
            this.ReportListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportListBox.FormattingEnabled = true;
            this.ReportListBox.HorizontalScrollbar = true;
            this.ReportListBox.ItemHeight = 25;
            this.ReportListBox.Location = new System.Drawing.Point(0, 0);
            this.ReportListBox.Name = "ReportListBox";
            this.ReportListBox.Size = new System.Drawing.Size(825, 505);
            this.ReportListBox.TabIndex = 0;
            // 
            // DailySummaryTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ReportListBox);
            this.Name = "DailySummaryTemplate";
            this.Size = new System.Drawing.Size(825, 505);
            this.Load += new System.EventHandler(this.ReportsTemplate_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ReportListBox;
    }
}
