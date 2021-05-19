using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q2.Models
{
    class Course
    {
        private string courseTile;
        private List<Student> listOfStudents = new List<Student>();

        public Course()
        {
        }

        public Course(string courseTile)
        {
            this.CourseTile = courseTile;
        }

        public Course(string courseTile, List<Student> students)
        {
            this.CourseTile = courseTile;
            listOfStudents = students;
        }

        public string CourseTile { get => courseTile; set => courseTile = value; }
        public List<Student> ListOfStudents { get => listOfStudents; set => listOfStudents = value; }

        public override string ToString()
        {
            string rs = "";
            for (int i = 0; i < listOfStudents.Count; i++)
            {
                rs += "| Student: "+ listOfStudents[i].StudentID + " - " + listOfStudents[i].StudentName +"\n";
            }
            return
                "\n| Course's info: " +
                "\n| Title: " + this.CourseTile +
                "\n| List of Students: \n" + rs;
        }
    }
}
