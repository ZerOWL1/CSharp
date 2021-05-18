using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.Selection_Switch
{
    class Program
    {
        enum Color : int
        {
            Red,
            Yellow,
            Green
        }

        /// <summary>
        /// 5. Selection Statement
        /// - if
        /// - if else / if elseif else / nested if
        /// - switch case
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region if_else

            /*Enter:
            Console.Write($"| Please enter a number: ");
            string input = Console.ReadLine();
            bool isNumber = Int32.TryParse(input, out int ouput);

            if (!isNumber)
            {
                Console.WriteLine("| You've not enter a number!! Please enter again!!");
                goto Enter;;
            }
            else
            {
                if (ouput % 2 == 0)
                {
                    Console.WriteLine("| You've enter a even number!!");
                }
                else
                {
                    Console.WriteLine("| You've enter a odd number!!");
                }

            }

            Console.ReadKey();*/

            #endregion

            #region switch_case with enum
            /*Enter:
            string inputNumCorlor = "";
            Console.WriteLine("|------------- Welcome to our Program -------------|");
            Console.WriteLine("| 0. Exit ");
            Console.WriteLine("| 1. Return Program ");
            Console.WriteLine("| 2. Choose Color: ");
            Console.WriteLine("|    a. 0. Red ");
            Console.WriteLine("|    b. 1. Yellow ");
            Console.WriteLine("|    c. 2. Green ");
            Console.Write($"| Please enter the number: ");
            inputNumCorlor = Console.ReadLine();
            bool isNumber = Int32.TryParse(inputNumCorlor, out int ouput);

            if (!isNumber)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("| You've not enter a number, please enter again!!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                goto Enter;
            }
            else
            {
                switch (ouput)
                {
                    default: break;
                    case 0:
                    {
                        Console.WriteLine("| You've choose Exit. Hope you enjoy our program!!");
                        break;
                    }
                    case 1:
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine();
                        Console.WriteLine("| You've want return program!!");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        goto Enter;
                    }
                    case 2:
                    {
                        EnterCase2:
                        Console.WriteLine();
                        Console.Write($"| Please enter the number of Color or Choose Other to EXIT: ");
                        inputNumCorlor = Console.ReadLine();
                        bool isCase2NUM = Int32.TryParse(inputNumCorlor, out int case2OUT);

                        if (!isCase2NUM)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("| You've not enter a number, please enter again!!");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            goto EnterCase2;
                        }
                        else
                        {
                            switch (case2OUT)
                            {
                                default:
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("| You've want return program!!");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine();
                                    goto Enter;
                                case (int) Color.Red:
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("| You've choose Red!!");
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    goto EnterCase2;
                                }
                                case (int) Color.Green:
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("| You've choose Green!!");
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    goto EnterCase2;
                                }
                                case (int) Color.Yellow:
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("| You've choose Yellow!!");
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    goto EnterCase2;
                                }
                            }
                        }
                        break;;
                    }
                }
            }

            Console.ReadKey();*/
            #endregion

            

        }
    }
}
