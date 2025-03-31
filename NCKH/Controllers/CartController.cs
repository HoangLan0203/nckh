using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NCKH.Models;
using NCKH.ViewModel;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace NCKH.Controllers
{
    public class CartController : Controller
    {
        private readonly NckhB2cContext _context;
        private const string CartSession = "CartSession";

        public CartController(NckhB2cContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var cart = HttpContext.Session.GetString(CartSession);
            var list = new List<CartViewModel>();

            if (!string.IsNullOrEmpty(cart))
            {
                list = JsonConvert.DeserializeObject<List<CartViewModel>>(cart);
            }
            return View(list);
        }

        [HttpPost]
        public IActionResult AddCart(int productId, string size, int quantity = 1)
        {
            var product = _context.ChiTietSanPhams.Find(productId);
            if (product == null)
            {
                return NotFound(); 
            }

            var cart = HttpContext.Session.GetString(CartSession);
            List<CartViewModel> list = string.IsNullOrEmpty(cart) ? new List<CartViewModel>() : JsonConvert.DeserializeObject<List<CartViewModel>>(cart);

            var existingItem = list.FirstOrDefault(x => x.chiTietSanPham.MaSanPhamChiTiet == productId && x.Size == size);
            if (existingItem != null)
            {
                existingItem.SoLuong += quantity;
            }
            else
            {
                list.Add(new CartViewModel
                {
                    chiTietSanPham = product,
                    SoLuong = quantity,
                    Size = size
                });
            }

            HttpContext.Session.SetString(CartSession, JsonConvert.SerializeObject(list));

            return RedirectToAction("Index");
        }
        public IActionResult RemoveFromCart(int productId, string size)
        {
            var cart = HttpContext.Session.GetString(CartSession);
            if (cart != null)
            {
                var list = JsonConvert.DeserializeObject<List<CartViewModel>>(cart);
                var itemToRemove = list.FirstOrDefault(c => c.chiTietSanPham.MaSanPhamChiTiet == productId && c.Size == size);
                if (itemToRemove != null)
                {
                    list.Remove(itemToRemove);
                    HttpContext.Session.SetString(CartSession, JsonConvert.SerializeObject(list));
                    return Json(new { success = true, message = "Xóa sản phẩm thành công!" });

                }
                return Json(new { success = false, message = "Không tìm thấy sản phẩm trong giỏ hàng!" });

            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult UpdateCart(int productId, string size, int quantity)
        {
            var cart = HttpContext.Session.GetString(CartSession);
            if (cart != null)
            {
                var list = JsonConvert.DeserializeObject<List<CartViewModel>>(cart);
                var itemToUpdate = list.FirstOrDefault(c => c.chiTietSanPham.MaSanPhamChiTiet == productId && c.Size == size);
                if (itemToUpdate != null)
                {
                    itemToUpdate.SoLuong = quantity;
                    HttpContext.Session.SetString(CartSession, JsonConvert.SerializeObject(list));
                    return Json(new { success = true, message = "Cập nhật giỏ hàng thành công!" });

                }
                return Json(new { success = false, message = "Sản phẩm không tồn tại trong giỏ hàng!" });

            }
            return RedirectToAction("Index");

        }
    }
}