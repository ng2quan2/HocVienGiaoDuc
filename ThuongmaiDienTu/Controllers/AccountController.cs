using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThuongmaiDienTu.Models;

namespace ThuongmaiDienTu.Controllers
{


    public class AccountController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        void connectionString()
        {
            con.ConnectionString = "data source = DESKTOP-0DS3L8S; database = ThuongMaiDienTu; integrated security = SSPI";
        }
        public ActionResult Verify(Account acc)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from DangNhap where TenDangNhap='" + acc.Name + "' and MatKhau='" + acc.Password + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return View("Verify");
            }
            else
            {
                con.Close();
                return View("Error");
            }
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}