using Customers.Entity;

namespace Customers.CustomerServices
{
    public interface ICustomerServices
    {
        Task<List<Customer>> GetAllCustomersAsync();
        Task<Customer> GetCustomerByIdAsync(int id);

    }
}
