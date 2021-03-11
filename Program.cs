using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using H2School_ForumDB_Web.Data;
using H2School_ForumDB_Web.Models;
using H2School_ForumDB_Web.Repositories;

namespace H2School_ForumDB_Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConnectionConfig.ConnectionSQL();
            //TopicRepository myRep = new TopicRepository();
            //Topic t = myRep.CreateTopic("Hej", "Med dig", 1, 2);
            //myRep.DeleteTopic(t);
            //List<Topic> topics = myRep.GetAllTopics();
            //List<Topic> userTopics = myRep.GetTopicByAuthor(1);
            //List<Topic> categoryTopics = myRep.GetTopicByCategory(2);
            //List<Topic> dateTopics = myRep.GetTopicByDate(DateTime.Now);
            //Topic topic = myRep.GetTopicByID(2);

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
