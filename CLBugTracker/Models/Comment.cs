using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerLibrary.Models
{
    public class Comment
    {
        public int comment_Id { get; set; }
        public int user_Id { get; set; }
        public int issue_Id { get; set; }
        public string content_ { get; set; }
    }
}
