using CaoCao.CoreBusiness.Models;
using CaoCao.DataStore.SQL.Dapper.Helpers;
using CaoCao.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaoCao.DataStore.SQL.Dapper
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDataAccess dataAccess;

        public ProductRepository(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public Product GetProduct(int id)
        {
            return dataAccess.QuerySingle<Product, dynamic>("SELECT * FROM Product WHERE ProductId=@ProductId",
                    new { ProductId = id });
        }

        public IEnumerable<Product> GetProducts(string filter)
        {
            List<Product> list;
            if (string.IsNullOrWhiteSpace(filter))
            {
                list = dataAccess.Query<Product, dynamic>("SELECT * FROM Product", new { });
            }
            else
                list = dataAccess.Query<Product, dynamic>("SELECT * FROM Product WHERE Name like '%'+@filter+'%'",
                        new { filter = filter });
            return list.AsEnumerable();
        }
    }
}
