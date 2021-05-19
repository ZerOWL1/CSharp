using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q2.Models;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int numberStudents;
            Console.Write("Enter the number of students: ");
            numberStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberStudents; i++)
            {
                string id = "";
                do
                {
                    Console.Write("Enter ID: ");
                    id = Console.ReadLine();
                } while (students.Where(s => s.StudentID == id).FirstOrDefault() != null);

                string name;
                Console.Write("Enter Name: ");
                name = Console.ReadLine();
                Student student = new Student(id, name);
                students.Add(student);
            }
            Course course = new Course("PRN292", students);
            Console.Write(course);

            Console.ReadLine();
        }
    }
}
