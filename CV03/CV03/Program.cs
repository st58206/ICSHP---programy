using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fei.BaseLib;

namespace CV03
{
    public enum FakultaEnum
    {
        //Resharper disable InconsistentNaming
        FEI,
        FES,
        FF,
        FCHT
        //Resharper enable InconsistentNaming
    }

    internal class Student
    {
        private string jmeno;

        //Resharper disable InconsistentNaming
        public string Jmeno
        {
            get => jmeno;
            set => jmeno = value;
        }
        public int Cislo { get; set; }

        public FakultaEnum Fakulta { get; set; }

        public override string ToString()
        {
            return $"{Jmeno} {Cislo} {Fakulta}";
        }
    }

    internal class Program
    {
        private delegate int StudentsComparator(Student student, Student anotherStudent);

        private static int Compare(Student student, Student anotherStudent)
        {
            //Resharper disable PossibleNullReferenceException
            return student.Cislo - anotherStudent.Cislo;
            //Resharper enable PossibleNullReferenceException
        }

        //Seřazení podle čísla
        private static void Sort(Student[] students, StudentsComparator comparator)
        {
            for (int i = 0; i < students.Length; i++)
            {
                for (int j = 0; j < students.Length - 1; j++)
                {
                    if (comparator(students[j],students[j + 1]) > 1)
                    {
                        Student pom = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = pom;
                    } 
                }
            }
        }

        private delegate int StudentsNameComparator(Student student, Student anotherStudent);

        private static int CompareName(Student student, Student anotherStudent)
        {
            //Resharper disable PossibleNullReferenceException
            return String.Compare(student.Jmeno, anotherStudent.Jmeno);
            //Resharper enable PossibleNullReferenceException
        }

        //Seřazení podle Jména
        private static void SortName(Student[] students, StudentsNameComparator comparator)
        {
            for (int i = 0; i < students.Length; i++)
            {
                for (int j = 0; j < students.Length - 1; j++)
                {
                    if (comparator(students[j], students[j + 1]) > 0)
                    {
                        Student pom = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = pom;
                    }
                }
            }
        }

        private delegate int StudentsFacultyComparator(Student student, Student anotherStudent);

        private static int CompareFaculty(Student student, Student anotherStudent)
        {
            return student.Fakulta - anotherStudent.Fakulta;
        }

        //Seřazení podle fakulty
        private static void SortFaculty(Student[] students, StudentsFacultyComparator comparator)
        {
            for (int i = 0; i < students.Length; i++)
            {
                for (int j = 0; j < students.Length - 1; j++)
                {
                    if (comparator(students[j], students[j + 1]) > 0)
                    {
                        Student pom = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = pom;
                    }
                }
            }
        }

        private static void Main(string[] args)
        {
            var students = new Student[10];
            var random = new Random();
            for(var i = 0; i < students.Length; i++)
            {
                var cislo = random.Next(10,100);
                students[i] = new Student
                {
                    Jmeno = $"Student{cislo}",
                    Cislo = cislo,
                    Fakulta = (FakultaEnum) random.Next(4)
                };
            }


            int polozka = 10;

            while (polozka != 0)
            {
                //Uživatelské menu
                Console.WriteLine();
                Console.WriteLine("1. Načtení studentů z klávesnice");
                Console.WriteLine("2. Výpis studentů na obrazovku");
                Console.WriteLine("3. Seřazení studentů podle čísla");
                Console.WriteLine("4. Seřazení studentů podle jména");
                Console.WriteLine("5. Seřazení studentů podle fakulty");
                Console.WriteLine("0. Konec programu");
                Console.WriteLine();

                Console.WriteLine("Zadej číslo pro výběr dané položky: ");
                polozka = Convert.ToInt32(Console.ReadLine());
                //Spouštění metod pro dané zadané číslo vycházející z uživatelského menu
                switch (polozka)
                {
                    case 1:
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine();
                        foreach (var student in students)
                        {
                            Console.WriteLine(student);
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine();
                        Sort(students, Compare);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine();
                        SortName(students, CompareName);
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine();
                        SortFaculty(students, CompareFaculty);
                        Console.ReadKey();
                        break;
                    case 0:
                        polozka = 0;
                        break;
                    default:
                        Console.WriteLine("Špatná hodnota vstupu.");
                        Console.ReadKey();
                        break;
                }


            }
            Console.ReadKey();
        }
    }
}
