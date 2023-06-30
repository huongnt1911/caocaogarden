using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaoCao.CoreBusiness.Services.Interfaces;
using CaoCao.UseCases.AdminPortal.OrderDetailScreen.interfaces;
using CaoCao.UseCases.PluginInterfaces.DataStore;

namespace CaoCao.UseCases.AdminPortal.OrderDetailScreen
{
    public class ProcessOrderUseCase : IProcessOrderUseCase
    {
        private readonly IOrderRepository orderRepository;
        private readonly IOrderService orderService;
        public ProcessOrderUseCase(IOrderRepository orderRepository, IOrderService orderService)
        {
            this.orderRepository = orderRepository;
            this.orderService = orderService;
        }

        public bool Execute(int orderId, string adminUserName)
        {
            var order = orderRepository.GetOrder(orderId);
            order.AdminUser = adminUserName;
            order.DateProcessed = DateTime.Now;
            if (orderService.ValidateProcessOrder(order))
            {
                orderRepository.UpdateOrder(order);
                return true;
            }
            return false;
        }
    }
}
