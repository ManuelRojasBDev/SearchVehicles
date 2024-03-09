using SearchVehicles.Application.Validations;
using SearchVehicles.Domain.DTO.SearchVehicles.Input;
using SearchVehicles.Domain.DTO.SearchVehicles.Output;
using SearchVehicles.Domain.Interfaces.Repositories;
using SearchVehicles.Domain.Interfaces.Services;
using static SearchVehicles.Domain.Constants;

namespace SearchVehicles.Application.SearchVehicles
{
    public class SearchVehiclesService : ISearchVehiclesService
    {
        private readonly ISearchVehiclesRepository _searchVehiclesRepository;

        public SearchVehiclesService(ISearchVehiclesRepository searchVehiclesRepository)
        {
            this._searchVehiclesRepository = searchVehiclesRepository;
        }

        public async Task<SearchVehicleOutput> GetVehiclesByLocality(SearchVehicleInput searchVehicleInput)
        {
            SearchVehicleValidator searchValidator = new();
            var validationResult = await searchValidator.ValidateAsync(searchVehicleInput);

            if (!validationResult.IsValid) 
            { 
                var error = validationResult.Errors.First();

                return new SearchVehicleOutput
                {
                    SearchError = new() 
                    {
                        Resource = RESOURCE_GET_VEHICLE_BY_LOCALITY,
                        ErrorCode = string.IsNullOrEmpty(error.ErrorCode) ? error.ErrorCode : APPLICATION_ERROR_CODE,
                        ErrorMessage = error.ErrorMessage
                    }                  
                };
            }

            var result = await _searchVehiclesRepository.GetVehiclesByLocality(searchVehicleInput);

            return result;
        }
    }
}
