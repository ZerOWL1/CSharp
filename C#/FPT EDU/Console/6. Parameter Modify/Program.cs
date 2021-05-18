using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.Parameter_Modify
{
    class Program
    {
        /// <summary>
        /// 6. Parameter Types:
        /// - ref
        /// - out
        /// - params
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //ref para
            int x = 5;
            int y = 10;
            Console.WriteLine($"| Gia tri truoc khi swap la: X = {x} & Y = {y}");
            Swap(ref x, ref y);
            Console.WriteLine($"| Gia tri sau khi swap la: X = {x} & Y = {y}");


            //out para
            int rs;
            Sum(x, y, out rs);
            Console.WriteLine($"| Result: {rs}");

            //param
            //Tu dong tang giam tham so
            Console.WriteLine($"| Diem trung binh cua sinh vien 1 " +
                              $"(5.5 , 7, 8.5) : {MarkAverage(5.5, 7,8.5)}");


            Console.ReadLine();
        }



        #region ref parameter

        public static void Swap(ref int a, ref int b)
        {
            //Hoan vi
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        #endregion


        #region out parameter

        public static void Sum( int a, int b, out int sum)
        {
            Console.WriteLine($"| A: {a}");
            Console.WriteLine($"| B: {b}");
            sum = a + b;
        }

        #endregion

        #region params parameter

        static double MarkAverage(params double[] score)
        {
            double sum = 0.0;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }

            return sum / score.Length;
        }

        #endregion
    }
}
