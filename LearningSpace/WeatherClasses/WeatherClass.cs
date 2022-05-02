using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LearningSpace.Classes
{
    class WeatherClass
    {
        #region --Переменные--
        [JsonProperty("base")]
        public string Base;

        public double visibility;

        public double dt;

        public int id;

        public string name;

        public double cod;
        #endregion
    }
}
