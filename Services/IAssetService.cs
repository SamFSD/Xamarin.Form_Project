using System.Collections.Generic;
using System.Threading.Tasks;
using IoTAssetManagement.Models;

namespace IoTAssetManagement.Services
{
    public interface IAssetService
    {
        Task<List<Car>> GetCarsAsync();
        Task<List<Truck>> GetTrucksAsync();
        Task<List<Generator>> GetGeneratorsAsync();
        Task<List<Fridge>> GetFridgesAsync();
    }
}
