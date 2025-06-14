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
            phoneControl1.Visible = false;
            bookControl1.Visible = false;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {

            if (clientControl1.Visible == true || phoneControl1.Visible == true || bookControl1.Visible == true)
            {
                btnPhone.BackColor = Color.DarkRed;
                phoneControl1.Visible = false;
                phoneControl1.Enabled = false;

                btnClient.BackColor = Color.DarkRed;
                clientControl1.Visible = false;
                clientControl1.Enabled = false;

                btnBook.BackColor = Color.DarkRed;
                bookControl1.Enabled = false;
                bookControl1.Visible = false;
            }
            if (employeeControl1.Visible == false)
            {
                btnEmployee.BackColor = Color.Maroon;
                employeeControl1.Visible = true;
                employeeControl1.Enabled = true;
            }
            else
            {
                btnEmployee.BackColor = Color.DarkRed;
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
                btnPhone.BackColor = Color.DarkRed;
                phoneControl1.Visible = false;
                phoneControl1.Enabled = false;

                btnEmployee.BackColor = Color.DarkRed;
                employeeControl1.Visible = false;
                employeeControl1.Enabled = false;

                btnBook.BackColor = Color.DarkRed;
                bookControl1.Enabled = false;
                bookControl1.Visible = false;
            }
            if (clientControl1.Visible == false) 
            {
                btnClient.BackColor = Color.Maroon;
                clientControl1.Visible = true; 
                clientControl1.Enabled = true;
            } else 
            { 
                btnClient.BackColor = Color.DarkRed;
                clientControl1.Visible = false;
                clientControl1.Enabled = false;
            }
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            if (employeeControl1.Visible == true || clientControl1.Visible == true || bookControl1.Visible == true)
            {
                btnClient.BackColor= Color.DarkRed;
                clientControl1.Visible = false;
                clientControl1.Enabled = false;

                btnEmployee.BackColor = Color.DarkRed;
                employeeControl1.Visible = false;
                employeeControl1.Enabled = false;

                btnBook.BackColor = Color.DarkRed;
                bookControl1.Enabled = false;
                bookControl1.Visible = false;
            }
            if (phoneControl1.Visible == false)
            {
                btnPhone.BackColor = Color.Maroon;
                phoneControl1.Visible = true;
                phoneControl1.Enabled = true;
            }
            else
            {
                btnPhone.BackColor= Color.DarkRed;
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
                btnClient.BackColor = Color.DarkRed;
                clientControl1.Visible = false;
                clientControl1.Enabled = false;

                btnEmployee.BackColor = Color.DarkRed;
                employeeControl1.Visible = false;
                employeeControl1.Enabled = false;
                btnPhone.BackColor = Color.DarkRed;
                phoneControl1.Visible=false;
                phoneControl1.Enabled=false;
            }
            if (bookControl1.Visible == false)
            {
                btnBook.BackColor = Color.Maroon;
                bookControl1.Visible = true;
                bookControl1.Enabled = true;
            }
            else
            {
                btnBook.BackColor = Color.DarkRed;
                bookControl1.Visible = false;
                bookControl1.Enabled = false;
            }
        }
    }
}
