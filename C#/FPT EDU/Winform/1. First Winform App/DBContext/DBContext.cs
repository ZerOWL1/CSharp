using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace _1.First_Winform_App.DBContext
{
    public class DBContext
    {
        //method tra ve doi tuong ket noi toi CSDL
        public SqlConnection GeConnection()
        {
            string strCon = ConfigurationManager.ConnectionStrings["PRN292"].ToString();
            return new SqlConnection(strCon);
        }

    }
}
