using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerLibrary
{
    internal class User
    {
        public int user_Id { get; set; }
        public int issue_Id { get; set; }
        public string email { get; set; }
        public string role { get; set; }
        public string name { get; set; }
    }
}
