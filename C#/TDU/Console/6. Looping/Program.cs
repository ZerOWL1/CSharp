using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.Looping
{
    class Program
    {
        /// <summary>
        /// 6. Looping
        /// - for
        /// - while / do while
        /// - for each
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region for each

            /*int[] arr = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            foreach (int item in arr)
            {
                Console.WriteLine($"| Phan tu trong mang lan luot la : {item}");
            }*/

            #endregion

            #region Bai Toan Tinh Giai Thua

            Console.Write($"| Enter number: ");
            string input = Console.ReadLine();
            int number = Int32.Parse(input);
            int sup = 1;
            for (int i = number; i >= 1 ; i--)
            {
                sup *= i;
            }
            Console.WriteLine("| " + sup);
            Console.ReadKey();

            #endregion

        }
    }
}
