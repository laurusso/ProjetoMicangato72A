namespace ProjetoMiçangato72A
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadUsuario = new System.Windows.Forms.Button();
            this.lblSemConta = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEsqueci = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblFundo = new System.Windows.Forms.Label();
            this.lblMicangato = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnVersenha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadUsuario
            // 
            this.btnCadUsuario.BackColor = System.Drawing.Color.Indigo;
            this.btnCadUsuario.FlatAppearance.BorderSize = 0;
            this.btnCadUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadUsuario.Font = new System.Drawing.Font("Segoe Print", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadUsuario.ForeColor = System.Drawing.Color.Plum;
            this.btnCadUsuario.Location = new System.Drawing.Point(677, 329);
            this.btnCadUsuario.Name = "btnCadUsuario";
            this.btnCadUsuario.Size = new System.Drawing.Size(133, 48);
            this.btnCadUsuario.TabIndex = 1;
            this.btnCadUsuario.Text = "&cadastre-se";
            this.btnCadUsuario.UseVisualStyleBackColor = false;
            this.btnCadUsuario.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblSemConta
            // 
            this.lblSemConta.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemConta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSemConta.Location = new System.Drawing.Point(502, 341);
            this.lblSemConta.Name = "lblSemConta";
            this.lblSemConta.Size = new System.Drawing.Size(187, 26);
            this.lblSemConta.TabIndex = 2;
            this.lblSemConta.Text = "Não possui uma conta? ";
            this.lblSemConta.Click += new System.EventHandler(this.lblSemConta_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLogin.Location = new System.Drawing.Point(316, 63);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(531, 43);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSenha.Location = new System.Drawing.Point(344, 196);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(58, 26);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmail.Location = new System.Drawing.Point(344, 138);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(64, 26);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(380, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 26);
            this.label3.TabIndex = 7;
            // 
            // btnEsqueci
            // 
            this.btnEsqueci.BackColor = System.Drawing.Color.Indigo;
            this.btnEsqueci.FlatAppearance.BorderSize = 0;
            this.btnEsqueci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsqueci.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsqueci.ForeColor = System.Drawing.Color.Plum;
            this.btnEsqueci.Location = new System.Drawing.Point(349, 281);
            this.btnEsqueci.Name = "btnEsqueci";
            this.btnEsqueci.Size = new System.Drawing.Size(185, 48);
            this.btnEsqueci.TabIndex = 8;
            this.btnEsqueci.Text = "&Esqueci minha senha.";
            this.btnEsqueci.UseVisualStyleBackColor = false;
            this.btnEsqueci.Click += new System.EventHandler(this.btnEsqueci_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Indigo;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnEntrar.Location = new System.Drawing.Point(686, 274);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(104, 40);
            this.btnEntrar.TabIndex = 9;
            this.btnEntrar.Text = "&Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click_1);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(431, 138);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(359, 24);
            this.txtEmail.TabIndex = 10;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(431, 198);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(249, 24);
            this.txtSenha.TabIndex = 11;
            // 
            // lblFundo
            // 
            this.lblFundo.BackColor = System.Drawing.Color.MediumPurple;
            this.lblFundo.Location = new System.Drawing.Point(-14, -8);
            this.lblFundo.Name = "lblFundo";
            this.lblFundo.Size = new System.Drawing.Size(324, 493);
            this.lblFundo.TabIndex = 12;
            // 
            // lblMicangato
            // 
            this.lblMicangato.BackColor = System.Drawing.Color.MediumPurple;
            this.lblMicangato.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMicangato.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMicangato.Location = new System.Drawing.Point(3, 49);
            this.lblMicangato.Name = "lblMicangato";
            this.lblMicangato.Size = new System.Drawing.Size(307, 47);
            this.lblMicangato.TabIndex = 14;
            this.lblMicangato.Text = "MIÇANGATO";
            this.lblMicangato.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.pictureBox1.Image = global::ProjetoMiçangato72A.Properties.Resources.logotipo;
            this.pictureBox1.Location = new System.Drawing.Point(43, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSair.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnSair.Location = new System.Drawing.Point(94, 339);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(120, 48);
            this.btnSair.TabIndex = 40;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Indigo;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnExcluir.Location = new System.Drawing.Point(556, 275);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(104, 40);
            this.btnExcluir.TabIndex = 41;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnVersenha
            // 
            this.btnVersenha.BackColor = System.Drawing.Color.Indigo;
            this.btnVersenha.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVersenha.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnVersenha.Location = new System.Drawing.Point(686, 189);
            this.btnVersenha.Name = "btnVersenha";
            this.btnVersenha.Size = new System.Drawing.Size(104, 40);
            this.btnVersenha.TabIndex = 42;
            this.btnVersenha.Text = "&Ver senha";
            this.btnVersenha.UseVisualStyleBackColor = false;
            this.btnVersenha.Click += new System.EventHandler(this.btnVersenha_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnVersenha);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMicangato);
            this.Controls.Add(this.lblFundo);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnEsqueci);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblSemConta);
            this.Controls.Add(this.btnCadUsuario);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCadUsuario;
        private System.Windows.Forms.Label lblSemConta;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEsqueci;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblFundo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMicangato;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnVersenha;
    }
}