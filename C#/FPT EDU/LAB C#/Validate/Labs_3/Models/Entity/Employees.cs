using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labs_3.Models.Entity
{
    public class Employees
    {
        private int eID;
        private String firstName;
        private DateTime birthDate;
        private int reportTo;
        
        public Employees(){}

        public Employees(int eId, string firstName, DateTime birthDate, int reportTo)
        {
            eID = eId;
            this.firstName = firstName;
            this.birthDate = birthDate;
            this.reportTo = reportTo;
        }

        public int EID { get => eID; set => eID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public int ReportTo { get => reportTo; set => reportTo = value; }

        public override string ToString()
        {
            return
                "| EID: " + EID +
                "\n| First Name: " + FirstName +
                "\n| Birth Date: " + BirthDate +
                "\n| Report To: " + ReportTo;
        }
    }
}
