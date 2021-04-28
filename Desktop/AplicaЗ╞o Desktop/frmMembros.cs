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
    public partial class frmMembros : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=192.168.15.11;port=3306;username=andro;password=andro");


        public frmMembros()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmMembros_Load(object sender, EventArgs e)
        {
            try

            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM ajudasocial.trabalhador", connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "trabalhador");
                mEMBROSDataGridView.DataSource = ds.Tables["trabalhador"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void nomeToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM ajudasocial.trabalhador WHERE nome = " + "'" + nOMEToolStripTextBox1.Text + "'", connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "trabalhador");
                mEMBROSDataGridView.DataSource = ds.Tables["trabalhador"];
                connection.Close();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void mEMBROSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try

            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM ajudasocial.trabalhador", connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "trabalhador");
                mEMBROSDataGridView.DataSource = ds.Tables["trabalhador"];
                connection.Close();
                nOMEToolStripTextBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
