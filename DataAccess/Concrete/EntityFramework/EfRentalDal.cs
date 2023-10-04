using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, Context>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (var context = new Context())
            {
                var result = from x in context.Cars
                             join y in context.Rentals
                             on x.ID equals y.ID
                             from r in context.Rentals
                             join c in context.Customers
                             on r.ID equals c.Id
                             select new RentalDetailDto
                             { RentalId = y.ID, CarId = x.ID/*, RentalName = y.Name,*/, CustomerId = c.Id, CustomerName = c.FirstName, CarName = x.Name };
                return result.ToList();
            }
            throw new NotImplementedException();
        }
    }
}
