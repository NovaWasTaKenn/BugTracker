using BugTrackerLibrary.Models;

namespace BugTrackerLibrary
{
    public interface IBugTrackerData
    {
        Task AddComment(Comment comment);
        Task AddFile(Models.File file);
        Task AddIssues(Issue issue);
        Task<List<Issue>> GetIssue(string searchParameters);
        Task UpdateDifficultyLevel(int issue_Id, char difficultyLevel);
        Task UpdateIssue(string _name, string _description, char _status, string projectName, char difficultyLevel, char severityLevel, int issueId);
        Task UpdateIssueStatus(int issue_Id, char status);
        Task UpdateSeverityLevel(int issue_Id, char severityLevel);
    }
}