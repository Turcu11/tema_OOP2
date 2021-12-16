using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Facultate
    {
        public string NumeFacultate { get; set; }
        public Student[] Students;

        public Facultate(string Name)
        {
            this.NumeFacultate = NumeFacultate;
        }

        public string Index (string NumarMatricol)
        {
            for (int i = 0; i < NumarMatricol.Length+1; i++)
            {
                if (string.Equals(NumarMatricol, Students[i].NumarMatricol)) 
                {
                    string stud = Students[i].FirstName + " " + Students[i].LastName;
                    return stud;
                }
            }

            return "Acel student nu exista!";
        }
    }
}