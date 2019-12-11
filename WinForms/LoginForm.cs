using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void enterButton(object sender, EventArgs e)
        {
            if(this.loginText.Text == "Hi" && this.passwordText.Text == "12345")
            {
                this.informationText.Text = "Perfect";
            }
            else
            {
                this.informationText.Text = "Error";
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            this.informationText.Text = "Do you want close the window?";
        }
    }
}
