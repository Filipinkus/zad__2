using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace zad__2
{
    internal class Program
    {
        static void InsertionSort(List<Student> students, Comparison<Student> comparison)
        {
            for (int i = 1; i < students.Count; i++)
            {
                Student key = students[i];
                int j = i - 1;
                while (j >= 0 && comparison(students[j], key) > 0)
                {
                    students[j + 1] = students[j];
                    j--;
                }
                students[j + 1] = key;
            }
        }
        static void Main()
        {
            List<Student> students = new List<Student> {
            new Student("Ana", 5.50),
            new Student("Boris", 4.80),
            new Student("Vasil", 6.00),
            new Student("Ivana", 5.50),
            new Student("Galq", 5.00)
        };

            InsertionSort(students, (s1, s2) => s1.Grade.CompareTo(s2.Grade));
            InsertionSort(students, (s1, s2) => s1.Name.CompareTo(s2.Name));

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
