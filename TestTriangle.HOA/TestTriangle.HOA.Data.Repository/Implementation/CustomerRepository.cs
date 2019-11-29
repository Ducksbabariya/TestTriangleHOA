using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestTriangle.HOA.Data.Models;
using TestTriangle.HOA.Data.Repository.Contracts;
using System.Linq;

namespace TestTriangle.HOA.Data.Repository.Implementation
{
    public class CustomerRepository : ICustomerRepository
    {
        TestTriangleHOAContext _context;

        public CustomerRepository(TestTriangleHOAContext context)
        {
            _context = context;
        }

        public CustomerRepository()
        {
            _context = new TestTriangleHOAContext();
        }

        public BaseResponse<Customer> GetCustomersAsync(int page = 1, int pageSize = 50)
        {
            var data =
            _context.Customer
            .OrderBy(o => o.FirstName).AsQueryable();
            int skip = page > 1 ? (page - 1) * pageSize : 0;
            if (skip > 0)
            {
                data = data.Skip(skip);
            }
            data = data.Take(pageSize);

            var count = _context.Customer.Count();

            return new BaseResponse<Customer>()
            {
                Data = data,
                TotalCount = count
            };
        }

        public async Task<Customer> FindCustomerAsync(int id)
        {
            return await _context.Customer.FindAsync(id);
        }

        public async Task<int> InsertCustomerAsync(Customer customer)
        {
            _context.Customer.Add(customer);
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdatCustomerAsync(int id, Customer customer)
        {
            _context.Entry(customer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!await CustomerExistsAsync(id))
                {
                    return false;
                }
                else
                {
                    throw ex;
                }
            }

        }

        private async Task<bool> CustomerExistsAsync(int id)
        {
            return await _context.Customer.AnyAsync(e => e.CustomerId == id);
        }


        public async Task<bool> DeleteCustomerAsync(int id)
        {
            var customer = await _context.Customer.FindAsync(id);
            if (customer == null)
            {
                return false;
            }

            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();

            return true;
        }


    }
}
