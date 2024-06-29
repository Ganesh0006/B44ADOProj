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
    public partial class AdminMDI : Form
    {
        public AdminMDI()
        {
            InitializeComponent();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aDDPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertProduct i = new InsertProduct();
            i.Show();
        }

        private void eDITPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditProduct ed = new EditProduct();
            ed.Show();
        }

        private void dELPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteProduct d = new DeleteProduct();
            d.Show();
        }

        private void vIEWPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewProduct v = new ViewProduct();
            v.Show();
        }

        private void aDDMODELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddModel ad = new AddModel();
            ad.Show();
        }

        private void eDITMODELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditModel ed = new EditModel();
            ed.Show();
        }

        private void dELMODELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteModel dm = new DeleteModel();
            dm.Show();

        }

        private void vIEWMODELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewModel vm = new ViewModel();
            vm.Show();

        }

        private void eDITUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void AdminMDI_Load(object sender, EventArgs e)
        {

        }

        private void dAILYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dailysalesreport dr = new dailysalesreport();
            dr.Show();


        }

        private void pRODUCTVIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productwisereport pr = new productwisereport();
            pr.Show();
        }

        private void mODELToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            modelwisereport mr = new modelwisereport();
            mr.Show();
        }

        private void dATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datesbetween2date d2 = new datesbetween2date();
            d2.Show();
        }

        private void aDDUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adduseradmin aa = new adduseradmin();
            aa.Show();
        }

        private void eDITUSERToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Edituseradmin ea = new Edituseradmin();
            ea.Show();
        }

        private void dELUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deleteuseradmin da = new Deleteuseradmin();
            da.Show();
        }

        private void vIEWUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewuseradmin vu =new viewuseradmin();
            vu.Show();
        }
    }
}
