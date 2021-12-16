using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NumarMatricol { get; set; }

        public Student(string FirstName, string LastName, DateTime DateOfBirth, string NumarMatricol)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.NumarMatricol = NumarMatricol;
        }
    }
}
