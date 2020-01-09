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
    public partial class RegistrationForms : Form
    {
        public RegistrationForms()
        {
            InitializeComponent();

            loginText.Text = "Login";
            loginText.ForeColor = Color.Gray;
        }

        private void RegistrationForms_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if (loginText.Text == "Login") 
            {
                MessageBox.Show("Input Login");
                return;
            }

            if (passwordText.Text == "")
            {
                MessageBox.Show("Input password");
                return;
            }

            if (confirmPassText.Text == "")
            {
                MessageBox.Show("Confirm password");
                return;
            }

            if(passwordText.Text != confirmPassText.Text)
            {
                MessageBox.Show("Password don`t match ");
                return;
            }

            if (isUserExists() == true)
                return;

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `login` (`username`, `userpassword`) VALUES (@login , @password) ", db.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginText.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passwordText.Text;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)//если команда которую мы вполняем прошла успешна то ...
            {
                MessageBox.Show("Account was created");
            }
            else
                MessageBox.Show("Account wasn`t created");

            db.CloseConnection();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmPassText_MouseEnter(object sender, EventArgs e)
        {
            informationText.Text = "Confirm your password";
        }

        private void passwordText_MouseEnter(object sender, EventArgs e)
        {
            informationText.Text = "Input your password";
        }

        private void loginText_MouseEnter(object sender, EventArgs e)
        {
            informationText.Text = "Input your Name";
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            informationText.Text = "Do You want close the window";
        }

        Point lastpoint;


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
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
            if(loginText.Text == "")
            {
                loginText.Text = "Name";
            }
        }

        public Boolean isUserExists()
        {
            DataBase db = new DataBase();// create instance db
            DataTable table = new DataTable();//create instance table бд
            MySqlDataAdapter adapter = new MySqlDataAdapter();// need for execute command(request)

            MySqlCommand command = new MySqlCommand("SELECT * FROM `login` WHERE `username` = @log ", db.GetConnection());
            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = loginText.Text;

            adapter.SelectCommand = command;//execute command
            adapter.Fill(table);//write into table

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Accout with this login already exists");
                return true;
            }
            else
                return false;


        }
    }
}
