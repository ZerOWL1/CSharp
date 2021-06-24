using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using _2.ASP.NET_DBContext.DBContext;

namespace _2.ASP.NET_DBContext.Models
{
    public class CategoryControl
    {
        public DataTable GetAllCategory()
        {
            return DBConnection.GetDataBySQL("SELECT * FROM dbo.Categories");
        }

        public DataTable GetProductByCateI(int cateId)
        {
            //ProductID, ProductName, ProductPrice
            return DBConnection.GetDataBySQL($"SELECT * FROM dbo.Products WHERE CategoryID = {cateId}");
        }
    }
}