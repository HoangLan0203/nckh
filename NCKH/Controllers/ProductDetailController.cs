using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NCKH.Models;

namespace NCKH.Controllers
{
    public class ProductDetailController : Controller
    {
        private readonly NckhB2cContext _context;

        public ProductDetailController(NckhB2cContext context)
        {
            _context = context;
        }

        public IActionResult Details(int id)
        {
            var productDetail = _context.ChiTietSanPhams
             .Include(p => p.SanPhamSizes)     
             .FirstOrDefault(p => p.MaSanPhamChiTiet == id);

            if (productDetail == null)
            {
                return NotFound();
            }

            return View(productDetail);
        }
       
    }
}
