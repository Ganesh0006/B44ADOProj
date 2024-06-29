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
    public partial class EditModel : Form
    {
        public EditModel()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();
        private void button1_Click(object sender, EventArgs e)
        {
            
            int x = db.upmodel(int.Parse(comboBox1.Text), textBox1.Text, int.Parse(textBox5.Text), textBox6.Text, textBox4.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            MessageBox.Show(x + "model updated sucessfully....");
            loaddata();

        }

        private void loaddata()
        {
            DataTable dt = new DataTable();
            dt = db.ViewModel();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "mid";
        }

        private void EditModel_Load(object sender, EventArgs e)
        {

            loaddata();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cb = (sender as ComboBox);
                var selecteditem = (cb.SelectedItem as DataRowView);
                textBox1.Text = selecteditem["mname"].ToString();
                textBox5.Text = selecteditem["pid"].ToString();
                textBox6.Text = selecteditem["pname"].ToString();
                textBox4.Text = selecteditem["spec"].ToString();
                textBox2.Text = selecteditem["uprice"].ToString();
                textBox3.Text = selecteditem["soh"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "errror");
            }

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
