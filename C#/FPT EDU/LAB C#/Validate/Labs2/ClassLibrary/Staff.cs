using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class Staff
    {
        private int iD;
        private string name;
        private int age;
        private double rate_Salary;
        private int basic_Salary;
        private int allowance;

        public Staff()
        {
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public double Rate_Salary { get => rate_Salary; set => rate_Salary = value; }
        public int Basic_Salary { get => basic_Salary; set => basic_Salary = value; }
        public int Allowance { get => allowance; set => allowance = value; }

        //methods
        public virtual double Caculate_Salary()
        {
            return (rate_Salary * basic_Salary);
        }

        public virtual double Caculate_Salary(int allowance)
        {
            return (Caculate_Salary() + (Caculate_Salary() * allowance) / 100);
        }

        public virtual void ShowInfor()
        {
            Console.WriteLine($"ID: {iD}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Total salary: {Caculate_Salary(allowance)}");
        }
    }
}
