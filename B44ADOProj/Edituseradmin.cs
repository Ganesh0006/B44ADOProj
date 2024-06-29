using System;
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
    public partial class Edituseradmin : Form
    {
        public Edituseradmin()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();
        public void LoadData()
        {

            DataTable dt = new DataTable();
            dt = db.viewuser();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "uid";
        }
        private void Edituseradmin_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = db.Updateuser(int.Parse(comboBox1.Text), textBox1.Text, textBox2.Text);
            MessageBox.Show(x + " Product Updated Sucessfully..");
            LoadData();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                var cb = (sender as ComboBox);
                var selecteditem = (cb.SelectedItem as DataRowView);
                textBox1.Text = selecteditem["uname"].ToString();
                textBox2.Text = selecteditem["utype"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "Error");
            }
        }
    }
}
