using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> 
          { new Car { Id = 1, BrandId = 2, ColorId = 324754, ModelYear = 2009 , CarName = "Audi", DailyPrice = 490, Description = "Temiz Araba"},
            new Car { Id = 2, BrandId = 2, ColorId = 324243, ModelYear = 2010 , CarName = "Audi", DailyPrice = 590, Description = "Kazasız,temiz Audi"},
            new Car { Id = 3, BrandId = 5, ColorId = 324546, ModelYear = 2013 , CarName = "Volkswagen", DailyPrice = 650, Description = "Ucuz fiyat,kiralama Volkswagen"},
            new Car { Id = 4, BrandId = 3, ColorId = 324123, ModelYear = 2018 , CarName = "BMW", DailyPrice = 870, Description = "2018 model BMW"},
            new Car { Id = 5, BrandId = 3, ColorId = 324765, ModelYear = 2020 , CarName = "BMW", DailyPrice = 1000, Description = "Yeni model BMW "},
            new Car { Id = 6, BrandId = 4, ColorId = 324685, ModelYear = 2015 , CarName = "Opel", DailyPrice = 450, Description = "Günlük güzel kullanımlık Opel"}
          };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=> c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.CarName = car.CarName;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
