using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestTriangle.HOA.Data.Models;

namespace TestTriangle.HOA.Data.Repository.Contracts
{
    public interface ICustomerRepository
    {
        BaseResponse<Customer> GetCustomersAsync(int page = 1, int pageSize = 50);
        Task<Customer> FindCustomerAsync(int id);
        Task<int> InsertCustomerAsync(Customer customer);
        Task<bool> UpdatCustomerAsync(int id, Customer customer);
        Task<bool> DeleteCustomerAsync(int id);
    }
}
