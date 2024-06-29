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
    public partial class ViewModel : Form
    {
        public ViewModel()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();

        private void ViewModel_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.ViewModel();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "mid";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.ViewModel();
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.ViewModel();
            dataGridView1.DataSource = dt;
        }
    }
}
