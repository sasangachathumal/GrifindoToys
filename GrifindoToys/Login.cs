﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToys
{
    public partial class Login : Form
    {
        private const string connectionString = "Data Source=SMSC-DESKTOP-PC;Initial Catalog=Grifindo_Toys;Integrated Security=True";

        public static String loginUserUsername = "";
        public static String loginUserPassowrd = "";
        public Login()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM Users WHERE username=@username COLLATE SQL_Latin1_General_CP1_CS_AS";
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@username", txtUsername.Text);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string password = reader.GetString(3);
                                if (string.Equals(password, txtPassword.Text))
                                {
                                    loginUserPassowrd = password;
                                    loginUserUsername = txtUsername.Text;

                                    HomePage homePage = new HomePage();
                                    homePage.loginPage = this;
                                    homePage.Show();

                                    txtPassword.Text = string.Empty;
                                    txtUsername.Text = string.Empty;
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Password is Incorrect! \n Check your passowrd and try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("User Not Found \n Check input username and enter valid username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);

                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
