using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab1_HE141223_HaiLD.Controllers;

namespace Lab1_HE141223_HaiLD
{
    class Program
    {
        /// <summary>
        /// Lab 1.
        ///  - Luc Duong Hai - HaiLD _ HE141223
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
        Enter:
            Console.WriteLine("1. Add. ");
            Console.WriteLine("2. Show. ");
            Console.WriteLine("3. Search. ");
            Console.WriteLine("4. Statistics. ");
            Console.WriteLine("5. Exit. ");
            Console.Write("Enter a option (1-5): ");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                default:
                    Console.WriteLine("| Not found option!!");
                    goto Enter;
                case 1:
                    {
                        CalculatorControl.addValue();
                        goto Enter;
                    }
                case 2:
                    {
                        CalculatorControl.showValue();
                        goto Enter;
                    }
                case 3:
                    {
                        CalculatorControl.searchValue();
                        goto Enter;
                    }
                case 4:
                    {
                        CalculatorControl.showStatistics();
                        goto Enter;
                    }
                case 5:
                    {
                        Console.WriteLine("You've want to EXIT!! Thanks for using!");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
