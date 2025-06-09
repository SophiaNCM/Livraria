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
            clientControl1.Visible = false;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {

            if (clientControl1.Visible == true || phoneControl1.Visible == true || bookControl1.Visible == true)
            {
                phoneControl1.Visible = false;
                phoneControl1.Enabled = false;
                clientControl1.Visible = false;
                clientControl1.Enabled = false;
                bookControl1.Enabled = false;
                bookControl1.Visible = false;
            }
            if (employeeControl1.Visible == false)
            {
                employeeControl1.Visible = true;
                employeeControl1.Enabled = true;
            }
            else
            {
                employeeControl1.Visible = false;
                employeeControl1.Enabled = false;
            }
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

        private void btnClient_Click(object sender, EventArgs e)
        {
            if (employeeControl1.Visible == true || phoneControl1.Visible == true || bookControl1.Visible == true)
            {
                phoneControl1.Visible = false;
                phoneControl1.Enabled = false;
                employeeControl1.Visible = false;
                employeeControl1.Enabled = false;
                bookControl1.Enabled = false;
                bookControl1.Visible = false;
            }
            if (clientControl1.Visible == false) 
            { 
                clientControl1.Visible = true; 
                clientControl1.Enabled = true;
            } else 
            { 
                clientControl1.Visible = false;
                clientControl1.Enabled = false;
            }
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            if (employeeControl1.Visible == true || clientControl1.Visible == true || bookControl1.Visible == true)
            {
                clientControl1.Visible = false;
                clientControl1.Enabled = false;
                employeeControl1.Visible = false;
                employeeControl1.Enabled = false;
                bookControl1.Enabled = false;
                bookControl1.Visible = false;
            }
            if (phoneControl1.Visible == false)
            {
                phoneControl1.Visible = true;
                phoneControl1.Enabled = true;
            }
            else
            {
                phoneControl1.Visible = false;
                phoneControl1.Enabled = false;
            }
        }

        private void phoneControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (employeeControl1.Visible == true || clientControl1.Visible == true || phoneControl1.Visible == true)
            {
                clientControl1.Visible = false;
                clientControl1.Enabled = false;
                employeeControl1.Visible = false;
                employeeControl1.Enabled = false;
                phoneControl1.Visible=false;
                phoneControl1.Enabled=false;
            }
            if (bookControl1.Visible == false)
            {
                bookControl1.Visible = true;
                bookControl1.Enabled = true;
            }
            else
            {
                bookControl1.Visible = false;
                bookControl1.Enabled = false;
            }
        }
    }
}
