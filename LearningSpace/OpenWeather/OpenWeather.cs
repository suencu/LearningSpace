using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LearningSpace.OpenWeather

{
    class OpenWeather
    {
        public coord coord { get; set; }

        public weather[] weather { get; set; }

        #region --Переменные--
        [JsonProperty("base")]
        public string Base { get; set; }

        public main main { get; set; }

        public double visibility { get; set; }

        public wind wind { get; set; }

        public clouds clouds { get; set; }

        public double dt { get; set; }

        public sys sys { get; set; }

        public int id { get; set; }

        public string name { get; set; }

        public double cod { get; set; }
        #endregion
    }
}
