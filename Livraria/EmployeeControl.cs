using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria
{
    public partial class EmployeeControl : UserControl
    {
        public EmployeeControl()
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
            idLabel.Enabled = false;
            NumberLabel.Enabled = false;
            idLabel.Visible = false;
            NumberLabel.Visible = false;
            btnSave.ForeColor = Color.White;
            btnNew.Enabled = true;
            btnNew.BackColor = Color.DarkRed;

            btnOn.Enabled = false;
            btnOff.Enabled = false;
            nameText.Enabled = false;
  

            UserInput.Enabled = false;
      

            PasswordInput.Enabled = false;
     

            btnCancel.Enabled = false;
            btnCancel.BackColor = Color.Maroon;
            btnCancel.ForeColor = Color.Gray;


            btnChange.Enabled = false;
            btnChange.BackColor = Color.Maroon;


            btnRemove.Enabled = false;
            btnRemove.BackColor = Color.Maroon;
            btnRemove.ForeColor = Color.Gray;


            btnSave.Enabled = false;
            btnSave.BackColor = Color.Maroon;
            btnSave.ForeColor = Color.Gray;

        }
        private void habilitaCampos()
        {

            btnOn.Enabled = true;
            btnOff.Enabled = true;

            nameText.Enabled = true;
  

            UserInput.Enabled = true;
      

            PasswordInput.Enabled = true;
        

            btnCancel.Enabled = true;
            btnCancel.BackColor = Color.DarkRed;
            btnCancel.ForeColor = Color.White;

            btnSave.Enabled = true;
            btnSave.BackColor = Color.DarkRed;
            btnSave.ForeColor = Color.White;

            btnNew.Enabled = false;
            btnNew.BackColor = Color.Maroon;

            Search.Text = "";
            dataView.DataSource = null;

        }
        private void limparCampos()
        {
            nameText.Clear();
            UserInput.Clear();
            PasswordInput.Clear();
            SearchInput.Clear();
            dataView.DataSource = null;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            habilitaCampos();
        }

        private void btnOff_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desabilitaCampos();
            limparCampos();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (nameText.Text == "" || UserInput.Text == "" || PasswordInput.Text == "")
            {
                MessageBox.Show("Há campos não preenchidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (PasswordInput.Text.Length < 8)
            {
                MessageBox.Show("É necessário que a senha tenha oito digitos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string name = nameText.Text;
                    string password = PasswordInput.Text;
                    string login = UserInput.Text;



                    string stringsql = "insert into tbl_employee(ds_login, ds_password,nm_employee) values(@login,@password,@name)";

                    cm.CommandText = stringsql;
                    cm.Connection = cn;
                    cm.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                    cm.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
                    cm.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();
                    MessageBox.Show("Dados adicionados com sucesso", "Feito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void SearchInput_TextChanged(object sender, EventArgs e)
        {
            if (SearchInput.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select cd_empoyee AS 'codigo', ds_login AS 'Login', ds_password AS 'Senha', nm_employee AS 'Nome', ds_status AS 'Status' from tbl_employee where nm_employee like ('" + SearchInput.Text + "%')";
                    cm.Connection = cn;

                    //receber os dados de uma tabela após a execução de um select
                    SqlDataAdapter da = new SqlDataAdapter();

                    //objeto DataTalbe pode representar uma ou mais tabelas de dados, as quais permanecem alocadas em memória
                    DataTable dt = new DataTable();

                    //recebendo dados da instrução
                    da.SelectCommand = cm;
                    da.Fill(dt);//preenchendo o datatable


                    //esse é o visualizador
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

        private void ChangeData()
        {
            btnChange.Enabled = true;
            btnChange.BackColor = Color.DarkRed;
            btnChange.ForeColor = Color.White;

            btnRemove.Enabled = true;
            btnRemove.BackColor = Color.DarkRed;
            btnRemove.ForeColor = Color.White;

            btnCancel.Enabled = true;
            btnCancel.BackColor = Color.DarkRed;
            btnCancel.ForeColor = Color.White;

            btnNew.Enabled = false;
            btnNew.BackColor = Color.Maroon;

            btnSave.Enabled = false;
            btnSave.BackColor = Color.Maroon;

            nameText.Enabled = true;
      

            UserInput.Enabled = true;
    

            PasswordInput.Enabled = true;


            idLabel.Enabled = true;
            NumberLabel.Enabled = true;
            idLabel.Visible = true;
            NumberLabel.Visible = true;
        }
        private void getEmployee()
        {
            NumberLabel.Text = dataView.SelectedRows[0].Cells[0].Value.ToString();
            UserInput.Text = dataView.SelectedRows[0].Cells[1].Value.ToString();
            PasswordInput.Text = dataView.SelectedRows[0].Cells[2].Value.ToString();
            nameText.Text = dataView.SelectedRows[0].Cells[3].Value.ToString();
            string valor = dataView.SelectedRows[0].Cells[4].Value.ToString();
            if (valor == "True")
            {
                btnOn.Checked = true;
            }
            else
            {
                btnOff.Checked = true;
            }
            ChangeData();


        }

        private void dataView_DoubleClick(object sender, EventArgs e)
        {
            getEmployee();
            if (btnOff.Checked)
            {
                btnRemove.Enabled = true;
            }
            else
            {
                btnRemove.Enabled = false;
                btnRemove.BackColor = Color.Maroon;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            
            if (NameInput.Text == "" || User.Text == "" || PasswordInput.Text == "" || NumberLabel.Text == "")
            {
                MessageBox.Show("Há campos não preenchidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (PasswordInput.Text.Length < 8)
            {
                MessageBox.Show("É necessário que a senha tenha oito digitos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(NumberLabel.Text);
                    string name = nameText.Text;
                    string password = PasswordInput.Text;
                    string login = UserInput.Text;
                    int status = 0;
                    if (btnOn.Checked)
                    {
                        status = 1;
                    }
                    else
                    {
                        status = 0;
                    }





                    string stringsql = "update tbl_employee set ds_login = @login, ds_password= @password, nm_employee=@name, ds_status =@status where cd_empoyee = @id";

                    cm.CommandText = stringsql;
                    cm.Connection = cn;
                    cm.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                    cm.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
                    cm.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                    cm.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cm.Parameters.Add("@status", SqlDbType.Bit).Value = status;
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (nameText.Text == "" || User.Text == "" || PasswordInput.Text == "" || NumberLabel.Text == "")
            {
                MessageBox.Show("Há campos não preenchidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (PasswordInput.Text.Length < 8)
            {
                MessageBox.Show("É necessário que a senha tenha oito digitos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(NumberLabel.Text);

                    if (btnOff.Checked)
                    {
                        string stringsql = "delete from tbl_employee where cd_empoyee = @id";
                        cm.CommandText = stringsql;
                        cm.Connection = cn;
                        cm.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        cn.Open();
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Dados foram removidos", "Feito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limparCampos();
                        cm.Parameters.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Não é possivel apagar um funcionario ativos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cm.Parameters.Clear();
                    }
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

        private void nameText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
