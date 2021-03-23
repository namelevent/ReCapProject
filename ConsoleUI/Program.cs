using Business.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntitiyFramework;
using System;
using Entities.Concrete;
using Entities.DTOs;
using Core.DataAccess.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager car1 = new CarManager(new EfCarDal());

            //Dataya veri ekleme
            //car.Add(new Car
            //{
            //    Id = 2,
            //    BrandId = 5,
            //    CarName = "Volkswogen",
            //    ColorId = 5754,
            //    DailyPrice = 1300,
            //    Description = "Günlük güzel araç",
            //    ModelYear = 2017
            //});
            foreach (var car2 in car1.GetAll())
            {
                Console.WriteLine(car2.CarName);
            }









            Console.Read();
        }
    }
}
