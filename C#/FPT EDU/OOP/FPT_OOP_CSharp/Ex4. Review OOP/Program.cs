using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex4.Review_OOP.Controller;
using Ex4.Review_OOP.Models.Entity;

namespace Ex4.Review_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
        Enter:
            Console.WriteLine("|_____ Program ____");
            Console.WriteLine("| 1. Add Student");
            Console.WriteLine("| 2. Show Student");
            Console.WriteLine("| 3. Add Teacher");
            Console.WriteLine("| 4. Show Teacher");
            Console.WriteLine("| 5. Exit");
            Console.Write($"| Enter number (1-5): ");
            string input = Console.ReadLine();

            bool isNumber = Int32.TryParse(input, out int output);
            if (!isNumber)
            {
                Console.WriteLine("| You've not enter number, Please Enter Again! \n");
                goto Enter;
            }
            else
            {
                switch (output)
                {
                    default:
                        {
                            Console.WriteLine("| You've not Enter True Number. Please Enter Again!! \n");
                            goto Enter;
                        }
                    case 1:
                        {
                            StudentControl.AddStudent();
                            goto Enter;
                        }
                    case 2:
                        {
                            StudentControl.ShowStudent();
                            goto Enter;
                        }
                    case 3:
                        {
                            StudentControl.AddTeacher();
                            goto Enter;
                        }
                    case 4:
                        {
                            StudentControl.ShowTeaher();
                            goto Enter;
                        }
                    case 5:
                        {
                            Console.WriteLine("| You've want to Exit!");
                            break;
                        }
                }
            }
        }
    }
}
