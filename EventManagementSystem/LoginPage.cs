﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using MySqlConnector;


namespace EventManagementSystem
{
    public partial class LoginPage : Form
    {
        private MySqlConnection connection = Program.db.GetConnection();
        private int role;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            UserDetail userDetail = new UserDetail(ActionType.Signup);
            userDetail.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            // Will be switched to database authentication
            if (CheckCredentials())
            {
                switch (role)
                {
                    case ((int)Role.Attendee):
                        CurrentUser.User = new Attendee();
                        break;
                    case ((int)Role.Manager):
                        CurrentUser.User = new Manager();
                        break;
                    case ((int)Role.Administrator):
                        CurrentUser.User = new Administrator();
                        break;

                }
                CurrentUser.User.Username = txtUserName.Text;
                AllEvents allEvents = new AllEvents();
                allEvents.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Incorrect user name or password!", "Error", MessageBoxButtons.OK);
            }
        }

        private bool CheckCredentials()
        {
            try
            {
                string username = txtUserName.Text;
                string password = txtPassword.Text;
                string sql = $"""
                    SELECT RoleId
                    FROM User
                    WHERE UserName = '{username}'
                    AND Password = '{password}';
                    """;

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        role = reader.GetInt32(0);
                    }
                    return reader.HasRows;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in database", "Error", MessageBoxButtons.OK);
                return false;
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
