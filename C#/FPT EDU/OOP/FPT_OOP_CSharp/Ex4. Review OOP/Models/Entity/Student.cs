using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex4.Review_OOP.Models.Entity
{
    class Student:People
    {
        public decimal _DonetMark;
        public decimal _JavaMark;
        public Student(decimal donetMark, decimal javaMark)
        {
            _DonetMark = donetMark;
            _JavaMark = javaMark;
        }

        public Student(int id, string name, int age, decimal donetMark, decimal javaMark) : base(id, name, age)
        {
            _DonetMark = donetMark;
            _JavaMark = javaMark;
        }

        public decimal DonetMark { get => _DonetMark; set => _DonetMark = value; }
        public decimal JavaMark { get => _JavaMark; set => _JavaMark = value; }

        public decimal GetAvarageMark()
        {
            decimal total = 0;
            total = (_DonetMark + _JavaMark) / 2;
            return total;
        }

        public override string ToString()
        {
            return
                base.ToString() +
                $"\n| Average Marks: {GetAvarageMark()}\n";

        }
    }
}
