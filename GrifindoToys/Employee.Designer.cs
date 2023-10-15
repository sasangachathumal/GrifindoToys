namespace GrifindoToys
{
    partial class Employee
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            btnRegister = new Button();
            txtEName = new TextBox();
            groupBox1 = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            comEID = new ComboBox();
            lblEID = new Label();
            txtEID = new TextBox();
            label6 = new Label();
            checkSearch = new CheckBox();
            txtNIC = new TextBox();
            btnDelete = new Button();
            label4 = new Label();
            txtAllowance = new TextBox();
            label3 = new Label();
            txtOTRate = new TextBox();
            label2 = new Label();
            txtMSalary = new TextBox();
            settingsBindingSource = new BindingSource(components);
            dgEmployee = new DataGridView();
            label5 = new Label();
            groupBox2 = new GroupBox();
            label11 = new Label();
            label12 = new Label();
            btnClear = new Button();
            lblBack = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)settingsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgEmployee).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(6, 87);
            label1.Name = "label1";
            label1.Size = new Size(58, 18);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Transparent;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.MidnightBlue;
            btnRegister.Location = new Point(461, 275);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(92, 36);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtEName
            // 
            txtEName.Location = new Point(87, 84);
            txtEName.Name = "txtEName";
            txtEName.Size = new Size(250, 26);
            txtEName.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(comEID);
            groupBox1.Controls.Add(lblEID);
            groupBox1.Controls.Add(txtEID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(checkSearch);
            groupBox1.Controls.Add(txtNIC);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtEName);
            groupBox1.ForeColor = Color.MidnightBlue;
            groupBox1.Location = new Point(12, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 164);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Info";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(50, 124);
            label10.Name = "label10";
            label10.Size = new Size(14, 18);
            label10.TabIndex = 19;
            label10.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(67, 87);
            label9.Name = "label9";
            label9.Size = new Size(14, 18);
            label9.TabIndex = 18;
            label9.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(46, 49);
            label7.Name = "label7";
            label7.Size = new Size(14, 18);
            label7.TabIndex = 15;
            label7.Text = "*";
            // 
            // comEID
            // 
            comEID.DropDownStyle = ComboBoxStyle.DropDownList;
            comEID.FormattingEnabled = true;
            comEID.Location = new Point(87, 46);
            comEID.Name = "comEID";
            comEID.Size = new Size(250, 26);
            comEID.TabIndex = 15;
            comEID.Visible = false;
            comEID.SelectedIndexChanged += comEID_SelectedIndexChanged;
            // 
            // lblEID
            // 
            lblEID.AutoSize = true;
            lblEID.ForeColor = Color.Black;
            lblEID.Location = new Point(6, 49);
            lblEID.Name = "lblEID";
            lblEID.Size = new Size(42, 18);
            lblEID.TabIndex = 15;
            lblEID.Text = "EID :";
            // 
            // txtEID
            // 
            txtEID.Cursor = Cursors.No;
            txtEID.Enabled = false;
            txtEID.Location = new Point(87, 46);
            txtEID.Name = "txtEID";
            txtEID.ReadOnly = true;
            txtEID.Size = new Size(250, 26);
            txtEID.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(6, 124);
            label6.Name = "label6";
            label6.Size = new Size(42, 18);
            label6.TabIndex = 10;
            label6.Text = "NIC :";
            // 
            // checkSearch
            // 
            checkSearch.AutoSize = true;
            checkSearch.Cursor = Cursors.Hand;
            checkSearch.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkSearch.ForeColor = Color.SteelBlue;
            checkSearch.Location = new Point(282, 17);
            checkSearch.Name = "checkSearch";
            checkSearch.Size = new Size(82, 23);
            checkSearch.TabIndex = 14;
            checkSearch.Text = "Search";
            checkSearch.UseVisualStyleBackColor = true;
            checkSearch.CheckedChanged += checkSearch_CheckedChanged;
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(87, 121);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(250, 26);
            txtNIC.TabIndex = 3;
            txtNIC.TextChanged += txtNIC_TextChanged;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.DarkRed;
            btnDelete.Location = new Point(575, 275);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 36);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(10, 78);
            label4.Name = "label4";
            label4.Size = new Size(87, 18);
            label4.TabIndex = 7;
            label4.Text = "Allowance :";
            // 
            // txtAllowance
            // 
            txtAllowance.Location = new Point(159, 75);
            txtAllowance.Name = "txtAllowance";
            txtAllowance.Size = new Size(180, 26);
            txtAllowance.TabIndex = 5;
            txtAllowance.TextChanged += txtAllowance_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(10, 124);
            label3.Name = "label3";
            label3.Size = new Size(74, 18);
            label3.TabIndex = 5;
            label3.Text = "OT Rate :";
            // 
            // txtOTRate
            // 
            txtOTRate.Location = new Point(159, 121);
            txtOTRate.Name = "txtOTRate";
            txtOTRate.Size = new Size(180, 26);
            txtOTRate.TabIndex = 6;
            txtOTRate.TextChanged += txtOTRate_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(10, 33);
            label2.Name = "label2";
            label2.Size = new Size(116, 18);
            label2.TabIndex = 3;
            label2.Text = "Monthly Salary :";
            // 
            // txtMSalary
            // 
            txtMSalary.Location = new Point(159, 30);
            txtMSalary.Name = "txtMSalary";
            txtMSalary.Size = new Size(180, 26);
            txtMSalary.TabIndex = 4;
            txtMSalary.TextChanged += txtMSalary_TextChanged;
            // 
            // settingsBindingSource
            // 
            settingsBindingSource.DataSource = typeof(Settings);
            // 
            // dgEmployee
            // 
            dgEmployee.AllowUserToAddRows = false;
            dgEmployee.AllowUserToDeleteRows = false;
            dgEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgEmployee.BackgroundColor = Color.AliceBlue;
            dgEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEmployee.GridColor = Color.Black;
            dgEmployee.Location = new Point(12, 326);
            dgEmployee.MultiSelect = false;
            dgEmployee.Name = "dgEmployee";
            dgEmployee.ReadOnly = true;
            dgEmployee.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgEmployee.RowTemplate.Height = 25;
            dgEmployee.ShowEditingIcon = false;
            dgEmployee.Size = new Size(731, 220);
            dgEmployee.TabIndex = 4;
            dgEmployee.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(206, 12);
            label5.Name = "label5";
            label5.Size = new Size(371, 37);
            label5.TabIndex = 10;
            label5.Text = "Employee Management";
            label5.Click += label5_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtAllowance);
            groupBox2.Controls.Add(txtMSalary);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtOTRate);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.ForeColor = Color.MidnightBlue;
            groupBox2.Location = new Point(388, 95);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(355, 164);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Salary Info";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(132, 33);
            label11.Name = "label11";
            label11.Size = new Size(14, 18);
            label11.TabIndex = 20;
            label11.Text = "*";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(83, 124);
            label12.Name = "label12";
            label12.Size = new Size(14, 18);
            label12.TabIndex = 21;
            label12.Text = "*";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Transparent;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.SteelBlue;
            btnClear.Location = new Point(668, 275);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 36);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.BackColor = Color.Transparent;
            lblBack.Cursor = Cursors.Hand;
            lblBack.Image = Properties.Resources.back;
            lblBack.Location = new Point(12, 9);
            lblBack.Name = "lblBack";
            lblBack.Padding = new Padding(8);
            lblBack.Size = new Size(36, 34);
            lblBack.TabIndex = 27;
            lblBack.Text = "   ";
            lblBack.Click += lblBack_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(755, 556);
            ControlBox = false;
            Controls.Add(lblBack);
            Controls.Add(btnClear);
            Controls.Add(groupBox2);
            Controls.Add(label5);
            Controls.Add(btnDelete);
            Controls.Add(btnRegister);
            Controls.Add(dgEmployee);
            Controls.Add(groupBox1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Employee";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            Load += Employee_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)settingsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgEmployee).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRegister;
        private TextBox txtEName;
        private GroupBox groupBox1;
        private BindingSource settingsBindingSource;
        private DataGridView dgEmployee;
        private Label label4;
        private TextBox txtAllowance;
        private Label label3;
        private TextBox txtOTRate;
        private Label label2;
        private TextBox txtMSalary;
        private Button btnDelete;
        private Label label5;
        private Label label6;
        private TextBox txtNIC;
        private GroupBox groupBox2;
        private CheckBox checkSearch;
        private ComboBox comEID;
        private Label lblEID;
        private TextBox txtEID;
        private Button btnClear;
        private Label label7;
        private Label label10;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label lblBack;
    }
}