using System;
namespace MahechaBJJ.Model
{
	public static class Constants
	{
		public static string AppName = "Mahecha BJJ";

		//OAUTH STUFF
		public static string iOSClientId = "938356160819-pqs05o2cdddnoc0en6sel7t79v3upflt.apps.googleusercontent.com";
		public static string AndroidClientId = "938356160819-rob4aok0n8gojaju292btpad63oghv6t.apps.googleusercontent.com";

		// These values do not need changing
		public static string Scope = "https://www.googleapis.com/auth/userinfo.email";
		public static string AuthorizeUrl = "https://accounts.google.com/o/oauth2/auth";
		public static string AccessTokenUrl = "https://www.googleapis.com/oauth2/v4/token";
		public static string UserInfoUrl = "https://www.googleapis.com/oauth2/v2/userinfo";

		//????
		//Set these to reversed iOS/Android client ids, with :/oauth2redirect appended
		public static string iOSRedirectUrl = "com.googleusercontent.apps.938356160819-pqs05o2cdddnoc0en6sel7t79v3upflt:/oauth2redirect";
		public static string AndroidRedirectUrl = "";
	}
}
