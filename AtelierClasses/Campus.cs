using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtelierClasses
{
    public class Campus
    {
        private string Name { get; set; }
        private List<Student> Students { get; set; }

        public Campus (string name, List<Student> students) // constructor
        {
            Name = name;
            Students = students;
        }

        public void DisplayStudents (List<Student> students) // method to get student's names from a given campus
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.GetName());
            }
        }

        public void GetAverageGrades(List<Student> students) 
        {
            float sum = 0;
            int countGrades = 0;

            foreach (Student student in students) // loop into students
            {
                foreach (float grade in student.GetGrades()) // loop into Grades from each student
                {
                    sum += grade; // add a new grade to the sum to get the total sum of the campus
                    countGrades ++; // count the total grades in the campus
                }
            }

            float averageGrades = sum / countGrades; // get the average
            Console.WriteLine("The average grade of the campus is " + averageGrades);

        }
    }
}