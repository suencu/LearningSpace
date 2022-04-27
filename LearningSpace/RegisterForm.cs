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
    public partial class RegisterForm : Form
    {
        //переменные для проекта

        Point movePoint;
        Thread thread;
        DataBase dataBase;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable dataTable;
        
        //=========================
        public RegisterForm()
        {
            InitializeComponent();
            passwordStub();
            InitialTextBox();
            dataBase = new DataBase();
            adapter = new MySqlDataAdapter();
            dataTable = new DataTable();
        }
        //нажатие на кнопки 
        private void CloseMenu(object sender, EventArgs e)
        {
            Close();
        }
        private void MinimizeAdd(object sender, EventArgs e)
        {
             this.WindowState = FormWindowState.Minimized;
        }
        private void GoToMenu(object sender, EventArgs e)
        {
            if (loginBox.Text == null || passwordBox.Text == null || checkPasswordBox.Text == null || loginBox.Text == "Login" || passwordBox.Text == "Password" || checkPasswordBox.Text == "Confirm password")
            {
                MessageBox.Show("Некоректрые данные");
                OpenRegisterForm();
                return;
            }
            else if (passwordBox.Text != checkPasswordBox.Text)
            {
                MessageBox.Show("Некоректрые данные");

                OpenRegisterForm();
                return;
            }
            else if (checkEnteredDate())
            {
                MessageBox.Show("Некоректрые данные");

                OpenRegisterForm();
                return;
            }

            command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `confirmPassword`) VALUES (@login, @password, @confirmPassword)" , dataBase.GetMySqlConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginBox.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passwordBox.Text;
            command.Parameters.Add("@confirmPassword", MySqlDbType.VarChar).Value = checkPasswordBox.Text;

            dataBase.OpenConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Вы зашли в систему");

                thread = new Thread(OpenNewForm);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                Close();
            }
            else
            {
                MessageBox.Show("Некоректрые данные");
            }

            dataBase.CloseConnection();
        }
        public bool checkEnteredDate()
        {
            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @login", dataBase.GetMySqlConnection());
            command1.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginBox.Text;

            adapter.SelectCommand = command1;
            adapter.Fill(dataTable);

            if(dataTable.Rows.Count > 0)
            {
                MessageBox.Show("This login already exists, enter another Login.");
                return true;
            }
            else
            {
                return false;
            }
        }
        private void OpenNewForm()
        {
            Application.Run(new MenuForm());
        }
        private void OpenRegisterForm()
        {
            //Application.Run(new RegisterForm());
            
            Update1();
            Update();
        }
        private void Update1()
        {
            loginBox.Text = "Login";
            loginBox.ForeColor = Color.Red;

            passwordBox.PasswordChar = '\0';
            passwordBox.Text = "Password";
            passwordBox.ForeColor = Color.Red;

            checkPasswordBox.PasswordChar = '\0';
            checkPasswordBox.Text = "Confirm password";
            checkPasswordBox.ForeColor = Color.Red;
        }
        //работа с формами 
        private void MoveForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - movePoint.X;
                this.Top += e.Y - movePoint.Y;
            }
        }
        private void passwordStub()
        {
            passwordBox.Text = "Password";
            passwordBox.ForeColor = Color.Gray;

            passwordBox.AutoSize = false;
            passwordBox.Size = new Size(this.passwordBox.Size.Width, 40);

            checkPasswordBox.Text = "Confirm password";
            checkPasswordBox.ForeColor = Color.Gray;

            checkPasswordBox.AutoSize = false;
            checkPasswordBox.Size = new Size(this.passwordBox.Size.Width, 40);
        }

        //работа с textBox
        private void InitialTextBox()
        {
            loginBox.Text = "Login";
            loginBox.ForeColor = Color.Gray;
            passwordBox.Text = "Password";
            checkPasswordBox.Text = "Confirm password";
        }
        private void loginBox_Enter(object sender, EventArgs e)
        {
            if(loginBox.Text == "Login")
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
        private void checkPasswordBox_Leave(object sender, EventArgs e)
        {
            if (checkPasswordBox.Text == "")
            {
                checkPasswordBox.PasswordChar = '\0'; 
                checkPasswordBox.Text = "Confirm password";
                checkPasswordBox.ForeColor = Color.Gray;
            }
        }
        private void checkPasswordBox_Enter(object sender, EventArgs e)
        {
            if (checkPasswordBox.Text == "Confirm password")
            {
                checkPasswordBox.PasswordChar = '•';
                checkPasswordBox.Text = "";
                checkPasswordBox.ForeColor = Color.Black;
            }
        }
    }
}
