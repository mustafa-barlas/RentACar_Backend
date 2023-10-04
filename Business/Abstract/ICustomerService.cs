﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();

        IDataResult<List<CustomerDetailDto>> GetCustomerDetails();

        IDataResult<Customer> GetById(int id);

        IResult Update(Customer customer);

        IResult Delete(Customer customer);

        IResult Add(Customer customer);
    }
}
