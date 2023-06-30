using CaoCao.CoreBusiness.Models;

namespace CaoCao.UseCases.SearchProductScreen
{
    public interface ISearchProductUseCase
    {
        IEnumerable<Product> Execute(string filter);
    }
}