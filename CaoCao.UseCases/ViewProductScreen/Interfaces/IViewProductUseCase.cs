using CaoCao.CoreBusiness.Models;

namespace CaoCao.UseCases.ViewProductScreen.Interfaces
{
    public interface IViewProductUseCase
    {
        Product Execute(int id);
    }
}