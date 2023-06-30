using CaoCao.CoreBusiness.Models;
using CaoCao.UseCases.PluginInterfaces.StateStore;
using CaoCao.UseCases.PluginInterfaces.UI;
using CaoCao.UseCases.ShoppingCartScreen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaoCao.UseCases.ShoppingCartScreen
{
    public class UpdateQuantityUseCase : IUpdateQuantityUseCase
    {
        private readonly IShoppingCart shoppingCart;
        private readonly IShoppingCartStateStore shoppingCartStateStore;
        public UpdateQuantityUseCase(IShoppingCart shoppingCart, IShoppingCartStateStore shoppingCartStateStore)
        {
            this.shoppingCart = shoppingCart;
            this.shoppingCartStateStore = shoppingCartStateStore;
        }

        public async Task<Order> Excute(int productId, int quantity)
        {
            var order = await shoppingCart.UpdateQuantityAsync(productId, quantity);
            shoppingCartStateStore.UpdateProductQuantity();
            return order;
        }
    }
}
