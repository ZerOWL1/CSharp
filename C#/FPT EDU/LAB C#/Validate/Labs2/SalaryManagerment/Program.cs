using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary;
using SalaryManagerment.Controllers;

namespace SalaryManagerment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Human Resource Management ----");
            ManagerController mc = new ManagerController();
            mc.AddStaff();
            mc.DisplayStaff();
            Console.WriteLine("\n-----------------------------------");
            mc.AddManager();
            mc.DisplayManager();
            Console.ReadLine();
        }
    }
}
