using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSpace.WeatherClasses
{
    class weatherClass1
    {
        #region --Переменные--
        public int id;

        public string name;

        public string description;

        private string icon;

        public Bitmap Icon //Картинка погоды 
        {
            get
            {
                return new Bitmap(Image.FromFile($"icons/{icon}.png"));
            }
        }
        #endregion

    }
}
