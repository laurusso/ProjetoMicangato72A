using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ProjetoMiçangato72A
{
    public partial class frmCarrinho : Form
    {
        Form parent;
        public frmCarrinho(Form parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void frmCarrinho_Load(object sender, EventArgs e)
        {
            try
            {
                
                string sql = "select * from ccarrinho ";
                sql += "where id_usuario = @1";

                List<object> param = new List<object>();
                param.Add(VarId_Usuario.Id);

                dgvPesquisa.DataSource = ConexaoBanco.selecionarDataTable(sql);
            }

            
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao acessar o carrinho" +
                    "\n\nMais detalhes" + ex.Message,
                    "Carrinho", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            frmComprar Formulario6 = new frmComprar(this);
            this.Hide();
            Formulario6.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuLogin Formulario4 = new frmMenuLogin(this);
            this.Hide();
            Formulario4.ShowDialog();
        }
    }
}
