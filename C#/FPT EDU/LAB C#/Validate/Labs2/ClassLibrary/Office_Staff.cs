using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class Office_Staff : Staff
    {
        private int number_NonWorkingDay;
        private int money_Decrease;

        public Office_Staff()
        {
        }

        public int Number_NonWorkingDay { get => number_NonWorkingDay; set => number_NonWorkingDay = value; }
        public int Money_Decrease { get => money_Decrease; set => money_Decrease = value; }


        //methods
        public override double Caculate_Salary()
        {
            return base.Caculate_Salary() - number_NonWorkingDay * money_Decrease;
        }

        public override double Caculate_Salary(int allowance)
        {
            return base.Caculate_Salary(allowance) - number_NonWorkingDay * money_Decrease;
        }

        public override void ShowInfor()
        {
            base.ShowInfor();
        }
    }
}
