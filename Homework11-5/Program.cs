using System;

namespace Homework11_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double minSalary = 42500;

            var student1 = new Student
            {
                FIO = "Sholohov Dmitriy",
                Group = "1VT-117",
                IncomePerFamilyMember = 98000,
                Pol = Pol.Male,
                FormOfEducation = FormOfEducation.Extramural
            };

            var student2 = new Student
            {
                FIO = "Ahmatova Maria",
                Group = "1VT-117",
                IncomePerFamilyMember = 95000,
                Pol = Pol.Female,
                FormOfEducation = FormOfEducation.FullTime
            };

            var student3 = new Student
            {
                FIO = "Korshynov Petr",
                Group = "",
                IncomePerFamilyMember = 40000,
                Pol = Pol.Male,
                FormOfEducation = FormOfEducation.Remote
            };

            int arraySize = 3;
            Student[] students = new Student[arraySize];
            students[0] = student1;
            students[1] = student2;
            students[2] = student3;

            Array.Sort(students, delegate (Student student1, Student student2)
            {
                return student1.IncomePerFamilyMember.CompareTo(student2.IncomePerFamilyMember);
            });

            int number = 1;
            foreach (var student in students)
            {
                if (student.IncomePerFamilyMember < minSalary * 2)
                {
                    Console.WriteLine($"{number}. {student.FIO}");
                }
            }




        }
    }
}
