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

namespace LearningSpace
{
    public partial class WeatherForm : Form
    {
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
            WeatherTextBox.Text = answer; //Передаем строку в textBox
        }
            #endregion
        
    }
}
