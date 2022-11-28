namespace ProjetoMiçangato72A
{
    partial class frmSplash
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
            this.components = new System.ComponentModel.Container();
            this.lblMicangato = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerSplash = new System.Windows.Forms.Timer(this.components);
            this.lblFundo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMicangato
            // 
            this.lblMicangato.BackColor = System.Drawing.Color.MediumPurple;
            this.lblMicangato.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMicangato.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMicangato.Location = new System.Drawing.Point(354, 153);
            this.lblMicangato.Name = "lblMicangato";
            this.lblMicangato.Size = new System.Drawing.Size(485, 108);
            this.lblMicangato.TabIndex = 17;
            this.lblMicangato.Text = "MIÇANGATO";
            this.lblMicangato.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.pictureBox1.Image = global::ProjetoMiçangato72A.Properties.Resources.logotipo;
            this.pictureBox1.Location = new System.Drawing.Point(4, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 459);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timerSplash
            // 
            this.timerSplash.Enabled = true;
            this.timerSplash.Interval = 2000;
            this.timerSplash.Tick += new System.EventHandler(this.timerSplash_Tick);
            // 
            // lblFundo
            // 
            this.lblFundo.BackColor = System.Drawing.Color.Indigo;
            this.lblFundo.Location = new System.Drawing.Point(-35, 423);
            this.lblFundo.Name = "lblFundo";
            this.lblFundo.Size = new System.Drawing.Size(979, 32);
            this.lblFundo.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Indigo;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Plum;
            this.label2.Location = new System.Drawing.Point(-1, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 39);
            this.label2.TabIndex = 45;
            this.label2.Text = "Desenvolvedores: 72A";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Indigo;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(160, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(761, 50);
            this.label1.TabIndex = 44;
            this.label1.Text = "Gustavo Rocha, 13 -  Karine Bertuzzo, 16  - Laura Russo, 18  - Rayssa Mauricio, 3" +
    "0  - Sarah Rezende, 32";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFundo);
            this.Controls.Add(this.lblMicangato);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmSplash";
            this.Text = "Splash Screen";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMicangato;
        private System.Windows.Forms.Timer timerSplash;
        private System.Windows.Forms.Label lblFundo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

