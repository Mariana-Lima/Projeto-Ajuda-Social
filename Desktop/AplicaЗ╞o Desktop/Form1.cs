using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicação
{
    public partial class FrmPrincipal : Form
    {

        
        public FrmPrincipal() 
        {
            InitializeComponent();
        }

        public FrmPrincipal(string texto)
        {
            InitializeComponent();
            lblUser.Text = texto; //O label está recebendo o valor que foi recebido por parâmetro

        }


        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            //chamar outra tela
            frmSobre Novo_Form = new frmSobre();
            Novo_Form.ShowDialog();
        }

        private void btnConta_Click(object sender, EventArgs e)
        {
            //Ppegar o valor do textBox
            string valor = lblUser.Text;

            //Aqui chamar o outro form passando o valor como parâmetro
            frmConta form = new frmConta(valor);
            form.ShowDialog();
        }


        private void btnGerenciar_Click(object sender, EventArgs e)
        {
            
            //chamar outra tela
            frmGerenciador Novo_Form = new frmGerenciador();
            Novo_Form.ShowDialog();        

        }


        private void btnPasso_Click(object sender, EventArgs e)
        {
            //chamar outra tela
            frmManual Novo_Form = new frmManual();
            Novo_Form.ShowDialog();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
           if ( MessageBox.Show("Deseja sair?", "AJUDA + SOCIAL ADMINISTRATIVO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Application.Exit(); 
            return;
            
        }
    }
}
