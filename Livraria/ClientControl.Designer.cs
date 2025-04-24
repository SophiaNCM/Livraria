namespace Livraria
{
    partial class ClientControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.RadioButton();
            this.btnOn = new System.Windows.Forms.RadioButton();
            this.status = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.NameInput = new System.Windows.Forms.Label();
            this.ClientTitle = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.Label();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.Label();
            this.logradouroInput = new System.Windows.Forms.TextBox();
            this.logradouro = new System.Windows.Forms.Label();
            this.Person = new System.Windows.Forms.Label();
            this.ComplementoInput = new System.Windows.Forms.TextBox();
            this.Complemento = new System.Windows.Forms.Label();
            this.BairroInput = new System.Windows.Forms.TextBox();
            this.Bairro = new System.Windows.Forms.Label();
            this.CityInput = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.Label();
            this.CEP = new System.Windows.Forms.Label();
            this.States = new System.Windows.Forms.Label();
            this.statesOption = new System.Windows.Forms.ComboBox();
            this.peopleOption = new System.Windows.Forms.ComboBox();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.SearchInput = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.cnpj = new System.Windows.Forms.Label();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.mskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
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
            this.panel1.TabIndex = 1;
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
            // btnOff
            // 
            this.btnOff.AutoSize = true;
            this.btnOff.Enabled = false;
            this.btnOff.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnOff.ForeColor = System.Drawing.Color.DarkRed;
            this.btnOff.Location = new System.Drawing.Point(510, 385);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(74, 23);
            this.btnOff.TabIndex = 15;
            this.btnOff.TabStop = true;
            this.btnOff.Text = "Inativo";
            this.btnOff.UseVisualStyleBackColor = true;
            // 
            // btnOn
            // 
            this.btnOn.AutoSize = true;
            this.btnOn.Enabled = false;
            this.btnOn.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnOn.ForeColor = System.Drawing.Color.DarkRed;
            this.btnOn.Location = new System.Drawing.Point(441, 385);
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
            this.status.ForeColor = System.Drawing.Color.DarkRed;
            this.status.Location = new System.Drawing.Point(380, 385);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(54, 19);
            this.status.TabIndex = 13;
            this.status.Text = "Status:";
            // 
            // nameText
            // 
            this.nameText.Enabled = false;
            this.nameText.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.nameText.Location = new System.Drawing.Point(136, 86);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(495, 25);
            this.nameText.TabIndex = 8;
            // 
            // NameInput
            // 
            this.NameInput.AutoSize = true;
            this.NameInput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.NameInput.ForeColor = System.Drawing.Color.DarkRed;
            this.NameInput.Location = new System.Drawing.Point(70, 86);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(54, 19);
            this.NameInput.TabIndex = 7;
            this.NameInput.Text = "Nome:";
            // 
            // ClientTitle
            // 
            this.ClientTitle.AutoSize = true;
            this.ClientTitle.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.ClientTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.ClientTitle.Location = new System.Drawing.Point(285, 27);
            this.ClientTitle.Name = "ClientTitle";
            this.ClientTitle.Size = new System.Drawing.Size(93, 32);
            this.ClientTitle.TabIndex = 0;
            this.ClientTitle.Text = "Cliente";
            // 
            // emailInput
            // 
            this.emailInput.Enabled = false;
            this.emailInput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.emailInput.Location = new System.Drawing.Point(136, 138);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(196, 25);
            this.emailInput.TabIndex = 10;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Email.ForeColor = System.Drawing.Color.DarkRed;
            this.Email.Location = new System.Drawing.Point(70, 138);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(50, 19);
            this.Email.TabIndex = 9;
            this.Email.Text = "Email:";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.phone.ForeColor = System.Drawing.Color.DarkRed;
            this.phone.Location = new System.Drawing.Point(346, 138);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(72, 19);
            this.phone.TabIndex = 11;
            this.phone.Text = "Telefone:";
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.CPF.ForeColor = System.Drawing.Color.DarkRed;
            this.CPF.Location = new System.Drawing.Point(380, 183);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(38, 19);
            this.CPF.TabIndex = 13;
            this.CPF.Text = "CPF:";
            // 
            // numberInput
            // 
            this.numberInput.Enabled = false;
            this.numberInput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.numberInput.Location = new System.Drawing.Point(424, 227);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(207, 25);
            this.numberInput.TabIndex = 16;
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Number.ForeColor = System.Drawing.Color.DarkRed;
            this.Number.Location = new System.Drawing.Point(349, 227);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(69, 19);
            this.Number.TabIndex = 15;
            this.Number.Text = "Numero:";
            // 
            // logradouroInput
            // 
            this.logradouroInput.Enabled = false;
            this.logradouroInput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.logradouroInput.Location = new System.Drawing.Point(136, 227);
            this.logradouroInput.Name = "logradouroInput";
            this.logradouroInput.Size = new System.Drawing.Size(196, 25);
            this.logradouroInput.TabIndex = 18;
            // 
            // logradouro
            // 
            this.logradouro.AutoSize = true;
            this.logradouro.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.logradouro.ForeColor = System.Drawing.Color.DarkRed;
            this.logradouro.Location = new System.Drawing.Point(36, 227);
            this.logradouro.Name = "logradouro";
            this.logradouro.Size = new System.Drawing.Size(94, 19);
            this.logradouro.TabIndex = 17;
            this.logradouro.Text = "Logradouro:";
            // 
            // Person
            // 
            this.Person.AutoSize = true;
            this.Person.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Person.ForeColor = System.Drawing.Color.DarkRed;
            this.Person.Location = new System.Drawing.Point(65, 189);
            this.Person.Name = "Person";
            this.Person.Size = new System.Drawing.Size(59, 19);
            this.Person.TabIndex = 19;
            this.Person.Text = "Pessoa:";
            // 
            // ComplementoInput
            // 
            this.ComplementoInput.Enabled = false;
            this.ComplementoInput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.ComplementoInput.Location = new System.Drawing.Point(136, 277);
            this.ComplementoInput.Name = "ComplementoInput";
            this.ComplementoInput.Size = new System.Drawing.Size(196, 25);
            this.ComplementoInput.TabIndex = 23;
            // 
            // Complemento
            // 
            this.Complemento.AutoSize = true;
            this.Complemento.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Complemento.ForeColor = System.Drawing.Color.DarkRed;
            this.Complemento.Location = new System.Drawing.Point(21, 277);
            this.Complemento.Name = "Complemento";
            this.Complemento.Size = new System.Drawing.Size(109, 19);
            this.Complemento.TabIndex = 22;
            this.Complemento.Text = "Complemento:";
            // 
            // BairroInput
            // 
            this.BairroInput.Enabled = false;
            this.BairroInput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.BairroInput.Location = new System.Drawing.Point(424, 277);
            this.BairroInput.Name = "BairroInput";
            this.BairroInput.Size = new System.Drawing.Size(207, 25);
            this.BairroInput.TabIndex = 21;
            // 
            // Bairro
            // 
            this.Bairro.AutoSize = true;
            this.Bairro.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Bairro.ForeColor = System.Drawing.Color.DarkRed;
            this.Bairro.Location = new System.Drawing.Point(363, 277);
            this.Bairro.Name = "Bairro";
            this.Bairro.Size = new System.Drawing.Size(55, 19);
            this.Bairro.TabIndex = 20;
            this.Bairro.Text = "Bairro:";
            // 
            // CityInput
            // 
            this.CityInput.Enabled = false;
            this.CityInput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.CityInput.Location = new System.Drawing.Point(136, 329);
            this.CityInput.Name = "CityInput";
            this.CityInput.Size = new System.Drawing.Size(196, 25);
            this.CityInput.TabIndex = 27;
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.City.ForeColor = System.Drawing.Color.DarkRed;
            this.City.Location = new System.Drawing.Point(70, 332);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(60, 19);
            this.City.TabIndex = 26;
            this.City.Text = "Cidade:";
            // 
            // CEP
            // 
            this.CEP.AutoSize = true;
            this.CEP.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.CEP.ForeColor = System.Drawing.Color.DarkRed;
            this.CEP.Location = new System.Drawing.Point(379, 329);
            this.CEP.Name = "CEP";
            this.CEP.Size = new System.Drawing.Size(39, 19);
            this.CEP.TabIndex = 24;
            this.CEP.Text = "CEP:";
            // 
            // States
            // 
            this.States.AutoSize = true;
            this.States.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.States.ForeColor = System.Drawing.Color.DarkRed;
            this.States.Location = new System.Drawing.Point(70, 375);
            this.States.Name = "States";
            this.States.Size = new System.Drawing.Size(30, 19);
            this.States.TabIndex = 28;
            this.States.Text = "UF:";
            // 
            // statesOption
            // 
            this.statesOption.Enabled = false;
            this.statesOption.FormattingEnabled = true;
            this.statesOption.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "MG",
            "RS"});
            this.statesOption.Location = new System.Drawing.Point(136, 372);
            this.statesOption.Name = "statesOption";
            this.statesOption.Size = new System.Drawing.Size(42, 21);
            this.statesOption.TabIndex = 29;
            // 
            // peopleOption
            // 
            this.peopleOption.Enabled = false;
            this.peopleOption.FormattingEnabled = true;
            this.peopleOption.Items.AddRange(new object[] {
            "juridica",
            "fisica"});
            this.peopleOption.Location = new System.Drawing.Point(136, 187);
            this.peopleOption.Name = "peopleOption";
            this.peopleOption.Size = new System.Drawing.Size(196, 21);
            this.peopleOption.TabIndex = 30;
            this.peopleOption.SelectedIndexChanged += new System.EventHandler(this.peopleOption_SelectedIndexChanged);
            // 
            // dataView
            // 
            this.dataView.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataView.GridColor = System.Drawing.Color.DarkRed;
            this.dataView.Location = new System.Drawing.Point(117, 525);
            this.dataView.MultiSelect = false;
            this.dataView.Name = "dataView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataView.Size = new System.Drawing.Size(429, 196);
            this.dataView.TabIndex = 33;
            // 
            // SearchInput
            // 
            this.SearchInput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.SearchInput.Location = new System.Drawing.Point(117, 473);
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Size = new System.Drawing.Size(429, 25);
            this.SearchInput.TabIndex = 31;
            this.SearchInput.TextChanged += new System.EventHandler(this.SearchInput_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.Search.ForeColor = System.Drawing.Color.DarkRed;
            this.Search.Location = new System.Drawing.Point(233, 432);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(201, 25);
            this.Search.TabIndex = 32;
            this.Search.Text = "Pesquisar por cliente";
            // 
            // cnpj
            // 
            this.cnpj.AutoSize = true;
            this.cnpj.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.cnpj.ForeColor = System.Drawing.Color.DarkRed;
            this.cnpj.Location = new System.Drawing.Point(369, 183);
            this.cnpj.Name = "cnpj";
            this.cnpj.Size = new System.Drawing.Size(48, 19);
            this.cnpj.TabIndex = 34;
            this.cnpj.Text = "CNPJ:";
            // 
            // mskPhone
            // 
            this.mskPhone.Enabled = false;
            this.mskPhone.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.mskPhone.ForeColor = System.Drawing.Color.Black;
            this.mskPhone.Location = new System.Drawing.Point(422, 138);
            this.mskPhone.Mask = "(00)00000-0000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(207, 25);
            this.mskPhone.TabIndex = 36;
            // 
            // mskCPF
            // 
            this.mskCPF.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.mskCPF.Location = new System.Drawing.Point(423, 183);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(206, 25);
            this.mskCPF.TabIndex = 37;
            this.mskCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCPF_MaskInputRejected);
            // 
            // mskCNPJ
            // 
            this.mskCNPJ.Enabled = false;
            this.mskCNPJ.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.mskCNPJ.Location = new System.Drawing.Point(422, 185);
            this.mskCNPJ.Mask = "00,000,000/0000-00";
            this.mskCNPJ.Name = "mskCNPJ";
            this.mskCNPJ.Size = new System.Drawing.Size(206, 25);
            this.mskCNPJ.TabIndex = 38;
            // 
            // mskCEP
            // 
            this.mskCEP.Enabled = false;
            this.mskCEP.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.mskCEP.Location = new System.Drawing.Point(423, 329);
            this.mskCEP.Mask = "00000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(206, 25);
            this.mskCEP.TabIndex = 39;
            // 
            // ClientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.mskCEP);
            this.Controls.Add(this.mskCNPJ);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.mskPhone);
            this.Controls.Add(this.cnpj);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.SearchInput);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.peopleOption);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.statesOption);
            this.Controls.Add(this.status);
            this.Controls.Add(this.States);
            this.Controls.Add(this.CityInput);
            this.Controls.Add(this.City);
            this.Controls.Add(this.CEP);
            this.Controls.Add(this.ComplementoInput);
            this.Controls.Add(this.Complemento);
            this.Controls.Add(this.BairroInput);
            this.Controls.Add(this.Bairro);
            this.Controls.Add(this.Person);
            this.Controls.Add(this.logradouroInput);
            this.Controls.Add(this.logradouro);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ClientTitle);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.NameInput);
            this.Name = "ClientControl";
            this.Size = new System.Drawing.Size(960, 739);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton btnOff;
        private System.Windows.Forms.RadioButton btnOn;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label NameInput;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label ClientTitle;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.TextBox logradouroInput;
        private System.Windows.Forms.Label logradouro;
        private System.Windows.Forms.Label Person;
        private System.Windows.Forms.TextBox ComplementoInput;
        private System.Windows.Forms.Label Complemento;
        private System.Windows.Forms.TextBox BairroInput;
        private System.Windows.Forms.Label Bairro;
        private System.Windows.Forms.TextBox CityInput;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label CEP;
        private System.Windows.Forms.Label States;
        private System.Windows.Forms.ComboBox statesOption;
        private System.Windows.Forms.ComboBox peopleOption;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.TextBox SearchInput;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Label cnpj;
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.MaskedTextBox mskCNPJ;
        private System.Windows.Forms.MaskedTextBox mskCEP;
    }
}
