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
        #region -- Переменные --
        //для перехода между Формами
        Thread th;
        //для движение Формой
        private bool dragging = false;
        private Point startPoint = new Point(0,0);
        //Цвет
        string HexColorForPicterBox = "#3e3c55";
        Color PicterBoxChangeColor;
        #endregion

        public MenuForm()
        {
            InitializeComponent();

            //установка цвета
            PicterBoxChangeColor = ColorTranslator.FromHtml(HexColorForPicterBox);
        }

        #region -- Нажатие на обйекты --
        //Button
        private void buttonNodes_Click(object sender, EventArgs e)
        {
            th = new Thread(OpenNodesForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            Close();

        }
      
        private void buttonCalender_Click(object sender, EventArgs e)
        {
            th = new Thread(OpenNewNodes);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            Close();
        }
        private void buttonWeather_Click(object sender, EventArgs e)
        {
            th = new Thread(OpenWeatherForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            Close();
        }

        //picterBox
        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pictureBoxClose_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        #endregion

        #region -- Загрузка форм --
        private void OpenNodesForm()
        {
            Application.Run(new Nodes());
        }
   
        private void OpenNewNodes()
        {
            Application.Run(new Calendar());
        }
        private void OpenWeatherForm()
        {
            Application.Run(new WeatherForm());
        }
        #endregion

        #region -- Движение формой --
        //panel
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
        //Form
        private void MenuForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point point = PointToScreen(e.Location);
                Location = new Point(point.X - this.startPoint.X, point.Y - this.startPoint.Y);
            }
        }

        private void MenuForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void MenuForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

      
    }
}
