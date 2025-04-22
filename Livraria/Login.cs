using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Livraria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string user;
        public static string idUser;
        //Conexao com database
        SqlConnection cn = new SqlConnection(@"Data Source=COMPUTADOR-SOPH;integrated security=SSPI;initial Catalog=db_livraria");

        //o sqlCommand faz com que seja possivel escrever comandos sql por aqui
        SqlCommand cm = new SqlCommand();
        //meio que vai montar uma tabela aqui 
        //SqlDataReader dt;
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void enter_Click(object sender, EventArgs e)
        {
            if (NameInput.Text == "" || PasswordIput.Text == "")
            {
                if (NameInput.Text == "")
                {
                    errorLogin.Text = "Digite um login";
                }
                if (PasswordIput.Text == "")
                {
                    errorPassword.Text = "Digite uma senha";
                }
            }
            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tbl_employee where ds_login = ('" + NameInput.Text + "') and ds_password = ('" + PasswordIput.Text + "') and ds_status = 1";
                    cm.Connection = cn;
                    //dt = cm.ExecuteReader();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    if (dt.Rows.Count > 0) // a contagem de linhas é maior que zero
                    {
                        user = dt.Rows[0]["nm_employee"].ToString();
                        idUser = dt.Rows[0]["cd_empoyee"].ToString();

                        FormMenu menu = new FormMenu();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        NameInput.Clear();
                        PasswordIput.Clear();
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
                finally
                {
                    cn.Close();

                }
            }
        }
    }
}
