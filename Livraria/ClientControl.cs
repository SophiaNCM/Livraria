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
            phoneInput.Enabled = false;
            peopleOption.Enabled = false;
            cpfInput.Enabled = false;
            logradouroInput.Enabled = false;
            numberInput.Enabled = false;
            ComplementoInput.Enabled = false;
            BairroInput.Enabled = false;
            CityInput.Enabled = false;
            cepInput.Enabled = false;
            statesOption.Enabled = false;
            btnOn.Enabled = false;
            btnOff.Enabled = false;
            

        }
        private void habilitaCampos()
        {

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
            phoneInput.Enabled = true;
            peopleOption.Enabled = true;
            cpfInput.Enabled = true;
            logradouroInput.Enabled = true;
            numberInput.Enabled = true;
            ComplementoInput.Enabled = true;
            BairroInput.Enabled = true;
            CityInput.Enabled = true;
            cepInput.Enabled = true;
            statesOption.Enabled = true;
            btnOn.Enabled = true;
            btnOff.Enabled = true;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            habilitaCampos();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desabilitaCampos();
        }
    }
}
