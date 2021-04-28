using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Aplicação
{
    public partial class frmCursos : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=192.168.15.11;port=3306;username=andro;password=andro");
        string modalidade;

        public frmCursos()
        {
            InitializeComponent();
        }


        private void frmCursos_Load(object sender, EventArgs e)
        {
   
        }


        private void vOLTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dATA_DO_CURSOLabel_Click(object sender, EventArgs e)
        {

        }

        private void tELEFONELabel_Click_1(object sender, EventArgs e)
        {

        }

        private void gravar_Click(object sender, EventArgs e)
        {
          
            if (!ckPresencial.Checked && !ckEad.Checked)
            {
                MessageBox.Show("Verifique os campos obrigatórios (*)", "AJUDA + SOCIAL ADMINISTRATIVO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(txtNomeCurso.Text))
            {
                MessageBox.Show("Verifique os campos obrigatórios (*)", "AJUDA + SOCIAL ADMINISTRATIVO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(Data.Text))
            {
                MessageBox.Show("Verifique os campos obrigatórios (*)", "AJUDA + SOCIAL ADMINISTRATIVO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(txtInfo.Text))
            {
                MessageBox.Show("Verifique os campos obrigatórios (*)", "AJUDA + SOCIAL ADMINISTRATIVO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(mEMBROSComboBox.Text))
            {
                MessageBox.Show("Verifique os campos obrigatórios (*)", "AJUDA + SOCIAL ADMINISTRATIVO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Define o titulo
            saveFileDialog1.Title = "Salvar Arquivo";
            //Define as extensões permitidas
            saveFileDialog1.Filter = "Text File|.doc";
            //define o indice do filtro
            saveFileDialog1.FilterIndex = 0;
            //Atribui um valor vazio ao nome do arquivo
            saveFileDialog1.FileName = "Membro_" + mEMBROSComboBox.Text + "_Data" + DateTime.Now.ToString("_dd-MM-yyyy_HHmmss");
            //Define a extensão padrão 
            saveFileDialog1.DefaultExt = ".doc";
            //define o diretório padrão
            saveFileDialog1.InitialDirectory = @"c:\dados";
            //restauro o diretorio atual antes de fechar a janela
            saveFileDialog1.RestoreDirectory = true;
            //exibe um aviso se o usuário informar um arquivo que não existe
            //saveFileDialog1.CheckFileExists = true;
            //exibe um aviso se o usuário informar um caminho que não existe
            saveFileDialog1.CheckPathExists = true;


            //Open the dialog and determine which button was pressed
            var resultado = saveFileDialog1.ShowDialog();

            //Se o ousuário pressionar o botão Salvar
            if (resultado == DialogResult.OK)
            {
                //Insere os dados no Banco de Dados
                try
                {
                    
                    if (ckPresencial.Checked)
                    {
                        modalidade = "PRESENCIAL";
                    }

                    if (ckEad.Checked)
                    {
                        modalidade = "EAD";
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter("INSERT INTO ajudasocial.oportunidades (cpf, tipo, nome, data, horario, descricao, telefone, email, modalidade) VALUES ('" + mEMBROSComboBox.Text + "', 'CURSO', '" + txtNomeCurso.Text + "', '" + Data.Text + "', '" + mskHora.Text + "', '" + txtInfo.Text + "', '" + mskTel.Text + "', '" + txtEmail.Text + "', '" + modalidade + "');", connection);
                    connection.Open();
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "oportunidades");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //Cria um stream usando o nome do arquivo
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);

                //Cria um escrito que irá escrever no stream
                StreamWriter writer = new StreamWriter(fs);
                //escreve o conteúdo da caixa de texto no stream
                writer.WriteLine("\nCurso: " + txtNomeCurso.Text);
                if (ckPresencial.Checked)
                {
                    writer.WriteLine("\nModalidade: " + ckPresencial.Text);
                }
                if (ckEad.Checked)
                {
                    writer.WriteLine("\nModalidade: " + ckEad.Text);
                }
                writer.WriteLine("\nData: " + Data.Text); 
                writer.WriteLine("\nHorário: " + mskHora.Text);
                writer.WriteLine("\nDescrição: " + txtInfo.Text);
                writer.WriteLine("\nTel.: " + mskTel.Text);
                writer.WriteLine("\nE-mail: " + txtEmail.Text);
                writer.WriteLine("\nMembro: " + mEMBROSComboBox.Text);
                writer.WriteLine("\n-------------------------------------------------------------------------------");
                writer.WriteLine("Ajuda + Social");
                //fecha o escrito e o stream
                writer.Close();

            }
            else
            {
                //exibe mensagem informando que a operação foi cancelada
                MessageBox.Show("Operação cancelada", "AJUDA + SOCIAL ADMINISTRATIVO");
            }

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja criar um novo curso? Todos os campos serão apagados.", "AJUDA + SOCIAL ADMINISTRATIVO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtNomeCurso.Clear();
                mskHora.Clear();
                txtInfo.Clear();
                mskTel.Clear();
                txtEmail.Clear();
                ckPresencial.Checked = false;
                ckEad.Checked = false;

                lblModalidade.Text = "";

                lblCurso.Text = "";

                lblDataC.Text = "";

                lblHoraC.Text = "";

                lblInfoC.Text = "";

                lblTelC.Text = "";

                lblEmailC.Text = "";

                mEMBROSComboBox.Text = "";

            }
        }


        private void remove_Click(object sender, EventArgs e)
        {
            
            txtNomeCurso.Clear();
            mskHora.Clear();
            txtInfo.Clear();
            mskTel.Clear();
            txtEmail.Clear();
            ckPresencial.Checked = false;
            ckEad.Checked = false;
            mEMBROSComboBox.Text = "";

        }

        private void ver_Click(object sender, EventArgs e)
        {

            //modalidade presencial
            if (ckPresencial.Checked)
            {
                string modalidade = ckPresencial.Text;
                lblModalidade.Text = modalidade;
            }


            //modalidade EAD
            if (ckEad.Checked)
            {
                string modalidade = ckEad.Text;
                lblModalidade.Text = modalidade;
            }

            //nome do curso
            if (txtNomeCurso.Text != "")
            {
                string vaga = txtNomeCurso.Text;
                lblCurso.Text = vaga;
            }
            else
            {
                lblCurso.Text = "";
            }

            //data
            if (Data.Text != "")
            {
                string data = Data.Text;
                lblDataC.Text = data;
            }
            else
            {
                lblDataC.Text = "";
            }

            //horario
            if (mskHora.Text != "")
            {
                string hora = mskHora.Text;
                lblHoraC.Text = hora;
            }
            else
            {
                lblHoraC.Text = "";
            }

            //descriçao
            if (txtInfo.Text != "")
            {
                string info = txtInfo.Text;
                lblInfoC.Text = info;
                lblInfoC.MaximumSize = new Size(380, 500);
                lblInfoC.AutoSize = true;
                
            }
            else
            {
                lblInfoC.Text = "";
            }

            //telefone
            if (mskTel.Text != "")
            {
                string tel = mskTel.Text;
                lblTelC.Text = tel;
            }
            else
            {
                lblTelC.Text = "";
            }

            //e-mail
            if (txtEmail.Text != "")
            {
                string email = txtEmail.Text;
                lblEmailC.Text = email;
            }
            else
            {
                lblEmailC.Text = "";
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ckPresencial_CheckedChanged(object sender, EventArgs e)
        {
            if (ckPresencial.Checked)
            {
                ckEad.Checked = false;
            }
        }

        private void ckEad_CheckedChanged(object sender, EventArgs e)
        {
            if (ckEad.Checked)
            {
                ckPresencial.Checked = false;
            }
        }

        private void grpCurso_Enter(object sender, EventArgs e)
        {

        }

        private void txtInfo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
