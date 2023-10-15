namespace GrifindoToys
{
    partial class SalaryReport
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
            txtEName = new TextBox();
            lblEname = new Label();
            checkEAll = new CheckBox();
            label1 = new Label();
            comEID = new ComboBox();
            pickStartDate = new DateTimePicker();
            dgSalary = new DataGridView();
            groupBox2 = new GroupBox();
            checkDateRange = new CheckBox();
            lblEndDate = new Label();
            pickEndDate = new DateTimePicker();
            label3 = new Label();
            label5 = new Label();
            btnClear = new Button();
            btnGenerate = new Button();
            lblBack = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgSalary).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEName);
            groupBox1.Controls.Add(lblEname);
            groupBox1.Controls.Add(checkEAll);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comEID);
            groupBox1.Location = new Point(12, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 122);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee Info";
            // 
            // txtEName
            // 
            txtEName.Cursor = Cursors.No;
            txtEName.Enabled = false;
            txtEName.Location = new Point(144, 76);
            txtEName.Name = "txtEName";
            txtEName.ReadOnly = true;
            txtEName.Size = new Size(183, 26);
            txtEName.TabIndex = 6;
            // 
            // lblEname
            // 
            lblEname.AutoSize = true;
            lblEname.Location = new Point(6, 79);
            lblEname.Name = "lblEname";
            lblEname.Size = new Size(132, 18);
            lblEname.TabIndex = 8;
            lblEname.Text = "Employee Name :";
            // 
            // checkEAll
            // 
            checkEAll.AutoSize = true;
            checkEAll.Location = new Point(284, 33);
            checkEAll.Name = "checkEAll";
            checkEAll.Size = new Size(44, 22);
            checkEAll.TabIndex = 2;
            checkEAll.Text = "All";
            checkEAll.UseVisualStyleBackColor = true;
            checkEAll.CheckedChanged += checkEAll_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(105, 18);
            label1.TabIndex = 6;
            label1.Text = "Employee ID :";
            // 
            // comEID
            // 
            comEID.DropDownStyle = ComboBoxStyle.DropDownList;
            comEID.FormattingEnabled = true;
            comEID.Location = new Point(144, 31);
            comEID.Name = "comEID";
            comEID.Size = new Size(121, 26);
            comEID.TabIndex = 1;
            comEID.SelectedIndexChanged += comEID_SelectedIndexChanged;
            // 
            // pickStartDate
            // 
            pickStartDate.Format = DateTimePickerFormat.Custom;
            pickStartDate.Location = new Point(99, 31);
            pickStartDate.Name = "pickStartDate";
            pickStartDate.Size = new Size(137, 26);
            pickStartDate.TabIndex = 3;
            // 
            // dgSalary
            // 
            dgSalary.AllowUserToAddRows = false;
            dgSalary.AllowUserToDeleteRows = false;
            dgSalary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgSalary.BackgroundColor = Color.AliceBlue;
            dgSalary.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgSalary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSalary.GridColor = Color.Black;
            dgSalary.Location = new Point(12, 227);
            dgSalary.MultiSelect = false;
            dgSalary.Name = "dgSalary";
            dgSalary.ReadOnly = true;
            dgSalary.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgSalary.RowTemplate.Height = 25;
            dgSalary.ShowEditingIcon = false;
            dgSalary.Size = new Size(832, 282);
            dgSalary.TabIndex = 5;
            dgSalary.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkDateRange);
            groupBox2.Controls.Add(lblEndDate);
            groupBox2.Controls.Add(pickEndDate);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(pickStartDate);
            groupBox2.Location = new Point(509, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(335, 122);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Date Info";
            // 
            // checkDateRange
            // 
            checkDateRange.AutoSize = true;
            checkDateRange.Location = new Point(250, 36);
            checkDateRange.Name = "checkDateRange";
            checkDateRange.Size = new Size(73, 22);
            checkDateRange.TabIndex = 4;
            checkDateRange.Text = "Range";
            checkDateRange.UseVisualStyleBackColor = true;
            checkDateRange.CheckedChanged += checkDateRange_CheckedChanged;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(6, 79);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(82, 18);
            lblEndDate.TabIndex = 11;
            lblEndDate.Text = "End Date :";
            lblEndDate.Visible = false;
            // 
            // pickEndDate
            // 
            pickEndDate.Format = DateTimePickerFormat.Custom;
            pickEndDate.Location = new Point(99, 76);
            pickEndDate.Name = "pickEndDate";
            pickEndDate.Size = new Size(137, 26);
            pickEndDate.TabIndex = 5;
            pickEndDate.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 34);
            label3.Name = "label3";
            label3.Size = new Size(87, 18);
            label3.TabIndex = 9;
            label3.Text = "Start Date :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(255, 9);
            label5.Name = "label5";
            label5.Size = new Size(243, 37);
            label5.TabIndex = 11;
            label5.Text = "Salary Reports";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Transparent;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.SteelBlue;
            btnClear.Location = new Point(769, 185);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 36);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.Transparent;
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerate.ForeColor = Color.MidnightBlue;
            btnGenerate.Location = new Point(653, 184);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(92, 36);
            btnGenerate.TabIndex = 6;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
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
            lblBack.TabIndex = 25;
            lblBack.Text = "   ";
            lblBack.Click += lblBack_Click;
            // 
            // SalaryReport
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(855, 521);
            ControlBox = false;
            Controls.Add(lblBack);
            Controls.Add(btnClear);
            Controls.Add(btnGenerate);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(dgSalary);
            Controls.Add(groupBox1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "SalaryReport";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SlaryReport";
            Load += SalaryReport_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgSalary).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox checkEAll;
        private Label label1;
        private ComboBox comEID;
        private DateTimePicker pickStartDate;
        private DataGridView dgSalary;
        private TextBox txtEName;
        private Label lblEname;
        private GroupBox groupBox2;
        private Label label3;
        private Label lblEndDate;
        private DateTimePicker pickEndDate;
        private CheckBox checkDateRange;
        private Label label5;
        private Button btnClear;
        private Button btnGenerate;
        private Label lblBack;
    }
}