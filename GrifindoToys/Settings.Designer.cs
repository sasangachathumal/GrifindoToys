namespace GrifindoToys
{
    partial class Settings
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnSave = new Button();
            txtNoOfLeaves = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtCycleDayCount = new TextBox();
            label4 = new Label();
            label5 = new Label();
            pickCycleStartDate = new DateTimePicker();
            pickCycleEndDate = new DateTimePicker();
            lblBack = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 81);
            label1.Name = "label1";
            label1.Size = new Size(148, 18);
            label1.TabIndex = 0;
            label1.Text = "No Of Leaves (Year)";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.DarkBlue;
            btnSave.Location = new Point(318, 253);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(101, 34);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtNoOfLeaves
            // 
            txtNoOfLeaves.Location = new Point(238, 78);
            txtNoOfLeaves.Name = "txtNoOfLeaves";
            txtNoOfLeaves.Size = new Size(181, 26);
            txtNoOfLeaves.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 123);
            label2.Name = "label2";
            label2.Size = new Size(177, 18);
            label2.TabIndex = 3;
            label2.Text = "Salary Cycyle Start Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 168);
            label3.Name = "label3";
            label3.Size = new Size(165, 18);
            label3.TabIndex = 5;
            label3.Text = "Salary Cycle End Date";
            // 
            // txtCycleDayCount
            // 
            txtCycleDayCount.Location = new Point(238, 212);
            txtCycleDayCount.Name = "txtCycleDayCount";
            txtCycleDayCount.Size = new Size(181, 26);
            txtCycleDayCount.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 215);
            label4.Name = "label4";
            label4.Size = new Size(172, 18);
            label4.TabIndex = 7;
            label4.Text = "Salary Cycle Day Count";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(81, 9);
            label5.Name = "label5";
            label5.Size = new Size(320, 37);
            label5.TabIndex = 10;
            label5.Text = "Apllication Settings";
            label5.Click += label5_Click;
            // 
            // pickCycleStartDate
            // 
            pickCycleStartDate.Format = DateTimePickerFormat.Short;
            pickCycleStartDate.Location = new Point(238, 117);
            pickCycleStartDate.Name = "pickCycleStartDate";
            pickCycleStartDate.Size = new Size(181, 26);
            pickCycleStartDate.TabIndex = 2;
            // 
            // pickCycleEndDate
            // 
            pickCycleEndDate.Format = DateTimePickerFormat.Short;
            pickCycleEndDate.Location = new Point(238, 162);
            pickCycleEndDate.Name = "pickCycleEndDate";
            pickCycleEndDate.Size = new Size(181, 26);
            pickCycleEndDate.TabIndex = 3;
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
            lblBack.TabIndex = 11;
            lblBack.Text = "   ";
            lblBack.Click += lblBack_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(482, 297);
            ControlBox = false;
            Controls.Add(lblBack);
            Controls.Add(pickCycleEndDate);
            Controls.Add(pickCycleStartDate);
            Controls.Add(label5);
            Controls.Add(txtCycleDayCount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNoOfLeaves);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Settings";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSave;
        private TextBox txtNoOfLeaves;
        private Label label2;
        private Label label3;
        private TextBox txtCycleDayCount;
        private Label label4;
        private Label label5;
        private DateTimePicker pickCycleStartDate;
        private DateTimePicker pickCycleEndDate;
        private Label lblBack;
    }
}