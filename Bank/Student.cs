using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public string StudentPhone { get; set; }
        public static Dictionary<string, int> Grades { get; set; }

        public static void AverageGrade()
        {
            int averageGrade = 0;
            foreach (var grade in Grades)
            {
                averageGrade += grade.Value;
            }

            Console.WriteLine($"Average Grade is {averageGrade / Grades.Count}");
        }
    }
}
