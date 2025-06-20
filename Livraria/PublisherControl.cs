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
            SearchInput.Enabled = false;
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
            btnNew.Enabled = true;
            btnNew.BackColor = Color.DarkRed;
            IdOutput.Text = "";
            PublisherInput.Text = "";

        }

        private void SearchInput_TextChanged(object sender, EventArgs e)
        {
            if (SearchInput.Text != "")
            {
                try { 
                    if (btn_Publisher.BackColor == Color.Maroon) 
                    {
                       
                        cn.Open();
                        cm.CommandText = "SELECT cd_Publisher AS codigo, nm_Publisher AS Editora FROM tbl_Publisher WHERE nm_Publisher like ('" + SearchInput.Text + "%');";
                        cm.Connection = cn;

                        SqlDataAdapter da = new SqlDataAdapter();

                        DataTable dt = new DataTable();
                        da.SelectCommand = cm;
                        da.Fill(dt);
                        dataView.DataSource = dt;
                        cn.Close();
                    }
                    if (btn_PublisherBooks.BackColor == Color.Maroon)
                    {
                       
                        cn.Open();
                        cm.CommandText = "SELECT tbl_Publisher.cd_Publisher AS codigo, tbl_Publisher.nm_Publisher AS Editora, COUNT(tbl_Book.nm_Book) Total_de_livros FROM tbl_Publisher INNER JOIN tbl_Book ON tbl_Book.cd_Publisher = tbl_Publisher.cd_publisher WHERE nm_Publisher like ('" + SearchInput.Text + "%') GROUP BY tbl_Publisher.cd_publisher,tbl_Publisher.nm_Publisher;";
                        cm.Connection = cn;

                        SqlDataAdapter da = new SqlDataAdapter();

                        DataTable dt = new DataTable();
                        da.SelectCommand = cm;
                        da.Fill(dt);
                        dataGridBook.DataSource = dt;
                        cn.Close();
                    }

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
            MessageBox.Show("Você poderar excluir e alterar as editoras dessas tabelas", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            IdOutput.Text = dataView.SelectedRows[0].Cells[0].Value.ToString();
            PublisherInput.Text = dataView.SelectedRows[0].Cells[1].Value.ToString();
            btnRemove.Enabled = true;
            btnRemove.BackColor = Color.DarkRed;
            btnChange.BackColor = Color.DarkRed;
            btnChange.Enabled = true;
            btnNew.BackColor = Color.Maroon;
            btnNew.Enabled = false;
            btnCancel.Enabled = true;
            btnCancel.BackColor = Color.DarkRed;
        
            PublisherInput.Enabled = true;
            PublisherInput.BackColor = Color.White;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
          if (PublisherInput.Text == "" && IdOutput.Text == " ")
            {
                MessageBox.Show("É preciso selecionar uma editora", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
          else
          {
                try
                {
                    string IdPublisher = IdOutput.Text;
                    string Publisher = PublisherInput.Text;
                    cm.CommandText = "UPDATE tbl_Publisher SET nm_Publisher = @Publisher  WHERE cd_publisher = @IdPublisher;";
                    cm.Connection = cn;
                    cm.Parameters.Add("@Publisher", SqlDbType.VarChar).Value = Publisher;
                    cm.Parameters.Add("@IdPublisher", SqlDbType.Int).Value = IdPublisher;
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cm.Connection = cn;
                    cm.Parameters.Clear();
                    MessageBox.Show("Dados alterados", "Feito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    IdOutput.Text = "";
                    PublisherInput.Clear();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                }
          }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            if (PublisherInput.Text == "" && IdOutput.Text == " ")
            {
                MessageBox.Show("É preciso selecionar uma editora", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
               
                try
                {
                    string IdPublisher = IdOutput.Text;
                    string Publisher = PublisherInput.Text;
                    cm.CommandText = "DELETE FROM tbl_Book WHERE cd_Publisher = @IdPublisher; DELETE FROM tbl_Publisher WHERE cd_publisher = @IdPublisher;";
                    cm.Connection = cn;
                    cm.Parameters.Add("@Publisher", SqlDbType.VarChar).Value = Publisher;
                    cm.Parameters.Add("@IdPublisher", SqlDbType.Int).Value = IdPublisher;
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cm.Connection = cn;
                    cm.Parameters.Clear();
                    MessageBox.Show("Dados foram removidos", "Feito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    IdOutput.Text = "";
                    PublisherInput.Clear();
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

        private void btn_Publisher_Click(object sender, EventArgs e)
        {
            SearchInput.Enabled = true;
            dataView.Enabled = true;
            dataView.Visible = true;
            btn_Publisher.BackColor = Color.Maroon;
            btn_PublisherBooks.BackColor = Color.Firebrick;
            dataGridBook.Enabled = false;
            dataGridBook.Visible = false;
        }

        private void dataGridBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_PublisherBooks_Click(object sender, EventArgs e)
        {
            SearchInput.Enabled = true;
            dataGridBook.Enabled = true;
            dataGridBook.Visible = true;
            dataView.Enabled = false;
            dataView.Visible = false;
            btn_PublisherBooks.BackColor = Color.Maroon;
            btn_Publisher.BackColor = Color.Firebrick;
        }

        private void dataGridBook_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Você só poderá alterar as editoras visivel aqui", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            IdOutput.Text = dataGridBook.SelectedRows[0].Cells[0].Value.ToString();
            PublisherInput.Text = dataGridBook.SelectedRows[0].Cells[1].Value.ToString();
            btnRemove.Enabled = false;
            btnRemove.BackColor = Color.Maroon;
            btnChange.BackColor = Color.DarkRed;
            btnChange.Enabled = true;
            btnNew.BackColor = Color.Maroon;
            btnNew.Enabled = false;
            btnCancel.Enabled = true;
            btnCancel.BackColor = Color.DarkRed;

            PublisherInput.Enabled = true;
            PublisherInput.BackColor = Color.White;
        }
    }
}
