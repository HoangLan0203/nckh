using NCKH.ViewModel;

namespace NCKH.Repository
{
    public interface IRepositoryCart
    {
     
            List<CartViewModel> GetCartItems(int? userId);
            void AddToCart(int productId, string size, int quantity, int? userId);
            void UpdateCart(int productId, string size, int quantity, int? userId);
            void RemoveFromCart(int productId, string size, int? userId);
            decimal GetTotalAmount(int? userId);
        


    }
}
