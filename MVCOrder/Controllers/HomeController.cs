using MVCOrder.Models.YKT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using 报表.Models.Model;

namespace MVCOrder.Controllers
{
    public class HomeController : Controller
    {
        public yikatong db = new yikatong();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //后台布局
        public ActionResult BackgroundManagement()
        {
            return View();
        }
        //前端布局

        //报表场内停车记录
        public ActionResult Parkinginfo()
        {
            return View();
        }

        public ActionResult TestMate()
        {
            return View();
        }
        public ActionResult TestMate2()
        {
            return View();
        }
        [HttpGet]
        public ActionResult dataparkinginfo()
        {
            string cmd = string.Format(@"exec 场内停车记录");
            var list = new List<场内停车记录>();
            list = db.Database.SqlQuery<场内停车记录>(cmd).ToList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}