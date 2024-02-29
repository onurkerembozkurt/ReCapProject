using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rental)
        {
            _rentalDal = rental;
        }
        public IResult Add(Rental rental)
        {
            var isRentACar = _rentalDal.GetAll(r => r.CarId == rental.CarId && r.ReturnDate==null).Any();
            if (rental.ReturnDate==null)
            {
                return new ErrorResult("This car already rent from somenone else");
            }
            else
            {
                
                _rentalDal.Add(rental);
                return new SuccessResult();
            }
            
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            _rentalDal.GetAll();
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());


        }
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }
    }
}




