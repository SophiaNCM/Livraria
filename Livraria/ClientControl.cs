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
    public partial class ClientControl : UserControl
    {
        public ClientControl()
        {
            InitializeComponent();
        }
        //Conexao com database
        SqlConnection cn = new SqlConnection(@"Data Source=COMPUTADOR-SOPH;integrated security=SSPI;initial Catalog=db_livraria");

        //o sqlCommand faz com que seja possivel escrever comandos sql por aqui
        SqlCommand cm = new SqlCommand();

        //meio que vai montar uma tabela aqui 
        SqlDataReader dt;

        private void desabilitaCampos()
        {

            btnSave.ForeColor = Color.White;
            btnNew.Enabled = true;
            btnNew.BackColor = Color.DarkRed;

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
            
            //Inputs
            nameText.Enabled = false;
            emailInput.Enabled = false;
            mskPhone.Enabled = false;
            peopleOption.Enabled = false;
            mskCPF.Enabled = false;
            mskCNPJ.Enabled = false; 
            mskCPF.Enabled = false;
            logradouroInput.Enabled = false;
            numberInput.Enabled = false;
            ComplementoInput.Enabled = false;
            BairroInput.Enabled = false;
            CityInput.Enabled = false;
            statesOption.Enabled = false;
            btnOn.Enabled = false;
            btnOff.Enabled = false;
            mskPhone.Enabled = false;
            mskCEP.Enabled = false;
            
            

        }
        private void habilitaCampos()
        {
            //botoes
            btnCancel.Enabled = true;
            btnCancel.BackColor = Color.DarkRed;
            btnCancel.ForeColor = Color.White;

            btnSave.Enabled = true;
            btnSave.BackColor = Color.DarkRed;
            btnSave.ForeColor = Color.White;

            btnNew.Enabled = false;
            btnNew.BackColor = Color.Maroon;

            SearchInput.Text = "";
            dataView.DataSource = null;

            //inputs
            nameText.Enabled = true;
            emailInput.Enabled = true;
            mskPhone.Enabled = true;
            peopleOption.Enabled = true;
            mskCPF.Enabled = true;
            mskCNPJ.Enabled= true;
            logradouroInput.Enabled = true;
            numberInput.Enabled = true;
            ComplementoInput.Enabled = true;
            BairroInput.Enabled = true;
            CityInput.Enabled = true;
            statesOption.Enabled = true;
            btnOn.Enabled = true;
            btnOff.Enabled = true;
            mskPhone.Enabled = true;
            mskCEP.Enabled = true;

        }
        private void limparCampos()
        {
            //inputs
            nameText.Clear();
            emailInput.Clear();
            mskPhone.Clear();
            peopleOption.SelectedIndex =-1;
            mskCPF.Clear();
            mskCNPJ.Clear();
            logradouroInput.Clear();
            numberInput.Clear();
            ComplementoInput.Clear();
            BairroInput.Clear();
            CityInput.Clear();
            mskCEP.Clear();
            statesOption.SelectedIndex = -1;
            btnOn.Checked = false;
            btnOff.Checked = false;
            labelId.Visible = false;
            idOutput.Visible = false;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            habilitaCampos();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitaCampos();
        }

        private void peopleOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (peopleOption.SelectedIndex) {
                case -1:
                    CPF.Enabled = false;
                    CPF.Visible = false;
                    mskCPF.Enabled = false;
                    mskCPF.Visible = false;

                    cnpj.Enabled = true;
                    cnpj.Visible = true;
                    mskCNPJ.Enabled = false;
                    mskCNPJ.Visible = true;


                    break;
                case 0:
                    CPF.Enabled = false;
                    CPF.Visible = false;
                    mskCPF.Enabled= false;
                    mskCPF.Visible= false;

                    cnpj.Enabled = true;
                    cnpj.Visible = true;
                    mskCNPJ.Enabled = true;
                    mskCNPJ.Visible = true;


                        break;
                case 1:
                    CPF.Enabled = true;
                    CPF.Visible = true;
                    mskCPF.Enabled = true;
                    mskCPF.Visible = true;

                    cnpj.Enabled = false;
                    cnpj.Visible = false;
                    mskCNPJ.Enabled = false;
                    mskCNPJ.Visible = false;


                    break;
            }
        }

        private void mskCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (peopleOption.SelectedIndex == -1 || statesOption.SelectedIndex == -1)
            {
                MessageBox.Show("É necessario escolher o tipo de pessoa e o seu estado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(mskCNPJ.Text == "" || mskCPF.Text =="")
            {
                MessageBox.Show("É necessario preencher o CPF ou CNPJ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (mskCPF.TextLength < 11 || mskCNPJ.TextLength < 14) {
                MessageBox.Show("O CPF deve ter onze digitos e o CNPJ deve ter catorze digitos ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (NameInput.Text == "" || emailInput.Text == "" || mskPhone.Text == "" || logradouroInput.Text == "" || numberInput.Text == "" || ComplementoInput.Text == ""|| BairroInput.Text =="" || CityInput.Text == "" || mskCEP.Text == "")
            {
                MessageBox.Show("É necessario preencher todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(btnOn.Checked == false)
            {
                MessageBox.Show("O cliente precisa ser ativo para ser inserido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(mskCEP.TextLength < 8)
            {
                MessageBox.Show("O CEP deve ter oito digitos ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if(mskPhone.TextLength < 11)
            {
                MessageBox.Show("O telefone deve ter onze digitos ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string name = nameText.Text;
                string email = emailInput.Text;
                string phone = mskPhone.Text;
                phone = phone.Replace("-", "");
                phone = phone.Replace("(", "");
                phone = phone.Replace(")", "");

                string cpf = mskCPF.Text;
                cpf = cpf.Replace(".", "");
                cpf = cpf.Replace("-", "");

                string cnpj = mskCNPJ.Text;
                cnpj = cnpj.Replace(".", "");
                cnpj = cnpj.Replace("-", "");
                cnpj = cnpj.Replace("/", "");


                string logradouro = logradouroInput.Text;
                string number = numberInput.Text;
                string complemento = ComplementoInput.Text;
                string bairro = BairroInput.Text;
                string city = CityInput.Text;
                string cep = mskCEP.Text;
                cep = cep.Replace("-", "");
                string states = statesOption.SelectedItem.ToString();
                int status = 1;
                string typePerson = "";
                if (peopleOption.SelectedIndex == 0)
                {
                    typePerson = "J";
                }
                else
                {
                    typePerson = "F";
                }
                    try
                    {

                        string stringsql = "insert into tbl_client(nm_Client,ds_Email,no_CPF, no_CNPJ, nm_Logradouro, no_Logradouro, ds_Complemento,nm_Bairro,nm_Cidade,sg_UF,no_CEP,ds_status, type_person) values(@name,@email,@cpf,@cnpj,@logradouro,@number,@complemento,@bairro,@city,@states,@cep,@status, @typePerson) set @cd= SCOPE_IDENTITY();";
                        cm.CommandText = stringsql;
                        cm.Connection = cn;
                        cm.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                        cm.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                        cm.Parameters.Add("@cpf", SqlDbType.Char).Value = cpf;
                        cm.Parameters.Add("@cnpj", SqlDbType.Char).Value = cnpj;
                        cm.Parameters.Add("@logradouro", SqlDbType.VarChar).Value = logradouro;
                        cm.Parameters.Add("@number", SqlDbType.VarChar).Value = number;
                        cm.Parameters.Add("@complemento", SqlDbType.VarChar).Value = complemento;
                        cm.Parameters.Add("@bairro", SqlDbType.VarChar).Value = bairro;
                        cm.Parameters.Add("@city", SqlDbType.VarChar).Value = city;
                        cm.Parameters.Add("@cep", SqlDbType.Char).Value = cep;
                        cm.Parameters.Add("@states", SqlDbType.Char).Value = states;
                        cm.Parameters.Add("@status", SqlDbType.Bit).Value = status;
                        cm.Parameters.AddWithValue("@cd", 0).Direction = ParameterDirection.Output;
                        cm.Parameters.Add("@typePerson", SqlDbType.Char).Value = typePerson;

                        cn.Open();
                        cm.ExecuteNonQuery();
                        int cd = Convert.ToInt32(cm.Parameters["@cd"].Value);


                        cm.CommandText = $"insert into tbl_phone(cd_Client,no_Phone)values('" + cd + "','" + phone + "');";
                        MessageBox.Show("Dados adicionados com sucesso", "Feito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cm.Connection = cn;
                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();

                        limparCampos();
                        //MessageBox.Show($"{states} ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                    cm.CommandText = "select * from viewClientEPhone where Cliente like ('"+SearchInput.Text+"%')";
                    cm.Connection = cn;

                    SqlDataAdapter da = new SqlDataAdapter();

                    DataTable dt = new DataTable();
                    da.SelectCommand = cm;
                    da.Fill(dt);
                    dataView.DataSource = dt;
                    cn.Close();
                }
                catch (Exception error) {
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

            //inputs
            nameText.Enabled = true;
            emailInput.Enabled = true;
            logradouroInput.Enabled = true;
            numberInput.Enabled = true;
            ComplementoInput.Enabled = true;
            BairroInput.Enabled = true;
            CityInput.Enabled = true;
            statesOption.Enabled = true;
            btnOff.Enabled = true;
            btnOn.Enabled = true;
            mskCEP.Enabled = true;
            peopleOption.Enabled = true;
            mskPhone.Enabled = true;
           
        }
        private void getClient()
        {
            labelId.Visible = true;
            idOutput.Visible = true;
            idOutput.Text = dataView.SelectedRows[0].Cells[0].Value.ToString();
            nameText.Text = dataView.SelectedRows[0].Cells[1].Value.ToString();
            emailInput.Text = dataView.SelectedRows[0].Cells[2].Value.ToString();
            mskCPF.Text = dataView.SelectedRows[0].Cells[3].Value.ToString();
            mskCNPJ.Text = dataView.SelectedRows[0].Cells[4].Value.ToString();
            logradouroInput.Text = dataView.SelectedRows[0].Cells[5].Value.ToString();
            numberInput.Text = dataView.SelectedRows[0].Cells[6].Value.ToString();
            ComplementoInput.Text = dataView.SelectedRows[0].Cells[7].Value.ToString();
            BairroInput.Text = dataView.SelectedRows[0].Cells[8].Value.ToString();
            CityInput.Text = dataView.SelectedRows[0].Cells[9].Value.ToString();
            string states = dataView.SelectedRows[0].Cells[10].Value.ToString();
            if (states == "SP")
            {
                statesOption.SelectedIndex = 0;
            }
            else if (states == "RJ")
            {
                statesOption.SelectedIndex = 1;
            }
            else if (states == "MG")
            {
                statesOption.SelectedIndex = 2;
            }
            else if (states == "RS")
            {
                statesOption.SelectedIndex = 3;
            }
            mskCEP.Text= dataView.SelectedRows[0].Cells[11].Value.ToString();
           
            string ativo = dataView.SelectedRows[0].Cells[12].Value.ToString();
            if(ativo == "True")
            {
                btnOn.Checked = true;
            }
            else
            {
                btnOff.Checked = true;
            }
            string typePerson = dataView.SelectedRows[0].Cells[13].Value.ToString();
            if(typePerson == "F")
            {
                peopleOption.SelectedIndex = 1;
                mskCPF.Enabled = true;
                mskCPF.Visible = true;
                CPF.Enabled = true;
                CPF.Visible = true;
                mskCNPJ.Enabled = false;
                mskCNPJ.Visible = false;
                cnpj.Enabled = false;
                cnpj.Visible = false;
            }
            else
            {
                peopleOption.SelectedIndex = 0;
                mskCNPJ.Enabled = true;
                mskCNPJ.Visible = true;
                cnpj.Enabled = true;
                cnpj.Visible = true;
                mskCPF.Enabled = false;
                mskCPF.Visible = false;
                CPF.Enabled = false;
                CPF.Visible = false;
            }
            mskPhone.Text = dataView.SelectedRows[0].Cells[14].Value.ToString();
            ChangeData();
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (peopleOption.SelectedIndex == -1 || statesOption.SelectedIndex == -1)
            {
                MessageBox.Show("É necessario escolher o tipo de pessoa e o seu estado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (mskCNPJ.Text == "" || mskCPF.Text == "")
            {
                MessageBox.Show("É necessario preencher o CPF ou CNPJ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (mskCPF.TextLength < 11 || mskCNPJ.TextLength < 14)
            {
                MessageBox.Show("O CPF deve ter onze digitos e o CNPJ deve ter catorze digitos ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (NameInput.Text == "" || emailInput.Text == "" || mskPhone.Text == "" || logradouroInput.Text == "" || numberInput.Text == "" || ComplementoInput.Text == "" || BairroInput.Text == "" || CityInput.Text == "" || mskCEP.Text == "")
            {
                MessageBox.Show("É necessario preencher todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (mskCEP.TextLength < 8)
            {
                MessageBox.Show("O CEP deve ter oito digitos ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (mskPhone.TextLength < 11)
            {
                MessageBox.Show("O telefone deve ter onze digitos ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(idOutput.Text);
                    string name = nameText.Text;
                    string email = emailInput.Text;
                    string phone = mskPhone.Text;
                    phone = phone.Replace("-", "");
                    phone = phone.Replace("(", "");
                    phone = phone.Replace(")", "");

                    string cpf = mskCPF.Text;
                    cpf = cpf.Replace(".", "");
                    cpf = cpf.Replace("-", "");

                    string cnpj = mskCNPJ.Text;
                    cnpj = cnpj.Replace(".", "");
                    cnpj = cnpj.Replace("-", "");
                    cnpj = cnpj.Replace("/", "");


                    string logradouro = logradouroInput.Text;
                    string number = numberInput.Text;
                    string complemento = ComplementoInput.Text;
                    string bairro = BairroInput.Text;
                    string city = CityInput.Text;
                    string cep = mskCEP.Text;
                    cep = cep.Replace("-", "");
                    string states = statesOption.SelectedItem.ToString();
                    int status = 1;
                    if (btnOn.Checked) {
                        status = 1;
                    }
                    else {
                        status = 0;
                    }
                    string typePerson = "";
                    if (peopleOption.SelectedIndex == 0)
                    {
                        typePerson = "J";
                    }
                    else
                    {
                        typePerson = "F";
                    }
                    string sqlUpdate = "update tbl_Client set nm_Client = @name,ds_Email =@email,no_CPF = @cpf, no_CNPJ = @cnpj, nm_Logradouro =@logradouro, no_Logradouro = @number, ds_Complemento= @complemento,nm_Bairro = @bairro,nm_Cidade = @city,sg_UF = @states,no_CEP=@cep,ds_status = @status, type_person = @typePerson where cd_Client = @id; update tbl_phone  set no_Phone = @phone where cd_Client = @id" ;
                    cm.CommandText = sqlUpdate;
                    cm.Connection = cn;
                    cm.Parameters.Add("@phone", SqlDbType.Char).Value = phone;
                    cm.Parameters.Add("@id",SqlDbType.Int).Value= id;
                    cm.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                    cm.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                    cm.Parameters.Add("@cpf", SqlDbType.Char).Value = cpf;
                    cm.Parameters.Add("@cnpj", SqlDbType.Char).Value = cnpj;
                    cm.Parameters.Add("@logradouro", SqlDbType.VarChar).Value = logradouro;
                    cm.Parameters.Add("@number", SqlDbType.VarChar).Value = number;
                    cm.Parameters.Add("@complemento", SqlDbType.VarChar).Value = complemento;
                    cm.Parameters.Add("@bairro", SqlDbType.VarChar).Value = bairro;
                    cm.Parameters.Add("@city", SqlDbType.VarChar).Value = city;
                    cm.Parameters.Add("@cep", SqlDbType.Char).Value = cep;
                    cm.Parameters.Add("@states", SqlDbType.Char).Value = states;
                    cm.Parameters.Add("@status", SqlDbType.Bit).Value = status;
                    cm.Parameters.AddWithValue("@cd", 0).Direction = ParameterDirection.Output;
                    cm.Parameters.Add("@typePerson", SqlDbType.Char).Value = typePerson;
                    cn.Open();
                    cm.ExecuteNonQuery();
                    
                    cm.Connection = cn;
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

        private void dataView_DoubleClick(object sender, EventArgs e)
        {
            getClient();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (peopleOption.SelectedIndex == -1 || statesOption.SelectedIndex == -1)
            {
                MessageBox.Show("É necessario escolher o tipo de pessoa e o seu estado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (mskCNPJ.Text == "" || mskCPF.Text == "")
            {
                MessageBox.Show("É necessario preencher o CPF ou CNPJ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (mskCPF.TextLength < 11 || mskCNPJ.TextLength < 14)
            {
                MessageBox.Show("O CPF deve ter onze digitos e o CNPJ deve ter catorze digitos ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (NameInput.Text == "" || emailInput.Text == "" || mskPhone.Text == "" || logradouroInput.Text == "" || numberInput.Text == "" || ComplementoInput.Text == "" || BairroInput.Text == "" || CityInput.Text == "" || mskCEP.Text == "")
            {
                MessageBox.Show("É necessario preencher todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (mskCEP.TextLength < 8)
            {
                MessageBox.Show("O CEP deve ter oito digitos ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (mskPhone.TextLength < 11)
            {
                MessageBox.Show("O telefone deve ter onze digitos ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    string phone = mskPhone.Text;
                    int id = Convert.ToInt32(idOutput.Text);
                    if (btnOff.Checked) 
                    {
                        string stringsql = " delete from tbl_phone where cd_Client = @id;delete from tbl_client where cd_Client = @id";
                        cm.CommandText = stringsql;
                        cm.Connection = cn;
                        cm.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        cm.Parameters.Add("@phone", SqlDbType.Char).Value = phone;
                        cn.Open();
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Dados foram removidos", "Feito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limparCampos();
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

        private void emailInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
