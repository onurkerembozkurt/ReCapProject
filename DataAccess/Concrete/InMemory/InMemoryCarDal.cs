﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal() {
            _cars = new List<Car>() {
             new Car { Id = 1,BrandId=1,ColorId=1,DailyPrice=12312366,Description="BMW",ModelYear=2015},
             new Car { Id = 2,BrandId=2,ColorId=2,DailyPrice=14412421,Description="Audi",ModelYear=2016},
             new Car { Id = 3,BrandId=2,ColorId=2,DailyPrice=45454545,Description="Fiat",ModelYear=2017},
            };
        }
        public void Add(Car car)
        {
           _cars.Add(car);
        }
        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }
        public List<Car> GetAll()
        {
            return _cars;
        }
        public List<Car> GetById(int id)
        {
            return _cars.Where(c=>c.Id==id).ToList();
        }
        public void Update(Car car)
        {
            Car carToUpdate= _cars.SingleOrDefault(c=>c.Id == car.Id);
            carToUpdate.BrandId= car.BrandId;
            carToUpdate.ColorId= car.ColorId;
            carToUpdate.ModelYear= car.ModelYear;
            carToUpdate.DailyPrice= car.DailyPrice;
            carToUpdate.Description= car.Description;
        }
    }
}