using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.Static_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Su dung cac thanh phan trong class Static Ultility
            
            /*Console.WriteLine("| Name: " + (Ultility.name = "HAILD" ));
            Console.WriteLine($"| Truth: {Ultility.Truth}");
            Console.Write($"| Currrent Date: ");
            Ultility.PrintDate();

            //tra ve kieu void. neu muon ket hop thi tra ve string return ve string;
            Console.Write($"| Currrent Time: ");
            Ultility.PrintTime();*/


            //2. Su dung class 'AccountSaving'
                //500$ open bank
            AccountSaving s1 = new AccountSaving(500);

            AccountSaving s2 = new AccountSaving(1000);

            Console.WriteLine($"| Lai suat trc khi s2 mo tai khoan: {AccountSaving.currentInterestRate}");
            
            
            //Ngan hang thay doi lai suat chinh tai thoi diem s2 duoc mo
            s2.setInterestRateObj(0.08);
            AccountSaving s3 = new AccountSaving(2500);
            Console.WriteLine($"| Lai suat sau khi s2 mo tai khoan: {AccountSaving.currentInterestRate}");
            Console.WriteLine("| Tong tien sau 1 nam gui tiet kiem la: " +
                              (s3.currentBalance + s3.currentBalance*AccountSaving.currentInterestRate));

            Console.ReadKey();
        }
    }
}
