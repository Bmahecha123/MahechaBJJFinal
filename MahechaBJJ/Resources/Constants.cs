using System;
namespace MahechaBJJ.Resources
{
    public class Constants
    {
		public static string pivotalHost = "https://mahechabjj.cfapps.io/";
		public static string localHost = "http://localhost:8080/";
		public static string AppName = "mahechabjj";

		public static string CREATEUSER = "user/create";
		public static string FINDUSER = "user/findById/";
        public static string FINDUSERBYEMAIL = "user/findByEmail/";
		public static string FINDPLAYLIST = "user/getplaylist/";
		public static string ADDPLAYLIST = "user/addplaylist/";
		public static string GETPLAYLIST = "user/getplaylists/";
		public static string UPDATEPLAYLIST = "user/updateplaylists/";
		public static string DELETEPLAYLIST = "user/deleteplaylist/";
		public static string DELETEVIDEOFROMPLAYLIST = "user/deleteVideo/";
		public static string LOADBLOGPOSTS = "https://api.tumblr.com/v2/blog/mahechabjj/posts?api_key=vPbcUP6WSBbQ6RiVQC5ZO9paNGQE7QT4kXGefQXKlkM2jBJdos";
	}
}
