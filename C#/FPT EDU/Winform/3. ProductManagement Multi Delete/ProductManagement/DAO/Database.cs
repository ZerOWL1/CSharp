using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ProductManagement.Models;

namespace ProductManagement.DAO
{
    public class Database
    {
        private static SqlCommand cmd;
        private static SqlDataAdapter da = new SqlDataAdapter();

        public static SqlConnection GetConnection()
        {
            string strCon = ConfigurationManager.ConnectionStrings["ProductDB"].ToString();
            return new SqlConnection(strCon);
        }

        //SELECT Method
        public static DataTable GetDataBySQL(string sql)
        {
            DataSet ds = new DataSet();
            DataTable table = new DataTable();
            cmd = new SqlCommand(sql, GetConnection());
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds.Tables[0];
        }


        //Insert, Update, Delete have to open Connected
        public static int ExecuteSQL(string sql, params SqlParameter[] sqlParameter)
        {
            cmd = new SqlCommand(sql, GetConnection());
            //Add using Parameter
            cmd.Parameters.AddRange(sqlParameter);
            cmd.Connection.Open();

            int rs = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return rs;
        }

    }
}
