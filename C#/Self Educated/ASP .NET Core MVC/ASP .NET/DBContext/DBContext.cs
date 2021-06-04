using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using DAL_Database;
using Microsoft.Extensions.Configuration;

namespace _6._Generic_Reponsitory.Models.DBContext
{
    public class DBContext
    {
        public string GetConnection()
        {
            DBConnection dbCon = new DBConnection();
            var conStr = dbCon.GetConnectionString();
            return conStr;
        }
    }
}
