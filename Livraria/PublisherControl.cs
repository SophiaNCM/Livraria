using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria
{
    public partial class PublisherControl : UserControl
    {
        public PublisherControl()
        {
            InitializeComponent();
        }
        //Conexao com database
        SqlConnection cn = new SqlConnection(@"Data Source=COMPUTADOR-SOPH;integrated security=SSPI;initial Catalog=db_livraria");

        //o sqlCommand faz com que seja possivel escrever comandos sql por aqui
        SqlCommand cm = new SqlCommand();

        //meio que vai montar uma tabela aqui 
        //SqlDataReader dt;

        private void desabilitaCampos()
        {
            PublisherInput.BackColor = Color.Silver;
            PublisherInput.Enabled = false;

            btnChange.Enabled = false;
            btnChange.BackColor = Color.Maroon;
            btnSave.Enabled = false;
            btnSave.BackColor = Color.Maroon;
            btnRemove.Enabled = false;
            btnRemove.BackColor = Color.Maroon;

        }
        private void habilitarCampos()
        {
            PublisherInput.BackColor = Color.White;
            PublisherInput.Enabled = true;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnSave.BackColor = Color.DarkRed;
            habilitarCampos();
        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (PublisherInput.Text == "")
            {
                MessageBox.Show("É preciso colocar o nome da editora", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    string publisher = PublisherInput.Text;

                    cm.CommandText = "INSERT INTO tbl_Publisher(nm_Publisher) VALUES(@publisher)";
                    cm.Connection = cn;
                    cm.Parameters.Add("@publisher", SqlDbType.VarChar).Value = publisher;
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cm.Connection = cn;
                    cm.Parameters.Clear();
                    MessageBox.Show("Dados adicionados com sucesso", "Feito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desabilitaCampos();

        }

        private void SearchInput_TextChanged(object sender, EventArgs e)
        {
            if (SearchInput.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "SELECT cd_publisher AS codigo, nm_Publisher AS Editora FROM tbl_Publisher WHERE nm_Publisher like ('" + SearchInput.Text+"%')";
                    cm.Connection = cn;

                    SqlDataAdapter da = new SqlDataAdapter();

                    DataTable dt = new DataTable();
                    da.SelectCommand = cm;
                    da.Fill(dt);
                    dataView.DataSource = dt;
                    cn.Close();

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

            }
            else
            {
                dataView.DataSource = null;
            }
        }

        private void dataView_DoubleClick(object sender, EventArgs e)
        {
            IdOutput.Text = dataView.SelectedRows[0].Cells[0].Value.ToString();
            PublisherInput.Text = dataView.SelectedRows[0].Cells[1].Value.ToString();
            btnRemove.Enabled = true;
            btnRemove.BackColor = Color.DarkRed;
            btnChange.BackColor = Color.DarkRed;
            btnChange.Enabled = true;
            btnNew.BackColor = Color.Maroon;
            btnNew.Enabled = false;
            btnCancel.Enabled = true;
        
            PublisherInput.Enabled = true;
            PublisherInput.BackColor = Color.White;
        }
    }
}
