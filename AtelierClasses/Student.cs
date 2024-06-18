using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtelierClasses
{
    public class Student
    {
        private string Name;
        private List<float> Grades;

        public Student(string name, List<float> grades) // constructor of student
        {
            Name = name;
            Grades = grades;
        }

        public void TalkToSomeone(Student student) // method where a student talks to someone
        {
            Console.WriteLine("blablabla...");
        }

        public void ShoutAtSomeone(Student student) // method where a student shouts at someone
        {
            Console.WriteLine("BLABLABLA!!!!!");
        }


        // getters and setters
        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public List<float> GetGrades()
        {
            return Grades;
        }

        public void AddGrade(float grade)
        {
            Grades.Add(grade);
        }
    }
}