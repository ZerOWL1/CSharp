using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex4.Review_OOP.Models.Entity
{
    class People
    {
        public People()
        {
        }

        public People(int id, string name, int age)
        {
            _ID = id;
            _Name = name;
            _Age = age;
        }

        private int _ID;
        private string _Name;
        private int _Age;

        public int ID { get => _ID; set => _ID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public int Age { get => _Age; set => _Age = value; }

        public override string ToString()
        {
            return
                "| ID: " + this.ID +
                "\n| Name: " + this.Name +
                "\n| Age: " + this.Age;
        }
    }
}
