﻿using System;
namespace MahechaBJJ.Service
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
