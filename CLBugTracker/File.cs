using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerLibrary
{
    internal class File  // revoir structure de classe est ce que
                         // meilleur moyen de stocker fichier en C#
    {
        public int file_Id { get; set; }
        public int issue_Id { get; set; }
        public string name { get; set; }
        public int comment_Id { get; set; }
        public string type { get; set; }
        public int size { get; set; }
        public int MyProperty { get; set; }//Blob ds SQL quoi en C#

    }
}
