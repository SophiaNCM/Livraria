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
    public partial class BookControl : UserControl
    {
        public BookControl()
        {
            InitializeComponent();
        }
        //Conexao com database
        SqlConnection cn = new SqlConnection(@"Data Source=COMPUTADOR-SOPH;integrated security=SSPI;initial Catalog=db_livraria");

        //o sqlCommand faz com que seja possivel escrever comandos sql por aqui
        SqlCommand cm = new SqlCommand();

        private void limparCampos()
        {
            titleText.Clear();
            pageInput.Clear();
            priceInput.Clear();
            StockInput.Clear();
            CategoryInput.Clear();
            publisherInput.Clear();
            writerInput.Clear();

        }
        private void habilitarCampos()
        {
            titleText.Enabled = true;
            pageInput.Enabled = true;
            priceInput.Enabled = true;
            StockInput.Enabled = true;
            dateInput.Enabled = true;
            CategoryInput.Enabled = true;
            publisherInput.Enabled = true;
            writerInput.Enabled = true;
        }
        private void DesabilitaCampos()
        {
            titleText.Enabled = false;
            pageInput.Enabled = false;
            priceInput.Enabled = false;
            StockInput.Enabled = false;
            dateInput.Enabled = false;
            CategoryInput.Enabled = false;
            publisherInput.Enabled = false;
            writerInput.Enabled = false;
            btnNew.Enabled = true;
            btnNew.BackColor = Color.DarkRed;
            btnSave.Enabled = false;
            btnSave.BackColor = Color.Maroon;
            btnChange.Enabled = false;
            btnChange.BackColor = Color.Maroon;
            btnRemove.Enabled = false;
            btnRemove.BackColor = Color.Maroon;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            btnCancel.Enabled = true;
            btnCancel.BackColor = Color.DarkRed;
            btnSave.Enabled = true;
            btnSave.BackColor = Color.DarkRed;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (titleInput.Text == "" ||pageInput.Text =="" || priceInput.Text == "" || StockInput.Text ==""|| dateInput.Text ==""|| CategoryInput.Text ==""|| publisherInput.Text ==""|| writerInput.Text =="") 
            {
                MessageBox.Show("Nenhum campo pode estar vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            limparCampos();
            DesabilitaCampos();
        }
    }
}
