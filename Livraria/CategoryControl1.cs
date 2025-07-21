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
    public partial class CategoryControl1 : UserControl
    {
        public CategoryControl1()
        {
            InitializeComponent();
        }
        //Conexao com database
        SqlConnection cn = new SqlConnection(@"Data Source=COMPUTADOR-SOPH;integrated security=SSPI;initial Catalog=db_livraria");

        //o sqlCommand faz com que seja possivel escrever comandos sql por aqui
        SqlCommand cm = new SqlCommand();

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnSave.BackColor = Color.DarkRed;
            categoryInput.Enabled = true;
            btnCancel.Enabled = true;
            btnCancel.BackColor = Color.DarkRed;

         
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(categoryInput.Text == "")
            {
                MessageBox.Show("Escreva o nome da categoria!!","Atenção",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string category = categoryInput.Text;

                try
                {
                    string sqlCommand = "INSERT INTO tbl_Category(nm_Category) VALUES (@category) SET @IdCategory = SCOPE_IDENTITY()";

                    cm.CommandText = sqlCommand;
                    cm.Parameters.Add("@category", SqlDbType.VarChar).Value = category;
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cm.Connection = cn;
                    cm.Parameters.Clear();

                    MessageBox.Show("Categoria adicionada", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    categoryInput.Clear();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Enabled=false;
            btnSave.BackColor = Color.Maroon;
            btnChange.Enabled=false;
            btnCancel.BackColor = Color.Maroon;
            btnRemove.Enabled=false;
            btnRemove.BackColor = Color.Maroon;
            categoryInput.Clear();
            categoryInput.Enabled=false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if(idOutput.Text == "" && categoryInput.Text == "")
            {

            }

        }
    }
}
