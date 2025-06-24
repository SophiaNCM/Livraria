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
            idOutput.Text = "";
            BookInput.Text = "";

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
        private void getBook()
        {
            titleText.Enabled = true;
            priceInput.Enabled = true;
            pageInput.Enabled= true;
            StockInput.Enabled= true;
            dateInput.Enabled= true;
            publisherInput.Enabled= true;
            writerInput.Enabled= true;
            CategoryInput.Enabled= true;


            idOutput.Text = dataView.SelectedRows[0].Cells[0].Value.ToString();
            titleText.Text = dataView.SelectedRows[0].Cells[1].Value.ToString();
            pageInput.Text = dataView.SelectedRows[0].Cells[2].Value.ToString();
            priceInput.Text = dataView.SelectedRows[0].Cells[3].Value.ToString();
            StockInput.Text = dataView.SelectedRows[0].Cells[4].Value.ToString();
            dateInput.Text = dataView.SelectedRows[0].Cells[5].Value.ToString();
            CategoryInput.Text = dataView.SelectedRows[0].Cells[6].Value.ToString();
            publisherInput.Text = dataView.SelectedRows[0].Cells[7].Value.ToString();
            writerInput.Text = dataView.SelectedRows[0].Cells[8].Value.ToString();
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
           if (titleInput.Text == "" || pageInput.Text == "" || priceInput.Text == "" || StockInput.Text == "" ||  CategoryInput.Text == "" || publisherInput.Text == "" || writerInput.Text == "")
            {
                MessageBox.Show("Nenhum campo pode estar vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string title = titleText.Text;
                string price = priceInput.Text;
                string noPage = pageInput.Text;
                string quantStock = StockInput.Text;
                string dataRelease = dateInput.Text;
                string category = CategoryInput.Text;
                string publisher = publisherInput.Text;
                string writer = writerInput.Text;
                try
                {
                    string sqlCommand = "DECLARE @IdCategory INT; " +
                        "DECLARE @IdPublisher INT; " +
                        "DECLARE @IdWriter INT; " +
                        "DECLARE @IdBook INT; " +
                        "SELECT @IdCategory = cd_Category FROM tbl_Category WHERE nm_Category = @category; " +
                        "SELECT @IdPublisher = cd_publisher FROM tbl_Publisher Where nm_Publisher =@publisher; " +
                        "SELECT @IdWriter = cd_Writer FROM tbl_writer Where nm_Writer =@writer; " +
                        "SELECT @IdBook = cd_Book FROM tbl_Book WHERE nm_Book =@title " +
                        "IF @IdCategory IS NULL " +
                        "BEGIN " +
                        "INSERT INTO tbl_Category(nm_Category) VALUES (@category) SET @IdCategory = SCOPE_IDENTITY(); " +
                        "END " +
                        "IF @IdPublisher IS NULL " +
                        "BEGIN " +
                        "INSERT INTO tbl_Publisher(nm_Publisher) VALUES (@publisher) SET @IdPublisher = SCOPE_IDENTITY(); " +
                        "END " +
                        "IF @IdWriter IS NULL " +
                        "BEGIN " +
                        "INSERT INTO tbl_writer(nm_Writer) Values(@writer) SET @IdWriter = SCOPE_IDENTITY(); " +
                        "END " +
                        "IF @IdCategory IS NOT NULL AND @IdPublisher IS NOT NULL AND @IdWriter IS NOT NULL AND @IdBook IS NULL " +
                        "BEGIN   " +
                        "INSERT INTO tbl_Book(nm_Book,no_Page, Price_Book,qt_Stock,dt_Release,cd_Category,cd_Publisher) VALUES(@title,@noPage,@price,@quantStock,@dataRelease,@IdCategory,@IdPublisher) SET @IdBook = SCOPE_IDENTITY(); INSERT INTO tbl_writerBook(cd_Writer,cd_Book) VALUES(@IdWriter,@IdBook);" +
                        "END;";

                    cm.CommandText = sqlCommand;
                    cm.Connection = cn;
                    cm.Parameters.Add("@category", SqlDbType.VarChar).Value = category;
                    cm.Parameters.Add("@publisher", SqlDbType.VarChar).Value = publisher;
                    cm.Parameters.Add("@title", SqlDbType.VarChar).Value = title;
                    cm.Parameters.Add("@noPage",SqlDbType.VarChar).Value = noPage;
                    cm.Parameters.Add("@price", SqlDbType.Decimal).Value = price;
                    cm.Parameters.Add("@quantStock", SqlDbType.Int).Value = quantStock;
                    cm.Parameters.Add("@dataRelease", SqlDbType.Date).Value = dataRelease;
                    cm.Parameters.Add("@writer",SqlDbType.VarChar).Value = writer;
                    
                    cn.Open();

                    cm.ExecuteNonQuery();
                    cm.Connection = cn;
                    cm.Parameters.Clear();
                    MessageBox.Show("Dados adicionados com sucesso", "Feito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            limparCampos();
            DesabilitaCampos();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (titleInput.Text == "" || pageInput.Text == "" || priceInput.Text == "" || StockInput.Text == "" || CategoryInput.Text == "" || publisherInput.Text == "" || writerInput.Text == "")
            {
                MessageBox.Show("Nenhum campo pode estar vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(idOutput.Text);
                    string stringsql = "DELETE FROM tbl_writerBook WHERE cd_Book = @id;DELETE FROM tbl_Book WHERE cd_Book = @id;";
                    cm.CommandText = stringsql;
                    cm.Connection = cn;
                    cm.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cn.Open();
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Os dados foram removidos","Feito",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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

        private void BookInput_TextChanged(object sender, EventArgs e)
        {
            if (BookInput.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "SELECT * FROM viewBook_AllInfo where titulo like ('"+BookInput.Text+"%')";
                    cm.Connection = cn;

                    SqlDataAdapter da = new SqlDataAdapter();

                    DataTable dt = new DataTable();
                    da.SelectCommand = cm;
                    da.Fill(dt);
                    dataView.DataSource = dt;
                    cn.Close();

                }
                catch (Exception error){
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
            getBook();
            btnCancel.Enabled = true;
            btnCancel.BackColor = Color.DarkRed;
            btnRemove.Enabled = true;
            btnRemove.BackColor = Color.DarkRed;
            btnChange.Enabled = true;
            btnChange.BackColor = Color.DarkRed;
            btnNew.Enabled = false; 
            btnNew.BackColor = Color.Maroon;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (titleInput.Text == "" || pageInput.Text == "" || priceInput.Text == "" || StockInput.Text == "" || CategoryInput.Text == "" || publisherInput.Text == "" || writerInput.Text == "")
            {
                MessageBox.Show("Nenhum campo pode estar vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string IdBook = idOutput.Text;
                string title = titleText.Text;
                string price = priceInput.Text;
                string noPage = pageInput.Text;
                string quantStock = StockInput.Text;
                string dataRelease = dateInput.Text;
                string category = CategoryInput.Text;
                string publisher = publisherInput.Text;
                string writer = writerInput.Text;
                try
                {
                   
                    cm.CommandText ="DECLARE @IdCategory INT; " +
                        "DECLARE @IdPublisher INT; " +
                        "DECLARE @IdWriter INT; " +
                        "SELECT @IdCategory = cd_Category FROM tbl_Category WHERE nm_Category = @category; " +
                        "SELECT @IdPublisher = cd_publisher FROM tbl_Publisher Where nm_Publisher =@publisher; " +
                        "SELECT @IdWriter = cd_Writer FROM tbl_writer Where nm_Writer =@writer; " +
                        "IF @IdCategory IS NULL " +
                        "BEGIN " +
                        "INSERT INTO tbl_Category(nm_Category) VALUES (@category) SET @IdCategory = SCOPE_IDENTITY(); " +
                        "END " +
                        "IF @IdPublisher IS NULL " +
                        "BEGIN " +
                        "INSERT INTO tbl_Publisher(nm_Publisher) VALUES (@publisher) SET @IdPublisher = SCOPE_IDENTITY(); " +
                        "END " +
                        "IF @IdWriter IS NULL " +
                        "BEGIN " +
                        "INSERT INTO tbl_writer(nm_Writer) Values(@writer) SET @IdWriter = SCOPE_IDENTITY(); " +
                        "END " +
                        "IF @IdCategory IS NOT NULL AND @IdPublisher IS NOT NULL AND @IdWriter IS NOT NULL " +
                        "BEGIN   " +
                        "UPDATE tbl_book set nm_Book = @title, no_Page = @noPage, Price_Book = @price, qt_Stock =@quantStock, dt_Release = @dataRelease, cd_Category = @IdCategory, cd_Publisher = @IdPublisher WHERE cd_Book = @IdBook; UPDATE tbl_writerBook set cd_Writer =@IdWriter WHERE cd_Book = @IdBook;" +
                        "END;";
                    cm.Connection = cn;
                    cm.Parameters.Add("@IdBook", SqlDbType.Int).Value = IdBook;
                    cm.Parameters.Add("@category", SqlDbType.VarChar).Value = category;
                    cm.Parameters.Add("@publisher", SqlDbType.VarChar).Value = publisher;
                    cm.Parameters.Add("@title", SqlDbType.VarChar).Value = title;
                    cm.Parameters.Add("@noPage", SqlDbType.VarChar).Value = noPage;
                    cm.Parameters.Add("@price", SqlDbType.Decimal).Value = price;
                    cm.Parameters.Add("@quantStock", SqlDbType.Int).Value = quantStock;
                    cm.Parameters.Add("@dataRelease", SqlDbType.Date).Value = dataRelease;
                    cm.Parameters.Add("@writer", SqlDbType.VarChar).Value = writer;
                    cn.Open();
                    cm.ExecuteNonQuery();

                    cm.Connection = cn;
                    cm.Parameters.Clear();
                    MessageBox.Show("Dados alterados", "Feito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    limparCampos();

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

        private void writerInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void publisherInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void titleText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
