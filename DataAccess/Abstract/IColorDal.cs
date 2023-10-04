using Core.DataAccess;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Abstract
{
    public interface IColorDal : IEntityRepository<Color> 
    {
        List<ColorDetailDto> GetColorDetails();
    }
}
