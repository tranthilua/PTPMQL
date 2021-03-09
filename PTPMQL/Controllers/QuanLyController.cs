using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PTPMQL.Models;

namespace PTPMQL.Controllers
{
    public class QuanLyController : Controller
    {
        //khai báo đối tượng kết nối tới dâtbase
        DemoDbContext db = new DemoDbContext();
        // GET: QuanLy
        public ActionResult Index()
        {
            //lay toan bo du lieu trong bang khach hang
            // tra ve dang list roi hien thi len view

            return View(db.QuanLys.ToList());
        }
    }
}