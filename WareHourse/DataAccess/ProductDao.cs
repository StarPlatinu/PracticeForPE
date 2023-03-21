using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class ProductDao
    {
        private static ProductDao instance = null;
        private static readonly object instanceLock = new object();
        private ProductDao() { }
        public static ProductDao Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDao();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Product> GetProductsList()
        {
            List<Product> products;

            try
            {
                var db = new ShopingMiniContext();
                products = db.Products.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return products;
        }

        public Product GetProductByID(int productID)
        {
            Product product = null;
            try
            {
                var db = new ShopingMiniContext();
                product = db.Products.SingleOrDefault(product => product.ProductId == productID);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }
        public IEnumerable<Product> GetProductsByUnitPrice(decimal price)
        {
            List<Product> products;
            List<Product> productsbyunitprice = null;
            try
            {
                var db = new ShopingMiniContext();
                products = db.Products.ToList();

                foreach (Product pr in products)
                {
                    decimal unit = pr.UnitPrice;
                    if (Decimal.Compare(unit, price) == 0)
                    {
                        productsbyunitprice.Add(pr);
                    }
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return productsbyunitprice;
        }
        public IEnumerable<Product> GetProductsByUnitsInStock(int price)
        {
            List<Product> products;
            List<Product> productsbyunitsinstock = null;
            try
            {
                var db = new ShopingMiniContext();
                products = db.Products.ToList();
                foreach (Product pr in products)
                {
                    if (pr.UnitsInStock.CompareTo(price) == 0)
                    {
                        productsbyunitsinstock.Add(pr);
                    }
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return productsbyunitsinstock;
        }
        public IEnumerable<Product> GetProductByName(string productname)
        {
            Product product = null;
            List<Product> productsl = null;

            try
            {
                var db = new ShopingMiniContext();
                product = db.Products.SingleOrDefault(product => product.ProductName.Equals(productname));
                productsl.Add(product);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return productsl;
        }

        public void AddNew(Product product)
        {
            try
            {
                Product _product = GetProductByID(product.ProductId);
                if (_product == null)
                {
                    var db = new ShopingMiniContext();
                    db.Products.Add(product);
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("Product is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Product product)
        {
            try
            {
                Product p = GetProductByID(product.ProductId);
                if (p != null)
                {
                    var db = new ShopingMiniContext();
                    db.Entry<Product>(product).State = EntityState.Modified;
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("Product does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(Product product)
        {
            try
            {
                Product _product = GetProductByID(product.ProductId);
                if (_product != null)
                {
                    var db = new ShopingMiniContext();
                    db.Products.Remove(_product);
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("Product does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
