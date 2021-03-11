using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H2School_ForumDB_Web.Models
{
    public class TopicTags
    {
        public int TopicTagID { get; set; }
        public Tags TagId { get; set; }
        public Topic TopicID { get; set; }
    }
}
