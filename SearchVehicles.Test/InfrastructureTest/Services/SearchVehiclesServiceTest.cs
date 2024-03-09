using Moq;
using SearchVehicles.Application.SearchVehicles;
using SearchVehicles.Domain.DTO.SearchVehicles.Input;
using SearchVehicles.Domain.DTO.SearchVehicles.Output;
using SearchVehicles.Domain.Interfaces.Repositories;

namespace SearchVehicles.Test.InfrastructureTest.Services
{
    public class SearchVehiclesServiceTest
    {
        SearchVehicleInput searchVehicleInput;
        SearchVehicleOutput searchVehicleOutput;
        VehicleOutput vehicleOutput;
        ErrorSearchVehicle errorSearchVehicle;
        Mock<ISearchVehiclesRepository> mockSearchVehiclesRepository;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            searchVehicleInput = new SearchVehicleInput();
            searchVehicleOutput = new SearchVehicleOutput();
            vehicleOutput = new VehicleOutput();
            errorSearchVehicle = new ErrorSearchVehicle();
            mockSearchVehiclesRepository = new Mock<ISearchVehiclesRepository>();
        }

        //POSITIVE
        [Test]
        public void SearchVehiclesService_InputOk_ReturnVehicleListOk()
        {      
            //Arrange
            SearchVehicleOutput resultObj = new();

            mockSearchVehiclesRepository.Setup(r => r.GetVehiclesByLocality(It.IsAny<SearchVehicleInput>()))
               .Returns(Task.FromResult(resultObj));

            SearchVehiclesService searchVehiclesService = new(mockSearchVehiclesRepository.Object);

            //Act
            var result = searchVehiclesService.GetVehiclesByLocality(searchVehicleInput).GetAwaiter().GetResult();

            //Assert
            Assert.IsNotNull(result);
        }

        //NEGATIVE
        [Test]
        public void SearchVehiclesService_ErrorInput_ReturnErrorCode()
        {
            //Arrange
            searchVehicleInput = new()
            {
                LocalityCollectionId = 0,
                LocalityReturnId = 0
            };

            SearchVehiclesService searchVehiclesService = new(mockSearchVehiclesRepository.Object);

            //Act
            var result = searchVehiclesService.GetVehiclesByLocality(searchVehicleInput).GetAwaiter().GetResult();

            //Assert
            Assert.That(result.SearchError.ErrorCode, Is.EqualTo("999"));
        }
    }
}
