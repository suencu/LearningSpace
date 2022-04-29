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
        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            textDate.Text = NewNodes.static_month + "/" + UserControlDays.static_day + "/" + NewNodes.static_year;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `tbl` (`event` , `date` ) VALUES (@event , @date )", dataBase.GetMySqlConnection());
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = textDate.Text;
            command.Parameters.Add("@event", MySqlDbType.VarChar).Value = textEvent.Text;


            dataBase.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Saved");
                Close();
            }
            

            dataBase.CloseConnection();
        }
    }
}
