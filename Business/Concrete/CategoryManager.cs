using Business.Abstract;
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
    public class CategoryManager : ICategoryService
    {


        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
            
        }



        public List<Category> GetAll()
        {
          


            return _categoryDal.GetAll();
        }

        public Category GetById(int id)
        {
           

            return _categoryDal.Get(c => c.CategoryId == id);



        }
    }
}
