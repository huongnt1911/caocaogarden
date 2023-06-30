using CaoCao.CoreBusiness.Models;

namespace CaoCao.UseCases.AdminPortal.ProcessedOrdersScreen
{
    public interface IViewProcessedOrdersUseCase
    {
        IEnumerable<Order> Execute();
    }
}