using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Course
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Instructor { get; set; }
        public List<Student> Students { get; set; }

        public List<Student> GetStudents() 
        { 
            return Students; 
        }
    }
}
