using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H2School_ForumDB_Web.Models
{
    public class Topic
    {
        public int TopicID { get; set; }
        public Category CategoryID { get; set; }
        public User UserID { get; set; }
        public string HeadLine { get; set; }
        public string BodyText { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
