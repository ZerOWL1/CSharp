using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.Class_Objects.Models
{
    class Student
    {
       

        private int id;
        private String name;

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Student()
        {
        }

        
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
