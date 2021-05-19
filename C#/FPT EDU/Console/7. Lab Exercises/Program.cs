using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _7.Lab_Exercises.Controllers;

namespace _7.Lab_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
        Enter:
            Console.WriteLine("|------------ Welcome to my Lab 1 Program ------------|");
            Console.WriteLine("| 1. Add. ");
            Console.WriteLine("| 2. Show. ");
            Console.WriteLine("| 3. Search. ");
            Console.WriteLine("| 4. Statistics. ");
            Console.WriteLine("| 5. Exit. ");
            Console.Write("| Enter a option (1-5): ");
            string input = Console.ReadLine();
            bool isNumber = Int32.TryParse(input, out int ouputNumber);

            //check number
            if (!isNumber)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("| You've not enter a number!! Please check again!!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                goto Enter;
            }
            else
            {
                switch (ouputNumber)
                {
                    default:
                        Console.WriteLine("| Not found option!!");
                        goto Enter;
                    case 1:
                        {
                            CalculationFunc.addValue();
                            goto Enter;
                        }
                    case 2:
                        {
                            CalculationFunc.showValue();
                            goto Enter;
                        }
                    case 3:
                        {
                            CalculationFunc.searchValue();
                            goto Enter;
                        }
                    case 4:
                        {
                            CalculationFunc.showStatistics();
                            goto Enter;
                        }
                    case 5:
                        {
                            Console.WriteLine("| You've want to EXIT!! Thanks for using!");
                            break;
                        }
                }
            }
            Console.ReadKey();
        }
    }
}
