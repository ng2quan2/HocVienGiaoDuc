using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using ThuongmaiDienTu.Models;

namespace ThuongmaiDienTu.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Research()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Train()
        {
            return View();
        }
        public ActionResult Work()
        {
            return View();
        }
        public ActionResult Admissions()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Chat()
        {
            return View();
        }
    }
}