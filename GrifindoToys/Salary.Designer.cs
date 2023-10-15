namespace GrifindoToys
{
    partial class Salary
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
            groupBox1 = new GroupBox();
            label6 = new Label();
            txtENIC = new TextBox();
            label5 = new Label();
            txtAllowance = new TextBox();
            label4 = new Label();
            txtOTRate = new TextBox();
            label3 = new Label();
            txtMSalary = new TextBox();
            label2 = new Label();
            txtEName = new TextBox();
            comEID = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            pickStartDate = new DateTimePicker();
            label8 = new Label();
            pickEndDate = new DateTimePicker();
            label7 = new Label();
            btnCalSalary = new Button();
            groupBox3 = new GroupBox();
            label17 = new Label();
            txtTaxRate = new TextBox();
            label12 = new Label();
            txtOTHours = new TextBox();
            label11 = new Label();
            txtNoOfAbsents = new TextBox();
            label10 = new Label();
            txtNoOfHolidays = new TextBox();
            label9 = new Label();
            txtNoOfLeaves = new TextBox();
            groupBox4 = new GroupBox();
            label18 = new Label();
            txtTaxAmount = new TextBox();
            label15 = new Label();
            txtNoPay = new TextBox();
            label14 = new Label();
            txtGrossPay = new TextBox();
            label13 = new Label();
            txtBasePay = new TextBox();
            btnClear = new Button();
            btnSave = new Button();
            btnReport = new Button();
            label16 = new Label();
            lblBack = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtENIC);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtAllowance);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtOTRate);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMSalary);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEName);
            groupBox1.Controls.Add(comEID);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(617, 169);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee Info";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 130);
            label6.Name = "label6";
            label6.Size = new Size(42, 18);
            label6.TabIndex = 11;
            label6.Text = "NIC :";
            // 
            // txtENIC
            // 
            txtENIC.Cursor = Cursors.No;
            txtENIC.Enabled = false;
            txtENIC.Location = new Point(86, 127);
            txtENIC.Name = "txtENIC";
            txtENIC.ReadOnly = true;
            txtENIC.Size = new Size(212, 26);
            txtENIC.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(318, 130);
            label5.Name = "label5";
            label5.Size = new Size(87, 18);
            label5.TabIndex = 9;
            label5.Text = "Allowance :";
            // 
            // txtAllowance
            // 
            txtAllowance.Cursor = Cursors.No;
            txtAllowance.Enabled = false;
            txtAllowance.Location = new Point(444, 127);
            txtAllowance.Name = "txtAllowance";
            txtAllowance.ReadOnly = true;
            txtAllowance.Size = new Size(157, 26);
            txtAllowance.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(318, 82);
            label4.Name = "label4";
            label4.Size = new Size(74, 18);
            label4.TabIndex = 7;
            label4.Text = "OT Rate :";
            // 
            // txtOTRate
            // 
            txtOTRate.Cursor = Cursors.No;
            txtOTRate.Enabled = false;
            txtOTRate.Location = new Point(444, 79);
            txtOTRate.Name = "txtOTRate";
            txtOTRate.ReadOnly = true;
            txtOTRate.Size = new Size(157, 26);
            txtOTRate.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(318, 36);
            label3.Name = "label3";
            label3.Size = new Size(120, 18);
            label3.TabIndex = 5;
            label3.Text = "Monthly Salary : ";
            // 
            // txtMSalary
            // 
            txtMSalary.Cursor = Cursors.No;
            txtMSalary.Enabled = false;
            txtMSalary.Location = new Point(444, 33);
            txtMSalary.Name = "txtMSalary";
            txtMSalary.ReadOnly = true;
            txtMSalary.Size = new Size(157, 26);
            txtMSalary.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 82);
            label2.Name = "label2";
            label2.Size = new Size(58, 18);
            label2.TabIndex = 3;
            label2.Text = "Name :";
            // 
            // txtEName
            // 
            txtEName.Cursor = Cursors.No;
            txtEName.Enabled = false;
            txtEName.Location = new Point(86, 79);
            txtEName.Name = "txtEName";
            txtEName.ReadOnly = true;
            txtEName.Size = new Size(212, 26);
            txtEName.TabIndex = 2;
            // 
            // comEID
            // 
            comEID.DropDownStyle = ComboBoxStyle.DropDownList;
            comEID.FormattingEnabled = true;
            comEID.Location = new Point(86, 33);
            comEID.Name = "comEID";
            comEID.Size = new Size(139, 26);
            comEID.TabIndex = 1;
            comEID.SelectedIndexChanged += comEID_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 36);
            label1.Name = "label1";
            label1.Size = new Size(42, 18);
            label1.TabIndex = 0;
            label1.Text = "EID :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pickStartDate);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(pickEndDate);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(12, 247);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(617, 77);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Salary Cycle Info";
            // 
            // pickStartDate
            // 
            pickStartDate.Format = DateTimePickerFormat.Short;
            pickStartDate.Location = new Point(138, 32);
            pickStartDate.Name = "pickStartDate";
            pickStartDate.Size = new Size(160, 26);
            pickStartDate.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(318, 38);
            label8.Name = "label8";
            label8.Size = new Size(82, 18);
            label8.TabIndex = 2;
            label8.Text = "End Date :";
            // 
            // pickEndDate
            // 
            pickEndDate.Format = DateTimePickerFormat.Short;
            pickEndDate.Location = new Point(444, 32);
            pickEndDate.Name = "pickEndDate";
            pickEndDate.Size = new Size(157, 26);
            pickEndDate.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 38);
            label7.Name = "label7";
            label7.Size = new Size(87, 18);
            label7.TabIndex = 0;
            label7.Text = "Start Date :";
            // 
            // btnCalSalary
            // 
            btnCalSalary.Cursor = Cursors.Hand;
            btnCalSalary.FlatStyle = FlatStyle.Flat;
            btnCalSalary.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalSalary.ForeColor = Color.MediumBlue;
            btnCalSalary.Location = new Point(480, 514);
            btnCalSalary.Name = "btnCalSalary";
            btnCalSalary.Size = new Size(150, 34);
            btnCalSalary.TabIndex = 9;
            btnCalSalary.Text = "Calculate Salary";
            btnCalSalary.UseVisualStyleBackColor = true;
            btnCalSalary.Click += btnCalSalary_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(txtTaxRate);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(txtOTHours);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtNoOfAbsents);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txtNoOfHolidays);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtNoOfLeaves);
            groupBox3.Location = new Point(12, 339);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(617, 165);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Salary Info";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(11, 122);
            label17.Name = "label17";
            label17.Size = new Size(76, 18);
            label17.TabIndex = 21;
            label17.Text = "Tax Rate :";
            // 
            // txtTaxRate
            // 
            txtTaxRate.Location = new Point(139, 119);
            txtTaxRate.Name = "txtTaxRate";
            txtTaxRate.Size = new Size(160, 26);
            txtTaxRate.TabIndex = 8;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(316, 80);
            label12.Name = "label12";
            label12.Size = new Size(82, 18);
            label12.TabIndex = 19;
            label12.Text = "OT Hours :";
            // 
            // txtOTHours
            // 
            txtOTHours.Location = new Point(444, 77);
            txtOTHours.Name = "txtOTHours";
            txtOTHours.Size = new Size(157, 26);
            txtOTHours.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(316, 39);
            label11.Name = "label11";
            label11.Size = new Size(116, 18);
            label11.TabIndex = 17;
            label11.Text = "No Of Absents :";
            // 
            // txtNoOfAbsents
            // 
            txtNoOfAbsents.Location = new Point(444, 36);
            txtNoOfAbsents.Name = "txtNoOfAbsents";
            txtNoOfAbsents.Size = new Size(157, 26);
            txtNoOfAbsents.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 80);
            label10.Name = "label10";
            label10.Size = new Size(120, 18);
            label10.TabIndex = 15;
            label10.Text = "No Of Holidays :";
            // 
            // txtNoOfHolidays
            // 
            txtNoOfHolidays.Location = new Point(138, 77);
            txtNoOfHolidays.Name = "txtNoOfHolidays";
            txtNoOfHolidays.Size = new Size(160, 26);
            txtNoOfHolidays.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 39);
            label9.Name = "label9";
            label9.Size = new Size(111, 18);
            label9.TabIndex = 13;
            label9.Text = "No Of Leaves :";
            // 
            // txtNoOfLeaves
            // 
            txtNoOfLeaves.Location = new Point(138, 36);
            txtNoOfLeaves.Name = "txtNoOfLeaves";
            txtNoOfLeaves.Size = new Size(160, 26);
            txtNoOfLeaves.TabIndex = 4;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(txtTaxAmount);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(txtNoPay);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(txtGrossPay);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(txtBasePay);
            groupBox4.Location = new Point(13, 550);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(618, 111);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Calculations";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(318, 72);
            label18.Name = "label18";
            label18.Size = new Size(95, 18);
            label18.TabIndex = 27;
            label18.Text = "Tax Amount :";
            // 
            // txtTaxAmount
            // 
            txtTaxAmount.Cursor = Cursors.No;
            txtTaxAmount.Enabled = false;
            txtTaxAmount.Location = new Point(444, 69);
            txtTaxAmount.Name = "txtTaxAmount";
            txtTaxAmount.ReadOnly = true;
            txtTaxAmount.Size = new Size(157, 26);
            txtTaxAmount.TabIndex = 26;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(12, 72);
            label15.Name = "label15";
            label15.Size = new Size(123, 18);
            label15.TabIndex = 25;
            label15.Text = "No Pay Amount :";
            // 
            // txtNoPay
            // 
            txtNoPay.Cursor = Cursors.No;
            txtNoPay.Enabled = false;
            txtNoPay.Location = new Point(138, 69);
            txtNoPay.Name = "txtNoPay";
            txtNoPay.ReadOnly = true;
            txtNoPay.Size = new Size(157, 26);
            txtNoPay.TabIndex = 24;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(318, 33);
            label14.Name = "label14";
            label14.Size = new Size(89, 18);
            label14.TabIndex = 23;
            label14.Text = "Gross Pay :";
            // 
            // txtGrossPay
            // 
            txtGrossPay.Cursor = Cursors.No;
            txtGrossPay.Enabled = false;
            txtGrossPay.Location = new Point(444, 30);
            txtGrossPay.Name = "txtGrossPay";
            txtGrossPay.ReadOnly = true;
            txtGrossPay.Size = new Size(157, 26);
            txtGrossPay.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(10, 33);
            label13.Name = "label13";
            label13.Size = new Size(84, 18);
            label13.TabIndex = 21;
            label13.Text = "Base Pay :";
            // 
            // txtBasePay
            // 
            txtBasePay.Cursor = Cursors.No;
            txtBasePay.Enabled = false;
            txtBasePay.Location = new Point(138, 30);
            txtBasePay.Name = "txtBasePay";
            txtBasePay.ReadOnly = true;
            txtBasePay.Size = new Size(160, 26);
            txtBasePay.TabIndex = 20;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.SteelBlue;
            btnClear.Location = new Point(544, 667);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(85, 34);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Blue;
            btnSave.Location = new Point(441, 667);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(85, 34);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReport
            // 
            btnReport.Cursor = Cursors.Hand;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReport.ForeColor = Color.DarkCyan;
            btnReport.Location = new Point(14, 667);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(85, 34);
            btnReport.TabIndex = 12;
            btnReport.Text = "Report";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.MidnightBlue;
            label16.Location = new Point(98, 9);
            label16.Name = "label16";
            label16.Size = new Size(457, 37);
            label16.TabIndex = 12;
            label16.Text = "Employee Salary Calculation";
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
            lblBack.TabIndex = 26;
            lblBack.Text = "   ";
            lblBack.Click += lblBack_Click;
            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(642, 714);
            ControlBox = false;
            Controls.Add(lblBack);
            Controls.Add(label16);
            Controls.Add(btnReport);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(btnCalSalary);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Salary";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salary";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private TextBox txtENIC;
        private Label label5;
        private TextBox txtAllowance;
        private Label label4;
        private TextBox txtOTRate;
        private Label label3;
        private TextBox txtMSalary;
        private Label label2;
        private TextBox txtEName;
        private ComboBox comEID;
        private Label label1;
        private GroupBox groupBox2;
        private DateTimePicker pickStartDate;
        private Label label8;
        private DateTimePicker pickEndDate;
        private Label label7;
        private Button btnCalSalary;
        private GroupBox groupBox3;
        private Label label12;
        private TextBox txtOTHours;
        private Label label11;
        private TextBox txtNoOfAbsents;
        private Label label10;
        private TextBox txtNoOfHolidays;
        private Label label9;
        private TextBox txtNoOfLeaves;
        private GroupBox groupBox4;
        private Label label13;
        private TextBox txtBasePay;
        private Label label14;
        private TextBox txtGrossPay;
        private Button btnClear;
        private Button btnSave;
        private Button btnReport;
        private Label label16;
        private Label label17;
        private TextBox txtTaxRate;
        private Label label18;
        private TextBox txtTaxAmount;
        private Label label15;
        private TextBox txtNoPay;
        private Label lblBack;
    }
}