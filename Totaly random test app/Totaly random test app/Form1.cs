﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Totaly_random_test_app
{
    public partial class Form1 : Form
    {
        Form2 frm2;
        string Username = "TESTUSER", Password = "TESTPASS";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == Username && txtPassword.Text == Password)
            {
                MessageBox.Show("Logged In!");
                frm2 = new Form2();
                this.Hide();
                frm2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Function1()
        {

        }
    }
}
