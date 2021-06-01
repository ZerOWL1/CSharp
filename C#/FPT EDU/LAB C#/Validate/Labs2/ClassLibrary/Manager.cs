using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class Manager : Staff
    {
        private int number_BusinessDay;
        private int money_Increase;

        public int Number_BusinessDay { get => number_BusinessDay; set => number_BusinessDay = value; }
        public int Money_Increase { get => money_Increase; set => money_Increase = value; }
        public Manager()
        {
        }

        public override double Caculate_Salary()
        {
            return base.Caculate_Salary() + number_BusinessDay * money_Increase;
        }

        public override double Caculate_Salary(int allowance)
        {
            return base.Caculate_Salary(allowance) + number_BusinessDay * money_Increase;
        }

        public override void ShowInfor()
        {
            base.ShowInfor();
        }
    }
}
