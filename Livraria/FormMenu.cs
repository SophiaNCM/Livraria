using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            employeeControl1.Visible = false;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            
            if (employeeControl1.Visible == false){ employeeControl1.Visible = true;}else{ employeeControl1.Visible = false;}
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login screnLogin = new Login();
            this.Hide();
            screnLogin.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            userOutput.Text = Login.user;

        }
    }
}
