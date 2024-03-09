using SearchVehicles.Domain.DTO.SearchVehicles.Input;
using SearchVehicles.Domain.DTO.SearchVehicles.Output;

namespace SearchVehicles.Domain.Interfaces.Services
{
    public interface ISearchVehiclesService
    {
        Task<SearchVehicleOutput> GetVehiclesByLocality(SearchVehicleInput searchVehicleInput);
    }
}
