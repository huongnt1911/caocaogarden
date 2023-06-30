using CaoCao.CoreBusiness.Models;

namespace CaoCao.UseCases.AdminPortal.OutstandingOrdersScreen
{
    public interface IViewOutstandingOrdersUseCase
    {
        IEnumerable<Order> Execute();
    }
}