using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameWork;

public class EFProductDal : Core.DataAccess.EntityFramework.EFEntityRepositoryBase<Product, NorthwindContext>, IProductDal
{


    public List<ProductDetailsDto> GetProductDetails()
    {

        using (NorthwindContext context = new NorthwindContext())
        {
            var result = from p in context.Products
                         join c in context.Categories
                         on p.CategoryId equals c.CategoryId
                         select new ProductDetailsDto
                         {
                             ProductId = p.ProductId,
                             ProductName = p.ProductName,
                             CategoryName = c.CategoryName,
                             UnitsInStock = p.UnitInStock
                         };



            return result.ToList(); ;






        }
    }
}


    
