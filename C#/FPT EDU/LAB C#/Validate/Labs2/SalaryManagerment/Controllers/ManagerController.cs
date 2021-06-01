using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary;

namespace SalaryManagerment.Controllers
{
    class ManagerController
    {
        private List<Office_Staff> officeList = new List<Office_Staff>();
        private List<Manager> managerList = new List<Manager>();


        //add staff func
        public void AddStaff()
        {
            //input 2 staff
            for (int i = 0; i < 2; i++)
            {
                //declare o_staff
                Office_Staff officeStaff = new Office_Staff();
                Console.WriteLine("Input Office staff: #" + (i + 1));
                
                Console.Write("ID: ");
                officeStaff.ID = int.Parse(Console.ReadLine());
                
                Console.Write("Name: ");
                officeStaff.Name = Console.ReadLine();
                
                Console.Write("Age: ");
                officeStaff.Age = int.Parse(Console.ReadLine());
                
                Console.Write("Rate salary: ");
                officeStaff.Rate_Salary = double.Parse(Console.ReadLine());
                
                Console.Write("Basic salary: ");
                officeStaff.Basic_Salary = int.Parse(Console.ReadLine());
                
                Console.Write("Allowance: ");
                officeStaff.Allowance = int.Parse(Console.ReadLine());
                
                Console.Write("Number non-working day: ");
                officeStaff.Number_NonWorkingDay = int.Parse(Console.ReadLine());
                
                Console.Write("Money decrease: ");
                officeStaff.Money_Decrease = int.Parse(Console.ReadLine());
                officeList.Add(officeStaff);
                Console.WriteLine("------------");
            }
        }

        //show staff func
        public void DisplayStaff()
        {
            Console.WriteLine("\n-- Information Office staff --");
            foreach (var item in officeList)
            {
                item.ShowInfor();
            }
        }

        //add manager func
        public void AddManager()
        {
            //add total 2 manager
            for (int i = 0; i < 2; i++)
            {
                Manager manager = new Manager();
                Console.WriteLine("Input Manager: #" + (i + 1));

                Console.Write("ID: ");
                manager.ID = Int32.Parse(Console.ReadLine());
                
                Console.Write("Name: ");
                manager.Name = Console.ReadLine();
                
                Console.Write("Age: ");
                manager.Age = manager.ID = Int32.Parse(Console.ReadLine());
                
                Console.Write("Rate salary: ");
                manager.Rate_Salary = double.Parse(Console.ReadLine());
                
                Console.Write("Basic salary: ");
                manager.Basic_Salary = manager.ID = Int32.Parse(Console.ReadLine());
                
                Console.Write("Allowance: ");
                manager.Allowance = manager.ID = Int32.Parse(Console.ReadLine());
                
                Console.Write("Number business day: ");
                manager.Number_BusinessDay = manager.ID = Int32.Parse(Console.ReadLine());
                
                Console.Write("Money increase: ");
                manager.Money_Increase = manager.ID = Int32.Parse(Console.ReadLine());
                managerList.Add(manager);
                Console.WriteLine("------------");
            }
        }

        //display manager func
        public void DisplayManager()
        {
            Console.WriteLine("\n-- Information Manager --");
            foreach (var item in managerList)
            {
                item.ShowInfor();
            }
        }

    }
}
