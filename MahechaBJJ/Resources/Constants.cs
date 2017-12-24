using System;
using System.Collections.Generic;
using System.Linq;
using MahechaBJJ.Model;

namespace MahechaBJJ.Resources
{
    public class Constants
    {
		public static string pivotalHost = "https://mahechabjj.cfapps.io/";
		public static string localHost = "http://localhost:8080/";
		public static string AppName = "mahechabjj";

        public static string GETUSER = "user/getUser";
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
        public static string CHANGEPASSWORD = "password/changePassword";

        public static string VIMEOGIANDNOGIALBUM = "https://api.vimeo.com/me/albums/4802536/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&version=3.2";
        public static string VIMEOGIALBUM = "https://api.vimeo.com/me/albums/4802538/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&version=3.2";
        public static string VIMEONOGIALBUM = "https://api.vimeo.com/me/albums/4802539/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&version=3.2";

        public static string VIMEONOGIBACKTAKEALBUM = "https://api.vimeo.com/me/albums/4802551/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&version=3.2";
        public static string VIMEONOGIDEFENSEALBUM = "https://api.vimeo.com/me/albums/4802550/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&version=3.2";
        public static string VIMEONOGIGUARDPASSALBUM = "https://api.vimeo.com/me/albums/4802549/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&version=3.2";
        public static string VIMEONOGISUBMISSIONALBUM = "https://api.vimeo.com/me/albums/4802548/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&version=3.2";
        public static string VIMEONOGITAKEDOWNALBUM = "https://api.vimeo.com/me/albums/4802547/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&version=3.2";
        public static string VIMEONOGISWEEPALBUM = "https://api.vimeo.com/me/albums/4802546/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&version=3.2";
        public static string VIMEONOGIDRILLSALBUM = "https://api.vimeo.com/me/albums/4908665/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&version=3.2";
        public static string VIMEOGIBACKTAKEALBUM = "https://api.vimeo.com/me/albums/4802545/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&version=3.2";
        public static string VIMEOGIDEFENSEALBUM = "https://api.vimeo.com/me/albums/4802544/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&version=3.2";
        public static string VIMEOGIGUARDPASSALBUM = "https://api.vimeo.com/me/albums/4802543/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&version=3.2";
        public static string VIMEOGISUBMISSIONALBUM = "https://api.vimeo.com/me/albums/4802542/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&version=3.2";
        public static string VIMEOGITAKEDOWNALBUM = "https://api.vimeo.com/me/albums/4802541/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&version=3.2";
        public static string VIMEOGISWEEPALBUM = "https://api.vimeo.com/me/albums/4802540/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&version=3.2";
        public static string VIMEOGIDRILLSALBUM = "https://api.vimeo.com/me/albums/4908664/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&version=3.2";
        public static string VIMEOBACKTAKEALBUM = "https://api.vimeo.com/me/albums/4908492/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&version=3.2";
        public static string VIMEODEFENSEALBUM = "https://api.vimeo.com/me/albums/4908506/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&version=3.2";
        public static string VIMEOGUARDPASSALBUM = "https://api.vimeo.com/me/albums/4908507/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&version=3.2";
        public static string VIMEOSUBMISSIONALBUM = "https://api.vimeo.com/me/albums/4908508/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&version=3.2";
        public static string VIMEOTAKEDOWNALBUM = "https://api.vimeo.com/me/albums/4908509/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&version=3.2";
        public static string VIMEOSWEEPALBUM = "https://api.vimeo.com/me/albums/4908512/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&version=3.2";
        public static string VIMEODRILLSALBUM = "https://api.vimeo.com/me/albums/4908663/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&version=3.2";

        public static string GetAlbum(string albumName)
        {
            Dictionary<string, string> albums = new Dictionary<string, string>();

            albums.Add("VIMEONOGIBACKTAKEALBUM", VIMEONOGIBACKTAKEALBUM);
            albums.Add("VIMEONOGIDEFENSEALBUM", VIMEONOGIDEFENSEALBUM);
            albums.Add("VIMEONOGIGUARDPASSALBUM", VIMEONOGIGUARDPASSALBUM);
            albums.Add("VIMEONOGISUBMISSIONALBUM", VIMEONOGISUBMISSIONALBUM);
            albums.Add("VIMEONOGITAKEDOWNALBUM", VIMEONOGITAKEDOWNALBUM);
            albums.Add("VIMEONOGISWEEPALBUM", VIMEONOGISWEEPALBUM);
            albums.Add("VIMEONOGIDRILLSALBUM", VIMEONOGIDRILLSALBUM);

            albums.Add("VIMEOGIBACKTAKEALBUM", VIMEOGIBACKTAKEALBUM);
            albums.Add("VIMEOGIDEFENSEALBUM", VIMEOGIDEFENSEALBUM);
            albums.Add("VIMEOGIGUARDPASSALBUM", VIMEOGIGUARDPASSALBUM);
            albums.Add("VIMEOGISUBMISSIONALBUM", VIMEOGISUBMISSIONALBUM);
            albums.Add("VIMEOGITAKEDOWNALBUM", VIMEOGITAKEDOWNALBUM);
            albums.Add("VIMEOGISWEEPALBUM", VIMEOGISWEEPALBUM);
            albums.Add("VIMEOGIDRILLSALBUM", VIMEOGIDRILLSALBUM);

            albums.Add("VIMEOBACKTAKEALBUM", VIMEOBACKTAKEALBUM);
            albums.Add("VIMEODEFENSEALBUM", VIMEODEFENSEALBUM);
            albums.Add("VIMEOGUARDPASSALBUM", VIMEOGUARDPASSALBUM);
            albums.Add("VIMEOSUBMISSIONALBUM", VIMEOSUBMISSIONALBUM);
            albums.Add("VIMEOTAKEDOWNALBUM", VIMEOTAKEDOWNALBUM);
            albums.Add("VIMEOSWEEPALBUM", VIMEOSWEEPALBUM);
            albums.Add("VIMEODRILLSALBUM", VIMEODRILLSALBUM);

            return albums[albumName.ToUpper()];
        }
    }
}
