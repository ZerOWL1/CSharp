using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8.Nullrable
{
    class Program
    {
        /// <summary>
        /// 8. Nullable
        /// - String
        /// - Object
        /// - With other types: add "?" | VD: int? age = null
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int? age = null;
            float? mark = null;
            double? price = null;
            string value = null;
            age = 10;
            mark = 5;

            Console.WriteLine($"| Age: {age}");

            //Toan tu 3 ngoi phai trong ngoac tron () 
            //Toan tu 3 ngoi || (?? Neu null thi lay gia tri "Contact us")
            Console.WriteLine($"| Value: {(value != null ? value : "Contact Us!!")}");
            Console.WriteLine($"| Price: " + (price ?? 0));

            //Toan tu 3 ngoi vs HasValue method
            Console.WriteLine($"| Mark: {(mark.HasValue ? mark.Value : 0)}");
            Console.ReadKey();




            #region BTVN B1

            /*Console.Write($"| Enter a: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write($"| Enter b: ");
            int b = Int32.Parse(Console.ReadLine());


            double rs = (double)a / b;

            Console.WriteLine($"| A/B : {rs}");
            Console.ReadKey();*/

            #endregion



        }
    }
}
