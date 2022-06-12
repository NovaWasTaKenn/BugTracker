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
        public void AddIssue(string name, string reportedby_id, string description, int status = 0/* statut = pas commencé*/, 
            string project_name, int importance_level=-1, int difficulty_level = -1 /*-1 = non défini*/)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnHelper.ConnVal("DefaultConnection")))
            {
                connection.Query<Issue>($"" +
                    $"").ToList();
            }
        }
          
    }
}
