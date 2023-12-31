﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraping
{
    public class Job
    {
        private string title;
        private string company;
        private string location;
        private string keywords;
        private string detailsUrl;
        private string datePosted;
        private string organizationImage;
        
        public Job() { }

        public string Title { get => title; set => title = value; }
        public string Company { get => company; set => company = value; }
        public string Location { get  => location; set => location = value; }
        public string Keywords { get => keywords; set => keywords = value; }
        public string DetailsUrl { get => detailsUrl; set => detailsUrl = value; }
        public string DatePosted { get => datePosted; set => datePosted = value; }
        public string OrganizationImage { get => organizationImage; set => organizationImage = value; }
    }
}
