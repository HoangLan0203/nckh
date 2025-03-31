using Microsoft.EntityFrameworkCore;
using NCKH.Models;
using NCKH.ViewModel;
using Newtonsoft.Json;

namespace NCKH.Repository
{
    public class CartRepository:IRepositoryCart
    {
        private readonly NckhB2cContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CartRepository(NckhB2cContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        private List<CartViewModel> GetSessionCart()
        {
            var session = _httpContextAccessor.HttpContext.Session;
            var jsonCart = session.GetString("Cart");

            return jsonCart == null ? new List<CartViewModel>() : JsonConvert.DeserializeObject<List<CartViewModel>>(jsonCart);
        }

        private void SaveSessionCart(List<CartViewModel> cart)
        {
            var session = _httpContextAccessor.HttpContext.Session;
            var jsonCart = JsonConvert.SerializeObject(cart);
            session.SetString("Cart", jsonCart);
        }

        public void AddToCart(int productId, string size, int quantity, int? userId)
        {
            var cart = GetSessionCart();
            var item = cart.FirstOrDefault(c => c.chiTietSanPham.MaSanPhamChiTiet == productId && c.Size == size);

            if (item != null)
            {
                item.SoLuong += quantity;
            }
            else
            {
                var product = _context.ChiTietSanPhams.Find(productId);
                if (product != null)
                {
                    cart.Add(new CartViewModel
                    {
                        chiTietSanPham = product,
                        Size = size,
                        SoLuong = quantity
                    });
                }
            }
            SaveSessionCart(cart);
        }

        public void UpdateCart(int productId, string size, int quantity, int? userId)
        {
            var cart = GetSessionCart();
            var item = cart.FirstOrDefault(c => c.chiTietSanPham.MaSanPhamChiTiet == productId && c.Size == size);
            if (item != null)
            {
                item.SoLuong = quantity;
            }
            SaveSessionCart(cart);
        }

        public void RemoveFromCart(int productId, string size, int? userId)
        {
            var cart = GetSessionCart();
            var item = cart.FirstOrDefault(c => c.chiTietSanPham.MaSanPhamChiTiet == productId && c.Size == size);
            if (item != null)
            {
                cart.Remove(item);
            }
            SaveSessionCart(cart);
        }

        public decimal GetTotalAmount(int? userId)
        {
            return GetSessionCart().Sum(x => x.SoLuong * x.chiTietSanPham.Gia);
        }
    }
}
