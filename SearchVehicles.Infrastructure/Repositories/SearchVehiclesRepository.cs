using Microsoft.EntityFrameworkCore;
using SearchVehicles.Domain.DTO.SearchVehicles.Input;
using SearchVehicles.Domain.DTO.SearchVehicles.Output;
using SearchVehicles.Domain.Interfaces.Repositories;
using SearchVehicles.Infrastructure.Data.DBContext;
using static SearchVehicles.Domain.Constants;

namespace SearchVehicles.Infrastructure.Repositories
{
    public class SearchVehiclesRepository : ISearchVehiclesRepository
    {
        IDBContextSQL _dBContextSQL;

        public SearchVehiclesRepository(IDBContextSQL dBContextSQL)
        {
            this._dBContextSQL = dBContextSQL;
        }

        public async Task<SearchVehicleOutput> GetVehiclesByLocality(SearchVehicleInput searchVehicleInput)
        {
            SearchVehicleOutput searchVehicleOutput = new();

            var vehiclesList = await _dBContextSQL.VehiclesByLocality.ToListAsync();

            vehiclesList = vehiclesList.Where(x => x.IdCollectionLocality == searchVehicleInput.LocalityCollectionId &&
                                                x.IdReturnLocality == searchVehicleInput.LocalityReturnId && x.Available == true).ToList();

            var localityCollection = _dBContextSQL.Locality.Where(c => c.IdLocality == searchVehicleInput.LocalityCollectionId).First();
            var localityReturn = _dBContextSQL.Locality.Where(c => c.IdLocality == searchVehicleInput.LocalityReturnId).First();

            if (vehiclesList.Any())
            {
                List<VehicleOutput> vehiclesSearched = new List<VehicleOutput>();

                foreach (var vehicle in vehiclesList)
                {
                    var vehicleData = _dBContextSQL.Vehicle.Where(y => y.IdVehicle == vehicle.IdVehicle).First();
                    var category = _dBContextSQL.Category.Where(y => y.IdCategory == vehicleData.IdCategory).First();

                    VehicleOutput vehicleResult = new()
                    {
                        VehicleDescription = vehicleData.VehicleDescription,
                        Model = vehicleData.Model,
                        CategoryName = category.CategoryName
                    };

                    vehiclesSearched.Add(vehicleResult);
                }

                searchVehicleOutput.LocalityCollection = localityCollection.LocalityName;
                searchVehicleOutput.LocatityReturn = localityReturn.LocalityName;
                searchVehicleOutput.Vehicles = vehiclesSearched;
            }
            else
            {
                ErrorSearchVehicle errorSearchVehicle = new()
                {
                    ErrorMessage = MESSAGE_VEHICLES_NOT_FOUND,
                    ErrorCode = ERROR_CODE_VEHICLES_NOT_FOUND,
                    Resource = RESOURCE_GET_VEHICLE_BY_LOCALITY
                };

                searchVehicleOutput.SearchError = errorSearchVehicle;
            }

            return searchVehicleOutput;
        }
    }
}
