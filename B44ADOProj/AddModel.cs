using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B44ADOProj
{
    public partial class AddModel : Form
    {
        public AddModel()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();
        


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int x = db.InModel(int.Parse(textBox5.Text), textBox6.Text,int.Parse (comboBox1.Text),textBox1.Text,textBox4.Text,int.Parse(textBox2.Text),int.Parse(textBox3.Text));
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

        private void AddModel_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.ViewProduct();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "pid";




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cb = (sender as ComboBox);
                var selecteditem = (cb.SelectedItem as DataRowView);
                textBox6.Text = selecteditem["pname"].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString() + "errror");
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
