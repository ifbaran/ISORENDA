﻿using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfDiscountCourseMentorDal : EfEntityRepositoryBase<DiscountCourseMentor, IsorendaContext>, IDiscountCourseMentorDal
    {
        public EfDiscountCourseMentorDal()
        {
        }
    }
}
