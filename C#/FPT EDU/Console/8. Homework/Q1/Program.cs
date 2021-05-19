using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1.Models;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Food f = new Food();
            Console.Write("Enter ID: ");
            f.Id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name: ");
            f.Name = Console.ReadLine();
            Console.Write("Enter Amount: ");
            f.Amount = float.Parse(Console.ReadLine());
            Console.WriteLine(f);
            
            Console.ReadLine();
        }
    }
}
