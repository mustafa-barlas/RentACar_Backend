using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract;

public interface ICarImageService
{
    IDataResult<List<CarImage>> GetAll();
    IResult Add(IFormFile image, CarImage img);
    IResult Update(IFormFile image, CarImage img);
    IResult Delete(CarImage img);
    IDataResult<CarImage> Get(CarImage img);
    IDataResult<List<CarImage>> GetCarListByCarID(int carID);
}