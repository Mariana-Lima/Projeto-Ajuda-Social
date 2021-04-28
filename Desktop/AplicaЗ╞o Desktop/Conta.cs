using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicação
{
    public partial class frmConta : Form
    {
        

        public frmConta()
        {
            InitializeComponent();
        }

       public frmConta(string texto)
        {
            InitializeComponent();
            lblUsuario.Text = texto; //O label está recebendo o valor que foi recebido por parâmetro
            
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vOLTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void lblLogin_Click(object sender, EventArgs e)
        {

        }


        private void frmConta_Load(object sender, EventArgs e)
        {
            /*if (!this.Propriedade.Equals(""))
            {
                return;
            }
            lblUsuario.Text = this.Propriedade;*/
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
