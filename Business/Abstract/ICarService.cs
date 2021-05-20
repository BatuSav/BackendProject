using Core.Utilities.Results;
using DataAccess.Abstract;
using Entitites.Concrete;
using Entitites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService 
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarByBrandId(int id);
        IDataResult<List<Car>> GetCarByColorId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetail();
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
    }

}
