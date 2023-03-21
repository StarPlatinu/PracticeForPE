using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void DeleteProduct(Product product) => ProductDao.Instance.Remove(product);
        public Product GetProductByID(int productId) => ProductDao.Instance.GetProductByID(productId);
        public IEnumerable<Product> GetProductByName(String productname) => ProductDao.Instance.GetProductByName(productname);
        public IEnumerable<Product> GetProductsByUnitPrice(decimal price) => ProductDao.Instance.GetProductsByUnitPrice(price);
        public IEnumerable<Product> GetProductsByUnitsInStock(int price) => ProductDao.Instance.GetProductsByUnitsInStock(price);
        public IEnumerable<Product> GetProducts() => ProductDao.Instance.GetProductsList();
        public void InsertProduct(Product product) => ProductDao.Instance.AddNew(product);
        public void UpdateProduct(Product product) => ProductDao.Instance.Update(product);
    }
}
