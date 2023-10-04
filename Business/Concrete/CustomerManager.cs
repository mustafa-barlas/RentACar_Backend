using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;


namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal=customerDal;
        }

        IResult ICustomerService.Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.ProductAdded);
        }

        IResult ICustomerService.Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.ProductDeleted);
        }

        IDataResult<List<Customer>> ICustomerService.GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(),Messages.ProductGetAll);
        }

        IDataResult<Customer> ICustomerService.GetById(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(x => x.Id == id),Messages.ProductGetAll);
        }

        IDataResult<List<CustomerDetailDto>> ICustomerService.GetCustomerDetails()
        {
            return new SuccessDataResult<List<CustomerDetailDto>>(_customerDal.GetCustomerDetails(),Messages.ProductGetAll);
        }

        IResult ICustomerService.Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
