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
    public partial class NewNodes : Form
    {
        int month, year;
        Thread th;





        public NewNodes()
        {
            InitializeComponent();
        }

        private void buttonBackToNodes_Click(object sender, EventArgs e)
        {
            th = new Thread(openBackNotes);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            Close();
        }
        private void openBackNotes()
        {
            Application.Run(new Nodes());
        }

        private void NewNodes_Load(object sender, EventArgs e)
        {
            displaDays();
        }

        private void displaDays()
        {
            DateTime now = DateTime.Now;

            month = now.Month;

            year = now.Year;

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            LBDATE.Text = monthName + " " + year;
                

            DateTime statrtOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayOfTheWeek = Convert.ToInt32(statrtOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for(int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                daycontainer.Controls.Add(userControlBlank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays userControlDays = new UserControlDays();
                userControlDays.days(i);
                daycontainer.Controls.Add(userControlDays);
            }

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            month--;
            if (month == 0)
            {
                month = 12;
                year--;
            }

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            LBDATE.Text = monthName + " " + year;
            
            DateTime statrtOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayOfTheWeek = Convert.ToInt32(statrtOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                daycontainer.Controls.Add(userControlBlank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays userControlDays = new UserControlDays();
                userControlDays.days(i);
                daycontainer.Controls.Add(userControlDays);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            month++;
            if(month == 13)
            {
                month = 1;
                year++;
            }
          
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            LBDATE.Text = monthName + " " + year;

           

            DateTime statrtOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayOfTheWeek = Convert.ToInt32(statrtOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                daycontainer.Controls.Add(userControlBlank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays userControlDays = new UserControlDays();
                userControlDays.days(i);
                daycontainer.Controls.Add(userControlDays);
            }
        }
    }
}
