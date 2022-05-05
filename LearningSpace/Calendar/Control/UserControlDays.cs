using MySql.Data.MySqlClient;
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
        DataBase dataBase;
        MySqlDataAdapter dataAdapter;
        DataTable dataTable;
        string HexColorBackColorUserControl = "#23b113";
        Color UserControlColor;
      
        #endregion

        #region UserControlDays
        public UserControlDays()
        {
            InitializeComponent();
            dataBase = new DataBase();
            dataAdapter = new MySqlDataAdapter();
            dataTable = new DataTable();

            labelCountOfEvenr.AutoSize = true;
            UserControlColor = ColorTranslator.FromHtml(HexColorBackColorUserControl);
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            displayEvent();
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

        private void displayEvent()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `calendar` WHERE `login_user` = @login AND `date` = @date", dataBase.GetMySqlConnection());
            command.Parameters.Add($"@login", MySqlDbType.VarChar).Value = AuthorizationForm.login_user;
            command.Parameters.Add($"@date", MySqlDbType.Date).Value = Calendar.static_year + "-" + Calendar.static_month + "-" + labelDays.Text;
            dataBase.OpenConnection();
            dataAdapter.SelectCommand = command;

            dataAdapter.Fill(dataTable);

            dataBase.CloseConnection();

            string numberOfEvent = dataTable.Rows.Count.ToString();

            labelCountOfEvenr.Text = numberOfEvent;

            if(labelCountOfEvenr.Text != "0")
            {
                this.BackColor = UserControlColor;
            }

        }

        private void UserControlDays_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5)
            {
                displayEvent();
            }
        }
    }
}
