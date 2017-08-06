﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace MahechaBJJ.Model
{   
	[JsonObject]
	public class User
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("email")]
		public string Email { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

        [JsonProperty("belt")]
        public string Belt { get; set; }

        [JsonProperty("secretQuestions")]
        public Dictionary<String, String> SecretQuestions { get; set; }

        [JsonProperty("password")]
        public string password { get; set; }

        [JsonProperty("playlists")]
        public ObservableCollection<PlayList> PlayLists { get; set; }
	}
}
