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
    public partial class PhoneControl : UserControl
    {
        public PhoneControl()
        {
            InitializeComponent();
        }

        //Conexao com database
        SqlConnection cn = new SqlConnection(@"Data Source=COMPUTADOR-SOPH;integrated security=SSPI;initial Catalog=db_livraria");

        //o sqlCommand faz com que seja possivel escrever comandos sql por aqui
        SqlCommand cm = new SqlCommand();

        //meio que vai montar uma tabela aqui 
        SqlDataReader dt;

        private void limparCampos()
        {
            IdOutput.Text = "";
            ClientOutput.Text = "";
            mskPhone.Text = "";
            SearchInput.Text = "";
        }
        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }
        private void getPhone()
        {
            NameClient.Visible = true;
            ClientID.Visible = true;
            IdOutput.Text = dataView.SelectedRows[0].Cells[0].Value.ToString();
            ClientOutput.Text = dataView.SelectedRows[0].Cells[1].Value.ToString();
            if (btnNew.Enabled == false) {
                mskPhone.Text = dataView.SelectedRows[0].Cells[2].Value.ToString();
            }
            else 
            {
                mskPhone.Text = "";
            }
        }

                private void SearchInput_TextChanged(object sender, EventArgs e)
                {
                    if (SearchInput.Text != "")
                    {
                        try
                        {
                            cn.Open();
                            cm.CommandText = "SELECT * FROM ViewPhone WHERE nm_Client lIKE ('" + SearchInput.Text + "%')";
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
            getPhone();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            
            if (IdOutput.Text == "" || ClientOutput.Text == "" || mskPhone.Text == "")
            {
                MessageBox.Show("Não esqueça de escrever o numero ou clicar em um cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(IdOutput.Text);
                    string phone = mskPhone.Text;
                    phone = phone.Replace("-", "");
                    phone = phone.Replace("(", "");
                    phone = phone.Replace(")", "");


                    string sqlAdd = "INSERT INTO tbl_phone(cd_Client, no_Phone) VALUES(@id,@phone)";
                    cm.CommandText = sqlAdd;
                    cm.Connection = cn;

                    cm.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cm.Parameters.Add("@phone", SqlDbType.Char).Value = phone;
                    cn.Open();
                    cm.ExecuteNonQuery();


                    cm.Parameters.Clear();
                    MessageBox.Show("Dados Adicionados", "Feito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    limparCampos();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                finally
                {
                    cn.Close();
                }
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            btnNew.Visible = true;
           
            btnChange.Enabled = false;
            btnChange.BackColor = Color.Maroon;
            btnRemove.Enabled = false;
            btnRemove.BackColor = Color.Maroon;
            mskPhone.Text = "";

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = false;
            btnNew.Visible = false;
            btnChange.Enabled = true;
            btnRemove.Enabled = true;
            mskPhone.Text = "";
            ClientOutput.Text = "";
            IdOutput.Text = "";
            SearchInput.Text = "";


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(mskPhone.Text == ""|| IdOutput.Text == "")
            {
                MessageBox.Show("Digite o numero que será removido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string phone = mskPhone.Text;
                    phone = phone.Replace("-", "");
                    phone = phone.Replace("(", "");
                    phone = phone.Replace(")", "");
                    int id = Convert.ToInt32(IdOutput.Text);
                    string removesql = "DELETE FROM tbl_phone where no_Phone =@phone ";
                    cm.CommandText = removesql;
                    cm.Connection = cn;
                    cm.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cm.Parameters.Add("@phone", SqlDbType.Char).Value = phone;
                    cn.Open();
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Dados foram removidos", "Feito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    limparCampos();
                    cm.Parameters.Clear();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);

                }
                finally
                {
                    cn.Close();
                }
            }

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (mskPhone.Text != "" && IdOutput.Text != "")
            {
                try 
                {
                    string phone = mskPhone.Text;
                    phone = phone.Replace("-", "");
                    phone = phone.Replace("(", "");
                    phone = phone.Replace(")", "");
                    int id = Convert.ToInt32(IdOutput.Text);
                    string alterSql = "update tbl_phone set no_phone = @phone where cd_Client = @id";
                    cm.CommandText = alterSql;
                    cm.Connection = cn;
                    cm.Parameters.Add("@phone", SqlDbType.Char).Value = phone;
                    cm.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();
                    MessageBox.Show("Dados alterados", "Feito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    limparCampos();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                finally
                {
                    cn.Close();
                }

            }
        
        }
    }
}
