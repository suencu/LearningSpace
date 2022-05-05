using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;
using LearningSpace.CreateEvent;
using System.Data;

namespace LearningSpace
{
    public partial class EventForm : Form
    {
        Thread thread;
        DataBase dataBase;
        MySqlDataAdapter dataAdapter;
        DataTable dataTable;
        string HexColorForBackColor = "#2a2c3b";
        Color TextBoxBackColor;
        string HexColorForFontColor = "#dcdacd";
        Color TextBoxFontColor;

        List<ComboBox> comboBoxes;
        int x_LocotionComboBoxes;
        int y_LocotionComboBoxes;

        List<ComboBox> EventComboBoxes;
        int x_LocotionEventComboBoxes;
        int y_LocotionEventComboBoxes;

        List<Label> labels;
        int x_LocotionLabels;
        int y_LocotionLabels;

        int textInLabelCount;
        string[] itemsInComboBox;
        string[] itemsInEventComboBox;

        ComboBox comboBox;
        ComboBox comboBoxForEvent;

        #region EventForm
        public EventForm()
        {
            InitializeComponent();
            dataBase = new DataBase();
            dataAdapter = new MySqlDataAdapter();
            dataTable = new DataTable();

            TextBoxBackColor = ColorTranslator.FromHtml(HexColorForBackColor);
            TextBoxFontColor = ColorTranslator.FromHtml(HexColorForFontColor);

            comboBoxes = new List<ComboBox>();
            comboBoxes.Add(BOXperformanceEvaluation);
            x_LocotionComboBoxes = BOXperformanceEvaluation.Location.X;
            y_LocotionComboBoxes = BOXperformanceEvaluation.Location.Y;

            EventComboBoxes = new List<ComboBox>();
            EventComboBoxes.Add(comboBoxEvent);
            x_LocotionEventComboBoxes = comboBoxEvent.Location.X;
            y_LocotionEventComboBoxes = comboBoxEvent.Location.Y;
            
            labels = new List<Label>();
            textInLabelCount = 1;
            labels.Add(labelCountEvent);
            x_LocotionLabels = labelCountEvent.Location.X;
            y_LocotionLabels = labelCountEvent.Location.Y;

            itemsInComboBox = initialComboBoxHours();
            BOXperformanceEvaluation.Items.AddRange(itemsInComboBox);

            itemsInEventComboBox = selectedDateOfuser();
            comboBoxEvent.Items.AddRange(itemsInEventComboBox);
        }


        #endregion

        #region Настройка формы при загрузке
        private void EventForm_Load(object sender, EventArgs e)
        {
            textDate.Text = Calendar.static_year + "-" + Calendar.static_month + "-" + UserControlDays.static_day; //Помещаем день, месяц, год
        }
        #endregion

        #region Работа с MySql
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string SQLCommand = "INSERT INTO `calendar` (`event`, `date`, `hours`, `login_user`) VALUES ";
            string finalSqlCommand = string.Empty;

            int countEvent = 0;
            int count = 0;

            List<string> listOfEvent = new List<string>();
            List<string> TEMPlistOfHoursEvent = new List<string>();
            List<int> listOfHoursEvent = new List<int>();
            for (int i = 0; i < labels.Count; i++)
            {
                listOfEvent.Add(EventComboBoxes[i].Text);
            }
            for (int i = 0; i < labels.Count; i++)
            {
                TEMPlistOfHoursEvent.Add(comboBoxes[i].Text);
            }

            int countBlock = labels.Count;

            for (int i = countBlock - 1; i >= 0 ; i--)
            {
                if ((string.IsNullOrWhiteSpace(TEMPlistOfHoursEvent[i]) || TEMPlistOfHoursEvent[i] == "Hours") || (string.IsNullOrWhiteSpace(listOfEvent[i]) || listOfEvent[i] == "Your event"))
                {
                    TEMPlistOfHoursEvent.RemoveAt(i);
                    listOfEvent.RemoveAt(i);
                    countBlock--;
                }

            }
            for (int i = 0; i < TEMPlistOfHoursEvent.Count; i++)
            {
                listOfHoursEvent.Add(Convert.ToInt32(TEMPlistOfHoursEvent[i]));
            }

            if (listOfEvent.Count == 0 || listOfHoursEvent.Count == 0)
            {
                MessageBox.Show("Добавлять нечего");
                UpdateEventForm();
                return;
            }

            //==============================
            while (count < listOfEvent.Count && count < listOfHoursEvent.Count)
            {
                string some_event = $"(@event{count}";
                string some_date = $"@date{count}";
                string some_hours = $"@hours{count}";
                string some_login_user = $"@login_user{count}), ";

                SQLCommand += some_event + ", "+ some_date + ", " + some_hours + ", " + some_login_user;

                count++;

                if (count == listOfEvent.Count && count == listOfHoursEvent.Count)
                {
                    finalSqlCommand += SQLCommand.Remove(SQLCommand.Length - 2, 2);
                }
            }

            MySqlCommand command = new MySqlCommand(finalSqlCommand, dataBase.GetMySqlConnection());

