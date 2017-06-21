﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using Newtonsoft.Json;

namespace MahechaBJJ
{
	public class FacebookService
	{
        HttpClient httpClient;

        public FacebookService() {
            httpClient = new HttpClient();
        }
		public async Task<FacebookProfile> GetFacebookProfileAsync(string accessToken)
		{
			var requestUrl =
				"https://graph.facebook.com/v2.7/me/?fields=name,picture,work,website,religion,location,locale,link,cover,age_range,birthday,devices,email,first_name,last_name,gender,hometown,is_verified,languages&access_token="
				+ accessToken;

			var userJson = await httpClient.GetStringAsync(requestUrl);

			var facebookProfile = JsonConvert.DeserializeObject<FacebookProfile>(userJson);

			return facebookProfile;
		}
	}
}
