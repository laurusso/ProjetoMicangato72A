using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMiçangato72A
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadUsuario_Click(object sender, EventArgs e)
        {
            frmLogin Formulario1 = new frmLogin(this);
            this.Hide();
            Formulario1.ShowDialog();
        }

        private void lblFundo_Click(object sender, EventArgs e)
        {

        }

      

        private void btnSair_Click(object sender, EventArgs e)
        {
            string mensagem = "Deseja realmente sair?";
            DialogResult resposta = MessageBox.Show(mensagem, "Verificação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            frmSplash Splash = new frmSplash(this);
            Splash.ShowDialog();
            frmLogin Login = new frmLogin(this);
            Login.ShowDialog();
            this.Visible = true;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
