using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex4.Review_OOP.Models.Entity
{
    class Teacher:People
    {
        public decimal _ClassNumber;
        public decimal _SubjectNumber;
        public Teacher(){ }
        
        public Teacher(decimal classNumber, decimal subjectNumber)
        {
            ClassNumber = classNumber;
            SubjectNumber = subjectNumber;
        }

        public Teacher(int id, string name, int age, decimal classNumber, decimal subjectNumber) : base(id, name, age)
        {
            ClassNumber = classNumber;
            SubjectNumber = subjectNumber;
        }

        public decimal ClassNumber { get => _ClassNumber; set => _ClassNumber = value; }
        public decimal SubjectNumber { get => _SubjectNumber; set => _SubjectNumber = value; }


        public decimal GetTotalSubject()
        {
            decimal total = 0;
            total = (_ClassNumber * _SubjectNumber);
            return total;
        }

        public override string ToString()
        {
            return 
                base.ToString() + 
                $"\n| Total Subject: {GetTotalSubject()}\n";
        }
    }
}
