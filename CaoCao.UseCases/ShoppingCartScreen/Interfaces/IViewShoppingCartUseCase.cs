using CaoCao.CoreBusiness.Models;

namespace CaoCao.UseCases.ShoppingCartScreen.Interfaces
{
    public interface IViewShoppingCartUseCase
    {
        Task<Order> Excute();
    }
}