using CaoCao.CoreBusiness.Models;

namespace CaoCao.UseCases.OrderConfirmationScreen
{
    public interface IViewOrderConfirmationUseCase
    {
        Order Excute(string uniqueId);
    }
}