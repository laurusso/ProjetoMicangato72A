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
    public partial class frmCadUsuario : Form
    {
        //private NpgsqlConnection cn = new NpgsqlConnection();
        //static string stringConexao = "Server = pgsql.projetoscti.com.br; " +
        //                               "Database = projetoscti6; Port=5432;" +
        //                               "User ID= projetoscti6; password = miçangato1313;";
        Form parent;

        public frmCadUsuario(Form parent)
        {
            this.parent = parent;
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmCadUsuario_Load(object sender, EventArgs e)
        {
            /*try
            {
                //cn.ConnectionString = stringConexao;
                //cn.Open();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro na conexão com o banco de dados" +
                    "\n\nMais detalhes" + ex.Message,
                    "Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void lblCadastro_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin Formulario2 = new frmLogin(this);
            this.Hide();
            Formulario2.ShowDialog();
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



        private void LimparForm()
        {
            txtNome.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtConfirmarSen.Clear();
        }
        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            string sql;
            

            try
            {
                //testes de consistencia = campos vazios
                if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtCidade.Text) || string.IsNullOrEmpty(txtEstado.Text) || string.IsNullOrEmpty(txtTelefone.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSenha.Text))
                {
                    MessageBox.Show("Você deve preencher todos os campos" +
                    "\n\nMais detalhes",
                    "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //teste = senhas iguais
                if (txtSenha.Text != txtConfirmarSen.Text)
                {
                    MessageBox.Show("Os campos SENHA e Confirmar senha, devem ser iguais" +
                    "\n\nMais detalhes",
                    "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtConfirmarSen.Text = "";
                    txtSenha.Focus();
                    return;
                }
                string senha_cript = MD5.returnHash(txtSenha.Text);

                //teste = estado
                if (txtEstado.Text.Length!=2)
                {
                    MessageBox.Show("O campo ESTADO deve ser preenchido com somente dois caracteres.",
                    "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEstado.Text = "";
                    txtEstado.Focus();
                    return ;
                }

                sql = "select * from cliente ";
                sql += "where email = @1";
               

                List<object> param = new List<object>();
                param.Add(txtEmail.Text.ToLower());

                NpgsqlDataReader dr = ConexaoBanco.selecionar(sql, param);

                if (dr.Read())
                {
                    MessageBox.Show("O email já foi cadastrado", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmail.Text = "";
                    txtEmail.Focus();
                    return ;
                }
                    
                sql = "insert into cliente " +
                        "(nome, cidade, estado, telefone, email, senha) " +
                        " values (@2, @3, @4, @5, @1, @6)";

                //List<object> param = new List<object>();
                param.Add(txtNome.Text);
                param.Add(txtCidade.Text.ToUpper());
                param.Add(txtEstado.Text.ToUpper());
                param.Add(txtTelefone.Text);
                //param.Add(txtEmail.Text.ToLower());
                param.Add(senha_cript);


                ConexaoBanco.executar(sql, param);

                MessageBox.Show("Seus dados foram salvos com sucesso!!",
                   "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparForm();

                frmLogin Formulario2 = new frmLogin(this);
                this.Hide();
                Formulario2.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar os seus dados " +
                    "\n\nMais detalhes" + ex.Message,
                    "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '\u0000')
            {
                txtSenha.PasswordChar = '*';
            }
            else
            {
                txtSenha.PasswordChar = '\u0000';
            }
        }

        private void btnVer2_Click(object sender, EventArgs e)
        {
            if (txtConfirmarSen.PasswordChar == '\u0000')
            {
                txtConfirmarSen.PasswordChar = '*';
            }
            else
            {
                txtConfirmarSen.PasswordChar = '\u0000';
            }
        }
    }
}
