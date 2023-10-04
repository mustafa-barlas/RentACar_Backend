using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.Dtos;
using System.Drawing;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, Context>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (var context = new Context())
            {
                var result = from car in context.Cars
                             join brand in context.Brands
                             on car.BrandID equals brand.Id

                             join color in context.Colors
                             on car.ColorID equals color.Id

                             select new CarDetailDto
                             {
                                 BrandName = brand.Name,
                                 CarDescription = car.Description,
                                 CarName = car.Name,
                                 ColorName = color.Name,

                             };

                return result.ToList();
            }
            throw new NotImplementedException();
		}
    }
}


