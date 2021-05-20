using DataAccess.Abstract;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal 

    {
        readonly List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=150,ModelYear=2017,Description="Sedan, Otomatik vites"},
                new Car{CarId=2,BrandId=2,ColorId=3,DailyPrice=125,ModelYear=2015,Description="Hatchback,Manuel vites"},
                new Car{CarId=3,BrandId=1,ColorId=2,DailyPrice=300,ModelYear=2019,Description="Sport Sedan,Otomatik vites"},
                new Car{CarId=4,BrandId=2,ColorId=1,DailyPrice=250,ModelYear=2018,Description="Sport Hatchback,Manuel vites"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToBeDeleted = _cars.SingleOrDefault(x => x.CarId == car.CarId);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(x => x.CarId == Id).ToList();
        }

        public void Update(Car car)
        {
            Car CarToBeUpdated = _cars.SingleOrDefault(x => x.CarId == car.CarId);
            CarToBeUpdated.ModelYear = car.ModelYear;
            CarToBeUpdated.ColorId = car.ColorId;
            CarToBeUpdated.Description = car.Description;

        }
    }
}
