using System.Transactions;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private IRentalDal _rentalDal;
       /* private ICarDal _carDal;*/ // EntityManager kendisinden başka bir DAL'ı  enjekte edemez;
        private ICarService _carService; //ICarDal yerine kulanıldı Yabancı veya herhangi bir başka servis bu şekilde enjekte edilecek
        public RentalManager(IRentalDal rentalDal, ICarService carService)
        {
            _rentalDal = rentalDal;
            _carService = carService;
        }


        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(RentalValidator))]
        [CacheRemoveAspect("IProductService.Get")]
        public IResult Add(Rental rental)
        {
            IResult result = BusinessRules.Run
                (CheckIfRentalNameExists(rental.Name),CheckIfRentalCountOfCar(rental.ID), CheckIfCarLimitExceeded());

            if (result != null)
            {
                return result;
            }

            _rentalDal.Add(rental);
            return new SuccessResult(Messages.ProductAdded);

        }

        [ValidationAspect(typeof(RentalValidator))]
        [CacheRemoveAspect("IProductService.Get")]
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.ProductUpdated);
        }
        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.ProductDeleted);
        }

        [CacheAspect]
        public IDataResult<List<Rental>> GetAll()
        {
            if (DateTime.Now.Hour == 2)
            {
                return new ErrorDataResult<List<Rental>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.ProductGetAll);
        }
        [PerformanceAspect(5)]
        [CacheAspect]
        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(x => x.ID == id), Messages.ProductGetAll);
        }

        //public IDataResult<List<Rental>> GetByUnitPrice(decimal min, decimal max)
        //{
        //    return new SuccessDataResult<List<Rental>>
        //        (_rentalDal.GetAll(x => x.DailyPrice >= min && x.DailyPrice <= max), Messages.ProductGetAll);
        //}

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails(), Messages.ProductGetAll);
        }

        private IResult CheckIfRentalCountOfCar(int carId)  // refactoring 
        {
            var result = _rentalDal.GetAll(x => x.ID == carId).Count;
            if (result >= 10)
            {
                return new ErrorResult(Messages.CountError);
            }

            return new SuccessResult();
        }
        private IResult CheckIfRentalNameExists(string rentalName)
        {
            var result = _rentalDal.GetAll(x => x.Name == rentalName).Any();
            if (result)
            {
                return new ErrorResult(Messages.RentalNameAlreadyExists);
            }

            return new SuccessResult();
        }

        private IResult CheckIfCarLimitExceeded()
        {

            var result = _carService.GetAll();
            if (result.Data.Count > 15)
            {
                return new ErrorResult(Messages.CarLimitExceeded);
            }

            return new SuccessResult();
        }

        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Rental rental)
        {
            
            //Add(rental);
            //if (rental.Address.Length < 2)
            //{
            //    throw new Exception("");
            //}
            
            Add(rental);

            return null;
        }
    }
}
