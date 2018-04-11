using System;
using System.Web;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCOrder.Controllers;
using MVCOrder.Models.YKT;

namespace MVCOrder.Tests.Controllers
{
    [TestClass]
    public class IndexControllerTest
    {
        [TestMethod]
        public void 登录检查()
        {
            //准备
            IndexController indexController = new IndexController();
            //动作
            int result = indexController.logincheck("西门岗亭", "123456");
            //断言
            Assert.AreEqual(1, result);
        }
    }
}
