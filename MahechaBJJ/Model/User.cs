using System;
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

        [JsonProperty("secretQuestion")]
        public string SecretQuestion { get; set; }

        [JsonProperty("secretQuestionAnswer")]
        public string SecretQuestionAnswer { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("playlists")]
        public ObservableCollection<PlayList> PlayLists { get; set; }

        [JsonProperty("packages")]
        public Packages Packages { get; set; }
	}
}