            try
            {
                dataBase.OpenConnection();
                while (countEvent < listOfEvent.Count && countEvent < listOfHoursEvent.Count)
                {

                    command.Parameters.Add($"@event{countEvent}", MySqlDbType.VarChar).Value = listOfEvent[countEvent];
                    command.Parameters.Add($"@date{countEvent}", MySqlDbType.Date).Value = textDate.Text;
                    command.Parameters.Add($"@hours{countEvent}", MySqlDbType.UInt32).Value = listOfHoursEvent[countEvent];
                    command.Parameters.Add($"@login_user{countEvent}", MySqlDbType.VarChar).Value = AuthorizationForm.login_user;
                    
                    countEvent++;
                }

                if (command.ExecuteNonQuery() == countBlock) 
                {
                    MessageBox.Show("Saved");
                    UpdateEventForm();
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

        private void buttonADD_Click(object sender, EventArgs e)
        {
            y_LocotionLabels += 40;
            textInLabelCount++;
            labels.Add(new Label
            {
                Location = new Point(x_LocotionLabels, y_LocotionLabels - 3),
                BackColor = Color.Transparent,
                Size = new Size(21, 23),
                ForeColor = TextBoxFontColor,
                Font = labelCountEvent.Font,
                AutoSize = true,
                Text = textInLabelCount.ToString(),
            });
            labels.ForEach(i => this.Controls.Add(i));

            y_LocotionComboBoxes += 40;
            comboBox = new ComboBox() 
            {
                Location = new Point(x_LocotionComboBoxes, y_LocotionComboBoxes - 3),
                BackColor = TextBoxBackColor,
                Size = new Size(BOXperformanceEvaluation.Width, BOXperformanceEvaluation.Height),
                ForeColor = TextBoxFontColor,
                Font = BOXperformanceEvaluation.Font,
                FlatStyle = FlatStyle.Flat,
                Text = "Hours",
                DropDownHeight = BOXperformanceEvaluation.DropDownHeight,
                DropDownWidth = BOXperformanceEvaluation.DropDownWidth,
            };
            comboBox.Items.AddRange(itemsInComboBox);
            comboBoxes.Add(comboBox);
            this.Controls.Add(comboBox);

            y_LocotionEventComboBoxes += 40;
            comboBoxForEvent = new ComboBox() 
            {
                Location = new Point(x_LocotionEventComboBoxes, y_LocotionEventComboBoxes - 3),
                BackColor = TextBoxBackColor,
                Size = new Size(comboBoxEvent.Width, comboBoxEvent.Height),
                ForeColor = TextBoxFontColor,
                Font = comboBoxEvent.Font,
                FlatStyle = FlatStyle.Flat,
                Text = "Your event",
                DropDownHeight = comboBoxEvent.DropDownHeight,
                DropDownWidth = comboBoxEvent.DropDownWidth,
            };
            comboBoxForEvent.Items.AddRange(itemsInEventComboBox);
            EventComboBoxes.Add(comboBoxForEvent);
            this.Controls.Add(comboBoxForEvent);


            if (labels.Count == 6)
            {
                buttonADD.Enabled = false;
                buttonADD.BackColor = Color.White;
                MessageBox.Show("Больше нельзя добавить событий!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thread = new Thread(OpenCreateEventForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            Close();
        }

        private void OpenCreateEventForm()
        {
            Application.Run(new CreateEventForm());
        }
        private string[] selectedDateOfuser()
        {

            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `event` WHERE `login` = @login ", dataBase.GetMySqlConnection()); //ORDER BY `login` DESC
            mySqlCommand.Parameters.Add("@login", MySqlDbType.VarChar).Value = AuthorizationForm.login_user;

            dataBase.OpenConnection();

            dataAdapter.SelectCommand = mySqlCommand;
            dataAdapter.Fill(dataTable);
            itemsInEventComboBox = new string[dataTable.Rows.Count];

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                itemsInEventComboBox[i] = dataTable.Rows[i][0].ToString();
            }

            dataBase.CloseConnection();

            return itemsInEventComboBox;
        }

        private string[] initialComboBoxHours()
        {
            string[] array = new string[24];
            int hours = 1;
            for (int i = 0; i < 24; i++)
            {
                array[i] = hours.ToString();
                hours++;
            }
            return array;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete all?", "DELETE", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                UpdateEventForm();

                if (buttonADD.Enabled == false)
                {
                    buttonADD.Enabled = true;
                    buttonADD.BackColor = TextBoxBackColor;
                }
            }
        }

        private void UpdateEventForm()
        {
            for (int i = 1; i < labels.Count; i++)
            {
                this.Controls.Remove(labels[i]);
            }

            for (int i = 1; i < EventComboBoxes.Count; i++)
            {
                this.Controls.Remove(EventComboBoxes[i]);
            }

            for (int i = 1; i < comboBoxes.Count; i++)
            {
                this.Controls.Remove(comboBoxes[i]);
            }

            if (EventComboBoxes.Count == 1 || comboBoxes.Count == 1)
            {
                comboBoxEvent.Text = "Your event";
                BOXperformanceEvaluation.Text = "Hours";
                return;
            }


            labels.RemoveRange(1, labels.Count - 1);
            x_LocotionLabels = labelCountEvent.Location.X;
            y_LocotionLabels = labelCountEvent.Location.Y;
            textInLabelCount = 1;

            EventComboBoxes.RemoveRange(1, EventComboBoxes.Count - 1);
            x_LocotionEventComboBoxes = comboBoxEvent.Location.X;
            y_LocotionEventComboBoxes = comboBoxEvent.Location.Y;

            comboBoxes.RemoveRange(1, comboBoxes.Count - 1);
            x_LocotionComboBoxes = BOXperformanceEvaluation.Location.X;
            y_LocotionComboBoxes = BOXperformanceEvaluation.Location.Y;

            if (EventComboBoxes.Count == 1 || comboBoxes.Count == 1)
            {
                comboBoxEvent.Text = "Your event";
                BOXperformanceEvaluation.Text = "Hours";
                return;
            }
        }

    }
}
