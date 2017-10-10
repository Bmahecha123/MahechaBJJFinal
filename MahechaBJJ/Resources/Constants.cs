using System;
namespace MahechaBJJ.Resources
{
    public class Constants
    {
		public static string pivotalHost = "https://mahechabjj.cfapps.io/";
		public static string localHost = "http://localhost:8080/";
		public static string AppName = "mahechabjj";

		/*public static string CREATEUSER = pivotalHost + "user/create";
		public static string FINDUSER = pivotalHost + "user/findById/";
        public static string FINDUSERBYEMAIL = pivotalHost + "user/findByEmail/";
		public static string FINDPLAYLIST = pivotalHost + "user/getplaylist/";
		public static string ADDPLAYLIST = pivotalHost + "user/addplaylist/";
		public static string GETPLAYLIST = pivotalHost + "user/getplaylists/";
		public static string UPDATEPLAYLIST = pivotalHost + "user/updateplaylists/";
		public static string DELETEPLAYLIST = pivotalHost + "user/deleteplaylist/";
		public static string DELETEVIDEOFROMPLAYLIST = pivotalHost + "user/deleteVideo/";
		public static string LOADBLOGPOSTS = "https://api.tumblr.com/v2/blog/mahechabjj/posts?api_key=vPbcUP6WSBbQ6RiVQC5ZO9paNGQE7QT4kXGefQXKlkM2jBJdos"; */

		public static string CREATEUSER = localHost + "user/create";
		public static string FINDUSER = localHost + "user/findById/";
		public static string FINDUSERBYEMAIL = localHost + "user/findByEmail/";
		public static string FINDPLAYLIST = localHost + "user/getplaylist/";
		public static string ADDPLAYLIST = localHost + "user/addplaylist/";
		public static string GETPLAYLIST = localHost + "user/getplaylists/";
		public static string UPDATEPLAYLIST = localHost + "user/updateplaylists/";
		public static string DELETEPLAYLIST = localHost + "user/deleteplaylist/";
		public static string DELETEVIDEOFROMPLAYLIST = localHost + "user/deleteVideo/";
		public static string LOADBLOGPOSTS = "https://api.tumblr.com/v2/blog/mahechabjj/posts?api_key=vPbcUP6WSBbQ6RiVQC5ZO9paNGQE7QT4kXGefQXKlkM2jBJdos";



		/* public static string CreateUser(bool local) 
         {
             if (local) {
                 return localHost + CREATEUSER;
             } else {
                 return pivotalHost + CREATEUSER;
             }
         }
         public static string FindUser(bool local)
         {
             if (local)
             {
                 return localHost + FINDUSER;
             }
             else
             {
                 return pivotalHost + FINDUSER;
             }
         }
         public static string FindPlayList(bool local)
         {
             if (local)
             {
                 return localHost + FINDPLAYLIST;
             }
             else
             {
                 return pivotalHost + FINDPLAYLIST;
             }
         }
         public static string AddPlayList(bool local)
         {
             if (local)
             {
                 return localHost + ADDPLAYLIST;
             }
             else
             {
                 return pivotalHost + ADDPLAYLIST;
             }
         }
         public static string GetPlayList(bool local)
         {
             if (local)
             {
                 return localHost + GETPLAYLIST;
             }
             else
             {
                 return pivotalHost + GETPLAYLIST;
             }
         }
         public static string UpdatePlayList(bool local)
         {
             if (local)
             {
                 return localHost + UPDATEPLAYLIST;
             }
             else
             {
                 return pivotalHost + UPDATEPLAYLIST;
             }
         }
         public static string DeletePlayList(bool local)
         {
             if (local)
             {
                 return localHost + DELETEPLAYLIST;
             }
             else
             {
                 return pivotalHost + DELETEPLAYLIST;
             }
         }
         public static string DeleteVideoFromPlayList(bool local)
         {
             if (local)
             {
                 return localHost + DELETEVIDEOFROMPLAYLIST;
             }
             else
             {
                 return pivotalHost + DELETEVIDEOFROMPLAYLIST;
             }
         } */
	}
}
