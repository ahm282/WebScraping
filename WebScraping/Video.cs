﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace WebScraping
{
    public class Video
    {
        private string title;
        private string author;
        private string viewCount;
        private string uploadTimestamp;
        private string url;
        private string thumbnail;

        public Video() {}

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string ViewCount
        {
            get { return viewCount; }
            set { viewCount = value; }
        }

        public string UploadTimestamp
        {
            get { return uploadTimestamp; }
            set { uploadTimestamp = value; }
        }

        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        public string Thumbnail
        { 
            get { return thumbnail; }
            set {  thumbnail = value; }
        }
    }
}
