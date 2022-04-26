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
    public partial class MainForm : Form
    {
        Thread thread;
        public MainForm()
        {
            InitializeComponent();
            passwordBox.PasswordChar = '•';
            passwordBox.AutoSize = false;
            passwordBox.Size = new Size(this.passwordBox.Size.Width, 40);
            
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
            button1.Location = new Point(0, 0);
        }

        private void CloseApp(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimizeAdd(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
