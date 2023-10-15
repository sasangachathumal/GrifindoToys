namespace GrifindoToys
{
    partial class HomePage
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
            label1 = new Label();
            lblEmployeeManage = new Label();
            lblSalaryCal = new Label();
            lblLogout = new Label();
            lblSalaryReport = new Label();
            lblUserManage = new Label();
            lblSettings = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bauhaus 93", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(402, 73);
            label1.TabIndex = 0;
            label1.Text = "Grifindo Toys";
            // 
            // lblEmployeeManage
            // 
            lblEmployeeManage.AutoSize = true;
            lblEmployeeManage.BackColor = Color.RoyalBlue;
            lblEmployeeManage.Cursor = Cursors.Hand;
            lblEmployeeManage.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmployeeManage.ForeColor = Color.White;
            lblEmployeeManage.Location = new Point(13, 118);
            lblEmployeeManage.Name = "lblEmployeeManage";
            lblEmployeeManage.Padding = new Padding(15);
            lblEmployeeManage.Size = new Size(230, 48);
            lblEmployeeManage.TabIndex = 1;
            lblEmployeeManage.Text = "Employee Management";
            lblEmployeeManage.Click += lblEmployeeManage_Click;
            // 
            // lblSalaryCal
            // 
            lblSalaryCal.AutoSize = true;
            lblSalaryCal.BackColor = Color.RoyalBlue;
            lblSalaryCal.Cursor = Cursors.Hand;
            lblSalaryCal.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSalaryCal.ForeColor = Color.White;
            lblSalaryCal.Location = new Point(273, 118);
            lblSalaryCal.Name = "lblSalaryCal";
            lblSalaryCal.Padding = new Padding(35, 15, 35, 15);
            lblSalaryCal.Size = new Size(232, 48);
            lblSalaryCal.TabIndex = 2;
            lblSalaryCal.Text = "Salary Calculation";
            lblSalaryCal.Click += lblSalaryCal_Click;
            // 
            // lblLogout
            // 
            lblLogout.AutoSize = true;
            lblLogout.BackColor = Color.Transparent;
            lblLogout.Cursor = Cursors.Hand;
            lblLogout.FlatStyle = FlatStyle.Flat;
            lblLogout.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogout.ForeColor = Color.Tomato;
            lblLogout.Image = Properties.Resources.shutdown__2_;
            lblLogout.Location = new Point(727, 9);
            lblLogout.Name = "lblLogout";
            lblLogout.Padding = new Padding(7);
            lblLogout.Size = new Size(39, 33);
            lblLogout.TabIndex = 6;
            lblLogout.Tag = "Logout";
            lblLogout.Text = "    ";
            lblLogout.Click += lblLogout_Click;
            // 
            // lblSalaryReport
            // 
            lblSalaryReport.AutoSize = true;
            lblSalaryReport.BackColor = Color.RoyalBlue;
            lblSalaryReport.Cursor = Cursors.Hand;
            lblSalaryReport.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSalaryReport.ForeColor = Color.White;
            lblSalaryReport.Location = new Point(541, 118);
            lblSalaryReport.Name = "lblSalaryReport";
            lblSalaryReport.Padding = new Padding(50, 15, 50, 15);
            lblSalaryReport.Size = new Size(222, 48);
            lblSalaryReport.TabIndex = 3;
            lblSalaryReport.Text = "Salary Report";
            lblSalaryReport.Click += lblSalaryReport_Click;
            // 
            // lblUserManage
            // 
            lblUserManage.AutoSize = true;
            lblUserManage.BackColor = Color.RoyalBlue;
            lblUserManage.Cursor = Cursors.Hand;
            lblUserManage.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserManage.ForeColor = Color.White;
            lblUserManage.Location = new Point(13, 202);
            lblUserManage.Name = "lblUserManage";
            lblUserManage.Padding = new Padding(35, 15, 35, 15);
            lblUserManage.Size = new Size(227, 48);
            lblUserManage.TabIndex = 4;
            lblUserManage.Text = "User Management";
            lblUserManage.Click += lblUserManage_Click;
            // 
            // lblSettings
            // 
            lblSettings.AutoSize = true;
            lblSettings.BackColor = Color.RoyalBlue;
            lblSettings.Cursor = Cursors.Hand;
            lblSettings.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSettings.ForeColor = Color.White;
            lblSettings.Location = new Point(541, 202);
            lblSettings.Name = "lblSettings";
            lblSettings.Padding = new Padding(73, 15, 73, 15);
            lblSettings.Size = new Size(221, 48);
            lblSettings.TabIndex = 5;
            lblSettings.Text = "Settings";
            lblSettings.Click += lblSettings_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(778, 266);
            ControlBox = false;
            Controls.Add(lblSettings);
            Controls.Add(lblUserManage);
            Controls.Add(lblSalaryReport);
            Controls.Add(lblLogout);
            Controls.Add(lblSalaryCal);
            Controls.Add(lblEmployeeManage);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            Load += HomePage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblEmployeeManage;
        private Label lblSalaryCal;
        private Label lblLogout;
        private Label lblSalaryReport;
        private Label lblUserManage;
        private Label lblSettings;
    }
}