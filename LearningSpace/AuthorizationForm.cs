using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningSpace
{
    public partial class AuthorizationForm : Form
    {
        //переменные для проекта 
        Thread thread;
        Point movePoint;

        //==========================
        public AuthorizationForm()
        {
            InitializeComponent();
            passwordStub();
            InitialTextBox();
        }

        //нажатие на кнопки 
        private void GoToMenu(object sender, EventArgs e)
        {
            //получаем данные пользователя 
            string loginUser = loginBox.Text;
            string passwordUser = passwordBox.Text;

            DataBase dataBase = new DataBase();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            //указываем команду которая относится к базе данных
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND  `password` = @uP", dataBase.GetMySqlConnection());
            //вместо заглушек указываем переменные
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordUser;

            //выбираем коману и выполняем 
            dataAdapter.SelectCommand = command;

            //полученные данные помещаем в объект dataTable
            dataAdapter.Fill(dataTable);

            //проверяем ряды так как если пользователь есть то у него есть 3 ряд ID
            if (dataTable.Rows.Count > 0)
            {

                thread = new Thread(OpenNewForm);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                Close();
            }
            else
            {
                MessageBox.Show("You're not in the database. ");
            }


        }
        private void CloseApp(object sender, EventArgs e)
        {
            Close();
        }
        private void MinimizeAdd(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void GoToRegister(object sender, EventArgs e)
        {
            thread = new Thread(OpenRegisterForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            Close();
        }

        //работа с меню
        private void MoveForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - movePoint.X;
                this.Top += e.Y - movePoint.Y;
            }
        }
        private void OpenNewForm()
        {
            Application.Run(new MenuForm());
        }
        private void OpenRegisterForm()
        {
            Application.Run(new RegisterForm());
        }
        private void passwordStub()
        {
            passwordBox.Text = "Password";
            passwordBox.ForeColor = Color.Gray;

            passwordBox.AutoSize = false;
            passwordBox.Size = new Size(this.passwordBox.Size.Width, 40);

        }

        //работа с textBox
        private void InitialTextBox()
        {
            loginBox.Text = "Login";
            loginBox.ForeColor = Color.Gray;
            passwordBox.Text = "Password";
        }
        private void loginBox_Enter(object sender, EventArgs e)
        {
            if (loginBox.Text == "Login")
            {
                loginBox.Text = "";
                loginBox.ForeColor = Color.Black;
            }
        }
        private void loginBox_Leave(object sender, EventArgs e)
        {
            if (loginBox.Text == "")
            {
                loginBox.Text = "Login";
                loginBox.ForeColor = Color.Gray;
            }
        }
        private void passwordBox_Enter(object sender, EventArgs e)
        {
            if (passwordBox.Text == "Password")
            {
                passwordBox.PasswordChar = '•';
                passwordBox.Text = "";
                passwordBox.ForeColor = Color.Black;
            }
        }
        private void passwordBox_Leave(object sender, EventArgs e)
        {
            if (passwordBox.Text == "")
            {
                passwordBox.PasswordChar = '\0';
                passwordBox.Text = "Password";
                passwordBox.ForeColor = Color.Gray;
            }
        }
    }
}
