using BugTrackerLibrary;
using Dapper;
using System.Data;

namespace Bugtracker
{
    public class DataAccess
    {
        public List<Issue> GetIssues(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnHelper.ConnVal("DefaultConnection")))
            {
               return connection.Query<Issue>($"SELECT FROM Issues WHERE name = '{name}'").ToList();
            }
        }
          
    }
}
