using CaoCao.CoreBusiness.Models;
using CaoCao.UseCases.PluginInterfaces.DataStore;
using CaoCao.UseCases.ViewProductScreen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaoCao.UseCases.ViewProductScreen
{
    public class ViewProductUseCase : IViewProductUseCase
    {
        private readonly IProductRepository procductRepository;
        public ViewProductUseCase(IProductRepository procductRepository)
        {
            this.procductRepository = procductRepository;
        }
        public Product Execute(int id)
        {
            return procductRepository.GetProduct(id);
        }
    }
}
