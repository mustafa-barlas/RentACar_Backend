using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, Context>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            throw new NotImplementedException();
        }
    }
}
