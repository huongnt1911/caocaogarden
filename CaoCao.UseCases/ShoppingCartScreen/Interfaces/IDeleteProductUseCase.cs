using CaoCao.CoreBusiness.Models;

namespace CaoCao.UseCases.ShoppingCartScreen.Interfaces
{
    public interface IDeleteProductUseCase
    {
        Task<Order> Execute(int productId);
    }
}