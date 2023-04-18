using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Student_Group.Models
{
    internal class Group
    {
        private static int id = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public Group(string name)
        {
            Id=++id;
            Name = name;
        }
    }
}
