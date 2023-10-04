using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, Context>, IBrandDal
    {
        public List<BrandDetailDto> GetBrandDetails()
        {
            throw new NotImplementedException();
        }
    }
}
