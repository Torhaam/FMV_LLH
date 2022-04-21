using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testlectvideo
{
    internal class Video
    {
        public string url;
        public string title;
        public string description;
        readonly int choice;
        public Video(string url,string title,string description,int choice)
        {
            this.url = url;
            this.title = title;
            this.description = description;
            
            this.choice = choice;
        }
        public string Url
        {
            get { return url; }
        }

        public string Title
        {
            get { return title; }
        }

        public int Choice {
            get { return choice; }
                }
    }
}
