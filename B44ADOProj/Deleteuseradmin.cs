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
    public partial class Deleteuseradmin : Form
    {
        public Deleteuseradmin()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();
        public void loaddata()
        {
            DataTable dt = new DataTable();
            dt = db.viewuser();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "uid";

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = db.deleteuser(int.Parse(comboBox1.Text));
            MessageBox.Show(x + "user deleted successfully");
            loaddata();
        }

        private void Deleteuseradmin_Load(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
