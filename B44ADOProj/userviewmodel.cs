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
    public partial class userviewmodel : Form
    {
        public userviewmodel()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();
        public void loaddata()
        {
            DataTable dt = new DataTable();
            dt = db.ViewModel();
              comboBox1.DataSource = dt;
            //comboBox2.DataSource = dt;
            //comboBox2.DisplayMember = "pid";
            comboBox1.DisplayMember = "mid";
            
        }
        private void userviewmodel_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = db.sales(int.Parse(textBox7.Text), textBox1.Text, int.Parse(comboBox1.Text), textBox2.Text, textBox3.Text, int.Parse(textBox4.Text), int.Parse(textBox5.Text), int.Parse(textBox6.Text));
            MessageBox.Show(x + "product saved successfully");
            loaddata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox6.Text = (int.Parse(textBox4.Text) * int.Parse(textBox5.Text)).ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cb = (sender as ComboBox);
                var Selecteditem = (cb.SelectedItem as DataRowView);
                textBox7.Text = Selecteditem["pid"].ToString();
                textBox1.Text = Selecteditem["pname"].ToString();
                textBox2.Text = Selecteditem["mname"].ToString();
                textBox3.Text = Selecteditem["spec"].ToString();
                textBox4.Text = Selecteditem["uprice"].ToString();
                // textBox5.Text = Selecteditem["qty"].ToString();
                // textBox6.Text = Selecteditem["total"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "error");
            }

        }
    }
}
