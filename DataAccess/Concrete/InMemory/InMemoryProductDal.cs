using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory;

public class InMemoryProductDal : IProductDal
{

   List<Product> _products;

    public InMemoryProductDal()
    {

        _products = new List<Product>
        {

            new Product{ProductId =1, CategoryId =1 , ProductName="Laptop" , UnitInStock= 10 , UnitPrice= 4000m },
            new Product{ProductId =2, CategoryId =1 , ProductName="Mouse" , UnitInStock= 20 , UnitPrice= 100m },
            new Product{ProductId =3, CategoryId =2 , ProductName="Klavye" , UnitInStock= 30 , UnitPrice= 200m },
            new Product{ProductId =4, CategoryId =2 , ProductName="SSD" , UnitInStock= 40 , UnitPrice= 350m },
            new Product{ProductId =5, CategoryId =2 , ProductName="Monitör" , UnitInStock= 50 , UnitPrice= 2500m },
        };

        
    }


    public void Add(Product product)
        {

        _products.Add(product);


        }

        public void Delete(Product product)
        {
           
           var productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
        }

        public List<Product> GetAll()
        {



        return _products;
        }

    public List<Product> GetByCategory(int categoryId)
    {
       
        return _products.Where(o => o.CategoryId == categoryId).ToList();
    }

    public void Update(Product product)
        {
          

        Product productToUpdate =  _products.SingleOrDefault(o => o.ProductId == product.ProductId); 

        if(productToUpdate != null)
        {

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitInStock = product.UnitInStock;
            productToUpdate.CategoryId = product.CategoryId;


        }
 //hata mesajı eklenecek !

        }
    }




