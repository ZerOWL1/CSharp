using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _2.Class_Objects.Models;

namespace _2.Class_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add value by Construct
            Book book = new Book(1, "Doraemon", "Author");
            Console.WriteLine("Book info: ");
            Console.WriteLine(book);

            //Add value by getter and setter
            Book book2 = new Book();
            Enter: 
            Console.Write("| Enter Number: ");
            String inputNumber = Console.ReadLine();
            bool isNumber = Int32.TryParse(inputNumber, out int inputNum);
            book2.BookNumber = inputNum;

            if (!isNumber)
            {
                Console.WriteLine("| You're not Enter a Number! Please Enter Again!!");
                goto Enter;
            }
            
            Console.Write("| Enter Book Title: ");
            book2.BookTitle = Console.ReadLine();
            Console.Write("| Enter Book Author: ");
            book2.BookAuthor = Console.ReadLine();

            Console.WriteLine("-----------------------");
            Console.WriteLine("| Book Infor: ");
            Console.WriteLine(book2);

            Console.ReadLine();
        }
    }
}
