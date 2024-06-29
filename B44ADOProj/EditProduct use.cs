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
    public partial class EditProduct_use : Form
    {
        public EditProduct_use()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();

        public void LoadData()
        {

            DataTable dt = new DataTable();
            dt = db.ViewProduct();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Pid";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int x = db.UpdateProduct(int.Parse(comboBox1.Text), textBox2.Text, textBox3.Text);
            MessageBox.Show(x + " Product Updated Sucessfully..");
            LoadData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cb = (sender as ComboBox);
                var selecteditem = (cb.SelectedItem as DataRowView);
                textBox2.Text = selecteditem["pname"].ToString();
                textBox3.Text = selecteditem["pdesc"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "Error");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void EditProduct_use_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}