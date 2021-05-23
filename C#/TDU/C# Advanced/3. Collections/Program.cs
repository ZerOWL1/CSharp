using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Collections
{
    class Program
    {
        /// <summary>
        /// 1. ArraList
        /// 2. Hash Table
        /// 3. Stack LIFO
        /// 4. Queue FIFO
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region Hash Table

            Hashtable hs = new Hashtable();
            hs.Add("A", "Pokemon");
            hs.Add("B", "Doraemon");
            hs.Add("C", "Hello World");
            hs.Add("D", "Demo Hash Table");

            if (hs.ContainsValue("Pikachu"))
            {
                Console.WriteLine("| This is a value in hash table.");
            }
            else
            {
                hs.Add("E", "Pikachu");
            }

            //lấy các collection key trong hash table
            ICollection key = hs.Keys;

            foreach (string item in key)
            {
                Console.WriteLine($"| {item}: {hs[item]}");
            }


            #endregion

            Console.ReadLine();
        }
    }
}
