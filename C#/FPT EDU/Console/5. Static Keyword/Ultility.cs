using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.Static_Keyword
{
    // Class nay chua cac thanh phan duoc su dung chung trong nhieu class khac
    static class Ultility
    {
        /* Chi chua:
         * - const
         * - properties
         * - methods
         * => all static
         */
        public static string name;
        public const bool Truth = true;

        //static constructer
        static Ultility(){}

        public static void PrintTime()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }

        public static void PrintDate()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }






    }
}
