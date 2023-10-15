namespace GrifindoToys
{
    partial class User
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
            btnClear = new Button();
            label5 = new Label();
            btnExit = new Button();
            btnDelete = new Button();
            btnRegister = new Button();
            dgUser = new DataGridView();
            groupBox1 = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            comUID = new ComboBox();
            lblEID = new Label();
            txtUID = new TextBox();
            label6 = new Label();
            checkSearch = new CheckBox();
            txtPassword = new TextBox();
            label1 = new Label();
            txtUsername = new TextBox();
            label8 = new Label();
            lblBack = new Label();
            ((System.ComponentModel.ISupportInitialize)dgUser).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Transparent;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.SteelBlue;
            btnClear.Location = new Point(490, 259);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(96, 43);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(294, -86);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(371, 37);
            label5.TabIndex = 19;
            label5.Text = "Employee Management";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(921, -77);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(64, 35);
            btnExit.TabIndex = 20;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.DarkRed;
            btnDelete.Location = new Point(370, 259);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 43);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Transparent;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.MidnightBlue;
            btnRegister.Location = new Point(223, 259);
            btnRegister.Margin = new Padding(4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(118, 43);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // dgUser
            // 
            dgUser.AllowUserToAddRows = false;
            dgUser.AllowUserToDeleteRows = false;
            dgUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgUser.BackgroundColor = Color.AliceBlue;
            dgUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUser.GridColor = Color.Black;
            dgUser.Location = new Point(10, 319);
            dgUser.Margin = new Padding(4);
            dgUser.MultiSelect = false;
            dgUser.Name = "dgUser";
            dgUser.ReadOnly = true;
            dgUser.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgUser.RowTemplate.Height = 25;
            dgUser.ShowEditingIcon = false;
            dgUser.Size = new Size(576, 232);
            dgUser.TabIndex = 17;
            dgUser.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(comUID);
            groupBox1.Controls.Add(lblEID);
            groupBox1.Controls.Add(txtUID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(checkSearch);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.MidnightBlue;
            groupBox1.Location = new Point(10, 90);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(576, 152);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(105, 111);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(15, 19);
            label10.TabIndex = 19;
            label10.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(107, 66);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(15, 19);
            label9.TabIndex = 18;
            label9.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(62, 21);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(15, 19);
            label7.TabIndex = 15;
            label7.Text = "*";
            // 
            // comUID
            // 
            comUID.DropDownStyle = ComboBoxStyle.DropDownList;
            comUID.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comUID.FormattingEnabled = true;
            comUID.Location = new Point(144, 17);
            comUID.Margin = new Padding(4);
            comUID.Name = "comUID";
            comUID.Size = new Size(320, 26);
            comUID.TabIndex = 15;
            comUID.Visible = false;
            comUID.SelectedIndexChanged += comUID_SelectedIndexChanged;
            // 
            // lblEID
            // 
            lblEID.AutoSize = true;
            lblEID.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEID.ForeColor = Color.Black;
            lblEID.Location = new Point(11, 21);
            lblEID.Margin = new Padding(4, 0, 4, 0);
            lblEID.Name = "lblEID";
            lblEID.Size = new Size(42, 18);
            lblEID.TabIndex = 15;
            lblEID.Text = "UID :";
            // 
            // txtUID
            // 
            txtUID.Cursor = Cursors.No;
            txtUID.Enabled = false;
            txtUID.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUID.Location = new Point(144, 17);
            txtUID.Margin = new Padding(4);
            txtUID.Name = "txtUID";
            txtUID.ReadOnly = true;
            txtUID.Size = new Size(320, 26);
            txtUID.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(11, 111);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(86, 18);
            label6.TabIndex = 10;
            label6.Text = "Password :";
            // 
            // checkSearch
            // 
            checkSearch.AutoSize = true;
            checkSearch.Cursor = Cursors.Hand;
            checkSearch.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkSearch.ForeColor = Color.SteelBlue;
            checkSearch.Location = new Point(486, 20);
            checkSearch.Margin = new Padding(4);
            checkSearch.Name = "checkSearch";
            checkSearch.Size = new Size(82, 23);
            checkSearch.TabIndex = 4;
            checkSearch.Text = "Search";
            checkSearch.UseVisualStyleBackColor = true;
            checkSearch.CheckedChanged += checkSearch_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(144, 107);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(320, 26);
            txtPassword.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(11, 66);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 18);
            label1.TabIndex = 0;
            label1.Text = "Username :";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(144, 63);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(320, 26);
            txtUsername.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(154, 20);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(292, 37);
            label8.TabIndex = 23;
            label8.Text = "User Management";
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
            lblBack.TabIndex = 24;
            lblBack.Text = "   ";
            lblBack.Click += lblBack_Click;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(599, 563);
            ControlBox = false;
            Controls.Add(lblBack);
            Controls.Add(label8);
            Controls.Add(btnClear);
            Controls.Add(label5);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnRegister);
            Controls.Add(dgUser);
            Controls.Add(groupBox1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "User";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            Load += User_Load;
            ((System.ComponentModel.ISupportInitialize)dgUser).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Label label5;
        private Button btnExit;
        private Button btnDelete;
        private Button btnRegister;
        private DataGridView dgUser;
        private GroupBox groupBox1;
        private Label label10;
        private Label label9;
        private Label label7;
        private ComboBox comUID;
        private Label lblEID;
        private TextBox txtUID;
        private Label label6;
        private CheckBox checkSearch;
        private TextBox txtPassword;
        private Label label1;
        private TextBox txtUsername;
        private Label label8;
        private Label lblBack;
    }
}