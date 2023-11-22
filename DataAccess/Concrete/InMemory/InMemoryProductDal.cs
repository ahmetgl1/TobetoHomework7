using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        private List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product { ProductId = 1, CategoryId = 1, ProductName = "Laptop", UnitInStock = 10, UnitPrice = 4000m },
                new Product { ProductId = 2, CategoryId = 1, ProductName = "Mouse", UnitInStock = 20, UnitPrice = 100m },
                new Product { ProductId = 3, CategoryId = 2, ProductName = "Klavye", UnitInStock = 30, UnitPrice = 200m },
                new Product { ProductId = 4, CategoryId = 2, ProductName = "SSD", UnitInStock = 40, UnitPrice = 350m },
                new Product { ProductId = 5, CategoryId = 2, ProductName = "Monitör", UnitInStock = 50, UnitPrice = 2500m },
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            var productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            if (productToDelete != null)
            {
                _products.Remove(productToDelete);
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            // Buraya gerekirse ileride bir filtreleme mantığı ekleyebilirsin.
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            // Buraya gerekirse ileride bir filtreleme mantığı ekleyebilirsin.
            throw new NotImplementedException();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailsDto> GetProductDetails()
        {
            // İleride buraya ürün detayları almak için gerekli kodları ekleyebilirsin.
            List<ProductDetailsDto> productDetailsDto = null;
            return productDetailsDto;
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            if (productToUpdate != null)
            {
                productToUpdate.ProductName = product.ProductName;
                productToUpdate.UnitPrice = product.UnitPrice;
                productToUpdate.UnitInStock = product.UnitInStock;
                productToUpdate.CategoryId = product.CategoryId;
            }
            // Hata mesajı ekleyebilirsin.
        }
    }
}
