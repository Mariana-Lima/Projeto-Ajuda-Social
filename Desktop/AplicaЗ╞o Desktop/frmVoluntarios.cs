using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aplicação
{
    public partial class frmVoluntarios : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=192.168.15.11;port=3306;username=andro;password=andro");
        public frmVoluntarios()
        {
            InitializeComponent();
        }

        private void vOLTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vOLUNTARIADOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vOLUNTARIADOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_DKSTDataSet1);

        }

        private void frmVoluntarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_DKSTDataSet1.VOLUNTARIADOS'. Você pode movê-la ou removê-la conforme necessário.
            try

            {
                //MySqlConnection connection = new MySqlConnection("datasource=192.168.15.11;port=3306;username=andro;password=andro");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM ajudasocial.voluntario", connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "voluntario");
                vOLUNTARIADOSDataGridView.DataSource = ds.Tables["voluntario"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void nomeToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.vOLUNTARIADOSTableAdapter.Nome(this.bD_DKSTDataSet1.VOLUNTARIADOS, nOMEToolStripTextBox.Text + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM ajudasocial.voluntario WHERE nome = "+"'"+ nOMEToolStripTextBox.Text +"'", connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "voluntario");
                vOLUNTARIADOSDataGridView.DataSource = ds.Tables["voluntario"];
                connection.Close();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void razãoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.vOLUNTARIADOSTableAdapter.Razão(this.bD_DKSTDataSet1.VOLUNTARIADOS, rAZAO_SOCIALToolStripTextBox.Text + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM ajudasocial.voluntario WHERE cpf = " + "'" + rAZAO_SOCIALToolStripTextBox.Text + "'", connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "voluntario");
                vOLUNTARIADOSDataGridView.DataSource = ds.Tables["voluntario"];
                connection.Close();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void vOLUNTARIADOSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nomeToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void rAZAO_SOCIALToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try

            {
                //MySqlConnection connection = new MySqlConnection("datasource=192.168.15.11;port=3306;username=andro;password=andro");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM ajudasocial.voluntario", connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "voluntario");
                vOLUNTARIADOSDataGridView.DataSource = ds.Tables["voluntario"];
                connection.Close();
                nOMEToolStripTextBox.Clear();
                rAZAO_SOCIALToolStripTextBox.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
