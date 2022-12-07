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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            pnlLogin.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //centralização do formulario de login
            pnlLogin.Location = new Point(this.Width / 2 - 166, this.Height / 2 - 170);
            pnlLogin.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //aviso caso falte algum campo
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Preencha o Usuário!");
                txtUsuario.Focus();
                return;
            }
            if (txtSenha.Text == "")
            {
                MessageBox.Show("Preencha a Senha!");
                txtSenha.Focus();
                return;
            }
            if (txtUsuario.Text != "admin" || txtSenha.Text != "123456")
            {
                MessageBox.Show("Usuário ou Senha está incorreto");
                txtSenha.Focus();
                return;
            }
            //codigo para o login
            frmMenu form = new frmMenu();
            //this.Hide();
            limpar();
            form.Show();
        }

        private void limpar()
        {
            txtSenha.Text = "";
            txtUsuario.Text = "";
        }

        private void frmLogin_Resize(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width / 2 - 166, this.Height / 2 - 170);
        }
    }
}
