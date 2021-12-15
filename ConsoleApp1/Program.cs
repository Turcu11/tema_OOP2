using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Facultate Universitatea_Emanuel_din_Oradea = new Facultate("Universitatea Emanuel din Oradea");
            Universitatea_Emanuel_din_Oradea.Students = new Student[] { new Student("Turcu", "Iosif", new DateTime(2001, 08, 11), "001"),
            new Student("Petrila", "Damaris", new DateTime(2001, 08, 27), "002"),
            new Student("Feher", "Stefan", new DateTime(2002, 04, 11), "003"),
            new Student("Andrei", "Daniel", new DateTime(2001, 11, 08), "004") };

            Console.WriteLine(Universitatea_Emanuel_din_Oradea.Index("003"));
        }
    }
}
