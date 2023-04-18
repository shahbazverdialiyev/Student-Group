using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Group.Models
{
    internal class Student
    {
        private static int id = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int GroupId { get; set; }
        public Student(string name, string surname, int groupId)
        {
            Id = ++id;
            Name = name;
            Surname = surname;
            GroupId = groupId;
        }
    }
}
