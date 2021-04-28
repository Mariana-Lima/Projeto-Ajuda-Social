using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Aplicação
{
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private string arquivo;
        private string mensagem;

        private void pesquisa_Click(object sender, EventArgs e)
        {
            List<string> mensagemLinha = new List<string>();
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Abrir Arquivo";
                openFileDialog.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    arquivo = openFileDialog.FileName;
            }
            if (String.IsNullOrEmpty(arquivo))
            {
                MessageBox.Show("Operação cancelada", "AJUDA + SOCIAL ADMINISTRATIVO");
            }
            else
            {
                using (StreamReader texto = new StreamReader(arquivo))
                {
                    while ((mensagem = texto.ReadToEnd()) != null)
                    {
                        txtTexto.Text = mensagem;

                        if ((mensagem = texto.ReadToEnd()).Equals(""))
                        {
                            break;
                        }
                    }
                }

            }
        }
    

        private void gravar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTexto.Text))
            {
                MessageBox.Show("Informe algo na caixa de texto", "AJUDA + SOCIAL ADMINISTRATIVO");
                return;
            }

            //Define o titulo
            saveFileDialog1.Title = "Salvar Arquivo";
            //Define as extensões permitidas
            saveFileDialog1.Filter = "Text File|.doc";
            //define o indice do filtro
            saveFileDialog1.FilterIndex = 0;
            //Atribui um valor vazio ao nome do arquivo
            saveFileDialog1.FileName = "Arquivo_Alterado_" + DateTime.Now.ToString("Data_ddMMyyyy_HHmmss");
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
                //Cria um stream usando o nome do arquivo
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);

                //Cria um escrito que irá escrever no stream
                StreamWriter writer = new StreamWriter(fs);
                //escreve o conteúdo da caixa de texto no stream
                writer.WriteLine("\nAlterado\n " + txtTexto.Text);

                //fecha o escrito e o stream
                writer.Close();

            }
            else
            {
                //exibe mensagem informando que a operação foi cancelada
                MessageBox.Show("Operação cancelada", "AJUDA + SOCIAL ADMINISTRATIVO");
            }

        }

        private void remover_Click(object sender, EventArgs e)
        {
            txtTexto.Clear();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
