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
        #region -- Переменные --
        //для перехода между Формами
        Thread thread;
        //для движения Формой
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        //цвет
        string HexColorForFontText= "#352c3c";
        Color TextBoxColor;
        string HexColorForFontTextEror= "#ce2d30";
        Color TextBoxColorEror;

        public static string login_user;

        #endregion

        public AuthorizationForm()
        {
            InitializeComponent();
            InitialTextBox();

            //установка цвета
            TextBoxColor = ColorTranslator.FromHtml(HexColorForFontText);
            TextBoxColorEror = ColorTranslator.FromHtml(HexColorForFontTextEror);

        }

        #region -- Нажатие на объекты --

        //button  
        private void GoToMenu(object sender, EventArgs e)
        {

            DataBase dataBase = new DataBase();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            //указываем команду которая относится к базе данных
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND  `password` = @uP", dataBase.GetMySqlConnection());
            //вместо заглушек указываем переменные
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginBox.Text;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordBox.Text;

            loginBox.Text = loginBox.Text;


            //выбираем коману и выполняем 
            dataAdapter.SelectCommand = command;

            //полученные данные помещаем в объект dataTable
            dataAdapter.Fill(dataTable);

            //проверяем ряды так как если пользователь есть то у него есть 3 ряд ID
            if (dataTable.Rows.Count > 0)
            {
                thread = new Thread(OpenMenuForm);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                Close();
            }
            else
            {
                MessageBox.Show("You're not in the database. ");
                UpdateAuthorizationForm();
            }

        }
        private void GoToRegister(object sender, EventArgs e)
        {
            thread = new Thread(OpenRegisterForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            Close();
        }
       
        //picterBox
        private void pictureBoxClose_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
        private void MinimizeAdd(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region -- Загрузка форм --
        private void UpdateAuthorizationForm()
        {
            loginBox.Text = "Login";
            loginBox.ForeColor = TextBoxColorEror;

            passwordBox.PasswordChar = '\0';
            passwordBox.Text = "Password";
            passwordBox.ForeColor = TextBoxColorEror;
        }
        private void OpenMenuForm()
        {
            Application.Run(new MenuForm());
        }
        private void OpenRegisterForm()
        {
            Application.Run(new RegisterForm());
        }

        #endregion

        #region -- Работа с textBox --
        private void InitialTextBox()
        {
            loginBox.Text = "Login";
            loginBox.ForeColor = TextBoxColor;
            passwordBox.Text = "Password";
            passwordBox.ForeColor = TextBoxColor;
        }
        private void loginBox_Enter(object sender, EventArgs e)
        {
            if (loginBox.Text == "Login")
            {
                loginBox.Text = null;
                loginBox.ForeColor = Color.Black;
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
                passwordBox.ForeColor = Color.Black;
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
        #endregion

        #region -- Движение Формой -- 

        //panel
        private void leftPanelMouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void leftPanelMouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point point = PointToScreen(e.Location);
                Location = new Point(point.X - this.startPoint.X, point.Y - this.startPoint.Y);
            }
        }

        private void leftPanelMouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        //form
        private void AuthorizationForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void AuthorizationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point point = PointToScreen(e.Location);
                Location = new Point(point.X - this.startPoint.X, point.Y - this.startPoint.Y);
            }
        }

        private void AuthorizationForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }


        #endregion

    }
}
