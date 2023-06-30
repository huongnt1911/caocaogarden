using CaoCao.CoreBusiness.Models;
using CaoCao.UseCases.PluginInterfaces.UI;
using CaoCao.UseCases.ShoppingCartScreen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaoCao.UseCases.ShoppingCartScreen
{
    public class ViewShoppingCartUseCase : IViewShoppingCartUseCase
    {
        private readonly IShoppingCart shoppingCart;

        public ViewShoppingCartUseCase(IShoppingCart shoppingCart)
        {
            this.shoppingCart = shoppingCart;
        }
        public Task<Order> Excute()
        {
            return shoppingCart.GetOrderAsync();
        }
    }
}
