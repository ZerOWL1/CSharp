using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex5.Interface.Models;

namespace Ex5.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment payment = new Payment() { _Amount = 1000 };
            payment.AmountChanged += AmountChanging; // your handling function
            payment.Amount = 990;
            Console.WriteLine( "Tax:" +payment.ComputeTax());
            Console.ReadLine();
        }
        public static void AmountChanging(float oldV, float newV)
        {
            Console.WriteLine($"| Amount changed {oldV} – old value: {newV}");
        }

    }
}
