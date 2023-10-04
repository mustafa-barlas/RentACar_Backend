using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();

        IDataResult<Rental> GetById(int id);

        //IDataResult<List<Rental>> GetByUnitPrice(decimal min, decimal max);

        IDataResult<List<RentalDetailDto>> GetRentalDetails();

        IResult Add(Rental rental);

        IResult Delete(Rental rental);

        IResult Update(Rental rental);

        IResult AddTransactionalTest(Rental rental);
    }
}
