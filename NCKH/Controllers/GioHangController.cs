using Microsoft.AspNetCore.Mvc;
using static NCKH.Repository.IRepositoryCart;

namespace NCKH.Controllers
{
    public class GioHangController : Controller
    {
        private readonly ICartRepository _cartRepository;

        public GioHangController(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public IActionResult Index()
        {
            var cart = _cartRepository.GetCartItems(null);
            return View(cart);
        }

        [HttpPost]
        public IActionResult AddToCart(int productId, string size, int quantity)
        {
            _cartRepository.AddToCart(productId, size, quantity, null);
            return Json(new { success = true });
        }

        [HttpPost]
        public IActionResult UpdateCart(int productId, string size, int quantity)
        {
            _cartRepository.UpdateCart(productId, size, quantity, null);
            return Json(new { success = true });
        }

        [HttpPost]
        public IActionResult RemoveFromCart(int productId, string size)
        {
            _cartRepository.RemoveFromCart(productId, size, null);
            return Json(new { success = true });
        }
    }
}
