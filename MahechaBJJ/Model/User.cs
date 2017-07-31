using System;
using System.Collections.Generic;
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

        [JsonProperty("secretQuestions")]
        public Dictionary<String, String> SecretQuestions;

        [JsonProperty("password")]
        public string password { get; set; }
	}
}
