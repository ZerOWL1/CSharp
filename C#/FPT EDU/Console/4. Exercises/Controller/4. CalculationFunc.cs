using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.Exercises.Controller
{
    class EX4
    {
        public int outputA;
        public int outputB;

        public void enterData()
        {
            EnterData:
            Console.Write($"| Enter a: ");
            string a = Console.ReadLine();
            Console.Write($"| Enter b: ");
            string b = Console.ReadLine();
            bool inputA = Int32.TryParse(a, out outputA);
            bool inputB = Int32.TryParse(b, out outputB);
            if (!inputA || !inputB)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("| You've not enter a number. Do it again!!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                goto EnterData;
            }
        }

        //Ham Cong
        public void calSum()
        {
            enterData();
            int rs = outputA + outputB;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"| Result A + B: {rs}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Ham Tru
        public void calSub()
        {
            enterData();
            int rs = outputA - outputB;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"| Result A - B: {rs}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Ham Nhan
        public void calMulti()
        {
            enterData();
            int rs = outputA * outputB;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"| Result A * B: {rs}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Ham Chia
        public void calDiv()
        {
            enterData();
            double rs = outputA / outputB;
            double rs1 = (double)outputA / outputB;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"| Result A / B: {rs}");
            Console.WriteLine($"| Result A / B in double types : {rs1}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Ham Chia Co Du
        public void calMod()
        {
            enterData();
            int rs = outputA % outputB;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"| Result A % B: {rs}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }


    }
}
