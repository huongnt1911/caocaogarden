using CaoCao.CoreBusiness.Models;
using CaoCao.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaoCao.DataStore.HardCoded
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products;
        public ProductRepository()
        {
            products = new List<Product>()
            {
                new Product { ProductId = 495,  Name = "Maybelline Face Studio Master Hi-Light Light Booster Bronzer", Price = 14.99, ImageLink = "https://d3t32hsnjxo7q6.cloudfront.net/i/991799d3e70b8856686979f8ff6dcfe0_ra,w158,h184_pa,w158,h184.png"},
            };
        }

        public Product GetProduct(int id)
        {
            return products.FirstOrDefault(x => x.ProductId == id);
        }

        public IEnumerable<Product> GetProducts(string filter = null)
        {
            if (string.IsNullOrWhiteSpace(filter)) return products;
            return products.Where(x => x.Name.ToLower().Contains(filter.ToLower()));
        }
    }
}
