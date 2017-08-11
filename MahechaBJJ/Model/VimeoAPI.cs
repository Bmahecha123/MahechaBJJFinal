using System;
namespace MahechaBJJ.Model
{
	public class BaseInfo
	{
		public int total { get; set; }
		public int page { get; set; }
		public int per_page { get; set; }
		public Paging paging { get; set; }
		public VideoData[] data { get; set; }
	}

	public class Paging
	{
		public string next { get; set; }
		public object previous { get; set; }
		public string first { get; set; }
		public string last { get; set; }
	}
	public class File
	{
		public string quality { get; set; }
		public string type { get; set; }
		public int width { get; set; }
		public int height { get; set; }
		public string link { get; set; }
		public DateTime created_time { get; set; }
		public float fps { get; set; }
		public int size { get; set; }
		public string md5 { get; set; }
		public string link_secure { get; set; }
	}
	public class VideoData
	{
		public string uri { get; set; }
		public string name { get; set; }
        public string description { get; set; }
		public string link { get; set; }
		public int width { get; set; }
		public int height { get; set; }
		public Embed embed { get; set; }
		public Privacy privacy { get; set; }
		public Pictures pictures { get; set; }
		public string resource_key { get; set; }
		public File[] files { get; set; }
	}

	public class Embed
	{
		public string uri { get; set; }
		public string html { get; set; }
		public Buttons buttons { get; set; }
		public Logos logos { get; set; }
		public Title title { get; set; }
		public bool playbar { get; set; }
		public bool volume { get; set; }
		public string color { get; set; }
	}

	public class Buttons
	{
		public bool like { get; set; }
		public bool watchlater { get; set; }
		public bool share { get; set; }
		public bool embed { get; set; }
		public bool hd { get; set; }
		public bool fullscreen { get; set; }
		public bool scaling { get; set; }
	}

	public class Logos
	{
		public bool vimeo { get; set; }
		public Custom custom { get; set; }
	}

	public class Custom
	{
		public bool active { get; set; }
		public object link { get; set; }
		public bool sticky { get; set; }
	}

	public class Title
	{
		public string name { get; set; }
		public string owner { get; set; }
		public string portrait { get; set; }
	}

	public class Privacy
	{
		public string view { get; set; }
		public string embed { get; set; }
		public bool download { get; set; }
		public bool add { get; set; }
		public string comments { get; set; }
	}

	public class Pictures
	{
		public string uri { get; set; }
		public bool active { get; set; }
		public string type { get; set; }
		public Size[] sizes { get; set; }
		public string resource_key { get; set; }
	}

	public class Size
	{
		public int width { get; set; }
		public int height { get; set; }
		public string link { get; set; }
		public string link_with_play_button { get; set; }
	}
}
