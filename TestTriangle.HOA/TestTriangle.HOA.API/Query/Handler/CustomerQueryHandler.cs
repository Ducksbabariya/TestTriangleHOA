﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTriangle.HOA.API.Query.Generic;
using TestTriangle.HOA.Data.Models;
using TestTriangle.HOA.Data.Repository.Contracts;
using TestTriangle.HOA.Data.Repository.Implementation;

namespace TestTriangle.HOA.API.Query.Handler
{
    public class CustomerQueryHandler
    {
        private readonly IUnitOfWork _unitOfWork;
        public CustomerQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public BaseResponse<Customer> HandleAsync(GetAllQuery<Customer> getAllQuery)
        {
            return  _unitOfWork.CustomerRepository.GetCustomersAsync(getAllQuery.Page, getAllQuery.PageSize);
        }

        public async Task<Customer> HandleAsync(FindQuery<Customer> findQuery)
        {
            return await _unitOfWork.CustomerRepository.FindCustomerAsync(findQuery.Id);
        }

    }

}
