using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using _4.Exercises.Controller;

namespace _4.Exercises
{
    class Program
    {


        static void Main(string[] args)
        {
            //1.	Write a C# program to print the result of dividing 24 into 5 on screen.

            #region Bai 1

            /*Console.Write("| Enter a: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("| Enter b: ");
            int b = Int32.Parse(Console.ReadLine());
            double rs =  (double)a/b;
            Console.WriteLine($"| Result A/B: {rs}");*/

            #endregion

            //2.	

            #region Bai 2

            /*int b2 = -1 + 4 * 6; //23
            int b3 = (35 + 5) % 7; //5
            int b4 = 14 + (-4) * 6 / 11; //12
            int b5 = 2 + 15 / 6 * 1 - 7 % 2; // 2 + 15 / 6 - 7 %2 = 2 + 2 - 1 = 3

            Console.WriteLine($"| b2: {b2}");
            Console.WriteLine($"| b3: {b3}");
            Console.WriteLine($"| b4: {b4}");
            Console.WriteLine($"| b5: {b5}");*/

            #endregion

            //3. 

            #region Bai 3

            /* Enter:
                 Console.WriteLine("|---------- Welcome to our program ----------|");
                 Console.WriteLine("| 0. Exit.");
                 Console.WriteLine("| 1. A + B.");
                 Console.WriteLine("| 2. A - B.");
                 Console.WriteLine("| 3. A * B.");
                 Console.WriteLine("| 4. A / B.");
                 Console.WriteLine("| 5. A % B.");
                 Console.Write("| Please enter select number: ");
                 string input = Console.ReadLine();
                 bool isNumber = Int32.TryParse(input, out int ouput);



                 if (!isNumber)
                 {
                     Console.ForegroundColor = ConsoleColor.Red;
                     Console.WriteLine();
                     Console.WriteLine("| You've not enter a number. Please enter again!!");
                     Console.WriteLine();
                     Console.ForegroundColor = ConsoleColor.White;
                     goto Enter;
                 }
                 else
                 {
                     EX4 ex4 = new EX4();

                     switch (ouput)
                     {
                         default:
                             Console.ForegroundColor = ConsoleColor.Cyan;
                             Console.WriteLine();
                             Console.WriteLine("| You've enter invalid number!! Please try again!!");
                             Console.WriteLine();
                             Console.ForegroundColor = ConsoleColor.White;
                             goto Enter;
                         case 0:
                             {
                                 Console.WriteLine("| Thank you for using our program!! See you next time!!");
                                 break;
                             }
                         case 1:
                             {
                                 ex4.calSum();
                                 goto Enter;
                             }
                         case 2:
                             {
                                 ex4.calSub();
                                 goto Enter;
                             }
                         case 3:
                             {
                                 ex4.calMulti();
                                 goto Enter;
                             }
                         case 4:
                             {
                                 ex4.calDiv();
                                 goto Enter;
                             }
                         case 5:
                             {
                                 ex4.calMod();
                                 goto Enter;
                             }
                     }
                 }*/

            #endregion

            //4.

            #region Bai 4
            /* int rs = 0;
             ArrayList list = new ArrayList();

             Console.Write($"| Enter the first number: ");
             list.Add(Int32.Parse(Console.ReadLine()));

             Console.Write($"| Enter the second number: ");
             list.Add(Int32.Parse(Console.ReadLine()));

             Console.Write($"| Enter the third number: ");
             list.Add(Int32.Parse(Console.ReadLine()));

             Console.Write($"| Enter the four number: ");
             list.Add(Int32.Parse(Console.ReadLine()));

             foreach (int items in list)
             {
                 rs += items;
             }

             rs = rs / list.Count;
             Console.WriteLine($"| The average of them is: {rs}");*/
            #endregion

            //5.

            #region Bai 5

            /* Console.Write("| Input a number: ");  
             int input = int.Parse(Console.ReadLine());  
             int Reverse = 0;  
             while(input>0)  
             {  
                 int remainder = input % 10;  
                 Reverse = (Reverse * 10) + remainder;  
                 input = input / 10;  
             }   
             Console.WriteLine($"| The number in reverse order is: {Reverse}");  
             Console.ReadLine();  */

            #endregion

            //6.

            #region Bai 6

            Console.Write($"| Input the number of elements to store in the array: ");
            int arrSize = Int32.Parse(Console.ReadLine());

            int[] arr = new int[arrSize];
            Console.WriteLine($"| Input {arrSize} number of elements in the array: ");


            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"| Element - {i}: ");
                arr.SetValue(int.Parse(Console.ReadLine()), i);
            }

            Console.Write("| The values store into the array are: ");
            foreach (int items in arr)
            {
                Console.Write(" " + items);
            }

            Array.Reverse(arr);

            Console.Write("\n| The values store into the array in reverse are: ");
            foreach (int items in arr)
            {
                Console.Write(" " + items);
            }

            Console.ReadLine();





            #endregion

            Console.ReadKey();
        }
    }
}

