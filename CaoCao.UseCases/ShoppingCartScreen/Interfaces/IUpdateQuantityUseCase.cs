using CaoCao.CoreBusiness.Models;

namespace CaoCao.UseCases.ShoppingCartScreen.Interfaces
{
    public interface IUpdateQuantityUseCase
    {
        Task<Order> Excute(int productId, int quantity);
    }
}