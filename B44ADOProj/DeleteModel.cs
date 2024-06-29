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
    public partial class DeleteModel : Form
    {
        public DeleteModel()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int x = db.DeleteModel(int.Parse(comboBox1.Text));
            MessageBox.Show(x + "delete model sucessfully");
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = new DataTable();
            dt = db.ViewModel();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "mid";
        }

        private void DeleteModel_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
