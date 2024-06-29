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
    public partial class productwisereport : Form
    {
        public productwisereport()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();

        private void productwisereport_Load(object sender, EventArgs e)
        {
            loaddata();

        }
        public void loaddata()
        {
            DataTable dt = new DataTable();
            dt = db.productrpt1();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "pid";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.productrpt(int.Parse(comboBox1.Text));
            dataGridView1.DataSource = dt;

        }
    }
}
