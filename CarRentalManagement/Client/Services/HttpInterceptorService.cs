using Microsoft.AspNetCore.Components;
using System.Net;
using Toolbelt.Blazor;

namespace CarRentalManagement.Client.Services
{
    public class HttpInterceptorService
    {
        private readonly HttpClientInterceptor _interceptor;
        private readonly NavigationManager _navigationManager;
        public HttpInterceptorService(HttpClientInterceptor interceptor, NavigationManager navManager)
        {
            _interceptor = interceptor;
            _navigationManager = navManager;
        }
        public void MonitorEvent() => _interceptor.AfterSend += InterceptorResponse;
        private void InterceptorResponse(object? sender, HttpClientInterceptorEventArgs e)
        {
            string message = string.Empty;
            if (!e.Response.IsSuccessStatusCode)
            {
                var resposneCode = e.Response.StatusCode;
                switch (resposneCode)
                {
                    case HttpStatusCode.NotFound:
                        _navigationManager.NavigateTo("/404");
                        message = "The requested resource was not found";
                        break;
                    case HttpStatusCode.Unauthorized:
                        _navigationManager.NavigateTo("/unauthorized");
                        message = "The requested resource was not found";
                        break;
                    default:
                        break;
                }
                throw new Exception(message);
            }
        }

        public void DisposeEvent() => _interceptor.AfterSend -= InterceptorResponse;
    }
}
