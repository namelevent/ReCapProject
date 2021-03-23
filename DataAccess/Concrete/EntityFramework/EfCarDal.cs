using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.Linq;
using Core.DataAccess.EntityFramework;
using Entities.DTOs;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, DataBaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (DataBaseContext context = new DataBaseContext())
            {
                var result = from c in context.Cars
                             join cl in context.Colors
                             on c.ColorId equals cl.ColorId
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             select new CarDetailDto { CarName = c.CarName, DailyPrice = c.DailyPrice, BrandName = b.BrandName, ColorName = cl.ColorName };
                return result.ToList();
            }
        }
    }
}
