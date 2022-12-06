using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pim
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void frmMenu_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void fecharProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddOs_Click(object sender, EventArgs e)
        {
            funcaoindisponivel();
        }

        private void funcaoindisponivel()
        {
            MessageBox.Show("Função Indisponivel");
            return;
        }

        private void btnSearchOs_Click(object sender, EventArgs e)
        {
            funcaoindisponivel();
        }

        private void btnCloseOs_Click(object sender, EventArgs e)
        {
            funcaoindisponivel();
        }

        private void btnListOs_Click(object sender, EventArgs e)
        {
            funcaoindisponivel();
        }

        private void btnEditOs_Click(object sender, EventArgs e)
        {
            funcaoindisponivel();
        }

        private void btnConfigBot_Click(object sender, EventArgs e)
        {
            funcaoindisponivel();
        }
    }
}
