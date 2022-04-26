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

        //=========================
        public RegisterForm()
        {
            InitializeComponent();
            passwordStub();
            InitialTextBox();
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
            thread = new Thread(OpenNewForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            Close();
        }
        private void OpenNewForm()
        {
            Application.Run(new MenuForm());
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
