using H2School_ForumDB_Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using H2School_ForumDB_Web.Data;
using System.Data;

namespace H2School_ForumDB_Web.Repositories
{
    public class TopicRepository : ITopicsRepository
    {
        /// <summary>
        /// This is where we create our new Topic through a connection to our SQL server.
        /// </summary>
        /// <param name="headLine"></param>
        /// <param name="bodyText"></param>
        /// <param name="user"></param>
        /// <param name="category"></param>
        /// <returns></returns>
        public Topic CreateTopic(string headLine, string bodyText, int user, int category)
        {
            Topic myTopic = null;
            SqlDataReader myReader = null;
            SqlConnection myConnection = new SqlConnection(ConnectionConfig.ConnectionSQL());
            SqlCommand myCommand = new SqlCommand("spCreateNewTopic", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.AddWithValue("@headLine", headLine);
            myCommand.Parameters.AddWithValue("@bodyText", bodyText);
            myCommand.Parameters.AddWithValue("@user_ID", user);
            myCommand.Parameters.AddWithValue("@category_ID", category);
            try
            {
                myConnection.Open();
                myReader = myCommand.ExecuteReader();
                if (myReader.Read())
                {
                    myTopic = new Topic();
                    myTopic.TopicID = Convert.ToInt32(myReader["Topics_ID"]);
                    myTopic.HeadLine = myReader["HeadLine"].ToString();
                    myTopic.BodyText = myReader["BodyText"].ToString();
                    myTopic.UserID = Convert.ToInt32(myReader["User_ID"]);
                    myTopic.CategoryID = Convert.ToInt32(myReader["Category_ID"]);
                    myTopic.CreateTime = Convert.ToDateTime(myReader["CreateTime"]);
                }
            }
            finally
            {
                myConnection.Close();
            }
            return myTopic;
        }

        /// <summary>
        /// This is where we Delete our Topics through a connection to our SQL server.
        /// </summary>
        /// <param name="topic">Needing a Topic to delete it.</param>
        public void DeleteTopic(Topic topic)
        {
            {
                SqlConnection myConnection = new SqlConnection(ConnectionConfig.ConnectionSQL());
                SqlCommand myCommand = new SqlCommand("spDeleteTopic", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("@topics_ID", topic.TopicID);
                try
                {
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                }
                finally
                {
                    myConnection.Close();
                }
            }
        }

        /// <summary>
        /// This is where we Show all our Topics through a connection to our SQL server.
        /// </summary>
        /// <returns></returns>
        public List<Topic> GetAllTopics()
        {
            List<Topic> myTopics = new List<Topic>();
            SqlDataReader myReader = null;
            SqlConnection myConnection = new SqlConnection(ConnectionConfig.ConnectionSQL());
            SqlCommand myCommand = new SqlCommand("spGetAllTopics", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            try
            {
                myConnection.Open();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    Topic myTopic = new Topic();
                    myTopic.TopicID = Convert.ToInt32(myReader["Topics_ID"]);
                    myTopic.HeadLine = myReader["HeadLine"].ToString();
                    myTopic.BodyText = myReader["BodyText"].ToString();
                    myTopic.UserID = Convert.ToInt32(myReader["User_ID"]);
                    myTopic.CategoryID = Convert.ToInt32(myReader["Category_ID"]);
                    myTopic.CreateTime = Convert.ToDateTime(myReader["CreateTime"]);
                    myTopics.Add(myTopic);
                }
            }
            finally
            {
                myConnection.Close();
            }
            return myTopics;
        }

        /// <summary>
        /// This is where we Show all our Topics by a specific User through a connection to our SQL server.
        /// </summary>
        /// <returns></returns>
        public List<Topic> GetTopicByAuthor(int user)
        {
            {
                List<Topic> myTopics = new List<Topic>();
                SqlDataReader myReader = null;
                SqlConnection myConnection = new SqlConnection(ConnectionConfig.ConnectionSQL());
                SqlCommand myCommand = new SqlCommand("spFilterTopicAfter_Author", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("@user_ID", user);
                try
                {
                    myConnection.Open();
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        Topic myTopic = new Topic();
                        myTopic.TopicID = Convert.ToInt32(myReader["Topics_ID"]);
                        myTopic.HeadLine = myReader["HeadLine"].ToString();
                        myTopic.BodyText = myReader["BodyText"].ToString();
                        myTopic.UserID = Convert.ToInt32(myReader["User_ID"]);
                        myTopic.CategoryID = Convert.ToInt32(myReader["Category_ID"]);
                        myTopic.CreateTime = Convert.ToDateTime(myReader["CreateTime"]);
                        myTopics.Add(myTopic);
                    }
                }
                finally
                {
                    myConnection.Close();
                }
                return myTopics;
            }
        }

        /// <summary>
        /// This is where we Show all our Topics by a specific Category through a connection to our SQL server.
        /// </summary>
        /// <returns></returns>
        public List<Topic> GetTopicByCategory(int category)
        {
            {
                {
                    List<Topic> myTopics = new List<Topic>();
                    SqlDataReader myReader = null;
                    SqlConnection myConnection = new SqlConnection(ConnectionConfig.ConnectionSQL());
                    SqlCommand myCommand = new SqlCommand("spFilterTopicAfter_Category", myConnection);
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("@category_ID", category);
                    try
                    {
                        myConnection.Open();
                        myReader = myCommand.ExecuteReader();
                        while (myReader.Read())
                        {
                            Topic myTopic = new Topic();
                            myTopic.TopicID = Convert.ToInt32(myReader["Topics_ID"]);
                            myTopic.HeadLine = myReader["HeadLine"].ToString();
                            myTopic.BodyText = myReader["BodyText"].ToString();
                            myTopic.UserID = Convert.ToInt32(myReader["User_ID"]);
                            myTopic.CategoryID = Convert.ToInt32(myReader["Category_ID"]);
                            myTopic.CreateTime = Convert.ToDateTime(myReader["CreateTime"]);
                            myTopics.Add(myTopic);
                        }
                    }
                    finally
                    {
                        myConnection.Close();
                    }
                    return myTopics;
                }
            }
        }

        /// <summary>
        /// This is where we Show all our Topics by a specific Date through a connection to our SQL server.
        /// </summary>
        /// <returns></returns>
        public List<Topic> GetTopicByDate(DateTime date)
        {
            {
                {
                    {
                        List<Topic> myTopics = new List<Topic>();
                        SqlDataReader myReader = null;
                        SqlConnection myConnection = new SqlConnection(ConnectionConfig.ConnectionSQL());
                        SqlCommand myCommand = new SqlCommand("spFilterTopicAfter_Date", myConnection);
                        myCommand.CommandType = CommandType.StoredProcedure;
                        myCommand.Parameters.AddWithValue("@createtime", date);
                        try
                        {
                            myConnection.Open();
                            myReader = myCommand.ExecuteReader();
                            while (myReader.Read())
                            {
                                Topic myTopic = new Topic();
                                myTopic.TopicID = Convert.ToInt32(myReader["Topics_ID"]);
                                myTopic.HeadLine = myReader["HeadLine"].ToString();
                                myTopic.BodyText = myReader["BodyText"].ToString();
                                myTopic.UserID = Convert.ToInt32(myReader["User_ID"]);
                                myTopic.CategoryID = Convert.ToInt32(myReader["Category_ID"]);
                                myTopic.CreateTime = Convert.ToDateTime(myReader["CreateTime"]);
                                myTopics.Add(myTopic);
                            }
                        }
                        finally
                        {
                            myConnection.Close();
                        }
                        return myTopics;
                    }
                }
            }
        }

        /// <summary>
        /// This is where we Show a Topic with a specific Topic ID through a connection to our SQL server.
        /// </summary>
        /// <returns></returns>
        public Topic GetTopicByID(int id)
        {
            Topic mytopic = null;
            SqlDataReader myReader = null;
            SqlConnection myConnection = new SqlConnection(ConnectionConfig.ConnectionSQL());
            SqlCommand myCommand = new SqlCommand("spGetTopic", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.AddWithValue("@topic_ID", id);
            try
            {
                myConnection.Open();
                myReader = myCommand.ExecuteReader();
                if (myReader.Read())
                {
                    mytopic = new Topic();
                    mytopic.TopicID = Convert.ToInt32(myReader["Topics_ID"]);
                    mytopic.HeadLine = myReader["HeadLine"].ToString();
                    mytopic.BodyText = myReader["BodyText"].ToString();
                    mytopic.UserID = Convert.ToInt32(myReader["User_ID"]);
                    mytopic.CategoryID = Convert.ToInt32(myReader["Category_ID"]);
                    mytopic.CreateTime = Convert.ToDateTime(myReader["CreateTime"]);
                }
            }
            finally
            {
                myConnection.Close();
            }
            return mytopic;
        }

        public Topic UpdateTopic(Topic topic, string headLine, string bodyText)
        {
            throw new NotImplementedException();
        }
    }
}
