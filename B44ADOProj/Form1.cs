﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B44ADOProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "admin" && textBox2.Text == "a" && comboBox1.Text == "Admin")
            {
               
               
                AdminMDI a = new AdminMDI();
                a.Show();

            }
            else if (textBox1.Text == "user" && textBox2.Text == "u" && comboBox1.Text == "User")
            {
                

               UserMDI u = new UserMDI();
               u.Show();
            }
            else
                MessageBox.Show("Invalid username/password....");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            
        }
    }
}
