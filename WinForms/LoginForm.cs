using MySql.Data.MySqlClient;
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

            loginText.Text = "Login";
            loginText.ForeColor = Color.Gray;

        }



        private void enterButton(object sender, EventArgs e)
        {
            string loginUser = loginText.Text;
            string passUser = passwordText.Text;

            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `login` WHERE `username` = @lU AND `userpassword` = @pU ", db.GetConnection());//sql команда и к какой бд подключаемся

            command.Parameters.Add("@lU", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@pU", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;//выполняем команду(comand)
            adapter.Fill(table);//записываем в table

            if (table.Rows.Count > 0) //если запись есть значит авторизован
            {
                MessageBox.Show("Sucsessfull");
            }
            else
            {
                MessageBox.Show("Error");
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


        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        private void loginText_MouseEnter(object sender, EventArgs e)
        {
            informationText.Text = "Input name";
        }

        private void passwordText_MouseEnter(object sender, EventArgs e)
        {
            informationText.Text = "input password";
        }

        private void crossRegistration_Click(object sender, EventArgs e)
        {

        }

        private void loginText_Enter(object sender, EventArgs e)
        {
            if (loginText.Text == "Login")
            {
                loginText.Text = null;
                loginText.ForeColor = Color.Black;
            }
        }

        private void loginText_Leave(object sender, EventArgs e)
        {
            if (loginText.Text == "")
                loginText.Text = "Login";
        }

        private void crossRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegistrationForms registDorm = new RegistrationForms();
            registDorm.Show();
        }
    }
}
