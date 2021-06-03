using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using _1.First_Winform_App.Models;

namespace _1.First_Winform_App.DBContext.LoadData
{
    public class AccountDB
    {
        public static DBContext db = new DBContext();
        private DataSet ds = new DataSet();
        private SqlCommand cmd;
        private SqlDataAdapter da = new SqlDataAdapter();

        public DataTable GetAccountAdmin(string user, string pass)
        {
            string sql = "SELECT * FROM Account WHERE Account = '"+user+"' and Passwords = '"+pass+"' and Roles = '1'";
            //Declare object command
            cmd = new SqlCommand(sql, db.GeConnection());
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            //Fill dataset
            da.Fill(ds);
            return ds.Tables[0];
        }

        public DataTable GetAccountMod(string user, string pass)
        {
            string sql = "SELECT * FROM Account WHERE Account = '"+user+"' and Passwords = '"+pass+"' and Roles = '2'";
            //Declare object command
            cmd = new SqlCommand(sql, db.GeConnection());
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            //Fill dataset
            da.Fill(ds);
            return ds.Tables[0];
        }

        public DataTable GetHaveAccount()
        {
            string sql = "SELECT * FROM Account";
            //Declare object command
            cmd = new SqlCommand(sql, db.GeConnection());
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            //Fill dataset
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}
