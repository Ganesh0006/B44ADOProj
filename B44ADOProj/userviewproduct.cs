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
    public partial class userviewproduct : Form
    {
        public userviewproduct()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();
        public void loaddata()
        {
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.ViewProductbyPid(int.Parse(comboBox1.Text));
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.ViewProduct();
            dataGridView1.DataSource = dt;
        }

        private void userviewproduct_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.ViewProduct();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Pid";
        }
    }
}
