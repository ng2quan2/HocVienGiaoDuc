using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThuongmaiDienTu.Models;

namespace ThuongmaiDienTu.Controllers
{
    public class GiangVienController : Controller
    {
        // GET: GiangVien
        public ActionResult GiangVien()
        {
            TMDTDataContext context = new TMDTDataContext();
            List<GiangVien> dsGiangVien = context.GiangViens.ToList();
            return View(dsGiangVien);
        }

        public ActionResult Create()
        {
            if (Request.Form.Count > 0)
            {
                string TenGiangVien = Request.Form["TenGiangVien"];
                string NgaySinh = Request.Form["NgaySinh"];
                int IDBoMon = int.Parse(Request.Form["IDBoMon"]);
                string DiaChi = Request.Form["DiaChi"];
                string SoDienThoai = Request.Form["SoDienThoai"];
                string Email = Request.Form["Email"];
                string HocVi = Request.Form["HocVi"];
                string TenDangNhap = Request.Form["TenDangNhap"];
                string MatKhau = Request.Form["MatKhau"];

                int IDKieuNguoiDung = int.Parse(Request.Form["IDKieuNguoiDung"]);
                string ChucVu = Request.Form["ChucVu"];
                TMDTDataContext context = new TMDTDataContext();

                GiangVien giangvien = new GiangVien();
                giangvien.TenGiangVien = TenGiangVien;
                giangvien.NgaySinh = NgaySinh;
                giangvien.IDBoMon = IDBoMon;
                giangvien.DiaChi = DiaChi;
                giangvien.SoDienThoai = SoDienThoai;
                giangvien.Email = Email;
                giangvien.HocVi = HocVi;
                giangvien.TenDangNhap = TenDangNhap;
                giangvien.MatKhau = MatKhau;
                giangvien.IDKieuNguoiDung = IDKieuNguoiDung;
                giangvien.ChucVu = ChucVu;
                context.GiangViens.InsertOnSubmit(giangvien);
                context.SubmitChanges();
                return RedirectToAction("GiangVien");
            }
            return View();
        }

        public ActionResult Delete(int MaGV)
        {
            TMDTDataContext context = new TMDTDataContext();

            GiangVien gv = context.GiangViens
                .FirstOrDefault(x => x.MaGV == MaGV);
            if (gv != null)
            {
                context.GiangViens.DeleteOnSubmit(gv);
                context.SubmitChanges();
            }
            return RedirectToAction("GiangVien");
        }

        public ActionResult Details(string MaGV)
        {
            TMDTDataContext context = new TMDTDataContext();
            GiangVien gv = context.GiangViens
            .FirstOrDefault(x => x.MaGV == int.Parse(MaGV));
            return View(gv);
        }

        public ActionResult Chat()
        {
            return View();
        }



        public ActionResult Edit(string MaGV)
        {
            TMDTDataContext context = new TMDTDataContext();


            GiangVien gv = context.GiangViens.FirstOrDefault(x => x.MaGV == int.Parse(MaGV));
            //Lay du lieu
            if (Request.Form.Count == 0)
            {
                return View(gv);
            }
            string TenGiangVien = Request.Form["TenGiangVien"];
            string NgaySinh = Request.Form["NgaySinh"];
            int IDBoMon = int.Parse(Request.Form["IDBoMon"]);
            string DiaChi = Request.Form["DiaChi"];
            string SoDienThoai = Request.Form["SoDienThoai"];
            string Email = Request.Form["Email"];
            string HocVi = Request.Form["HocVi"];
            string TenDangNhap = Request.Form["TenDangNhap"];
            string MatKhau = Request.Form["MatKhau"];

            int IDKieuNguoiDung = int.Parse(Request.Form["IDKieuNguoiDung"]);
            string ChucVu = Request.Form["ChucVu"];
            context.SubmitChanges();

            return RedirectToAction("GiangVien");
        }
    }
}