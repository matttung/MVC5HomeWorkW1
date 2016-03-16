using MVC5HomeWorkW1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5HomeWorkW1.Controllers
{
    public class 數量查詢Controller : Controller
    {
        private 客戶資料Entities db = new 客戶資料Entities();
        // GET: 數量查詢
        public ActionResult Index()
        {
            var data = db.數量查詢View.AsQueryable();
            return View(data);
        }
    }
}