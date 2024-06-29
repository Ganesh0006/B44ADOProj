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
    public partial class DailySalesRPT : Form
    {
        public DailySalesRPT()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
           // dt = db.dailyrpt();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
