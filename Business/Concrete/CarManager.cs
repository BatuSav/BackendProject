using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entitites.Concrete;
using Entitites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
         ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [SecuredOperation("admin,mod")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
            if (car.Description.Length>4 && car.DailyPrice>0)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.CarAddedSuccessfull);
            }
            return new ErrorResult(Messages.CarAddedGoneWrong);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarListed);
        }

        [CacheAspect]
        public IDataResult<List<Car>> GetCarByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(x => x.ColorId== id));
        }

        [CacheAspect]
        public IDataResult<List<CarDetailDto>> GetCarDetail()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetail(),Messages.CarDetailsListed);
        }

        [CacheAspect]
        public IDataResult<List<Car>> GetCarByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(x => x.BrandId == id),Messages.CarsListedByBrandName);
        }

        [SecuredOperation("admin,mod")]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
