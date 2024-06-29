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
    public partial class UserMDI : Form
    {
        public UserMDI()
        {
            InitializeComponent();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aDDPROJECTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addproduct_user au = new Addproduct_user();
            au.Show();

        }

        private void eDITPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditProduct_use eu = new EditProduct_use();
            eu.Show();
        }

        private void dELPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Deleteproduct_user du = new Deleteproduct_user();
            //du.Show();
        }

        private void vIEWPRODUCTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //viewproduct_user vu = new viewproduct_user();
            //vu.Show();
        }

        private void aDDMODELToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vIEWMODELSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userviewproduct uv = new userviewproduct();
            uv.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userviewmodel uv = new userviewmodel();
            uv.Show();
        }
    }
}
