using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using H2School_ForumDB_Web.Models;

namespace H2School_ForumDB_Web.Repositories
{
    public interface ITopicsRepository
    {
        List<Topic> GetTopicFromDate(DateTime date);
        Topic CreateTopic(string headLine, string bodyText, User user, Category category);
        void DeleteTopic(Topic topic);
        List<Topic> GetAllTopics();
        Topic GetTopicByID(int id);
        List<Topic> GetTopicByCategory(Category category);
        List<Topic> GetTopicByAuthor(User user);
        List<Topic> GetTopicByDate(DateTime date);
        Topic UpdateTopic(Topic topic, string headLine, string bodyText);
    }
}
