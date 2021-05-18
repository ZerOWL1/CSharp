using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.Reference_Parameters
{
    class Program
    {
        /// <summary>
        /// 7. Reference Parameters
        ///  - ref
        ///  - out
        ///  - param
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region ref parameters

            int a = 100;
            int b = 200;

            Console.WriteLine($"| Before Swap A: {a} & B: {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"| After Swap A: {a} & B: {b}");

            #endregion

            #region out parameters

            int c;
            SwapWithOut(out c);
            Console.WriteLine($"| Value of C: {c}");

            #endregion

            #region Tinh Giai Thua _ De Quy _ Factorial

            Calculation cal = new Calculation();
            int rs = cal.GetFactorial(4);
            Console.WriteLine($"| Factorial: {rs}");

            #endregion

            Console.ReadKey();

        }

       




        public static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        public static void SwapWithOut(out int c)
        {
            int temp = 100;
            c = temp;
        }

    }

    class Calculation
    {
        //Ham tinh giai thua
        public int GetFactorial(int number)
        {
            int fac = 1;
            if (number == 1)
            {
                return 1;
            }
            else
            {
                //ham goi chinh no
                fac = GetFactorial(number - 1) * number;
                return fac;
            }
        }
    }


    
}
