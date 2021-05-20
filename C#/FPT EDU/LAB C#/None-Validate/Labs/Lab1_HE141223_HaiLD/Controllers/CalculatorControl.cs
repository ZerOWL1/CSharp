using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1_HE141223_HaiLD.Controllers
{
    class CalculatorControl
    {
        //declare array with 1000 value
        private static float[] arr = new float[1000];

        //declare count to save value range in array
        private static int count = 0;


        //search add method
        public static void addValue()
        {
            //check if array[count] > 1000
            if (count > 1000)
            {
                Console.WriteLine("Array Full 1000 values!!");
            }
            else
            {
                //add value 
                float value = float.Parse(Console.ReadLine());

                //set value at count index and count += 1 also print message
                arr.SetValue(value, count);
                count++;
                Console.WriteLine();
            }
        }

        //search value method
        public static void showValue()
        {
            //check if array[count] == 0 <=> array no value
            if (count == 0)
            {
                Console.WriteLine("There're no Value!!");
            }
            else
            {
                //show value with i < count
                for (int i = 0; i < count; i++)
                {
                    Console.Write($"{arr[i]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        //search Value method
        public static void searchValue()
        {
            float input = float.Parse(Console.ReadLine());

            //check value in array exist or not
            if (arr.Contains(input))
            {
                //set countIndex support show value
                int countIndex = 0;

                //show value at index
                for (int i = 0; i < count; i++)
                {
                    if (arr[i] == input)
                    {
                        Console.WriteLine($"Value: {arr[i]} at index {i}");
                        countIndex++;
                    }
                }
                Console.WriteLine($"Found {countIndex} value {input} in Array!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Not found");
                Console.WriteLine();
            }
        }

        //show details
        public static void showStatistics()
        {
            //int sum = arr.Sum();

            float average = (float)Sum() / count;


            Console.WriteLine($"Total data: {count}");
            Console.WriteLine($"Sum: {Sum()}");
            Console.WriteLine($"Average: {average}");
            findMinMax(arr);
            Console.WriteLine();
        }

        //find min, max func
        public static void findMinMax(float[] numbers)
        {
            float min = numbers[0];
            float max = numbers[0];

            for (int i = 0; i < count; i++)
            {
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
                else if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Max: {max}");
        }

        //find sum
        public static float Sum()
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
