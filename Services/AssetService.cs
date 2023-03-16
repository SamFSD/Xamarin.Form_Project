using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using IoTAssetManagement.Models;
using Newtonsoft.Json;

namespace IoTAssetManagement.Services
{
    public class AssetService : IAssetService
    {
        private readonly HttpClient _httpClient;

        public AssetService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://myiotplatform.com/");
        }

        public async Task<List<Car>> GetCarsAsync()
        {
            var response = await _httpClient.GetAsync("api/cars");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var cars = JsonConvert.DeserializeObject<List<Car>>(json);
                return cars;
            }

            return new List<Car>();
        }

        public async Task<List<Truck>> GetTrucksAsync()
        {
            var response = await _httpClient.GetAsync("api/trucks");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var trucks = JsonConvert.DeserializeObject<List<Truck>>(json);
                return trucks;
            }

            return new List<Truck>();
        }

        public async Task<List<Generator>> GetGeneratorsAsync()
        {
            var response = await _httpClient.GetAsync("api/generators");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var generators = JsonConvert.DeserializeObject<List<Generator>>(json);
                return generators;
            }

            return new List<Generator>();
        }

        public async Task<List<Fridge>> GetFridgesAsync()
        {
            var response = await _httpClient.GetAsync("api/fridges");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var fridges = JsonConvert.DeserializeObject<List<Fridge>>(json);
                return fridges;
            }

            return new List<Fridge>();
        }
    }
}
