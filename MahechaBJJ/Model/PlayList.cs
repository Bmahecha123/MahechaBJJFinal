using System;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace MahechaBJJ.Model
{
    public class PlayList
    {
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("videos")]
		public ObservableCollection<Video> Videos { get; set; }
    }
}
