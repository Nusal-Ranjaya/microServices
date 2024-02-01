using Customers.Entity;

namespace Customers.Interface
{
    public interface ICustomerRepo
    {
        Task<List<Customer>> GetAllCustomersAsync();
        Task<Customer> GetCustomerByIdAsync(int id);
    }
}
