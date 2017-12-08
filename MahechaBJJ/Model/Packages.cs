using System;
using Newtonsoft.Json;

namespace MahechaBJJ.Model
{
    public class Packages
    {
        [JsonProperty("noGiJiuJitsu")]
        public bool NoGiJiuJitsu { get; set; }

        [JsonProperty("giJiuJitsu")]
        public bool GiJiuJitsu { get; set; }
    }
}
