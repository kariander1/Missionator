using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Missionator
{
    public class Mission
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Orginizer { get; set; }
        public bool Done { get; set; }
        public DateTime DueDate { get; set; }
        public List<string> Recipients { get; set; }
        public Mission(string title,string body,bool done,DateTime dueDate,List<string> recipients,string orginizer)
        {
            this.Orginizer = orginizer;
            this.Title = title;
            this.Body = body;
            this.Done = done;
            this.DueDate = dueDate;
            this.Recipients = recipients;
        }
    }
}
