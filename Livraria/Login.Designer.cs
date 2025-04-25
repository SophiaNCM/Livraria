namespace Livraria
{
    partial class Login
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.Dev = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.Nametext = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.PasswordIput = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.enter = new System.Windows.Forms.Button();
            this.errorLogin = new System.Windows.Forms.Label();
            this.errorPassword = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.Dev);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 480);
            this.panel1.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.Image = global::Livraria.Properties.Resources.e_book;
            this.logo.Location = new System.Drawing.Point(64, 39);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(137, 133);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 10;
            this.logo.TabStop = false;
            // 
            // Dev
            // 
            this.Dev.AutoSize = true;
            this.Dev.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Dev.ForeColor = System.Drawing.Color.White;
            this.Dev.Location = new System.Drawing.Point(42, 401);
            this.Dev.Name = "Dev";
            this.Dev.Size = new System.Drawing.Size(233, 19);
            this.Dev.TabIndex = 9;
            this.Dev.Text = "Desenvolvido por: Sophia Nicole";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DarkRed;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exit.Location = new System.Drawing.Point(597, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(31, 32);
            this.exit.TabIndex = 1;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Nametext
            // 
            this.Nametext.AutoSize = true;
            this.Nametext.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Nametext.ForeColor = System.Drawing.Color.DarkRed;
            this.Nametext.Location = new System.Drawing.Point(297, 310);
            this.Nametext.Name = "Nametext";
            this.Nametext.Size = new System.Drawing.Size(54, 19);
            this.Nametext.TabIndex = 2;
            this.Nametext.Text = "Nome:";
            // 
            // NameInput
            // 
            this.NameInput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.NameInput.Location = new System.Drawing.Point(357, 310);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(214, 25);
            this.NameInput.TabIndex = 3;
            this.NameInput.TextChanged += new System.EventHandler(this.NameInput_TextChanged);
            // 
            // PasswordIput
            // 
            this.PasswordIput.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.PasswordIput.Location = new System.Drawing.Point(357, 365);
            this.PasswordIput.MaxLength = 8;
            this.PasswordIput.Name = "PasswordIput";
            this.PasswordIput.PasswordChar = '.';
            this.PasswordIput.Size = new System.Drawing.Size(214, 25);
            this.PasswordIput.TabIndex = 5;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Password.ForeColor = System.Drawing.Color.DarkRed;
            this.Password.Location = new System.Drawing.Point(297, 365);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(54, 19);
            this.Password.TabIndex = 4;
            this.Password.Text = "Senha:";
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.DarkRed;
            this.enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.enter.ForeColor = System.Drawing.Color.Transparent;
            this.enter.Location = new System.Drawing.Point(301, 401);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 28);
            this.enter.TabIndex = 6;
            this.enter.Text = "entrar";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // errorLogin
            // 
            this.errorLogin.AutoSize = true;
            this.errorLogin.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.errorLogin.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLogin.Location = new System.Drawing.Point(297, 284);
            this.errorLogin.Name = "errorLogin";
            this.errorLogin.Size = new System.Drawing.Size(0, 19);
            this.errorLogin.TabIndex = 7;
            // 
            // errorPassword
            // 
            this.errorPassword.AutoSize = true;
            this.errorPassword.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.errorPassword.ForeColor = System.Drawing.Color.DarkRed;
            this.errorPassword.Location = new System.Drawing.Point(297, 346);
            this.errorPassword.Name = "errorPassword";
            this.errorPassword.Size = new System.Drawing.Size(0, 19);
            this.errorPassword.TabIndex = 8;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.errorPassword);
            this.Controls.Add(this.errorLogin);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.PasswordIput);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.Nametext);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label Nametext;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox PasswordIput;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Label errorLogin;
        private System.Windows.Forms.Label errorPassword;
        private System.Windows.Forms.Label Dev;
        private System.Windows.Forms.PictureBox logo;
    }
}

