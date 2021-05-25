using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using _10.Regex_and_Try_Catch.Models;

namespace _10.Regex_and_Try_Catch
{

    class Program
    {

        static void Main(string[] args)
        {
            Student st = new Student();
            Console.WriteLine("| Input Student");

            //roll
            Console.Write("| Roll: ");
            string roll = Console.ReadLine();
            Regex r = new Regex(@"^(HE|SE)\d{6}$");
            if (r.IsMatch(roll))
            {
                Console.WriteLine("| Roll Valid");
                st.Roll1 = roll;
            }
            else
            {
                Console.WriteLine("| Invalid Roll");
                goto End;
            }
            Console.Write("| Email: ");
            string email = Console.ReadLine();
            Regex nFPTMail = new Regex(@"^\w+@\w+.\w+(.vn)");
            Regex nGmail = new Regex(@"^\w+@\w+.\w+$");
            if (nFPTMail.IsMatch(email) || nGmail.IsMatch(email))
            {
                Console.WriteLine("| Email Valid");
                st.Email1 = email;
            }
            else
            {
                Console.WriteLine("| Invalid Email");
                goto End;
            }

            Console.Write($"| Name: ");
            string name = Console.ReadLine();
            Regex n = new Regex(@"[{(*+?^$|@]|[0-9]");
            if (!n.IsMatch(name))
            {   
                Console.WriteLine("| Name Valid");
                st.Name1 = name;
            }
            else
            {
                Console.WriteLine("| Invalid Name");
                goto End;
            }


            Console.WriteLine("\n| Show Student: ");
            Console.WriteLine($"| Roll: {st.Roll1.ToString()}");
            Console.WriteLine($"| Email: {st.Email1.ToString()}");
            Console.WriteLine($"| Name: {st.Name1.ToString()}");

            End:
            Console.ReadLine();
        }
    }
}
