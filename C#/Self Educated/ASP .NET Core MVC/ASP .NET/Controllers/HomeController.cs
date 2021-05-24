using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _1._Registration_Form.Models;
using _1._Registration_Form.Models.Entity;
using _1._Registration_Form.Models.Respository;

namespace _1._Registration_Form.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View("Privacy");
        }

        //Su dung viewResult (có thế đổi qua IActionResult)
        public ViewResult Home()
        {
            //view bag kiểu dữ liệu dynamic, cung cấp thuộc tính động cho viewData
            //viewdata
            ViewData["Pokemon"] = "Pikachu";
            //viewbag
            ViewBag.Dota = "Dota2VN"; 

            //Sau khi set Giá trị cho ViewBag và ViewData có thể truyền qua Views cshtml
            // + Prefer ViewBag

            //VD:
            DateTime dt = new DateTime();
            int hour = DateTime.Now.Hour;
            //Toán tử 3 ngôi so sánh rồi gán Greading ViewBag
            ViewBag.Greeding = hour < 12 ? "Chao buoi sang" : "Chao buoi toi";


            //tìm kiếm myView tại mục Home bởi đang tại HomeController
            return View("Home");
        }


        //Tao phan Register
        public IActionResult Register()
        {
            return View();
        }

        //Tao method
        [HttpPost]
        public IActionResult Register(Student st)
        {
            //Kiem tra neu nguoi dung nhap vao dap ung du yeu cau ben Entity Student hay khong
            // - Dap ung Anotation Require
            if (ModelState.IsValid)
            {
                 StudentRepository.AddStudent(st);
                 return View("Thanks", st);
            }
            else
            {
                return View();
            }
        }

        //print student
        public IActionResult PrintRegister()
        {
            return View(StudentRepository.GetStudents());
        }

        /* 3. Các kiểu trả về của Controller
         * - IActionResult or ActionResult - Dùng ActionResult khi action trả về nhiều hơn 1 lệnh return
         *  + Mỗi lệnh return có thể trả về nhiều kiểu dữ liệu khác nhau
         *  + (nếu k chắc chắn Action đấy sẽ trả về kiểu gì sau cùng)
         *
         * - ViewResult - Dùng khi Action chỉ trả về View chứ ko trả về cái khác
         *
         * - JsonResult - Ajax
         *  + Dùng jsonResult khi action trả về json
         */

        //VD: Trả về String 
        public string Index2()
        {
            return "Welcome index 2";
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
