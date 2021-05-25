using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.Regex_and_Try_Catch.Models
{
    class Student
    {

        private string Roll;
        private string Name;
        private string Email;


        public Student()
        {
        }

        public void InputInfo(string roll, string name, string email)
        {
            Roll1 = roll;
            Name1 = name;
            Email1 = email;
        }


        public string Roll1 { get => Roll; set => Roll = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Email1 { get => Email; set => Email = value; }

        public void DisplayInfo()
        {
            Console.WriteLine($"| Roll: {this.Roll1}");
            Console.WriteLine($"| Name: {this.Name1}");
            Console.WriteLine($"| Email: {this.Email1}");
        }
    }
}
