﻿using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class ProductManager : IProductService
{

    IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
        
    }


    public List<Product> GetAll()
    {
        return _productDal.GetAll();
    }

    public List<Product> GetAllByCategory(int categoryId)
    {
      
        return _productDal.GetAll(c => c.CategoryId == categoryId);




    }

    public List<Product> GetUnitById(decimal min, decimal max)
    {

        return _productDal.GetAll(o => o.UnitPrice<= min && o.UnitPrice <= max);


    }
}
