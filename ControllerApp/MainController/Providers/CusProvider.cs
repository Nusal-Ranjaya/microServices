using MainController.Models;
using System.Text.Json;

namespace MainController.Providers
{
    public class CusProvider : ICustomerProvider
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public CusProvider(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IEnumerable<Customer>> GetAllCus()
        {
            using var client = _httpClientFactory.CreateClient("customer");
            var response = await client.GetAsync("/api/customer");
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var customers = JsonSerializer.Deserialize<IEnumerable<Customer>>(jsonString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return customers ?? new List<Customer>();
            }
            else
            {
                // Handle HTTP response errors (e.g., log them, throw exception, or return an empty list)
                return new List<Customer>();
            }
        }

            public Task<Customer> GetCusByID(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
