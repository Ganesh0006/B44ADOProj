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
    public partial class viewuseradmin : Form
    {
        public viewuseradmin()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.viewuserbyuid(int.Parse(comboBox1.Text));
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.viewuser();
            dataGridView1.DataSource = dt;
        }
    }
}
