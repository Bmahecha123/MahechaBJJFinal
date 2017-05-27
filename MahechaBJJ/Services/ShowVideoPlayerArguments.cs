﻿using System;
namespace MahechaBJJ.Services
{
	public class ShowVideoPlayerArguments
	{
		public string Url { get; private set; }

		public ShowVideoPlayerArguments(string url)
		{
			Url = url;
		}
	}
}
