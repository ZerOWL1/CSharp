using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Lab3_HE141223_HaiLD.Models.DBContext;
using Lab3_HE141223_HaiLD.Models.Entity;

namespace Lab3_HE141223_HaiLD.Controllers
{
    public class EmployeesControl
    {
        private Employees em = new Employees();

        //Get all Employees Method return ArrayList
        public static ArrayList GetEmployees()
        {
            ArrayList list = new ArrayList();
            string sql = "SELECT * FROM dbo.Employees";
            DataTable employDt = Database.GetDataBySQL(sql);
            foreach (DataRow item in employDt.Rows)
            {
                Employees cate = new Employees();
                cate.EID = int.Parse(item["EmployeeID"].ToString());
                cate.FirstName = item["FirstName"].ToString();
                cate.BirthDate = DateTime.Parse(item["BirthDate"].ToString()).Date;
                cate.ReportTo = int.Parse(item["ReportsTo"].ToString());
                list.Add(cate);
            }
            return list;
        }

        //Get all Employees Method return DataTable
        public static DataTable GetEmployeesDT()
        {
            string sql = "SELECT * FROM dbo.Employees";
            DataTable employDt = Database.GetDataBySQL(sql);
            return employDt;
        }

        //Get manager by ReportTo ID
        public static DataTable GetManagerByReportTo(string id)
        {
            string sql = "SELECT * FROM dbo.Employees WHERE ReportsTo = '"+id+"'";
            DataTable employDt = Database.GetDataBySQL(sql);
            return employDt;
        }

        //Get OrderByID to check Delete func
        public static DataTable GetOrderByID(string id)
        {
            return Database.GetDataBySQL("SELECT * FROM dbo.Orders WHERE EmployeeID = '" + id + "'");
        }

        //Get TerritoryByID to check Delete func
        public static DataTable GetTerritoryByID(string id)
        {
            return Database.GetDataBySQL("SELECT * FROM dbo.EmployeeTerritories WHERE EmployeeID = '"+id+"'");
        }

        //Delete Func
        public static int DeleteEmployees(string id)
        {
            //Declare a int result
            int result = 0;
            //Check if table Order or Territories data exist or not
            if (GetOrderByID(id).Rows.Count > 0 || GetTerritoryByID(id).Rows.Count > 0)
            {
                //Exist return 0 and show message
                result = 0;
            }
            //Check if data Manager exist or not
            else if(GetManagerByReportTo(id).Rows.Count > 0)
            {
                //Exist return -1 and show message
                result = -1;
            }
            else
            {
                //Delete Func
                string sql = "DELETE FROM dbo.Employees WHERE EmployeeID = @eid";
                SqlParameter parameter = new SqlParameter("@eid", SqlDbType.Int);
                parameter.Value = id;
                result = Database.ExecuteSQL(sql, parameter);
            }
            return result;
        }

        //Add Method
        public static int AddEmployee(ArrayList list)
        {
            string sql = "INSERT INTO Employees(FirstName, BirthDate, ReportsTo) VALUES ( @FirstName ,  @BirthDate, @ReportsTo)";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@FirstName ", SqlDbType.NVarChar),
                new SqlParameter("@BirthDate", SqlDbType.DateTime),
                new SqlParameter("@ReportsTo", SqlDbType.Int),
            };

            for (int i = 0; i < list.Count; i++)
            {
                sqlParameters[i].Value = list[i];
            }

            return Database.ExecuteSQL(sql, sqlParameters);
        }
    }
}
