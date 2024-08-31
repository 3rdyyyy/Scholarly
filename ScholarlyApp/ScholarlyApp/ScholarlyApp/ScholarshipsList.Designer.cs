using System.Drawing;
using System.Windows.Forms;

namespace ScholarlyApp
{
    partial class ScholarshipsList
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewScholarships;

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
            this.dataGridViewScholarships = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScholarships)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewScholarships
            // 
            this.dataGridViewScholarships.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScholarships.Dock = DockStyle.Fill;
            this.dataGridViewScholarships.Location = new Point(0, 0);
            this.dataGridViewScholarships.Name = "dataGridViewScholarships";
            this.dataGridViewScholarships.Size = new Size(800, 450);
            this.dataGridViewScholarships.TabIndex = 0;
            // 
            // ScholarshipsList
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.dataGridViewScholarships);
            this.Name = "ScholarshipsList";
            this.Text = "Scholarships List";
            this.Load += new System.EventHandler(this.ScholarshipsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScholarships)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
