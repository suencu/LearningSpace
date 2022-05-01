using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningSpace
{
    public partial class Calendar : Form
    {
        #region Переменные

        
        int month, year;
        public static string static_month, static_year;
        Thread th;
        #endregion
        #region Окно календаря 
        public Calendar(  )
        {
            InitializeComponent();
        }
        #endregion
        #region Кнопка "Назад в меню"
        private void buttonBackToMenu_Click(object sender, EventArgs e)
        {
            th = new Thread(openBackMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            Close();
        }
        private void openBackMenu()
        {
            Application.Run(new MenuForm());
        }
        #endregion
        #region Кнопки "Закрыть,свернуть"
        private void pictureBoxClose_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
        private void MinimizeAdd(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        #region Основная логика календаря
        private void NewNodes_Load(object sender, EventArgs e)
        {
            displaDays(); //Показываем дни в календаре 
        }

        private void displaDays()
        {
            DateTime now = DateTime.Now; // Берем текущий месяц и год 

            month = now.Month;

            year = now.Year;

            DisplayCalendar(month, year);//Отображаем дни 
        }
        #endregion
        #region Кнопки управления "Следующий и предыдущий месяц" 
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            month--; //Попытка написать что-то самому
            if (month == 0)
            {
                month = 12;
                year--;
            }
            DisplayCalendar(month, year);//Отображаем дни
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            month++; //Попытка написать что-то самому №2
            if (month == 13) 
            {
                month = 1;
                year++;
            }
            DisplayCalendar(month, year);//Отображаем дни
        }
        #endregion
        #region Отображаем дни, меняем месяца,года 
        private void DisplayCalendar(int _month,int _year)
        {
            static_month = (Convert.ToString(_month)); // Делаем статик месяц и год (нужно для EventForm)
            static_year = (Convert.ToString(_year));
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(_month); //Берем месяц и год(пихаем в LBDATE)
            LBDATE.Text = monthName + " " + _year;
            DateTime statrtOfTheMonth = new DateTime(_year, _month, 1); // Задаем месяц, год, день

            int days = DateTime.DaysInMonth(_year, _month); // Узнаем сколько дней в нужном месяце 

            int dayOfTheWeek = Convert.ToInt32(statrtOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfTheWeek; i++) //Добавляем дни в календарь
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                daycontainer.Controls.Add(userControlBlank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays userControlDays = new UserControlDays();
                userControlDays.days(i);   //days берем из UsrControlDays
                daycontainer.Controls.Add(userControlDays);
            }
        }
        #endregion
    }
}
