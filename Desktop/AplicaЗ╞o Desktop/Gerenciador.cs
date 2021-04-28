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
    public partial class frmGerenciador : Form
    {
        public frmGerenciador()
        {
            InitializeComponent();
            
        }

        private void trabalhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //chamar outra tela
            frmEmpregos Novo_Forms = new frmEmpregos();
            Novo_Forms.ShowDialog();
        }

        private void vOLTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //chamar outra tela
            frmCursos Novo_Forms = new frmCursos();
            Novo_Forms.ShowDialog();
        }

        private void projetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //chamar outra tela
            frmProjetos Novo_Forms = new frmProjetos();
            Novo_Forms.ShowDialog();
        }

        private void oficinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //chamar outra tela
            frmOficinas Novo_Forms = new frmOficinas();
            Novo_Forms.ShowDialog();
        }

        private void membrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //chamar outra tela
            frmMembros Novo_Forms = new frmMembros();
            Novo_Forms.ShowDialog();
        }

        private void pessoaFísicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //chamar outra tela

        }

        private void pessoaJurídicaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmGerenciador_Load(object sender, EventArgs e)
        {

        }

        private void cONSULTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //chamar outra tela
            frmConsulta Novo_Forms = new frmConsulta();
            Novo_Forms.ShowDialog();
        }

        private void voluntariadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //chamar outra tela
            frmVoluntarios Novo_Forms = new frmVoluntarios();
            Novo_Forms.ShowDialog();
        }
    }
}
