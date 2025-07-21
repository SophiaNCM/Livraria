namespace Livraria
{
    partial class CategoryControl1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.categoryInput = new System.Windows.Forms.TextBox();
            this.CategoryTitle = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.idOutput = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.searchCategory = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.categoryInput);
            this.panel1.Controls.Add(this.CategoryTitle);
            this.panel1.Controls.Add(this.lbl_Category);
            this.panel1.Controls.Add(this.PasswordInput);
            this.panel1.Controls.Add(this.idOutput);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(683, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 739);
            this.panel1.TabIndex = 3;
            // 
            // categoryInput
            // 
            this.categoryInput.Enabled = false;
            this.categoryInput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.categoryInput.Location = new System.Drawing.Point(95, 139);
            this.categoryInput.MaxLength = 80;
            this.categoryInput.Name = "categoryInput";
            this.categoryInput.Size = new System.Drawing.Size(134, 25);
            this.categoryInput.TabIndex = 50;
            // 
            // CategoryTitle
            // 
            this.CategoryTitle.AutoSize = true;
            this.CategoryTitle.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.CategoryTitle.ForeColor = System.Drawing.Color.White;
            this.CategoryTitle.Location = new System.Drawing.Point(90, 35);
            this.CategoryTitle.Name = "CategoryTitle";
            this.CategoryTitle.Size = new System.Drawing.Size(123, 32);
            this.CategoryTitle.TabIndex = 43;
            this.CategoryTitle.Text = "Categoria";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_Category.ForeColor = System.Drawing.Color.White;
            this.lbl_Category.Location = new System.Drawing.Point(17, 139);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(79, 19);
            this.lbl_Category.TabIndex = 49;
            this.lbl_Category.Text = "Categoria:";
            // 
            // PasswordInput
            // 
            this.PasswordInput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.PasswordInput.Location = new System.Drawing.Point(96, 210);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(0, 25);
            this.PasswordInput.TabIndex = 12;
            // 
            // idOutput
            // 
            this.idOutput.AutoSize = true;
            this.idOutput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.idOutput.ForeColor = System.Drawing.Color.White;
            this.idOutput.Location = new System.Drawing.Point(91, 100);
            this.idOutput.Name = "idOutput";
            this.idOutput.Size = new System.Drawing.Size(0, 19);
            this.idOutput.TabIndex = 48;
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
            this.btnCancel.Location = new System.Drawing.Point(27, 550);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(217, 37);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.labelId.ForeColor = System.Drawing.Color.White;
            this.labelId.Location = new System.Drawing.Point(23, 100);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(62, 19);
            this.labelId.TabIndex = 47;
            this.labelId.Text = "Codigo:";
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
            this.btnRemove.Location = new System.Drawing.Point(27, 489);
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
            this.btnChange.Location = new System.Drawing.Point(27, 423);
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
            this.btnSave.Location = new System.Drawing.Point(27, 365);
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
            this.btnNew.Location = new System.Drawing.Point(27, 294);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(217, 37);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dataView
            // 
            this.dataView.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataView.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataView.GridColor = System.Drawing.Color.DarkRed;
            this.dataView.Location = new System.Drawing.Point(55, 139);
            this.dataView.MultiSelect = false;
            this.dataView.Name = "dataView";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataView.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataView.Size = new System.Drawing.Size(563, 263);
            this.dataView.TabIndex = 67;
            // 
            // searchCategory
            // 
            this.searchCategory.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.searchCategory.Location = new System.Drawing.Point(88, 94);
            this.searchCategory.Name = "searchCategory";
            this.searchCategory.Size = new System.Drawing.Size(503, 25);
            this.searchCategory.TabIndex = 65;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.Search.ForeColor = System.Drawing.Color.DarkRed;
            this.Search.Location = new System.Drawing.Point(239, 41);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(187, 25);
            this.Search.TabIndex = 66;
            this.Search.Text = "Pesquisar categoria";
            // 
            // CategoryControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.searchCategory);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.panel1);
            this.Name = "CategoryControl1";
            this.Size = new System.Drawing.Size(960, 739);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
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
        private System.Windows.Forms.Label CategoryTitle;
        private System.Windows.Forms.TextBox categoryInput;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label idOutput;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.TextBox searchCategory;
        private System.Windows.Forms.Label Search;
    }
}
