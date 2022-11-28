using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ProjetoMiçangato72A
{
    public partial class frmSplash : Form
    {

        Form parent;
        public frmSplash(Form parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

      
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void timerSplash_Tick(object sender, EventArgs e)
        {
            timerSplash.Enabled = false;
            this.Close();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
