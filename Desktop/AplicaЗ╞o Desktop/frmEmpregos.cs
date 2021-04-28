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
    public partial class frmEmpregos : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=192.168.15.11;port=3306;username=andro;password=andro");
        public frmEmpregos()
        {
            InitializeComponent();
        }

        private void eMPREGOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(nOME_DA_VAGATextBox.Text))
            {
                MessageBox.Show("Verifique os campos obrigatórios (*)", "AJUDA + SOCIAL ADMINISTRATIVO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(dATA_DA_VAGADateTimePicker.Text))
            {
                MessageBox.Show("Verifique os campos obrigatórios (*)", "AJUDA + SOCIAL ADMINISTRATIVO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(iNFO_DA_VAGARichTextBox.Text))
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
            saveFileDialog1.FileName = "Membro_" + mEMBROSComboBox.Text + "_Data" + DateTime.Now.ToString("_dd-MM-yyyy_HHmmss"); ;
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
                    MySqlDataAdapter adapter = new MySqlDataAdapter("INSERT INTO ajudasocial.oportunidades (cpf, tipo, nome, data, horario, descricao, telefone, email) VALUES ('" + mEMBROSComboBox.Text + "', 'EMPREGO', '" + nOME_DA_VAGATextBox.Text + "', '" + dATA_DA_VAGADateTimePicker.Text + "', '" + hORARIO_DA_VAGAMaskedTextBox.Text + "', '" + iNFO_DA_VAGARichTextBox.Text + "', '" + tELEFONEMaskedTextBox.Text + "', '" + eMAILTextBox.Text + "');", connection);
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
                writer.WriteLine("\nVaga: " + nOME_DA_VAGATextBox.Text);
                writer.WriteLine("\nData: " + dATA_DA_VAGADateTimePicker.Text);
                writer.WriteLine("\nHorário: " + hORARIO_DA_VAGAMaskedTextBox.Text);
                writer.WriteLine("\nDescrição: " + iNFO_DA_VAGARichTextBox.Text);
                writer.WriteLine("\nTel.: " + tELEFONEMaskedTextBox.Text);
                writer.WriteLine("\nE-mail: " + eMAILTextBox.Text);
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

        private void frmEmprego_Load(object sender, EventArgs e)
        {

        }

        private void iNFO_DA_VAGARichTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void grpVaga_Enter(object sender, EventArgs e)
        {

        }


        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
        private void add_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Deseja criar uma nova vaga? Todos os campos serão apagados.", "AJUDA + SOCIAL ADMINISTRATIVO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                nOME_DA_VAGATextBox.Clear();
                hORARIO_DA_VAGAMaskedTextBox.Clear();
                iNFO_DA_VAGARichTextBox.Clear();
                tELEFONEMaskedTextBox.Clear();
                eMAILTextBox.Clear();
                mEMBROSComboBox.Text = "";

            }     

        }

        private void remove_Click(object sender, EventArgs e)
        {
            nOME_DA_VAGATextBox.Clear();
            hORARIO_DA_VAGAMaskedTextBox.Clear();
            iNFO_DA_VAGARichTextBox.Clear();
            tELEFONEMaskedTextBox.Clear();
            eMAILTextBox.Clear();

            lblGerar.Text = "";

            lblData.Text = "";

            lblHora.Text = "";

            lblInfo.Text = "";

            lblTel.Text = "";

            lblEmail.Text = "";

            mEMBROSComboBox.Text = "";
        }

        private void ver_Click(object sender, EventArgs e)
        {
            //nome da vaga
            if (nOME_DA_VAGATextBox.Text != "")
            {
                string vaga = nOME_DA_VAGATextBox.Text;
                lblGerar.Text = vaga;
            }
            else
            {
                lblGerar.Text = "";
            }

            //data
            if (dATA_DA_VAGADateTimePicker.Text != "")
            {
                string data = dATA_DA_VAGADateTimePicker.Text;
                lblData.Text = data;
            }
            else
            {
                lblData.Text = "";
            }

            //horario
            if (hORARIO_DA_VAGAMaskedTextBox.Text != "")
            {
                string hora = hORARIO_DA_VAGAMaskedTextBox.Text;
                lblHora.Text = hora;
            }
            else
            {
                lblHora.Text = "";
            }

            //descriçao
            if (iNFO_DA_VAGARichTextBox.Text != "")
            {
                string info = iNFO_DA_VAGARichTextBox.Text;
                lblInfo.Text = info;
                lblInfo.MaximumSize = new Size(380, 500);
                lblInfo.AutoSize = true;
            }
            else
            {
                lblInfo.Text = "";
            }

            //telefone
            if (tELEFONEMaskedTextBox.Text != "")
            {
                string tel = tELEFONEMaskedTextBox.Text;
                lblTel.Text = tel;
            }
            else
            {
                lblTel.Text = "";
            }

            //e-mail
            if (eMAILTextBox.Text != "")
            {
                string email = eMAILTextBox.Text;
                lblEmail.Text = email;
            }
            else
            {
                lblEmail.Text = "";
            }
        }
    }
}
