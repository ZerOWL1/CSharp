using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace _7.Lab_Exercises.Controllers
{
    class CalculationFunc
    {
        private static float[] arr = new float[1000];
        private static int count = 0;


        //search add method
        public static void addValue()
        {
            if (count > 1000)
            {
                Console.WriteLine("| You're not allowed to enter value > 1000!!");
            }
            else
            { 
                AddValue:
                Console.Write("| Tell us value number you want to add: ");
                string value = Console.ReadLine();
                bool isNumber = float.TryParse(value, out float outValue);

                if (!isNumber)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("| You've not enter a number!! Please check again!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    goto AddValue;
                }
                else
                {
                    arr.SetValue(outValue, count);
                    count++;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("| Success add Value!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                }
            }
        }


        //search value method
        public static void showValue()
        {
            if (count == 0)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("| There're no Value!!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                string ouput = "| Values array:";
                for (int i = 0; i < count; i++)
                {
                    ouput += " " + arr[i];
                }
                Console.Write($"{ouput}\n");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        //search Value method
        public static void searchValue()
        {
        EnterSearch:
            Console.Write("| What value you want to search: ");
            string input = Console.ReadLine();
            bool isNumber = float.TryParse(input, out float outInput);
            if (!isNumber)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("| You've not enter a number!! Please check again!!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                goto EnterSearch;
            }
            else
            {
                if (arr.Contains(outInput))
                {
                    int countIndex = 0;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    for (int i = 0; i < count; i++)
                    {
                        if (arr[i] == outInput)
                        {
                            Console.WriteLine($"| Value: {arr[i]} at index {i}");
                            countIndex++;
                        }
                    }
                
                    /*var res = Enumerable.Range(0, arr.Length).Where(i => arr[i] == outInput).ToList();*/
                    Console.WriteLine($"| Found {countIndex} value {outInput} in Array!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("| Not found!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                }
            }
        }

        public static void showStatistics()
        {
            float sum = arr.Sum();
            double average = (double)sum / count;

           
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"| Total data: {count}");
            Console.WriteLine($"| Sum: {sum}");
            Console.WriteLine($"| Average: {average}");
            findMinMax(arr);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        public static void findMinMax(float[] numbers)
        {
            float min = numbers[0];
            float max = numbers[0];

            for (int i = 0; i < count; i++)
            {
                if (min > numbers[i])
                {
                    min = numbers[i];
                }else if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine($"| Min: {min}");
            Console.WriteLine($"| Max: {max}");
        }

        public static float  Sum()
        {
            float sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

    }
}


