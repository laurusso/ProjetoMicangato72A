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
    public partial class frmComprar : Form
    {

        Form parent;
        public frmComprar(Form parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void frmComprar_Load(object sender, EventArgs e)
        {

        }


        private void rdComercial_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtReferencia_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            string sql2;
            string sql3;
            int estoq;

            sql2 = "select * from cproduto " +
                    "where id_produto = @1";

            List<object> param = new List<object>();
            param.Add(VarId_Prod.IdProd);

            NpgsqlDataReader dr = ConexaoBanco.selecionar(sql2, param);

            if (dr.Read())
            {
                if (Convert.ToInt16(txtQtd.Text) > int.Parse(dr["estoque"].ToString()))
                {
                    MessageBox.Show("Numero Invalido, redigite" +
                    "\n\nMais detalhes",
                    "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //numNum.Focus();
                    return;
                };

            }

            estoq = int.Parse(dr["estoque"].ToString());
            dr.Close();

            if (string.IsNullOrEmpty(txtBairro.Text) || string.IsNullOrEmpty(txtRua.Text) || string.IsNullOrEmpty(txtCEP.Text))
            {
                MessageBox.Show("Você deve preencher todos os campos" +
                "\n\nMais detalhes",
                "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Convert.ToInt64(numNum.Text)< 1)
            {
                MessageBox.Show("Numero Invalido, redigite" +
                "\n\nMais detalhes",
                "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numNum.Focus();
                return;
            }


            string mensagem = "Deseja realmente finalizar a sua compra?";
            DialogResult resposta = MessageBox.Show(mensagem, "Verificação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                //DateTime dat = DateTime.Now;

                
                sql3 = "UPDATE cproduto SET estoque = @1 " +
                        "where id_produto = @2";

                estoq=estoq - Convert.ToInt16(txtQtd.Text);

                List<object> param2 = new List<object>();
                param2.Add(estoq);
                param2.Add(VarId_Usuario.Id);

                ConexaoBanco.executar(sql3, param2);


                MessageBox.Show("Compra efetuada com sucesso! Obrigada por escolher comprar com a nossa loja ;)",
                "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            frmMenuLogin Formulario5 = new frmMenuLogin(this);
            this.Hide();
            Formulario5.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string mensagem = "Deseja realmente cancelar a sua compra? ";
            DialogResult resposta = MessageBox.Show(mensagem, "Verificação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                frmMenuLogin Formulario5 = new frmMenuLogin(this);
                this.Hide();
                Formulario5.ShowDialog();
            }
        }

        private void RadBoleto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtQtd_TextChanged(object sender, EventArgs e)
        {

        }

        private void numNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radComercial_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
