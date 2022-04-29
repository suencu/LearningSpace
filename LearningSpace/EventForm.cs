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
        String connString = "server=localhost;user id=root;database=db_calendar;sslmode=none";
        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            textDate.Text =NewNodes.static_month+"/"+ UserControlDays.static_day + "/" + NewNodes.static_year;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();
            String sql = "INSERT INTO tbl_calendar(date,event)values(?,?)";
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", textDate.Text);
            cmd.Parameters.AddWithValue("event", textEvent.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
            cmd.Dispose();
            connection.Close();
        }
    }
}
