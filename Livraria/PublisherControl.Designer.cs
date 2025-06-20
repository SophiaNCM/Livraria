namespace Livraria
{
    partial class PublisherControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IdOutput = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.PublisherInput = new System.Windows.Forms.TextBox();
            this.lbl_publisher = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.Publisher = new System.Windows.Forms.Label();
            this.SearchInput = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.btn_Publisher = new System.Windows.Forms.Button();
            this.btn_PublisherBooks = new System.Windows.Forms.Button();
            this.dataGridBook = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBook)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.IdOutput);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Controls.Add(this.PublisherInput);
            this.panel1.Controls.Add(this.lbl_publisher);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.Publisher);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(683, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 739);
            this.panel1.TabIndex = 1;
            // 
            // IdOutput
            // 
            this.IdOutput.AutoSize = true;
            this.IdOutput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.IdOutput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IdOutput.Location = new System.Drawing.Point(92, 75);
            this.IdOutput.Name = "IdOutput";
            this.IdOutput.Size = new System.Drawing.Size(0, 19);
            this.IdOutput.TabIndex = 17;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.idLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.idLabel.Location = new System.Drawing.Point(33, 75);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(26, 19);
            this.idLabel.TabIndex = 16;
            this.idLabel.Text = "Id:";
            // 
            // PublisherInput
            // 
            this.PublisherInput.BackColor = System.Drawing.SystemColors.Window;
            this.PublisherInput.Enabled = false;
            this.PublisherInput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.PublisherInput.Location = new System.Drawing.Point(96, 111);
            this.PublisherInput.Name = "PublisherInput";
            this.PublisherInput.Size = new System.Drawing.Size(143, 25);
            this.PublisherInput.TabIndex = 8;
            // 
            // lbl_publisher
            // 
            this.lbl_publisher.AutoSize = true;
            this.lbl_publisher.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_publisher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_publisher.Location = new System.Drawing.Point(36, 111);
            this.lbl_publisher.Name = "lbl_publisher";
            this.lbl_publisher.Size = new System.Drawing.Size(62, 19);
            this.lbl_publisher.TabIndex = 7;
            this.lbl_publisher.Text = "Editora:";
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
            this.btnCancel.Location = new System.Drawing.Point(40, 652);
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
            this.btnRemove.Location = new System.Drawing.Point(40, 591);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(217, 37);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            this.btnChange.Location = new System.Drawing.Point(40, 525);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(217, 37);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Alterar";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
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
            this.btnSave.Location = new System.Drawing.Point(40, 467);
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
            this.btnNew.Location = new System.Drawing.Point(40, 396);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(217, 37);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Publisher
            // 
            this.Publisher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Publisher.AutoSize = true;
            this.Publisher.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.Publisher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Publisher.Location = new System.Drawing.Point(101, 19);
            this.Publisher.Name = "Publisher";
            this.Publisher.Size = new System.Drawing.Size(95, 32);
            this.Publisher.TabIndex = 0;
            this.Publisher.Text = "Editora";
            // 
            // SearchInput
            // 
            this.SearchInput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.SearchInput.Location = new System.Drawing.Point(129, 68);
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Size = new System.Drawing.Size(429, 25);
            this.SearchInput.TabIndex = 17;
            this.SearchInput.TextChanged += new System.EventHandler(this.SearchInput_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.Search.ForeColor = System.Drawing.Color.DarkRed;
            this.Search.Location = new System.Drawing.Point(240, 26);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(206, 25);
            this.Search.TabIndex = 18;
            this.Search.Text = "Pesquisar por editora";
            // 
            // dataView
            // 
            this.dataView.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataView.GridColor = System.Drawing.Color.DarkRed;
            this.dataView.Location = new System.Drawing.Point(175, 187);
            this.dataView.MultiSelect = false;
            this.dataView.Name = "dataView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataView.Size = new System.Drawing.Size(311, 441);
            this.dataView.TabIndex = 65;
            this.dataView.DoubleClick += new System.EventHandler(this.dataView_DoubleClick);
            // 
            // btn_Publisher
            // 
            this.btn_Publisher.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Publisher.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_Publisher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_Publisher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_Publisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Publisher.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Publisher.ForeColor = System.Drawing.Color.White;
            this.btn_Publisher.Location = new System.Drawing.Point(129, 113);
            this.btn_Publisher.Name = "btn_Publisher";
            this.btn_Publisher.Size = new System.Drawing.Size(120, 30);
            this.btn_Publisher.TabIndex = 66;
            this.btn_Publisher.Text = "Editoras";
            this.btn_Publisher.UseVisualStyleBackColor = false;
            this.btn_Publisher.Click += new System.EventHandler(this.btn_Publisher_Click);
            // 
            // btn_PublisherBooks
            // 
            this.btn_PublisherBooks.BackColor = System.Drawing.Color.Firebrick;
            this.btn_PublisherBooks.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_PublisherBooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_PublisherBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_PublisherBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PublisherBooks.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PublisherBooks.ForeColor = System.Drawing.Color.White;
            this.btn_PublisherBooks.Location = new System.Drawing.Point(269, 113);
            this.btn_PublisherBooks.Name = "btn_PublisherBooks";
            this.btn_PublisherBooks.Size = new System.Drawing.Size(120, 30);
            this.btn_PublisherBooks.TabIndex = 67;
            this.btn_PublisherBooks.Text = "Editoras com livros";
            this.btn_PublisherBooks.UseVisualStyleBackColor = false;
            this.btn_PublisherBooks.Click += new System.EventHandler(this.btn_PublisherBooks_Click);
            // 
            // dataGridBook
            // 
            this.dataGridBook.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridBook.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridBook.GridColor = System.Drawing.Color.DarkRed;
            this.dataGridBook.Location = new System.Drawing.Point(151, 187);
            this.dataGridBook.MultiSelect = false;
            this.dataGridBook.Name = "dataGridBook";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridBook.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBook.Size = new System.Drawing.Size(362, 441);
            this.dataGridBook.TabIndex = 68;
            this.dataGridBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBook_CellContentClick);
            this.dataGridBook.DoubleClick += new System.EventHandler(this.dataGridBook_DoubleClick);
            // 
            // PublisherControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.dataGridBook);
            this.Controls.Add(this.btn_PublisherBooks);
            this.Controls.Add(this.btn_Publisher);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.SearchInput);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.panel1);
            this.Name = "PublisherControl";
            this.Size = new System.Drawing.Size(960, 739);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label IdOutput;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox PublisherInput;
        private System.Windows.Forms.Label lbl_publisher;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label Publisher;
        private System.Windows.Forms.TextBox SearchInput;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button btn_Publisher;
        private System.Windows.Forms.Button btn_PublisherBooks;
        private System.Windows.Forms.DataGridView dataGridBook;
    }
}
