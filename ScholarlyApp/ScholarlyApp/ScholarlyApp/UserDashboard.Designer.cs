namespace ScholarlyApp
{
    partial class UserDashboard
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
            this.userNameLbl = new System.Windows.Forms.Label();
            this.lblScholarships = new System.Windows.Forms.Label();
            this.lblSubmissions = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameOfScholarshipText = new System.Windows.Forms.TextBox();
            this.studentIDTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.schoolTextBox = new System.Windows.Forms.TextBox();
            this.genAveTextBox = new System.Windows.Forms.TextBox();
            this.courseTextbox = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.Location = new System.Drawing.Point(868, 34);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(109, 23);
            this.userNameLbl.TabIndex = 0;
            this.userNameLbl.Text = "Username";
            // 
            // lblScholarships
            // 
            this.lblScholarships.AutoSize = true;
            this.lblScholarships.BackColor = System.Drawing.Color.Transparent;
            this.lblScholarships.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScholarships.ForeColor = System.Drawing.Color.White;
            this.lblScholarships.Location = new System.Drawing.Point(337, 31);
            this.lblScholarships.Name = "lblScholarships";
            this.lblScholarships.Size = new System.Drawing.Size(137, 25);
            this.lblScholarships.TabIndex = 1;
            this.lblScholarships.Text = "Scholarships";
            this.lblScholarships.Click += new System.EventHandler(this.lblScholarships_Click);
            // 
            // lblSubmissions
            // 
            this.lblSubmissions.AutoSize = true;
            this.lblSubmissions.BackColor = System.Drawing.Color.Transparent;
            this.lblSubmissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmissions.ForeColor = System.Drawing.Color.White;
            this.lblSubmissions.Location = new System.Drawing.Point(509, 33);
            this.lblSubmissions.Name = "lblSubmissions";
            this.lblSubmissions.Size = new System.Drawing.Size(165, 25);
            this.lblSubmissions.TabIndex = 2;
            this.lblSubmissions.Text = "My Applications";
            this.lblSubmissions.Click += new System.EventHandler(this.lblSubmissions_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(707, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Apply for Scholarship";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name of Scholarship";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "School";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "General Average";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(549, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Course";
            // 
            // nameOfScholarshipText
            // 
            this.nameOfScholarshipText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameOfScholarshipText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfScholarshipText.Location = new System.Drawing.Point(31, 211);
            this.nameOfScholarshipText.Name = "nameOfScholarshipText";
            this.nameOfScholarshipText.Size = new System.Drawing.Size(285, 30);
            this.nameOfScholarshipText.TabIndex = 9;
            // 
            // studentIDTextbox
            // 
            this.studentIDTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentIDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDTextbox.Location = new System.Drawing.Point(554, 344);
            this.studentIDTextbox.Name = "studentIDTextbox";
            this.studentIDTextbox.Size = new System.Drawing.Size(285, 30);
            this.studentIDTextbox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(549, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Student ID";
            // 
            // schoolTextBox
            // 
            this.schoolTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.schoolTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolTextBox.Location = new System.Drawing.Point(31, 359);
            this.schoolTextBox.Name = "schoolTextBox";
            this.schoolTextBox.Size = new System.Drawing.Size(285, 30);
            this.schoolTextBox.TabIndex = 12;
            // 
            // genAveTextBox
            // 
            this.genAveTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.genAveTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genAveTextBox.Location = new System.Drawing.Point(31, 508);
            this.genAveTextBox.Name = "genAveTextBox";
            this.genAveTextBox.Size = new System.Drawing.Size(285, 30);
            this.genAveTextBox.TabIndex = 13;
            // 
            // courseTextbox
            // 
            this.courseTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.courseTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseTextbox.Location = new System.Drawing.Point(554, 211);
            this.courseTextbox.Name = "courseTextbox";
            this.courseTextbox.Size = new System.Drawing.Size(285, 30);
            this.courseTextbox.TabIndex = 14;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.Lime;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(586, 490);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(136, 48);
            this.btnApply.TabIndex = 15;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // UserDashboard
            // 
            this.ClientSize = new System.Drawing.Size(1011, 589);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.courseTextbox);
            this.Controls.Add(this.genAveTextBox);
            this.Controls.Add(this.schoolTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.studentIDTextbox);
            this.Controls.Add(this.nameOfScholarshipText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSubmissions);
            this.Controls.Add(this.lblScholarships);
            this.Controls.Add(this.userNameLbl);
            this.Name = "UserDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label lblScholarships;
        private System.Windows.Forms.Label lblSubmissions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameOfScholarshipText;
        private System.Windows.Forms.TextBox studentIDTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox schoolTextBox;
        private System.Windows.Forms.TextBox genAveTextBox;
        private System.Windows.Forms.TextBox courseTextbox;
        private System.Windows.Forms.Button btnApply;
    }
}
