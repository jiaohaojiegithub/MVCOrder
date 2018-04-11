using MVCOrder.Models.YKT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCOrder.Controllers
{
    public class IndexController : Controller
    {
        public yikatong db = new yikatong();
        HttpCookie cookie = new HttpCookie("User");
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }
        //登录界面
        public ActionResult Login()
        {
            return View();
        }
        [Category("登录")]
        [Description("用户登录测试")]
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public int logincheck(string username,string password)
        {
            var state = 0;

            if (db._operator.Where(x => x.op_name == username).ToList().Count > 0)
            {
                List<_operator> user = db._operator.Where(x => x.op_name == username).ToList();
                if (user.Select(x => x.op_pass == password).Count() > 0)
                {
                    state = 1;//登录成功
                    //return RedirectToAction( "_operator", "operatorInfo" );
                    Session["Username"] = username;
                    /*使用Cookie*/
                    
                    //cookie.Value = "用户名";//单值
                    cookie.Values["username"] = HttpUtility.UrlEncode("用户名");
                    cookie.Values["password"] = HttpUtility.UrlEncode("密码");//多值
                    cookie.Expires = DateTime.MaxValue;//过期时间
                    Response.Cookies.Add(cookie);
                }
                else
                {
                    state = 2;//密码错误
                    //return Content("<script>alert('密码错误');</script>");
                }
            }
            else {
                state = 0;//无此用户
                //return Content("<script>alert('无此用户');</script>");
            }
            // return Content("<script>alert('无此用户');</script>");
            return state;
        }
    }
}