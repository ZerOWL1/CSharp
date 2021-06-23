using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using _6._Generic_Reponsitory.Models.Entity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace _6._Generic_Reponsitory.Models.LoadDB
{
    public class DirectorDB
    {
        public SqlCommand cmd = new SqlCommand();
        private DataSet ds = new DataSet();
        private SqlDataAdapter da = new SqlDataAdapter();
        private string status = String.Empty;
        private static DBContext.DBContext db = new DBContext.DBContext();
        private SqlDataReader dr;
        private SqlConnection con = new SqlConnection();


        public List<Director> GetDirectors()
        {
            List<Director> list = new List<Director>();
            try
            {
                con.ConnectionString = db.GetConnection();
                con.Open();
                cmd.Connection = con;
                string sql = "SELECT * FROM DIRECTOR";
                cmd.CommandText = sql;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(new Director()
                    {
                        DID = dr.GetInt32(0),
                        DName = dr.GetString(1),
                        DNation = dr.GetString(2)
                    });
                }
                cmd.Close();
            }
            catch (Exception e)
            {
                status = "Error while at GetDirector Func " + e.Message;
                throw;
            }
            return list;
        }
    }
}
