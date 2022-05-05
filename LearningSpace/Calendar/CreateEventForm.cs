using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using yt_DesignUI;

namespace LearningSpace.CreateEvent
{
    public partial class CreateEventForm : Form
    {
        Thread thread;
        DataBase dataBase;
        MySqlDataAdapter dataAdapter;
        DataTable dataTable;
        string HexColorForBackColor = "#2a2c3b";
        Color TextBoxBackColor;
        string HexColorForFontColor = "#dcdacd";
        Color TextBoxFontColor;
        List<TextBox> textBoxes;
        int x_LocotionTextBox;
        int y_LocotionTextBox;
        int x_LocotionLabels;
        int y_LocotionLabels;
        List<Label> labels;
        int textInLabalCount;

        public CreateEventForm()
        {
            InitializeComponent();
            Animator.Start();
            dataBase = new DataBase();
            dataAdapter = new MySqlDataAdapter();
            dataTable = new DataTable();

            TextBoxBackColor = ColorTranslator.FromHtml(HexColorForBackColor);
            TextBoxFontColor = ColorTranslator.FromHtml(HexColorForFontColor);

            textBoxes = new List<TextBox>();
            textBoxes.Add(usersEvent);
            x_LocotionTextBox = usersEvent.Location.X;
            y_LocotionTextBox = usersEvent.Location.Y;

            labels = new List<Label>();
            textInLabalCount = 1;
            labels.Add(labelCount);
            x_LocotionLabels = labelCount.Location.X;
            y_LocotionLabels = labelCount.Location.Y;

        }

        private void pictureBoxClose_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            y_LocotionTextBox += 40;
            textBoxes.Add(new TextBox
            {
                Location = new Point(x_LocotionTextBox, y_LocotionTextBox),
                BackColor = TextBoxBackColor,
                Size = new Size(usersEvent.Size.Width, usersEvent.Size.Height),
                ForeColor = TextBoxFontColor,
                BorderStyle = BorderStyle.None,
                Font = usersEvent.Font,
            });
            textBoxes.ForEach(i => this.Controls.Add(i));

            y_LocotionLabels += 40;
            textInLabalCount++;
            labels.Add(new Label
            {
                Location = new Point(x_LocotionLabels, y_LocotionLabels - 3),
                BackColor = Color.Transparent,
                Size = new Size(21, 23),
                ForeColor = TextBoxFontColor,
                Font = labelCount.Font,
                AutoSize = true,
                Text = textInLabalCount.ToString(),
            });
            labels.ForEach(i => this.Controls.Add(i));

            if (labels.Count == 7)
            {
                buttonADD.Enabled = false;
                buttonADD.BackColor = Color.White;
                MessageBox.Show("Больше нельзя добавить событий!");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string STRcommand = "INSERT INTO `event` (`nameOfEvent`, `login`) VALUES ";
            string finalCommand = string.Empty;
            int countEvent = 0;
            int count = 0;
            

            List<string> listOfEvent = new List<string>();
            for (int i = 0; i < labels.Count; i++)
            {
                listOfEvent.Add(textBoxes[i].Text);
            }

            //Проверка
            for (int i = listOfEvent.Count - 1; i >= 0; i--)
            {
                if (string.IsNullOrWhiteSpace(listOfEvent[i]))
                {
                    listOfEvent.RemoveAt(i);
                }
            }

            CheckEvent(listOfEvent);

            if (listOfEvent.Count == 0)
            {
                MessageBox.Show("Добавлять нечего");
                UpdateCreateEventForm();
                return;
            }

            //================================
            while (count < listOfEvent.Count)
            {
                string some_event = "(@some_event"+count.ToString();
                string login_user = $"@login_user{count}), ";

                STRcommand += some_event + ", " +login_user;

                count++;

                if(count == listOfEvent.Count)
                {
                    finalCommand += STRcommand.Remove(STRcommand.Length - 2 , 2);
                }
            }

            MySqlCommand command = new MySqlCommand(finalCommand, dataBase.GetMySqlConnection());

            try
            {
                dataBase.OpenConnection();
                while (countEvent < listOfEvent.Count)
                {
                    command.Parameters.Add($"@some_event{countEvent}", MySqlDbType.VarChar).Value = listOfEvent[countEvent];
                    command.Parameters.Add($"@login_user{countEvent}", MySqlDbType.VarChar).Value = AuthorizationForm.login_user;

                    countEvent++;
                }
                if (command.ExecuteNonQuery() == listOfEvent.Count) //Если все ок, то сохраняем 
                {
                    MessageBox.Show("Saved");
                    UpdateCreateEventForm();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            dataBase.CloseConnection();
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            thread = new Thread(OpenCalendar);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            Close();
        }

        private void OpenCalendar()
        {
            Application.Run(new Calendar());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete all?", "DELETE", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                UpdateCreateEventForm();
            }
        }
        private void UpdateCreateEventForm()
        {
            for (int i = 1; i < labels.Count; i++)
            {
                this.Controls.Remove(textBoxes[i]);
                this.Controls.Remove(labels[i]);
            }

            labels.RemoveRange(1, labels.Count - 1);
            textInLabalCount = 1;
            x_LocotionLabels = labelCount.Location.X;
            y_LocotionLabels = labelCount.Location.Y;

            textBoxes.RemoveRange(1, textBoxes.Count - 1);
            x_LocotionTextBox = usersEvent.Location.X;
            y_LocotionTextBox = usersEvent.Location.Y;

            if (textBoxes.Count == 1)
            {
                usersEvent.Text = null;
            }

            if (buttonADD.Enabled == false)
            {
                buttonADD.Enabled = true;
                buttonADD.BackColor = TextBoxBackColor;
            }
        }
        private List<string> CheckEvent(List<string> listOfEvetns)
        {
            

            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `event` WHERE login = @login ORDER BY `nameOfEvent` ASC", dataBase.GetMySqlConnection()); //ORDER BY `login` DESC
            mySqlCommand.Parameters.Add("@login", MySqlDbType.VarChar).Value = AuthorizationForm.login_user;

            dataBase.OpenConnection();

            dataAdapter.SelectCommand = mySqlCommand;

            dataAdapter.Fill(dataTable);

            for (int i = 0; i < listOfEvetns.Count; i++)
            {
                for (int j = 0; j < dataTable.Rows.Count; j++)
                {
                    if (listOfEvetns[i].Equals(dataTable.Rows[j][0].ToString()))
                    {
                        listOfEvetns.RemoveAt(i);
                        if (listOfEvetns.Count == 0)
                        {
                            return listOfEvetns;
                        }
                    }
                }
            }
            dataBase.CloseConnection();
            return listOfEvetns;
        }

    }
}
