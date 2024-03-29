﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
	public class ComicBook
	{
		public int Id { get; set; }
		public string SeriesTitle { get; set; }
		public int IssueNumber { get; set; }
		public string DescriptionHtml {get; set; }
		public string[] Artists { get; set; }
		public bool Favourite { get; set; }
	}
}