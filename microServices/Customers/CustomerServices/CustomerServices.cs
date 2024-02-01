using Customers.Entity;
using Customers.Interface;

namespace Customers.CustomerServices
{
    public class CustomerServices : ICustomerServices
    {
        private readonly ICustomerRepo _repo;
        public CustomerServices(ICustomerRepo repo)
        {
            _repo = repo; }
        public Task<List<Customer>> GetAllCustomersAsync()
        {
            return _repo.GetAllCustomersAsync();
        }

        public Task<Customer> GetCustomerByIdAsync(int id)
        {
            return _repo.GetCustomerByIdAsync(id);  
        }
    }
}
