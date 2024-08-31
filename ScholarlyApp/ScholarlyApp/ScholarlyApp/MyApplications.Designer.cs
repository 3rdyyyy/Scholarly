using System.Drawing;
using System.Windows.Forms;

namespace ScholarlyApp
{
    partial class MyApplications
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView ApplicationsView;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.ApplicationsView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationsView)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplicationsView
            // 
            this.ApplicationsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApplicationsView.Dock = DockStyle.Fill;
            this.ApplicationsView.Location = new Point(0, 0);
            this.ApplicationsView.Name = "ApplicationsView";
            this.ApplicationsView.Size = new Size(800, 450);
            this.ApplicationsView.TabIndex = 0;
            // 
            // MyApplications
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.ApplicationsView);
            this.Name = "MyApplications";
            this.Text = "My Applications";
            this.Load += new System.EventHandler(this.MyApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationsView)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
