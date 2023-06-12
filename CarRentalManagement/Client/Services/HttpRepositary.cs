using CarRentalManagement.Client.Contracts;
using System.Net.Http.Json;

namespace CarRentalManagement.Client.Services
{
    public class HttpRepositary<T> : IHttpRepositary<T> where T : class
    {
        private readonly HttpClient _httpClient;
        private readonly HttpInterceptorService _interceptor;
        public HttpRepositary(HttpClient httpClient, HttpInterceptorService interceptor)
        {
            _httpClient = httpClient;
            _interceptor = interceptor;
        }
        public async Task<T> Get(string url, int id)
        {
           var obj = await _httpClient.GetFromJsonAsync<T>(url);
            return obj;
        }
    }
}
