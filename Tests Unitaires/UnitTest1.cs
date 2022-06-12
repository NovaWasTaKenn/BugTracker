using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using Bugtracker;

namespace Tests_Unitaires
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DBConnection()
        {
            DataAccess dataAccess = new DataAccess();
            List<BugTrackerLibrary.Issue> result = dataAccess.GetIssues("quelconque").ToList();
            Assert.IsNotNull(result);
            Assert.AreEqual("quelconque", result[0].name);
        }
    }
}