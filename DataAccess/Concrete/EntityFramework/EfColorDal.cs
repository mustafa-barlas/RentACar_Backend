using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, Context>, IColorDal
    {
        public List<ColorDetailDto> GetColorDetails()
        {
            throw new NotImplementedException();
        }
    }
}
