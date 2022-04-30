using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace LearningSpace
{
    public partial class EventForm : Form
    {
        #region EventForm
        public EventForm()
        {
            InitializeComponent();
        }
        #endregion
        #region Настройка формы при загрузке
        private void EventForm_Load(object sender, EventArgs e)
        {
            textDate.Text = Calendar.static_month + "/" + UserControlDays.static_day + "/" + Calendar.static_year; //Помещаем день, месяц, год
        }
        #endregion
        #region Работа с MySql
        private void buttonSave_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase(); //Делаем экземпляр базы данных
            MySqlCommand command = new MySqlCommand("INSERT INTO `tbl` (`event` , `date` ) VALUES (@event , @date )", dataBase.GetMySqlConnection());
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = textDate.Text;
            command.Parameters.Add("@event", MySqlDbType.VarChar).Value = textEvent.Text;


            dataBase.OpenConnection();

            if (command.ExecuteNonQuery() == 1) //Если все ок, то сохраняем 
            {
                MessageBox.Show("Saved");
                Close();
            }
            

            dataBase.CloseConnection();
        }
        #endregion
        #region Кнопка "Закрыть"
        private void pictureBoxClose_(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
