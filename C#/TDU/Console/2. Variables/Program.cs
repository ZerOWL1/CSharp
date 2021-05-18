using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.Variables
{


    class Program
    {
        static string input = "Pokemon";
        /// <summary>
        /// Bien va Kieu Du lieu
        /// 1. Value types: (Bien tham tri)
        /// 2. Reference types: (Bien tham chieu)
        /// 3. Pointer types: (Bien con tro)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            #region 1. Values type
            /* 1. Values type:
             * - byte
             * - char
             * - int
             * - float
             * - sbyte
             * - short
             * - ushort
             * - uint > int
             * - double
             * - decimal
             * - long
             * - ulong
             * - bool
             */
            #endregion

            #region 2. Reference types

            /* 2. Reference types
             * - object
             * - string
             * - class
             * - delegate
             * - interface
             * - array
             */

            #endregion

            #region 3. Const and Enum

            /* const int pi = 3.14;
             *  enum diemThi : int
                    {
                        diemMax = 10,
                        diemMin = 0,
                        diemTB = 5
                    }
             */

            #endregion

            showInfo();
            Console.ReadLine();

        }

        public static void showInfo()
        {
            Console.WriteLine("| " + input);
        }
    }
}
