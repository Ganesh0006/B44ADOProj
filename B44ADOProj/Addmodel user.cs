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
    public partial class Addmodel_user : Form
    {
        public Addmodel_user()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            try
            {
                var cb = (sender as ComboBox);
                var selecteditem = (cb.SelectedItem as DataRowView);
                textBox1.Text = selecteditem["pname"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "errror");
            }



        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addmodel_user_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.ViewProduct();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "pid";

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBCon db = new DBCon();
            int x = db.InModel(int.Parse(comboBox1.Text), textBox1.Text, int.Parse(textBox5.Text), textBox6.Text, textBox4.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            MessageBox.Show(x + "model Inserted sucessfully....");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }
    }
}
