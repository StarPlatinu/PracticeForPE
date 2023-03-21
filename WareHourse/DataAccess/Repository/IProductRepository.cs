using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        IEnumerable<Product> GetProductsByUnitPrice(decimal price);
        IEnumerable<Product> GetProductsByUnitsInStock(int price);
        Product GetProductByID(int productId);
        IEnumerable<Product> GetProductByName(String productname);
        void InsertProduct(Product product);
        void DeleteProduct(Product product);
        void UpdateProduct(Product product);
    }
}
