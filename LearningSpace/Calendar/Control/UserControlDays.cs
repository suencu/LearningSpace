using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningSpace
{
    public partial class UserControlDays : UserControl
    {
        #region Переменные 
        public static string static_day;

        #endregion

        #region UserControlDays
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Выводим значение в календать 
        public void days(int numDay) //numDay берем из calendar(в конце логики)
        {
            labelDays.Text = numDay + ""; //Отображаем дни в месяце 
        }
        #endregion

        #region Клик по дню 
        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = labelDays.Text; //Передаем значение дня
            EventForm eventForm = new EventForm();
            eventForm.Show(); //Вызываем eventForm
        }
        #endregion
    }
}
