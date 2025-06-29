﻿namespace Livraria
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.User = new System.Windows.Forms.Label();
            this.userOutput = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnWriter = new System.Windows.Forms.Button();
            this.btnPublisher = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnPhone = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.publisherControl1 = new Livraria.PublisherControl();
            this.bookControl1 = new Livraria.BookControl();
            this.phoneControl1 = new Livraria.PhoneControl();
            this.clientControl1 = new Livraria.ClientControl();
            this.employeeControl1 = new Livraria.EmployeeControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.User);
            this.panel1.Controls.Add(this.userOutput);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.btnWriter);
            this.panel1.Controls.Add(this.btnPublisher);
            this.panel1.Controls.Add(this.btnCategory);
            this.panel1.Controls.Add(this.btnBook);
            this.panel1.Controls.Add(this.btnPhone);
            this.panel1.Controls.Add(this.btnClient);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 739);
            this.panel1.TabIndex = 0;
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.User.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.User.Location = new System.Drawing.Point(8, 693);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(162, 21);
            this.User.TabIndex = 12;
            this.User.Text = "Funcionario logado:";
            // 
            // userOutput
            // 
            this.userOutput.AutoSize = true;
            this.userOutput.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.userOutput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userOutput.Location = new System.Drawing.Point(176, 693);
            this.userOutput.Name = "userOutput";
            this.userOutput.Size = new System.Drawing.Size(0, 21);
            this.userOutput.TabIndex = 11;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(-9, 594);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(329, 42);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.DarkRed;
            this.btnPay.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPay.Location = new System.Drawing.Point(-9, 546);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(329, 42);
            this.btnPay.TabIndex = 9;
            this.btnPay.Text = "Caixa";
            this.btnPay.UseVisualStyleBackColor = false;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.DarkRed;
            this.btnOrder.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOrder.Location = new System.Drawing.Point(-9, 498);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(329, 42);
            this.btnOrder.TabIndex = 8;
            this.btnOrder.Text = "Pedidos";
            this.btnOrder.UseVisualStyleBackColor = false;
            // 
            // btnWriter
            // 
            this.btnWriter.BackColor = System.Drawing.Color.DarkRed;
            this.btnWriter.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnWriter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnWriter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWriter.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWriter.Location = new System.Drawing.Point(-9, 450);
            this.btnWriter.Name = "btnWriter";
            this.btnWriter.Size = new System.Drawing.Size(329, 42);
            this.btnWriter.TabIndex = 7;
            this.btnWriter.Text = "Autores";
            this.btnWriter.UseVisualStyleBackColor = false;
            // 
            // btnPublisher
            // 
            this.btnPublisher.BackColor = System.Drawing.Color.DarkRed;
            this.btnPublisher.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnPublisher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublisher.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublisher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPublisher.Location = new System.Drawing.Point(-9, 402);
            this.btnPublisher.Name = "btnPublisher";
            this.btnPublisher.Size = new System.Drawing.Size(329, 42);
            this.btnPublisher.TabIndex = 6;
            this.btnPublisher.Text = "Editoras";
            this.btnPublisher.UseVisualStyleBackColor = false;
            this.btnPublisher.Click += new System.EventHandler(this.btnPublisher_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.DarkRed;
            this.btnCategory.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCategory.Location = new System.Drawing.Point(-9, 354);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(329, 42);
            this.btnCategory.TabIndex = 5;
            this.btnCategory.Text = "Categorias";
            this.btnCategory.UseVisualStyleBackColor = false;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.DarkRed;
            this.btnBook.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBook.Location = new System.Drawing.Point(-9, 306);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(329, 42);
            this.btnBook.TabIndex = 4;
            this.btnBook.Text = "Livros";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnPhone
            // 
            this.btnPhone.BackColor = System.Drawing.Color.DarkRed;
            this.btnPhone.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnPhone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhone.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPhone.Location = new System.Drawing.Point(-9, 258);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(329, 42);
            this.btnPhone.TabIndex = 3;
            this.btnPhone.Text = "Telefone";
            this.btnPhone.UseVisualStyleBackColor = false;
            this.btnPhone.Click += new System.EventHandler(this.btnPhone_Click);
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.DarkRed;
            this.btnClient.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClient.Location = new System.Drawing.Point(-9, 210);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(329, 42);
            this.btnClient.TabIndex = 2;
            this.btnClient.Text = "Cliente";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.DarkRed;
            this.btnEmployee.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEmployee.Location = new System.Drawing.Point(-9, 162);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(329, 42);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "Funcionario";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // logo
            // 
            this.logo.Image = global::Livraria.Properties.Resources.e_book;
            this.logo.Location = new System.Drawing.Point(73, 26);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(154, 130);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(1233, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // publisherControl1
            // 
            this.publisherControl1.BackColor = System.Drawing.Color.MistyRose;
            this.publisherControl1.Location = new System.Drawing.Point(320, 0);
            this.publisherControl1.Name = "publisherControl1";
            this.publisherControl1.Size = new System.Drawing.Size(960, 739);
            this.publisherControl1.TabIndex = 5;
            // 
            // bookControl1
            // 
            this.bookControl1.BackColor = System.Drawing.Color.MistyRose;
            this.bookControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookControl1.Location = new System.Drawing.Point(320, 0);
            this.bookControl1.Name = "bookControl1";
            this.bookControl1.Size = new System.Drawing.Size(960, 739);
            this.bookControl1.TabIndex = 4;
            // 
            // phoneControl1
            // 
            this.phoneControl1.BackColor = System.Drawing.Color.MistyRose;
            this.phoneControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneControl1.Location = new System.Drawing.Point(320, 0);
            this.phoneControl1.Name = "phoneControl1";
            this.phoneControl1.Size = new System.Drawing.Size(960, 739);
            this.phoneControl1.TabIndex = 3;
            this.phoneControl1.Load += new System.EventHandler(this.phoneControl1_Load);
            // 
            // clientControl1
            // 
            this.clientControl1.BackColor = System.Drawing.Color.MistyRose;
            this.clientControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientControl1.Enabled = false;
            this.clientControl1.Location = new System.Drawing.Point(320, 0);
            this.clientControl1.Name = "clientControl1";
            this.clientControl1.Size = new System.Drawing.Size(960, 739);
            this.clientControl1.TabIndex = 2;
            this.clientControl1.Visible = false;
            // 
            // employeeControl1
            // 
            this.employeeControl1.BackColor = System.Drawing.Color.MistyRose;
            this.employeeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeControl1.Location = new System.Drawing.Point(320, 0);
            this.employeeControl1.Name = "employeeControl1";
            this.employeeControl1.Size = new System.Drawing.Size(960, 739);
            this.employeeControl1.TabIndex = 1;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1280, 739);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.publisherControl1);
            this.Controls.Add(this.bookControl1);
            this.Controls.Add(this.phoneControl1);
            this.Controls.Add(this.clientControl1);
            this.Controls.Add(this.employeeControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnPhone;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnPublisher;
        private System.Windows.Forms.Button btnWriter;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label userOutput;
        private System.Windows.Forms.Label User;
        private EmployeeControl employeeControl1;
        private ClientControl clientControl1;
        private PhoneControl phoneControl1;
        private BookControl bookControl1;
        private PublisherControl publisherControl1;
        private System.Windows.Forms.Button btnClose;
    }
}