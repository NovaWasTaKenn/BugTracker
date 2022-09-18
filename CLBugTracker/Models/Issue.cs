using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerLibrary.Models
{
    public class Issue
    {
        public string? reportedby_Id { get; set; }
        public int issue_Id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public int? status { get; set; } // Enum en SQL ? en C#
        public string? projet_Name { get; set; }
        public int importance_Level { get; set; }
        public int difficulty_Level { get; set; }

    }
}
