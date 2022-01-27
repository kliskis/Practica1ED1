using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace HelloWorld1.Models
{
    public class Student
    {
        public string StudentName { get; set; }
        public string StudentId { get; set; }
        public string StudentGrade { get; set; }

        public string GetInfo()
        {
            return $"Hello {StudentName} your ID is: {StudentId} and your grade is: {StudentGrade}";
        }
    }
    public class ClassRoom
    {
        private static List<Student> _students = new List<Student>();
        public List<Student> Students { get { return _students; } }

    }
}
