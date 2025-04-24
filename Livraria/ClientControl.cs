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

            Search.Text = "";
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
                try
                {

                    string stringsql = "insert into tbl_client(nm_Client,ds_Email,no_CPF, no_CNPJ, nm_Logradouro, no_Logradouro, ds_Complemento,nm_Bairro,nm_Cidade,sg_UF,no_CEP,ds_status) values(@name,@email,@cpf,@cnpj,@logradouro,@number,@complemento,@bairro,@city,@states,@cep,@status) set @cd= SCOPE_IDENTITY();";
                    cm.CommandText = stringsql;
                    cm.Connection = cn;
                    cm.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                    cm.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                    cm.Parameters.Add("@cpf", SqlDbType.Char).Value = cpf;
                    cm.Parameters.Add("@cnpj",SqlDbType.Char).Value = cnpj;
                    cm.Parameters.Add("@logradouro", SqlDbType.VarChar).Value = logradouro;
                    cm.Parameters.Add("@number", SqlDbType.VarChar).Value= number;
                    cm.Parameters.Add("@complemento", SqlDbType.VarChar).Value = complemento;
                    cm.Parameters.Add("@bairro",SqlDbType.VarChar).Value = bairro;
                    cm.Parameters.Add("@city",SqlDbType.VarChar).Value = city;
                    cm.Parameters.Add("@cep",SqlDbType.Char).Value= cep;
                    cm.Parameters.Add("@states", SqlDbType.Char).Value = states;
                    cm.Parameters.Add("@status", SqlDbType.Bit).Value = status;
                    cm.Parameters.AddWithValue("@cd", 0).Direction = ParameterDirection.Output;

                    cn.Open();
                    cm.ExecuteNonQuery();
                    int cd = Convert.ToInt32(cm.Parameters["@cd"].Value);
         

                    cm.CommandText = $"insert into tbl_phone(cd_Client,no_Phone)values('"+ cd +"','"+ phone+"');";
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
    }
}
