using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q2.Models
{
    class Student
    {
        private string studentID;
        private string studentName;


        public Student()
        {
        }

        public Student(string studentId, string studentName)
        {
            StudentID = studentId;
            this.StudentName = studentName;
        }

        public string StudentID { get => studentID; set => studentID = value; }
        public string StudentName { get => studentName; set => studentName = value; }

        public override string ToString()
        {
            return 
                "\n| " + this.StudentID +
                "\n| " + this.StudentName;
        }

       


    }
}
