using CaoCao.CoreBusiness.Models;
using CaoCao.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaoCao.UseCases.OrderConfirmationScreen
{
    public class ViewOrderConfirmationUseCase : IViewOrderConfirmationUseCase
    {
        private readonly IOrderRepository orderRepository;
        public ViewOrderConfirmationUseCase(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }
        public Order Excute(string uniqueId)
        {
            return orderRepository.GetOrderByUniqueId(uniqueId);
        }
    }
}
