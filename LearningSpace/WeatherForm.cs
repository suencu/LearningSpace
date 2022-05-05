using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Threading;

namespace LearningSpace
{
    public partial class WeatherForm : Form
    {
        #region --Переменные--
        Thread th;
        #endregion

        #region  --WeatherForm--
        public WeatherForm()
        {
            InitializeComponent();
        }
        #endregion

        #region --Кнопки-- 
        private void PictureBoxWeatherClose(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region --Создаем запрос на сервер и получаем Ответ--
        private async void WeatherForm_Load(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://api.openweathermap.org/data/2.5/weather?q=Moscow&APPID=f5dcd1872877203c54797330e23e1363"); //Создаем запрос на сервер

            request.Method = "POST"; //Cоздаем свойства для запроса

            request.ContentType = "application/x-www-urlencoded";

            WebResponse response = await request.GetResponseAsync(); //Принимаем ответ сервера

            string answer = string.Empty;

            using (Stream s = response.GetResponseStream()) //Получаем поток ответа
            {
                using (StreamReader reader = new StreamReader(s))
                {
                    answer = await reader.ReadToEndAsync(); //Записывает ответ в строку
                }
            }
            response.Close();
            //WeatherTextBox.Text = answer; //Передаем строку в textBox

            OpenWeather.OpenWeather OW = JsonConvert.DeserializeObject<OpenWeather.OpenWeather>(answer); //Конверт для удобства 

            panelПогода.BackgroundImage = OW.weather[0].Icon; //Иконка погоды

            label1.Text = OW.weather[0].main;

            label2.Text = OW.weather[0].description;

            label3.Text = "Средняя температура(°C): " + OW.main.temp.ToString("0.##");

            label6.Text = "Скорость (м/с): " + OW.wind.speed.ToString();

            label7.Text = "Направление °: " + OW.wind.deg.ToString();

            label4.Text = "Влажность (%): " + OW.main.humidity.ToString();

            label5.Text = "Давление (мм): " + ((int) OW.main.pressure).ToString();
        }

        #endregion



        #region Кнопка "Назад в меню"
        private void backToMenuWeather(object sender, EventArgs e)
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
        
    }
}
