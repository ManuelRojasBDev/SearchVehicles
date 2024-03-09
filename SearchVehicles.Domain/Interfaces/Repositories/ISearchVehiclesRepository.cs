using SearchVehicles.Domain.DTO.SearchVehicles.Input;
using SearchVehicles.Domain.DTO.SearchVehicles.Output;

namespace SearchVehicles.Domain.Interfaces.Repositories
{
    public interface ISearchVehiclesRepository
    {
        public Task<SearchVehicleOutput> GetVehiclesByLocality(SearchVehicleInput searchVehicleInput);
    }
}
