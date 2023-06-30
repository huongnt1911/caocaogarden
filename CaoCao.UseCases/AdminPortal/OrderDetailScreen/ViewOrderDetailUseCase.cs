using CaoCao.CoreBusiness.Models;
using CaoCao.UseCases.AdminPortal.OrderDetailScreen.interfaces;
using CaoCao.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaoCao.UseCases.AdminPortal.OrderDetailScreen
{
    public class ViewOrderDetailUseCase : IViewOrderDetailUseCase
    {
        private readonly IOrderRepository orderRepository;
        public ViewOrderDetailUseCase(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public Order Execute(int orderId)
        {
            return orderRepository.GetOrder(orderId);
        }
    }
}
