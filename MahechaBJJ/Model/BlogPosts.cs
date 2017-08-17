using System;
using System.Collections.Generic;

namespace MahechaBJJ.Model
{
    public class BlogPosts
    {
		public class Meta
		{
			public int status { get; set; }
			public string msg { get; set; }
		}

		public class Blog
		{
			public bool ask { get; set; }
			public bool ask_anon { get; set; }
			public string ask_page_title { get; set; }
			public bool can_subscribe { get; set; }
			public string description { get; set; }
			public bool is_adult { get; set; }
			public bool is_nsfw { get; set; }
			public string name { get; set; }
			public int posts { get; set; }
			public string reply_conditions { get; set; }
			public bool share_likes { get; set; }
			public bool subscribed { get; set; }
			public string title { get; set; }
			public int total_posts { get; set; }
			public int updated { get; set; }
			public string url { get; set; }
			public bool is_optout_ads { get; set; }
		}

		public class Reblog
		{
			public string comment { get; set; }
			public string tree_html { get; set; }
		}

		public class Theme
		{
			public string avatar_shape { get; set; }
			public string background_color { get; set; }
			public string body_font { get; set; }
			public string header_bounds { get; set; }
			public string header_image { get; set; }
			public string header_image_focused { get; set; }
			public string header_image_scaled { get; set; }
			public bool header_stretch { get; set; }
			public string link_color { get; set; }
			public bool show_avatar { get; set; }
			public bool show_description { get; set; }
			public bool show_header_image { get; set; }
			public bool show_title { get; set; }
			public string title_color { get; set; }
			public string title_font { get; set; }
			public string title_font_weight { get; set; }
		}

		public class Blog2
		{
			public string name { get; set; }
			public bool active { get; set; }
			public Theme theme { get; set; }
			public bool share_likes { get; set; }
			public bool share_following { get; set; }
			public bool can_be_followed { get; set; }
		}

		public class Post2
		{
			public object id { get; set; }
		}

		public class Trail
		{
			public Blog2 blog { get; set; }
			public Post2 post { get; set; }
			public string content_raw { get; set; }
			public string content { get; set; }
			public bool is_current_item { get; set; }
			public bool is_root_item { get; set; }
		}

		public class OriginalSize
		{
			public string url { get; set; }
			public int width { get; set; }
			public int height { get; set; }
		}

		public class AltSize
		{
			public string url { get; set; }
			public int width { get; set; }
			public int height { get; set; }
		}

		public class Photo
		{
			public string caption { get; set; }
			public OriginalSize original_size { get; set; }
			public List<AltSize> alt_sizes { get; set; }
		}

		public class Post
		{
			public string type { get; set; }
			public string blog_name { get; set; }
			public object id { get; set; }
			public string post_url { get; set; }
			public string slug { get; set; }
			public string date { get; set; }
			public int timestamp { get; set; }
			public string state { get; set; }
			public string format { get; set; }
			public string reblog_key { get; set; }
			public List<object> tags { get; set; }
			public string short_url { get; set; }
			public string summary { get; set; }
			public object recommended_source { get; set; }
			public object recommended_color { get; set; }
			public int note_count { get; set; }
			public string caption { get; set; }
			public Reblog reblog { get; set; }
			public List<Trail> trail { get; set; }
			public string image_permalink { get; set; }
			public List<Photo> photos { get; set; }
			public bool can_like { get; set; }
			public bool can_reblog { get; set; }
			public bool can_send_in_message { get; set; }
			public bool can_reply { get; set; }
			public bool display_avatar { get; set; }
			public string title { get; set; }
			public string body { get; set; }
		}

		public class Response
		{
			public Blog blog { get; set; }
			public List<Post> posts { get; set; }
			public int total_posts { get; set; }
			public List<object> supply_logging_positions { get; set; }
		}

		public class RootObject
		{
			public Meta meta { get; set; }
			public Response response { get; set; }
        }
    }
}
