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
    public partial class frmMenuLogin : Form
    {
        Form parent;
        public frmMenuLogin(Form parent)
        {
            this.parent = parent;
            InitializeComponent();
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

        private void btnComp3_Click(object sender, EventArgs e)
        {
            int id_prod = 1;
            VarId_Prod.IdProd = id_prod;

            string sql;
            sql = "select * from cproduto ";
            sql += "where id_produto = 16";

            NpgsqlDataReader dr = ConexaoBanco.selecionar(sql);

            //int estoq = Convert.ToInt16(dr["estoque"]);



            //if (dr.Read())
            //{

            dr.Close();

            string sql2 = "insert into citemvenda (id_produto, id_usuario)";
            sql2 += " values (@1, @2)";
            List<object> param = new List<object>();
            param.Add(VarId_Usuario.Id);
            param.Add(id_prod);

            frmComprar Formulario7 = new frmComprar(this);
            this.Hide();
            Formulario7.ShowDialog();

        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {

        }



        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnComp1_Click(object sender, EventArgs e)
        {
            int id_prod = 12;
            VarId_Prod.IdProd = id_prod;

            string sql;
            sql = "select * from cproduto ";
            sql += "where id_produto = 16";

            NpgsqlDataReader dr = ConexaoBanco.selecionar(sql);

            //int estoq = Convert.ToInt16(dr["estoque"]);



            //if (dr.Read())
            //{

            dr.Close();

            string sql2 = "insert into citemvenda (id_produto, id_usuario)";
            sql2 += " values (@1, @2)";
            List<object> param = new List<object>();
            param.Add(VarId_Usuario.Id);
            param.Add(id_prod);

            frmComprar Formulario7 = new frmComprar(this);
            this.Hide();
            Formulario7.ShowDialog();

        }

        private void btnCmp2_Click(object sender, EventArgs e)
        {

            int id_prod = 16;
            VarId_Prod.IdProd = id_prod;


            //int nume = Convert.ToInt16(txtQtd2.Text);

            string sql;
            sql = "select * from cproduto ";
            sql += "where id_produto = 16";

            NpgsqlDataReader dr = ConexaoBanco.selecionar(sql);

            //int estoq = Convert.ToInt16(dr["estoque"]);



            //if (dr.Read())
            //{

                dr.Close();

                string sql2 = "insert into citemvenda (id_produto, id_usuario)";
                sql2 += " values (@1, @2)";
                List<object> param = new List<object>();
                param.Add(VarId_Usuario.Id);
                param.Add(id_prod);

                frmComprar Formulario7 = new frmComprar(this);
                this.Hide();
                Formulario7.ShowDialog();


            //}


        }

        /*private void picPesquisar_Click(object sender, EventArgs e)
        {

            try
            {
                string sql = "select * from cproduto order by nome where ";

                dgvPesquisa.DataSource = ConexaoBanco.selecionarDataTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar" +
                    "\n\nMais detalhes" + ex.Message,
                    "Pesquisa produtos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private void picPesquisar_Click_1(object sender, EventArgs e)
        {
            string sql = "select * from cproduto where nome=@1;";
            List<object> param = new List<object>();
            param.Add(txtPesq.Text.ToLower());
            NpgsqlDataReader dr = ConexaoBanco.selecionar(sql, param);
            if (dr.Read())
            {
                lblText.Visible = false;
                lblNom.Text = "NOME";
                lblDes.Text = "DESCRIÇÃO";
                lblEst.Text = "ESTOQUE";
                lblPrec.Text = "PREÇO";
                lblNome.Text = dr["nome"].ToString();
                lblDescricao.Text = dr["descricao"].ToString();
                lblEstoque.Text = (Convert.ToInt64(dr["estoque"])).ToString();
                lblPreco.Text = (Convert.ToDouble(dr["preco"])).ToString();
            }
            else
            {
                MessageBox.Show("Nome não cadastrado, verifique!!");
                txtPesq.Focus();
            }
            dr.Close();
        }

        private void lblFundo_Click(object sender, EventArgs e)
        {

        }

        private void btnDeslogar_Click_1(object sender, EventArgs e)
        {
            frmLogin Formulario4 = new frmLogin(this);
            this.Hide();
            Formulario4.ShowDialog();
        }

        private void btnComp4_Click(object sender, EventArgs e)
        {
            int id_prod = 16;
            VarId_Prod.IdProd = id_prod;


            //int nume = Convert.ToInt16(txtQtd2.Text);

            string sql;
            sql = "select * from cproduto ";
            sql += "where id_produto = 16";

            NpgsqlDataReader dr = ConexaoBanco.selecionar(sql);

            //int estoq = Convert.ToInt16(dr["estoque"]);



            //if (dr.Read())
            //{

            dr.Close();

            string sql2 = "insert into citemvenda (id_produto, id_usuario)";
            sql2 += " values (@1, @2)";
            List<object> param = new List<object>();
            param.Add(VarId_Usuario.Id);
            param.Add(id_prod);

            frmComprar Formulario7 = new frmComprar(this);
            this.Hide();
            Formulario7.ShowDialog();

        }

        private void btnComp5_Click(object sender, EventArgs e)
        {
            int id_prod = 5;
            VarId_Prod.IdProd = id_prod;


            //int nume = Convert.ToInt16(txtQtd2.Text);

            string sql;
            sql = "select * from cproduto ";
            sql += "where id_produto = 16";

            NpgsqlDataReader dr = ConexaoBanco.selecionar(sql);

            //int estoq = Convert.ToInt16(dr["estoque"]);



            //if (dr.Read())
            //{

            dr.Close();

            string sql2 = "insert into citemvenda (id_produto, id_usuario)";
            sql2 += " values (@1, @2)";
            List<object> param = new List<object>();
            param.Add(VarId_Usuario.Id);
            param.Add(id_prod);

            frmComprar Formulario7 = new frmComprar(this);
            this.Hide();
            Formulario7.ShowDialog();


        }

        private void btnComp6_Click(object sender, EventArgs e)
        {
            int id_prod = 04;
            VarId_Prod.IdProd = id_prod;
            //int nume = Convert.ToInt16(txtQtd2.Text);

            string sql;
            sql = "select * from cproduto ";
            sql += "where id_produto = 16";

            NpgsqlDataReader dr = ConexaoBanco.selecionar(sql);

            //int estoq = Convert.ToInt16(dr["estoque"]);



            //if (dr.Read())
            //{

            dr.Close();

            string sql2 = "insert into citemvenda (id_produto, id_usuario)";
            sql2 += " values (@1, @2)";
            List<object> param = new List<object>();
            param.Add(VarId_Usuario.Id);
            param.Add(id_prod);

            frmComprar Formulario7 = new frmComprar(this);
            this.Hide();
            Formulario7.ShowDialog();

        }

        private void picCarrinho_Click(object sender, EventArgs e)
        {
            frmLogin Formulario7 = new frmLogin(this);
            this.Hide();
            Formulario7.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void frmMenuLogin_Load(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void btnPesqgeral_Click(object sender, EventArgs e)
        {
            frmPesquisa Formulario100 = new frmPesquisa(this);
            this.Hide();
            Formulario100.ShowDialog();
        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }
    }
}
