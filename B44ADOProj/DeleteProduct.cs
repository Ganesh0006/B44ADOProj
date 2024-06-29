using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B44ADOProj
{
    public partial class DeleteProduct : Form
    {
        public DeleteProduct()
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
            int x = db.DeleteProduct(int.Parse(comboBox1.Text));
            MessageBox.Show(x + " product delete sucessfully");
            LoadData();
        }

        private void DeleteProduct_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
