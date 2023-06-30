namespace CaoCao.UseCases.AdminPortal.OrderDetailScreen.interfaces
{
    public interface IProcessOrderUseCase
    {
        bool Execute(int orderId, string adminUserName);
    }
}