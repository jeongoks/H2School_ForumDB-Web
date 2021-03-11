using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using H2School_ForumDB_Web.Models;

namespace H2School_ForumDB_Web.Repositories
{
    public interface ITopicsRepository
    {
        Topic CreateTopic(string headLine, string bodyText, int user, int category);
        void DeleteTopic(Topic topic);
        List<Topic> GetAllTopics();
        Topic GetTopicByID(int id);
        List<Topic> GetTopicByCategory(int category);
        List<Topic> GetTopicByAuthor(int user);
        List<Topic> GetTopicByDate(DateTime date);
        Topic UpdateTopic(Topic topic, string headLine, string bodyText);
    }
}
