﻿namespace Livraria
{
    partial class PhoneControl
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.labelphone = new System.Windows.Forms.Label();
            this.titlePhone = new System.Windows.Forms.Label();
            this.NameClient = new System.Windows.Forms.Label();
            this.ClientOutput = new System.Windows.Forms.Label();
            this.ClientID = new System.Windows.Forms.Label();
            this.IdOutput = new System.Windows.Forms.Label();
            this.SearchInput = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.PasswordInput);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(672, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 739);
            this.panel1.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(28, 210);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(226, 37);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Clique aqui para adicionar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(28, 454);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(226, 37);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.DarkRed;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemove.Location = new System.Drawing.Point(28, 393);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(226, 37);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.DarkRed;
            this.btnChange.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnChange.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChange.Location = new System.Drawing.Point(28, 327);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(226, 37);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Alterar";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnNew
            // 
            this.btnNew.Enabled = false;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNew.Location = new System.Drawing.Point(28, 271);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(226, 37);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Visible = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // mskPhone
            // 
            this.mskPhone.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.mskPhone.ForeColor = System.Drawing.Color.Black;
            this.mskPhone.Location = new System.Drawing.Point(183, 193);
            this.mskPhone.Mask = "(00)00000-0000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(143, 25);
            this.mskPhone.TabIndex = 38;
            // 
            // labelphone
            // 
            this.labelphone.AutoSize = true;
            this.labelphone.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.labelphone.ForeColor = System.Drawing.Color.DarkRed;
            this.labelphone.Location = new System.Drawing.Point(105, 199);
            this.labelphone.Name = "labelphone";
            this.labelphone.Size = new System.Drawing.Size(72, 19);
            this.labelphone.TabIndex = 37;
            this.labelphone.Text = "Telefone:";
            // 
            // titlePhone
            // 
            this.titlePhone.AutoSize = true;
            this.titlePhone.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.titlePhone.ForeColor = System.Drawing.Color.DarkRed;
            this.titlePhone.Location = new System.Drawing.Point(258, 32);
            this.titlePhone.Name = "titlePhone";
            this.titlePhone.Size = new System.Drawing.Size(113, 32);
            this.titlePhone.TabIndex = 39;
            this.titlePhone.Text = "Telefone";
            this.titlePhone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NameClient
            // 
            this.NameClient.AutoSize = true;
            this.NameClient.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.NameClient.ForeColor = System.Drawing.Color.DarkRed;
            this.NameClient.Location = new System.Drawing.Point(46, 147);
            this.NameClient.Name = "NameClient";
            this.NameClient.Size = new System.Drawing.Size(127, 19);
            this.NameClient.TabIndex = 40;
            this.NameClient.Text = "Nome do cliente:";
            // 
            // ClientOutput
            // 
            this.ClientOutput.AutoSize = true;
            this.ClientOutput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.ClientOutput.ForeColor = System.Drawing.Color.DarkRed;
            this.ClientOutput.Location = new System.Drawing.Point(179, 147);
            this.ClientOutput.Name = "ClientOutput";
            this.ClientOutput.Size = new System.Drawing.Size(0, 19);
            this.ClientOutput.TabIndex = 41;
            // 
            // ClientID
            // 
            this.ClientID.AutoSize = true;
            this.ClientID.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.ClientID.ForeColor = System.Drawing.Color.DarkRed;
            this.ClientID.Location = new System.Drawing.Point(46, 100);
            this.ClientID.Name = "ClientID";
            this.ClientID.Size = new System.Drawing.Size(135, 19);
            this.ClientID.TabIndex = 42;
            this.ClientID.Text = "Codigo do cliente:";
            // 
            // IdOutput
            // 
            this.IdOutput.AutoSize = true;
            this.IdOutput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.IdOutput.ForeColor = System.Drawing.Color.DarkRed;
            this.IdOutput.Location = new System.Drawing.Point(187, 100);
            this.IdOutput.Name = "IdOutput";
            this.IdOutput.Size = new System.Drawing.Size(0, 19);
            this.IdOutput.TabIndex = 43;
            // 
            // SearchInput
            // 
            this.SearchInput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.SearchInput.Location = new System.Drawing.Point(106, 337);
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Size = new System.Drawing.Size(429, 25);
            this.SearchInput.TabIndex = 44;
            this.SearchInput.TextChanged += new System.EventHandler(this.SearchInput_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.Search.ForeColor = System.Drawing.Color.DarkRed;
            this.Search.Location = new System.Drawing.Point(212, 294);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(216, 25);
            this.Search.TabIndex = 45;
            this.Search.Text = "Pesquisar por telefone";
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
            this.dataView.Location = new System.Drawing.Point(50, 395);
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
            this.dataView.Size = new System.Drawing.Size(573, 316);
            this.dataView.TabIndex = 46;
            this.dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellContentClick);
            this.dataView.DoubleClick += new System.EventHandler(this.dataView_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ClientID);
            this.panel2.Controls.Add(this.dataView);
            this.panel2.Controls.Add(this.NameClient);
            this.panel2.Controls.Add(this.SearchInput);
            this.panel2.Controls.Add(this.titlePhone);
            this.panel2.Controls.Add(this.Search);
            this.panel2.Controls.Add(this.mskPhone);
            this.panel2.Controls.Add(this.IdOutput);
            this.panel2.Controls.Add(this.labelphone);
            this.panel2.Controls.Add(this.ClientOutput);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 739);
            this.panel2.TabIndex = 47;
            // 
            // PhoneControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PhoneControl";
            this.Size = new System.Drawing.Size(960, 739);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private System.Windows.Forms.Label labelphone;
        private System.Windows.Forms.Label titlePhone;
        private System.Windows.Forms.Label NameClient;
        private System.Windows.Forms.Label ClientOutput;
        private System.Windows.Forms.Label ClientID;
        private System.Windows.Forms.Label IdOutput;
        private System.Windows.Forms.TextBox SearchInput;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
    }
}
