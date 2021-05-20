using Core.Utilities.Results;
using Entitites.Concrete;
using Entitites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<CarRentalDetailDto>> GetCarRentalDetail();
        IDataResult<List<Rental>> GetAll();
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
    }
}
