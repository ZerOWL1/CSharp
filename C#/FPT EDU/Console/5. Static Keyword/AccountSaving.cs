using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.Static_Keyword
{
    class AccountSaving
    {
      

        public double currentBalance; //so tien trong tk
        public static double currentInterestRate; //lai suat

        public AccountSaving(double currentBalance)
        {
            this.currentBalance = currentBalance;
        }


        //thu tu uu tien. method see duoc goi tu dong khi co kieu Account save dc tao
        //chi goi 1 lan duy nhat
        static AccountSaving()
        {
            Console.WriteLine("| Lai suat khi gui la (Static construct) called.");
            currentInterestRate = 0.04; //4%
        }

        public static void setInterestRate(double newRate)
        {
            currentInterestRate = newRate;
        }

        public static double getInterestRate()
        {
            return currentInterestRate;
        }

        public void setInterestRateObj(double newRate)
        {
            currentInterestRate = newRate;
        }

        public double getInterestRateObj()
        {
            return currentInterestRate;
        }


    }
}
