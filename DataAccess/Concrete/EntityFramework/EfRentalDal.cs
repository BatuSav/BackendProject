using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entitites.Concrete;
using Entitites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapSQLServerContext>, IRentalDal
    {
        public List<CarRentalDetailDto> GetCarRentalDetail()
        {
            using (ReCapSQLServerContext context = new ReCapSQLServerContext())
            {

                var result = from rent in context.Rentals

                             join cust in context.Customers on rent.CustomerId equals cust.CustomerId 

                             join usr in context.Users on cust.UserId equals usr.Id

                             join car in context.Cars on rent.CarId equals car.CarId

                             join brand in context.Brands on car.BrandId equals brand.BrandId

                             select new CarRentalDetailDto
                             {
                                 RentalId = rent.RentalId,
                                 BrandName = brand.BrandName,
                                 FirstName = usr.FirstName,
                                 LastName = usr.LastName,
                                 RentDate = rent.RentDate,
                                 ReturnDate = rent.ReturnDate
                             };

                return result.ToList();
            }
        }
    }
}
