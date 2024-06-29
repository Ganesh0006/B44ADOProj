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
    public partial class EditProduct : Form
    {
        public EditProduct()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();

        public void LoadData()
        {

            DataTable dt = new DataTable();
            dt = db.ViewProduct();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Uid";
        }
        private void EditProduct_Load(object sender, EventArgs e)
        {
            LoadData();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cb = (sender as ComboBox);
                var selecteditem = (cb.SelectedItem as DataRowView);
                textBox1.Text = selecteditem["Uname"].ToString();
                textBox2.Text = selecteditem["Utype"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "Error");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = db.UpdateProduct(int.Parse(comboBox1.Text), textBox1.Text, textBox2.Text);
            MessageBox.Show(x + " Product Updated Sucessfully..");
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}