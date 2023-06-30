using CaoCao.UseCases.PluginInterfaces.DataStore;
using CaoCao.UseCases.PluginInterfaces.StateStore;
using CaoCao.UseCases.PluginInterfaces.UI;
using CaoCao.UseCases.ViewProductScreen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaoCao.UseCases.ViewProductScreen
{
    public class AddProductToCartUseCase : IAddProductToCartUseCase
    {
        private readonly IProductRepository productReposity;
        private readonly IShoppingCart shoppingCart;
        private readonly IShoppingCartStateStore shoppingCartStateStore;

        public AddProductToCartUseCase(
            IProductRepository productRepository,
            IShoppingCart shoppingCart,
            IShoppingCartStateStore shoppingCartStateStore)
        {
            this.productReposity = productRepository;
            this.shoppingCart = shoppingCart;
            this.shoppingCartStateStore = shoppingCartStateStore;
        }

        public async void Execute(int productId)
        {
            var product = productReposity.GetProduct(productId);
            await shoppingCart.AddProductAsync(product);

            shoppingCartStateStore.UpdateLineItemsCount();
        }
    }
}
