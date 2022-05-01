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
            textBoxCheck.Text = "Пользователь : " + AuthorizationForm.login_user;
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
            DataBase dataBase = new DataBase();
            //сохраняю переменную hours для дальнейшей работы в Graph
            UInt32 hours = Convert.ToUInt32(BOXperformanceEvaluation.SelectedItem.ToString());

            //проверка на null textBOX_Event , чтобы не сохранять пустое событие 
            if (textEvent.Text == null)
            {
                MessageBox.Show("Enter your event or click on close");
                return;
            }

            MySqlCommand command = new MySqlCommand("INSERT INTO `calendar` (`event`, `date`, `hours`, `login_user`) VALUES (@event, @date, @hours ,@login_user)", dataBase.GetMySqlConnection());

            try
            {
                dataBase.OpenConnection();
                command.Parameters.Add("@event", MySqlDbType.VarChar).Value = textEvent.Text;
                command.Parameters.Add("@date", MySqlDbType.VarChar).Value = textDate.Text;
                command.Parameters.Add("@hours", MySqlDbType.UInt32).Value = hours; 
                command.Parameters.Add("@login_user", MySqlDbType.VarChar).Value = AuthorizationForm.login_user;

                if (command.ExecuteNonQuery() == 1) //Если все ок, то сохраняем 
                {
                    MessageBox.Show("Saved");
                    Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
