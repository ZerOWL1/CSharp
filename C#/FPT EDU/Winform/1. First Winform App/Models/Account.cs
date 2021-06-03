using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.First_Winform_App.Models
{
    public class Account
    {
        public Account()
        {
        }

        public Account(int iD, string userName, string passWords, int roles)
        {
            this.iD = iD;
            this.userName = userName;
            this.passWords = passWords;
            this.roles = roles;
        }

        private int iD;
        private string userName;
        private string passWords;
        private int roles;

        public int ID { get => iD; set => iD = value; }
        public string UserName { get => userName; set => userName = value; }
        public string PassWords { get => passWords; set => passWords = value; }
        public int Roles { get => roles; set => roles = value; }

    }
}
