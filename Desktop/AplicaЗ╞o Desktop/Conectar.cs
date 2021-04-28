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
    

    public partial class frmConectar : Form
    {
        
        public frmConectar()
        {
            
            InitializeComponent();
            String texto = txtLoginUsuario.Text;
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "AJUDA + SOCIAL ADMINISTRATIVO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close();
            return;

        }

        private void btnConectarUsuario_Click(object sender, EventArgs e)
        {
            if (txtLoginUsuario.Text != "" && txtSenhaUsuario.Text != "")
            {

                this.Hide();
                //Ppegar o valor do textBox
                string valor = txtLoginUsuario.Text;

                //Aqui chamar o outro form passando o valor como parâmetro
                FrmPrincipal form = new FrmPrincipal(valor);
                form.ShowDialog();

            }
            else
            {
                MessageBox.Show("Login ou senha incorreta.", "AJUDA + SOCIAL ADMINISTRATIVO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            
        }

        private void txtSenhaUsuario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtLoginUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmConectar_Load(object sender, EventArgs e)
        {
            
        }
    }
    


}
