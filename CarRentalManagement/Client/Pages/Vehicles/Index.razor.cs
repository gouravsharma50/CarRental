using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Net.Http.Json;
using Toolbelt.Blazor;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class Index : IDisposable
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }
        [Inject] IJSRuntime Js { get; set; }
        private List<Vehicle> lst;

        protected async override Task OnInitializedAsync()
        {
            _interceptor.MonitorEvent();
            lst = await _client.GetFromJsonAsync<List<Vehicle>>($"{Endpoints.VehiclesEndpoint}");
        }
        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            await Js.InvokeVoidAsync("AddDataTable", "#vehicle-Table");
        }
        async Task Delete(int id)
        {
            var vehicle = lst.First(x => x.Id == id);
            if (await Js.InvokeAsync<bool>("confirm", $"Do you want to delete {vehicle.Vin}"))
            {
                await _client.DeleteAsync($"{Endpoints.VehiclesEndpoint}/{id}");
                await OnInitializedAsync();
            }
        }

        public void Dispose()
        {
            _interceptor.DisposeEvent();
            Js.InvokeVoidAsync("DataTablesDispose", "#vehicle-Table");
        }
    }
}
