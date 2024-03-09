using Microsoft.AspNetCore.Mvc;
using SearchVehicles.Domain.DTO.SearchVehicles.Input;
using SearchVehicles.Domain.Interfaces.Services;

namespace SearchVehicles.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchVehiclesController : Controller
    {
        private readonly ISearchVehiclesService _searchVehiclesService;

        public SearchVehiclesController(ISearchVehiclesService searchVehiclesService)
        {
            this._searchVehiclesService = searchVehiclesService;
        }


        [HttpGet("{IdCollection}, {IdReturn}")]
        public async Task<IActionResult> GetVehiclesByLocalities(int IdCollection, int IdReturn)
        {
            SearchVehicleInput searchInput = new()
            {
                LocalityCollectionId = IdCollection,
                LocalityReturnId = IdReturn
            };

            var searchResult =  await _searchVehiclesService.GetVehiclesByLocality(searchInput);
            if (searchResult == null) { return  NotFound(); }

            return Ok(searchResult);
        }
    }
}
