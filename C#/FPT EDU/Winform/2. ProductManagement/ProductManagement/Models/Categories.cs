using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ProductManagement.DAO;

namespace ProductManagement.Models
{
    public class Categories
    {
        private string cateID;
        private string cateName;
        private string cateDescription;
        public Categories()
        {
        }

        public Categories(string cateId, string cateName, string cateDescription)
        {
            cateID = cateId;
            this.cateName = cateName;
            this.cateDescription = cateDescription;
        }

        public string CateID { get => cateID; set => cateID = value; }
        public string CateName { get => cateName; set => cateName = value; }
        public string CateDescription { get => cateDescription; set => cateDescription = value; }


        public static List<Categories> GetCategories()
        {
            DataTable cateTable = Database.GetDataBySQL("SELECT *  FROM dbo.Categories");
            List<Categories> list = new List<Categories>();

            foreach (DataRow item in cateTable.Rows)
            {
                Categories cate = new Categories();
                cate.CateID = item["CategoryID"].ToString();
                cate.CateName = item["CategoryName"].ToString();
                cate.CateDescription = item["Description"].ToString();
                list.Add(cate);
            }
            return list;
        }

        public static DataTable getCategoryByID(string id)
        {
            string sql = "SELECT *  FROM dbo.Categories WHERE CategoryId = '" + id + "'";
            DataTable cateTable = Database.GetDataBySQL(sql);
            return cateTable;
        }
        public static DataTable getCategoryByName(string Name)
        {
            string sql = "SELECT *  FROM dbo.Categories WHERE CategoryName = '" + Name + "'";
            DataTable cateTable = Database.GetDataBySQL(sql);
            return cateTable;
        }

        public static int AddCategory(ArrayList arrayList)
        {
            string sql = "INSERT INTO dbo.Categories( CategoryId ,CategoryName ,Description) VALUES ( @CategoryId ,  @CategoryName , @Description)";

            Categories cate = new Categories();
            foreach (Categories item in arrayList)
            {
                cate.CateID = item.CateID;
                cate.CateName = item.CateName;
                cate.cateDescription = item.CateDescription;
            }

            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@CategoryId", SqlDbType.Char);
            sqlParameters[0].Value = cate.CateID;
            sqlParameters[1] = new SqlParameter("@CategoryName", SqlDbType.NVarChar);
            sqlParameters[1].Value = cate.CateName;
            sqlParameters[2] = new SqlParameter("@Description", SqlDbType.NText);
            sqlParameters[2].Value = cate.CateDescription;

            int rs = Database.ExecuteSQL(sql, sqlParameters);
            return rs;
        }
        public static int UpdateCategory(ArrayList arrayList)
        {
            string sql = "UPDATE dbo.Categories SET CategoryName = @CategoryName, [Description] = @Description WHERE CategoryId = @CategoryId";

            Categories cate = new Categories();
            foreach (Categories item in arrayList)
            {
                cate.CateID = item.CateID;
                cate.CateName = item.CateName;
                cate.cateDescription = item.CateDescription;
            }

            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@CategoryId", SqlDbType.Char);
            sqlParameters[0].Value = cate.CateID;
            sqlParameters[1] = new SqlParameter("@CategoryName", SqlDbType.NVarChar);
            sqlParameters[1].Value = cate.CateName;
            sqlParameters[2] = new SqlParameter("@Description", SqlDbType.NText);
            sqlParameters[2].Value = cate.CateDescription;

            int rs = Database.ExecuteSQL(sql, sqlParameters);
            return rs;
        }

        public static int DeleteCategory(string id)
        {
            string sql = "DELETE dbo.Categories WHERE CategoryId = @CategoryId";
            Categories cate = new Categories();
            cate.CateID = id;

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@CategoryId", SqlDbType.Char);
            sqlParameters[0].Value = cate.CateID;
            
            int rs = Database.ExecuteSQL(sql, sqlParameters);
            return rs;
        }
    }
}
