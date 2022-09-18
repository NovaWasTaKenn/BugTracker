using Bugtracker;
using BugTrackerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerLibrary
{
    public class BugTrackerData : IBugTrackerData
    {
        private readonly IDataAccess _db;

        public BugTrackerData(IDataAccess db)
        {
            this._db = db;
        }

        public Task<List<Issue>> GetIssue(string searchParameters)
        {
            string sqlCommand = "Call prcGetIssue(@searchPrameters)";

            return _db.LoadData<Issue, dynamic>(sqlCommand, searchParameters);
        }

        public Task<List<Issue>> GetAllIssue()
        {
            string sqlCommand = "SELECT * FROM BugTracker.dbo.Issues";
            return _db.LoadData<Issue, dynamic>(sqlCommand, new {});
        }

        public Task AddComment(Comment comment)
        {
            string sqlCommand = "Call prcAddComment(@user_Id, @issue_Id, @content)";

            return _db.SaveData<Comment>(sqlCommand, comment);
        }

        public Task AddIssues(Issue issue)
        {
            string sqlCommand = "Call prcAddIssues(@reportedby_id, @name, @description, @project_Name)";

            return _db.SaveData<Issue>(sqlCommand, issue);
        }
        public Task AddFile(Models.File file)
        {
            string sqlCommand = "Call prcAddFiles(@issue_Id, @name, @comment_Id, @type,@taile, @bin)";

            return _db.SaveData<Models.File>(sqlCommand, file);

        }
        public Task UpdateDifficultyLevel(int issue_Id, char difficultyLevel)
        {
            string sqlCommand = "Call prcUpdateDifficultyLevel(@newDifficultyLevel, @issue_Id)";

            return _db.SaveData<object>(sqlCommand, new { newDifficultyLevel = difficultyLevel, issue_Id = issue_Id });
        }
        public Task UpdateIssue(string _name, string _description, char _status, string projectName, char difficultyLevel, char severityLevel, int issueId)
        {
            string sqlCommand = "Call prcUpdateIssue(@name, @description, @status, @project_Name, @difficulty_Level, @severity_Level, @issue_Id)";

            return _db.SaveData<object>(sqlCommand, new { name = _name, description = _description, status = _status, project_Name = projectName, difficulty_Level = difficultyLevel, severity_Level = severityLevel, issue_Id = issueId });
        }
        public Task UpdateIssueStatus(int issue_Id, char status)
        {
            string sqlCommand = "Call prcUpdateIssueStatus(@newIssueStatus, @issue_Id)";

            return _db.SaveData<object>(sqlCommand, new { newIssueStatus = status, issue_Id = issue_Id });
        }
        public Task UpdateSeverityLevel(int issue_Id, char severityLevel)
        {
            string sqlCommand = "Call prcUpdateSeverityLevel(@newDifficultyLevel, @issue_Id)";

            return _db.SaveData<object>(sqlCommand, new { newSeverityLevel = severityLevel, issue_Id = issue_Id });
        }
    }
}