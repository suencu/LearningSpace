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
    public partial class MenuForm : Form
    {
        Thread th;
        private bool dragging = false;
        private Point startPoint = new Point(0,0);
        string HexColorForPicterBox = "#3e3c55";
        Color PicterBoxChangeColor;
        public MenuForm()
        {
            InitializeComponent();

            PicterBoxChangeColor = ColorTranslator.FromHtml(HexColorForPicterBox);
        }

        private void buttonNodes_Click(object sender, EventArgs e)
        {
            th = new Thread(OpenNodesForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            Close();

        }
        private void buttonTestMenu_Click(object sender, EventArgs e)
        {
            th = new Thread(OpenTestMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            Close();
        }

        #region открыть закрыть расширить FormMenu

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxMaximaze_Click(object sender, EventArgs e)
        {
            if(WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        #endregion





        /// что надо открыть 
        private void OpenNodesForm()
        {
            Application.Run(new Nodes());
        }
        private void OpenTestMenu()
        {
            Application.Run(new TestMenuForm());
        }

        private void pictureBoxClose_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            pictureBoxClose.BackColor = PicterBoxChangeColor;
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
    }
}
