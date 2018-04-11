using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCOrder.Models.YKT;

namespace MVCOrder.Controllers
{
    public class _operatorController : Controller
    {
        private yikatong db = new yikatong();
        //管理员数据显示Advanced toolbar
        public ActionResult OperatorAdvanced()
        {
            return View();
        }
        //管理员数据管理
        public ActionResult OperatorInfo()
        {
            string scookie = "";
            for (int i = 0; i < Request.Cookies.Count; i++)
            {
                HttpCookie cookies = Request.Cookies[i];
                if (cookies.Name == "User")
                {
                    if (cookies.HasKeys)//是否有子键 
                    {
                        scookie ="键名"+HttpUtility.UrlDecode(Request.Cookies["User"]["username"]) +HttpUtility.UrlDecode(cookies["password"]);//cookies.Values["password"]
                        //cookies.Expires = DateTime.Now.AddDays(-30);//设置过期
                    }
                }
            }
            string s = Session["Username"].ToString();
            if (Session["Username"] == null)

                return View();
            else
                return Content("未登录"+scookie);
        }

        // GET: _operator
        public ActionResult Index()
        {
            return View(db._operator.ToList());
        }

        // GET: _operator/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            _operator _operator = db._operator.Find(id);
            if (_operator == null)
            {
                return HttpNotFound();
            }
            return View(_operator);
        }

        // GET: _operator/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: _operator/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "op_code,op_name,op_pass,op_cardno,remark,creator,creatdt,deptno")] _operator _operator)
        {
            if (ModelState.IsValid)
            {
                db._operator.Add(_operator);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(_operator);
        }

        // GET: _operator/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            _operator _operator = db._operator.Find(id);
            if (_operator == null)
            {
                return HttpNotFound();
            }
            return View(_operator);
        }

        // POST: _operator/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "op_code,op_name,op_pass,op_cardno,remark,creator,creatdt,deptno")] _operator _operator)
        {
            if (ModelState.IsValid)
            {
                db.Entry(_operator).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(_operator);
        }

        // GET: _operator/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            _operator _operator = db._operator.Find(id);
            if (_operator == null)
            {
                return HttpNotFound();
            }
            return View(_operator);
        }

        // POST: _operator/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _operator _operator = db._operator.Find(id);
            db._operator.Remove(_operator);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult operatorInfoAll(int limit, int offset)
        {
            List<_operator> _Operator = db._operator.ToList<_operator>();
            var total = _Operator.Count;
            var rows = _Operator.Skip(offset).Take(limit).ToList();
            return Json(new { total = total, rows = rows }, JsonRequestBehavior.AllowGet);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        
    }
}
