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
    public partial class frmLogin : Form
    {
        Form parent;

        public frmLogin(Form parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadUsuario Formulario3 = new frmCadUsuario(this);
            this.Hide();
            Formulario3.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
        private void lblLogin_Click(object sender, EventArgs e)
        {

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

      

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.parent.Show();
            this.Hide();   
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            string id_Usu;
            string sql;
            string sql3;

            try
            {
                sql = "select * from cliente ";
                sql += "where email = @1";

               

                List<object> param = new List<object>();
                param.Add(txtEmail.Text.ToLower());

                NpgsqlDataReader dr = ConexaoBanco.selecionar(sql, param);


                if (dr.Read())
                {
                    //if (dr["senha"].ToString() == txtSenha.Text)
                    if(MD5.compareHash(txtSenha.Text,dr["senha"].ToString()))
                    {

                        if (Convert.ToBoolean(dr["excluido"]) == true)
                        {
                            dr.Close();
                            /*MessageBox.Show("Sua conta foi excluida", "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;*/
                            string mensagem = "Essa conta havia sido excluida, deseja recupera-la?";
                            DialogResult resposta = MessageBox.Show(mensagem, "Verificação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (resposta == DialogResult.Yes)
                            {
                                sql3 = "UPDATE cliente SET excluido = 'false' ";
                                sql3 += "where email = @1";
                                List<object> param3 = new List<object>();
                                param3.Add(txtEmail.Text.ToLower());
                                ConexaoBanco.executar(sql3, param3);

                                MessageBox.Show("Conta recuperada");
                             
                            }

                            return;
                        }

                        id_Usu = dr["id_usuario"].ToString();
                        VarId_Usuario.Id = Convert.ToInt16(id_Usu);

                        

                        //sql = "select id_usuario from cliente ";
                        //sql += "where email = @1";
                        //sql = id_Usu;

                        MessageBox.Show("Seja bem-vindo(a) " + dr["nome"].ToString() + "!", "Login confirmado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dr.Close();
                        frmMenuLogin Formulario5 = new frmMenuLogin(this);
                        this.Hide();
                        Formulario5.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("senha incorreta");
                        txtSenha.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Email n cadastrado, verifique");
                    txtEmail.Focus();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao fazer login" +
                    "\n\nMais detalhes "+ ex.Message,
                    "Login App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEsqueci_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Que pena, deveria ter anotado ;(",
                "Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string sql;
            string sql2;

                sql = "select * from cliente ";
                sql += "where email = @1";

                List<object> param = new List<object>();
                param.Add(txtEmail.Text.ToLower());

                NpgsqlDataReader dr = ConexaoBanco.selecionar(sql, param);


                if (dr.Read())
                {
                //MessageBox.Show("achei"+txtEmail.Text);
                    if (dr["senha"].ToString() == txtSenha.Text)
                    {
                        dr.Close();
                        string mensagem = "Deseja realmente excluir a sua conta?";
                        DialogResult resposta = MessageBox.Show(mensagem, "Verificação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resposta == DialogResult.Yes)
                        {
                            sql2 = "UPDATE cliente SET excluido = 'true' ";
                            sql2 += "where email = @1";
                            List<object> param2 = new List<object>();
                            param2.Add(txtEmail.Text.ToLower());
                            ConexaoBanco.executar(sql2, param2);

                            MessageBox.Show("Conta excluida com sucesso!!!");
                    }

                    }
                    else
                    {
                        MessageBox.Show("senha incorreta");
                        txtSenha.Focus();
                    }

                    dr.Close();

                }
                else
                {
                    MessageBox.Show("Email n cadastrado, verifique");
                    txtEmail.Focus();
                }
                //dr.Close();
        }

        private void lblSemConta_Click(object sender, EventArgs e)
        {

        }

        private void btnVersenha_Click(object sender, EventArgs e)
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
    }
}
