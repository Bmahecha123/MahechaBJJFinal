using System;
using Newtonsoft.Json;

namespace MahechaBJJ.Model
{
    public class Video
    {
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("image")]
		public string Image { get; set; }
		[JsonProperty("link")]
		public string Link { get; set; }
        [JsonProperty("linkHd")]
        public string LinkHD { get; set; }
		[JsonProperty("description")]
		public string Description { get; set; }

        public Video() {
            
        }

        public Video(string name, string image, string link, string linkHd, string description) 
        {
            Name = name;
            Image = image;
            Link = link;
            LinkHD = linkHd;
            Description = description;
        }
    }

}
