﻿using Core.DataAcces.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,CarRentalContext>,ICarDal
    {
        public List<CarDetailDto> GetDetails()
        {
            using (CarRentalContext context=new CarRentalContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             join r in context.Rentals
                             on c.Id equals r.CarId
                             select new CarDetailDto() {CarName=c.Description,BrandName=b.Name,ColorName=co.Name,RentDate=r.RentDate,ReturnDate=r.ReturnDate };
                return result.ToList();
            }
        }
    }
}
