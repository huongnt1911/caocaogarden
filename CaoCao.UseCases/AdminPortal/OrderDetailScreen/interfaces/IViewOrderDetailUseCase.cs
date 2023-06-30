using CaoCao.CoreBusiness.Models;

namespace CaoCao.UseCases.AdminPortal.OrderDetailScreen.interfaces
{
    public interface IViewOrderDetailUseCase
    {
        Order Execute(int orderId);
    }
}