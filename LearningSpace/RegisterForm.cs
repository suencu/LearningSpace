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
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        string HexColorForFontText = "#352c3c";
        Color TextBoxColor;
        string HexColorForFontTextEror = "#ce2d30";
        Color TextBoxColorEror;

        //=========================
        public RegisterForm()
        {
            InitializeComponent();
            passwordStub();
            InitialTextBox();
            dataBase = new DataBase();
            adapter = new MySqlDataAdapter();
            dataTable = new DataTable();
            TextBoxColor = ColorTranslator.FromHtml(HexColorForFontText);
            TextBoxColorEror = ColorTranslator.FromHtml(HexColorForFontTextEror);

            
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
            
            if (checkEnteredDate())
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
            if (loginBox.Text == null || passwordBox.Text == null || checkPasswordBox.Text == null || loginBox.Text == "Login" || passwordBox.Text == "Password" || checkPasswordBox.Text == "Confirm password")
            {

                OpenRegisterForm();
                return true;
            }
            else if (passwordBox.Text != checkPasswordBox.Text)
            {

                OpenRegisterForm();
                return true;
            }

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @login", dataBase.GetMySqlConnection());
            command1.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginBox.Text;

            adapter.SelectCommand = command1;
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("This login already exists, enter another Login.");
                return true;
            }
            else
            {
                return false;
            }
        }
        private void GoToAuthorization(object sender, EventArgs e)
        {
            thread = new Thread(OpenAuthorizationForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            Close();
        }
        private void OpenNewForm()
        {
            Application.Run(new MenuForm());
        }
        private void OpenAuthorizationForm()
        {
            Application.Run(new AuthorizationForm());
        }
        private void OpenRegisterForm()
        {
            UpdateForm();
        }
        private void UpdateForm()
        {
            loginBox.Text = "Login";
            loginBox.ForeColor = TextBoxColorEror;

            passwordBox.PasswordChar = '\0';
            passwordBox.Text = "Password";
            passwordBox.ForeColor = TextBoxColorEror;

            checkPasswordBox.PasswordChar = '\0';
            checkPasswordBox.Text = "Confirm password";
            checkPasswordBox.ForeColor = TextBoxColorEror;
        }
        //работа с формами 
        
        private void passwordStub()
        {
            passwordBox.Text = "Password";
            passwordBox.ForeColor = TextBoxColor;

            passwordBox.AutoSize = false;
            passwordBox.Size = new Size(this.passwordBox.Size.Width, 40);

            checkPasswordBox.Text = "Confirm password";
            checkPasswordBox.ForeColor = TextBoxColor;

            checkPasswordBox.AutoSize = false;
            checkPasswordBox.Size = new Size(this.passwordBox.Size.Width, 40);
        }

        //работа с textBox
        private void InitialTextBox()
        {
            loginBox.Text = "Login";
            loginBox.ForeColor = TextBoxColor;

            passwordBox.Text = "Password";
            passwordBox.ForeColor = TextBoxColor;

            checkPasswordBox.Text = "Confirm password";
            checkPasswordBox.ForeColor = TextBoxColor;

        }
        private void loginBox_Enter(object sender, EventArgs e)
        {
            if (loginBox.Text == "Login")
            {
                loginBox.Text = "";
                loginBox.ForeColor = TextBoxColor;
            }
        }
        private void loginBox_Leave(object sender, EventArgs e)
        {
            if (loginBox.Text == "")
            {
                loginBox.Text = "Login";
                loginBox.ForeColor = TextBoxColor;
            }
        }
        private void passwordBox_Enter(object sender, EventArgs e)
        {
            if (passwordBox.Text == "Password")
            {
                passwordBox.PasswordChar = '•';
                passwordBox.Text = "";
                passwordBox.ForeColor = TextBoxColor;
            }
        }
        private void passwordBox_Leave(object sender, EventArgs e)
        {
            if (passwordBox.Text == "")
            {
                passwordBox.PasswordChar = '\0';
                passwordBox.Text = "Password";
                passwordBox.ForeColor = TextBoxColor;
            }
        }
        private void checkPasswordBox_Leave(object sender, EventArgs e)
        {
            if (checkPasswordBox.Text == "")
            {
                checkPasswordBox.PasswordChar = '\0';
                checkPasswordBox.Text = "Confirm password";
                checkPasswordBox.ForeColor = TextBoxColor;
            }
        }
        private void checkPasswordBox_Enter(object sender, EventArgs e)
        {
            if (checkPasswordBox.Text == "Confirm password")
            { 
                checkPasswordBox.PasswordChar = '•';
                checkPasswordBox.Text = "";
                checkPasswordBox.ForeColor = TextBoxColor;
            }
        }
        //движение формы
        private void RegisterForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point point = PointToScreen(e.Location);
                Location = new Point(point.X - this.startPoint.X, point.Y - this.startPoint.Y);
            }
        }
        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point point = PointToScreen(e.Location);
                Location = new Point(point.X - this.startPoint.X, point.Y - this.startPoint.Y);
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void buttonForIgor_Click(object sender, EventArgs e)
        {
            thread = new Thread(OpenNewForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            Close();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBoxForPassword_Click(object sender, EventArgs e)
        {
            if (checkBoxForPassword.Checked)
            {
                passwordBox.PasswordChar = '\0';
                checkPasswordBox.PasswordChar = '\0';
            }
            else
            {
                if(passwordBox.Text == "Password")
                {
                    passwordBox.PasswordChar = '\0';
                }
                else if(checkPasswordBox.Text == "Confirm passwor")
                {
                    checkPasswordBox.PasswordChar = '\0';
                }
                else
                { 
                    passwordBox.PasswordChar = '•';
                    checkPasswordBox.PasswordChar = '•';
                }
            }
        }
    }
}
