using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex4.Review_OOP.Models.Entity;

namespace Ex4.Review_OOP.Controller
{
    class StudentControl
    {
        private static ArrayList list = new ArrayList();
        private static string status = string.Empty;
        public static void AddStudent()
        {
            while (true)
            {
                EnterStudent:
                try
                {
                    Console.WriteLine("\n| Enter Student....");
                    Console.Write("| ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("| Name: ");
                    string name = Console.ReadLine();
                    Console.Write("| Age: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write("| .Net Mark: ");
                    decimal _netMark = decimal.Parse(Console.ReadLine());
                    Console.Write("| Java Mark: ");
                    decimal javaMark = decimal.Parse(Console.ReadLine());
                    Student st = new Student(id, name, age, _netMark, javaMark);
                    list.Add(st);
                    Console.WriteLine();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("| Please Enter Again!!");
                    status = "| Error while enter value " + e.Message;
                    goto EnterStudent;
                }
            }
        }

        public static void ShowStudent()
        {
            Console.WriteLine("\n| All Student info: ");
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is Student)
                {
                    Student s = (Student) list[i];
                    Console.WriteLine($"| {s.ToString()}");
                }
            }
        }

        public static void AddTeacher()
        {
            while (true)
            {
                EnterStudent:
                try
                {
                    Console.WriteLine("\n| Enter Teacher....");
                    Console.Write("| ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("| Name: ");
                    string name = Console.ReadLine();
                    Console.Write("| Age: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write("| ClassNumber: ");
                    decimal classNum = decimal.Parse(Console.ReadLine());
                    Console.Write("| SubjectNumber: ");
                    decimal subjNum = decimal.Parse(Console.ReadLine());
                    Teacher tc = new Teacher(id, name, age, classNum, subjNum);
                    list.Add(tc);
                    Console.WriteLine();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("| Please Enter Again!!");
                    status = "| Error while enter value " + e.Message;
                    goto EnterStudent;
                }
            } 
        }

        public static void ShowTeaher()
        {
            Console.WriteLine("\n| All Teacher info: ");
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is Teacher)
                {
                    Teacher t = (Teacher) list[i];
                    Console.WriteLine(t.ToString());
                }
            }
        }
    }
}
