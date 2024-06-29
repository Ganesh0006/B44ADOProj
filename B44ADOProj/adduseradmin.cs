using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B44ADOProj
{
    public partial class adduseradmin : Form
    {
        public adduseradmin()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();

        private void button1_Click(object sender, EventArgs e)
        {
           int x = db.insertuser(int.Parse(textBox1.Text),textBox2.Text, textBox3.Text);
            MessageBox.Show(x + "USER ADDED SUCCESSFULLY");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
