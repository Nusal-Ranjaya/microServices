using Customers.CustomerDbContext;
using Customers.Entity;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace Customers.Interface
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly CustomerAppDbContext _context;
        

        public CustomerRepo(CustomerAppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Customer>> GetAllCustomersAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            return await _context.Customers.FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
