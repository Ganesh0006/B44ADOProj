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
    public partial class Addproduct_user : Form
    {
        public Addproduct_user()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBCon db = new DBCon();
            int x = db.InsertProduct(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text);
            MessageBox.Show(x + "Product Inserted sucessfully....");
        }
    }
}
