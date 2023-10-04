using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface ICarService 
    {
        IDataResult<List<Car>> GetAll();

        IDataResult<List<Car>> GetAllByBrandId(int id);

        IDataResult<List<Car>> GetAllByColorId(int id);

        IDataResult<List<CarDetailDto>> GetCarDetails();

        IDataResult<Car> GetById(int id);

        IResult Add(Car car);

        IResult Delete(Car car);

        IResult Update(Car car);

    }
}
