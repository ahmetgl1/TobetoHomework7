﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameWork;

public class EFCategoryDal :Core.DataAccess.EntityFramework.EFEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
{
    
}
