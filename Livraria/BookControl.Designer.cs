namespace Livraria
{
    partial class BookControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.BookTitle = new System.Windows.Forms.Label();
            this.idOutput = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.titleInput = new System.Windows.Forms.Label();
            this.pageInput = new System.Windows.Forms.TextBox();
            this.page = new System.Windows.Forms.Label();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.StockInput = new System.Windows.Forms.TextBox();
            this.Stock = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.publisherInput = new System.Windows.Forms.TextBox();
            this.Publisher = new System.Windows.Forms.Label();
            this.CategoryInput = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.Label();
            this.dateInput = new System.Windows.Forms.DateTimePicker();
            this.writerInput = new System.Windows.Forms.TextBox();
            this.Writer = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.PasswordInput);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(683, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 739);
            this.panel1.TabIndex = 2;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.PasswordInput.Location = new System.Drawing.Point(96, 210);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(0, 25);
            this.PasswordInput.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(28, 454);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(217, 37);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Maroon;
            this.btnRemove.Enabled = false;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemove.Location = new System.Drawing.Point(28, 393);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(217, 37);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Maroon;
            this.btnChange.Enabled = false;
            this.btnChange.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnChange.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChange.Location = new System.Drawing.Point(28, 327);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(217, 37);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Alterar";
            this.btnChange.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Maroon;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(28, 269);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(217, 37);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNew.Location = new System.Drawing.Point(28, 198);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(217, 37);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // BookTitle
            // 
            this.BookTitle.AutoSize = true;
            this.BookTitle.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.BookTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.BookTitle.Location = new System.Drawing.Point(271, 19);
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.Size = new System.Drawing.Size(81, 32);
            this.BookTitle.TabIndex = 42;
            this.BookTitle.Text = "Livros";
            // 
            // idOutput
            // 
            this.idOutput.AutoSize = true;
            this.idOutput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.idOutput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.idOutput.Location = new System.Drawing.Point(135, 69);
            this.idOutput.Name = "idOutput";
            this.idOutput.Size = new System.Drawing.Size(0, 19);
            this.idOutput.TabIndex = 44;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.labelId.ForeColor = System.Drawing.Color.DarkRed;
            this.labelId.Location = new System.Drawing.Point(67, 69);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(62, 19);
            this.labelId.TabIndex = 43;
            this.labelId.Text = "Codigo:";
            // 
            // titleText
            // 
            this.titleText.Enabled = false;
            this.titleText.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.titleText.Location = new System.Drawing.Point(139, 108);
            this.titleText.MaxLength = 80;
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(495, 25);
            this.titleText.TabIndex = 46;
            // 
            // titleInput
            // 
            this.titleInput.AutoSize = true;
            this.titleInput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.titleInput.ForeColor = System.Drawing.Color.DarkRed;
            this.titleInput.Location = new System.Drawing.Point(73, 108);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(52, 19);
            this.titleInput.TabIndex = 45;
            this.titleInput.Text = "Titulo:";
            // 
            // pageInput
            // 
            this.pageInput.Enabled = false;
            this.pageInput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.pageInput.Location = new System.Drawing.Point(228, 152);
            this.pageInput.MaxLength = 5;
            this.pageInput.Name = "pageInput";
            this.pageInput.Size = new System.Drawing.Size(148, 25);
            this.pageInput.TabIndex = 48;
            // 
            // page
            // 
            this.page.AutoSize = true;
            this.page.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.page.ForeColor = System.Drawing.Color.DarkRed;
            this.page.Location = new System.Drawing.Point(73, 152);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(149, 19);
            this.page.TabIndex = 47;
            this.page.Text = "Numero de paginas:";
            // 
            // priceInput
            // 
            this.priceInput.Enabled = false;
            this.priceInput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.priceInput.Location = new System.Drawing.Point(451, 152);
            this.priceInput.MaxLength = 10;
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(183, 25);
            this.priceInput.TabIndex = 50;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Price.ForeColor = System.Drawing.Color.DarkRed;
            this.Price.Location = new System.Drawing.Point(393, 155);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(52, 19);
            this.Price.TabIndex = 49;
            this.Price.Text = "Preço:";
            // 
            // StockInput
            // 
            this.StockInput.Enabled = false;
            this.StockInput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.StockInput.Location = new System.Drawing.Point(254, 198);
            this.StockInput.MaxLength = 60;
            this.StockInput.Name = "StockInput";
            this.StockInput.Size = new System.Drawing.Size(122, 25);
            this.StockInput.TabIndex = 52;
            // 
            // Stock
            // 
            this.Stock.AutoSize = true;
            this.Stock.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Stock.ForeColor = System.Drawing.Color.DarkRed;
            this.Stock.Location = new System.Drawing.Point(73, 198);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(175, 19);
            this.Stock.TabIndex = 51;
            this.Stock.Text = "Quantidade no estoque:";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.date.ForeColor = System.Drawing.Color.DarkRed;
            this.date.Location = new System.Drawing.Point(393, 204);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(44, 19);
            this.date.TabIndex = 53;
            this.date.Text = "Data:";
            // 
            // publisherInput
            // 
            this.publisherInput.Enabled = false;
            this.publisherInput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.publisherInput.Location = new System.Drawing.Point(463, 249);
            this.publisherInput.MaxLength = 20;
            this.publisherInput.Name = "publisherInput";
            this.publisherInput.Size = new System.Drawing.Size(171, 25);
            this.publisherInput.TabIndex = 58;
            // 
            // Publisher
            // 
            this.Publisher.AutoSize = true;
            this.Publisher.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Publisher.ForeColor = System.Drawing.Color.DarkRed;
            this.Publisher.Location = new System.Drawing.Point(393, 255);
            this.Publisher.Name = "Publisher";
            this.Publisher.Size = new System.Drawing.Size(62, 19);
            this.Publisher.TabIndex = 57;
            this.Publisher.Text = "Editora:";
            // 
            // CategoryInput
            // 
            this.CategoryInput.Enabled = false;
            this.CategoryInput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.CategoryInput.Location = new System.Drawing.Point(158, 249);
            this.CategoryInput.MaxLength = 20;
            this.CategoryInput.Name = "CategoryInput";
            this.CategoryInput.Size = new System.Drawing.Size(218, 25);
            this.CategoryInput.TabIndex = 56;
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Category.ForeColor = System.Drawing.Color.DarkRed;
            this.Category.Location = new System.Drawing.Point(73, 249);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(79, 19);
            this.Category.TabIndex = 55;
            this.Category.Text = "Categoria:";
            // 
            // dateInput
            // 
            this.dateInput.Enabled = false;
            this.dateInput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.dateInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInput.Location = new System.Drawing.Point(451, 203);
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(183, 25);
            this.dateInput.TabIndex = 59;
            // 
            // writerInput
            // 
            this.writerInput.Enabled = false;
            this.writerInput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.writerInput.Location = new System.Drawing.Point(131, 293);
            this.writerInput.MaxLength = 60;
            this.writerInput.Name = "writerInput";
            this.writerInput.Size = new System.Drawing.Size(503, 25);
            this.writerInput.TabIndex = 61;
            // 
            // Writer
            // 
            this.Writer.AutoSize = true;
            this.Writer.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Writer.ForeColor = System.Drawing.Color.DarkRed;
            this.Writer.Location = new System.Drawing.Point(73, 293);
            this.Writer.Name = "Writer";
            this.Writer.Size = new System.Drawing.Size(52, 19);
            this.Writer.TabIndex = 60;
            this.Writer.Text = "Autor:";
            // 
            // BookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.writerInput);
            this.Controls.Add(this.Writer);
            this.Controls.Add(this.dateInput);
            this.Controls.Add(this.publisherInput);
            this.Controls.Add(this.Publisher);
            this.Controls.Add(this.CategoryInput);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.date);
            this.Controls.Add(this.StockInput);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.pageInput);
            this.Controls.Add(this.page);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.titleInput);
            this.Controls.Add(this.idOutput);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.BookTitle);
            this.Controls.Add(this.panel1);
            this.Name = "BookControl";
            this.Size = new System.Drawing.Size(960, 739);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label BookTitle;
        private System.Windows.Forms.Label idOutput;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.Label titleInput;
        private System.Windows.Forms.TextBox pageInput;
        private System.Windows.Forms.Label page;
        private System.Windows.Forms.TextBox priceInput;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox StockInput;
        private System.Windows.Forms.Label Stock;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.TextBox publisherInput;
        private System.Windows.Forms.Label Publisher;
        private System.Windows.Forms.TextBox CategoryInput;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.DateTimePicker dateInput;
        private System.Windows.Forms.TextBox writerInput;
        private System.Windows.Forms.Label Writer;
    }
}
