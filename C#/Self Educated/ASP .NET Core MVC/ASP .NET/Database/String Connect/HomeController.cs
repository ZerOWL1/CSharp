using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _5._Repsitory_and_Generic_Repository_Pattern.Models;
using _5._Repsitory_and_Generic_Repository_Pattern.Models.NewFolder;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace _5._Repsitory_and_Generic_Repository_Pattern.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 1. Using  'using Microsoft.Extensions.Configuration;'
        /// - Install SqlCilent and SqlServer.Types libraries in nuget
        /// </summary>
        public SqlCommand com = new SqlCommand();
        public SqlDataReader dr;
        private string status = string.Empty;
        List<Director> list = new List<Director>();

        //set IConfiguration
        public IConfiguration _configuration;
        public SqlConnection con = new SqlConnection();

        //ILogger default
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger, IConfiguration config)
        {
            //set connect with connect string in appsettings.json file
            _logger = logger;
            _configuration = config;
            string conString = this._configuration.GetConnectionString("DefaultConnection");
            con.ConnectionString = conString;

            //Using it if you connect in Project Properties
            //con.ConnectionString = _5._Repsitory_and_Generic_Repository_Pattern.Properties.Resources.ConnectionString;
        }

        //Get Data Func
        public void GetDirctor()
        {
            if(list.Count() > 0)
            {
                list.Clear();
            }
            try
            {
                //open connection
                con.Open();
                com.Connection = con;
                
                //command Sql here
                com.CommandText = "select * from DIRECTOR";
                //execute Query with ExecuteReader
                dr = com.ExecuteReader();
                //using while to add data
                while (dr.Read())
                {
                    list.Add(new Director()
                    {
                        DID = dr.GetInt32(0),
                        DName = dr.GetString(1),
                        DNation = dr.GetString(2),
                    });
                }
                //close connection
                con.Close();
            }
            catch (Exception e)
            {
                status = "Error while at GetDirector Func " + e.Message;
                throw;
            }
        }

        public IActionResult Index()
        {
            GetDirctor();
            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
