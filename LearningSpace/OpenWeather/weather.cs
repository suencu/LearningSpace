using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSpace.OpenWeather
{
    class weather
    {
        #region --Переменные--
        public int id { get; set; }
        public string main { get; set; }
        

        public string description { get; set; }

        public string icon { get; set; }

        public Bitmap Icon //Картинка погоды 
        {
            get
            {
                return new Bitmap(Image.FromFile($@"icons\{icon}.png"));
            }
        }
        #endregion

    }
}
