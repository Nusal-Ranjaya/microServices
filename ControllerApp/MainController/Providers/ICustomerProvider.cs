
using MainController.Models;

namespace MainController.Providers
{
    public interface ICustomerProvider
    {
        Task<IEnumerable<Customer>> GetAllCus();
        Task<Customer> GetCusByID(int Id);
    }
}
