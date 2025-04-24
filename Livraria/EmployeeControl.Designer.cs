namespace Livraria
{
    partial class EmployeeControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.btnOff = new System.Windows.Forms.RadioButton();
            this.btnOn = new System.Windows.Forms.RadioButton();
            this.status = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.NameInput = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.EmployeeTitle = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SearchInput = new System.Windows.Forms.TextBox();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.NumberLabel);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Controls.Add(this.btnOff);
            this.panel1.Controls.Add(this.btnOn);
            this.panel1.Controls.Add(this.status);
            this.panel1.Controls.Add(this.PasswordInput);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.UserInput);
            this.panel1.Controls.Add(this.User);
            this.panel1.Controls.Add(this.nameText);
            this.panel1.Controls.Add(this.NameInput);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.EmployeeTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(683, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 739);
            this.panel1.TabIndex = 0;
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.NumberLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NumberLabel.Location = new System.Drawing.Point(92, 75);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(0, 19);
            this.NumberLabel.TabIndex = 17;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Enabled = false;
            this.idLabel.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.idLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.idLabel.Location = new System.Drawing.Point(33, 75);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(26, 19);
            this.idLabel.TabIndex = 16;
            this.idLabel.Text = "Id:";
            this.idLabel.Visible = false;
            // 
            // btnOff
            // 
            this.btnOff.AutoSize = true;
            this.btnOff.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnOff.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOff.Location = new System.Drawing.Point(165, 264);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(74, 23);
            this.btnOff.TabIndex = 15;
            this.btnOff.TabStop = true;
            this.btnOff.Text = "Inativo";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.CheckedChanged += new System.EventHandler(this.btnOff_CheckedChanged);
            // 
            // btnOn
            // 
            this.btnOn.AutoSize = true;
            this.btnOn.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnOn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOn.Location = new System.Drawing.Point(96, 264);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(63, 23);
            this.btnOn.TabIndex = 14;
            this.btnOn.TabStop = true;
            this.btnOn.Text = "Ativo";
            this.btnOn.UseVisualStyleBackColor = true;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.status.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.status.Location = new System.Drawing.Point(35, 264);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(54, 19);
            this.status.TabIndex = 13;
            this.status.Text = "Status:";
            // 
            // PasswordInput
            // 
            this.PasswordInput.Enabled = false;
            this.PasswordInput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.PasswordInput.Location = new System.Drawing.Point(96, 210);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(143, 25);
            this.PasswordInput.TabIndex = 12;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Password.Location = new System.Drawing.Point(36, 210);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(54, 19);
            this.Password.TabIndex = 11;
            this.Password.Text = "Senha:";
            // 
            // UserInput
            // 
            this.UserInput.Enabled = false;
            this.UserInput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.UserInput.Location = new System.Drawing.Point(96, 158);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(143, 25);
            this.UserInput.TabIndex = 10;
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.User.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.User.Location = new System.Drawing.Point(36, 158);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(51, 19);
            this.User.TabIndex = 9;
            this.User.Text = "Login:";
            // 
            // nameText
            // 
            this.nameText.Enabled = false;
            this.nameText.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.nameText.Location = new System.Drawing.Point(96, 111);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(143, 25);
            this.nameText.TabIndex = 8;
            this.nameText.TextChanged += new System.EventHandler(this.nameText_TextChanged);
            // 
            // NameInput
            // 
            this.NameInput.AutoSize = true;
            this.NameInput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.NameInput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameInput.Location = new System.Drawing.Point(36, 111);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(54, 19);
            this.NameInput.TabIndex = 7;
            this.NameInput.Text = "Nome:";
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
            // EmployeeTitle
            // 
            this.EmployeeTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EmployeeTitle.AutoSize = true;
            this.EmployeeTitle.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.EmployeeTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmployeeTitle.Location = new System.Drawing.Point(67, 21);
            this.EmployeeTitle.Name = "EmployeeTitle";
            this.EmployeeTitle.Size = new System.Drawing.Size(150, 32);
            this.EmployeeTitle.TabIndex = 0;
            this.EmployeeTitle.Text = "Funcionario";
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.Search.ForeColor = System.Drawing.Color.DarkRed;
            this.Search.Location = new System.Drawing.Point(210, 27);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(249, 25);
            this.Search.TabIndex = 16;
            this.Search.Text = "Pesquisar por Funcionario";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SearchInput
            // 
            this.SearchInput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.SearchInput.Location = new System.Drawing.Point(126, 69);
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Size = new System.Drawing.Size(429, 25);
            this.SearchInput.TabIndex = 16;
            this.SearchInput.TextChanged += new System.EventHandler(this.SearchInput_TextChanged);
            // 
            // dataView
            // 
            this.dataView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataView.Location = new System.Drawing.Point(126, 121);
            this.dataView.MultiSelect = false;
            this.dataView.Name = "dataView";
            this.dataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataView.Size = new System.Drawing.Size(429, 429);
            this.dataView.TabIndex = 19;
            this.dataView.DoubleClick += new System.EventHandler(this.dataView_DoubleClick);
            // 
            // EmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.SearchInput);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeControl";
            this.Size = new System.Drawing.Size(960, 739);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label EmployeeTitle;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label NameInput;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.RadioButton btnOn;
        private System.Windows.Forms.RadioButton btnOff;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox SearchInput;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label NumberLabel;
    }
}
