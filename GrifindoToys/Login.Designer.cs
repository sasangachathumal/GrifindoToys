namespace GrifindoToys
{
    partial class Login
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            btnLogin = new Button();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(346, 60);
            label1.Name = "label1";
            label1.Size = new Size(109, 22);
            label1.TabIndex = 0;
            label1.Text = "Username :";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(456, 60);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(176, 26);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(456, 103);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(176, 26);
            txtPassword.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(346, 103);
            label2.Name = "label2";
            label2.Size = new Size(102, 22);
            label2.TabIndex = 2;
            label2.Text = "Password :";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.RoyalBlue;
            btnLogin.Location = new Point(544, 146);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(88, 34);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bauhaus 93", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(12, 58);
            label3.Name = "label3";
            label3.Size = new Size(270, 36);
            label3.TabIndex = 5;
            label3.Text = "WelCome Back to";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bauhaus 93", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(12, 94);
            label5.Name = "label5";
            label5.Size = new Size(301, 54);
            label5.TabIndex = 7;
            label5.Text = "Grifindo Toys";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(12, 187);
            label6.Name = "label6";
            label6.Size = new Size(377, 17);
            label6.TabIndex = 8;
            label6.Text = "* use you username and password to login to the system";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(644, 215);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label2;
        private Button btnLogin;
        private Label label3;
        private Label label5;
        private Label label6;
    }
}