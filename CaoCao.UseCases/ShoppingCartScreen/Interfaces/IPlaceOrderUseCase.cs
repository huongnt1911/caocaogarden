using CaoCao.CoreBusiness.Models;

namespace CaoCao.UseCases.ShoppingCartScreen.Interfaces
{
    public interface IPlaceOrderUseCase
    {
        Task<string> Excute(Order order);
    }
}