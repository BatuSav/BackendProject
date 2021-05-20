using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entitites.Concrete;
using Entitites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.NewRentalSuccess);

        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleteSuccess);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.GetRentalListSuccess);
        }

        public IDataResult<List<CarRentalDetailDto>> GetCarRentalDetail()
        {
            return new SuccessDataResult<List<CarRentalDetailDto>>(_rentalDal.GetCarRentalDetail());

        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
