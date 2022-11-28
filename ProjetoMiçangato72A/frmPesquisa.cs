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
    public partial class frmPesquisa : Form
    {
        Form parent;
        public frmPesquisa(Form parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void dgvPesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                sql = "SELECT nome,descricao,preco,estoque FROM cproduto ORDER BY nome";
                ConexaoBanco.executar(sql);
                dgvPesquisa.DataSource = ConexaoBanco.selecionarDataTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar! \n\nMais detalhes: " + ex.Message,"Erro de pesquisa",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            //string sql;

            //try
            //{
                
            //    sql = "select nome from cproduto ";
            //    sql += "where nome = @1";

            //    List<object> param = new List<object>();
            //    param.Add(txtPesq.Text.ToLower());


            //    NpgsqlDataReader dr = ConexaoBanco.selecionar(sql, param);
                

            //    if (dr.Read())
            //    {
            //        if (dr["nome"].ToString() == txtPesq.Text)
            //        {
            //            dr.Close();

            //            try
            //            {
            //                //sql = "select nome, descricao, preco, estoque from cproduto where ";
            //                //sql += "where nome = @1";
            //                dgvPesquisa.DataSource = ConexaoBanco.selecionarDataTable(sql);
            //            }
            //            catch (Exception ex)
            //            {
            //                MessageBox.Show("Ocorreu um erro ao conectar-se" +
            //                    "\n\nMais detalhes " + ex.Message,
            //                    "Pesquisar Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Produto não cadastrado, verifique");
            //        txtPesq.Focus();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Ocorreu um erro ao fazer login" +
            //        "\n\nMais detalhes" + ex.Message,
            //        "Login App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.parent.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            string mensagem = "Deseja realmente sair?";
            DialogResult resposta = MessageBox.Show(mensagem, "Verificação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
                this.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmPesquisa_Load(object sender, EventArgs e)
        {

        }
    }
}
