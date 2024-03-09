
/*
 * File: SearchVehicleOutput.cs
 * Creatio Date: March 08, 2023
 * Created By: Ing. Manuel Rojas | marojas@pichincha.com
 *
 * Copyright (c) 2024 Browser Travel Solutions
 */

using SearchVehicles.Domain.Entities;

namespace SearchVehicles.Domain.DTO.SearchVehicles.Output
{
    public class SearchVehicleOutput
    {
        public string? LocalityCollection { get; set; }
        public string? LocatityReturn { get; set; }
        public List<VehicleOutput> Vehicles { get; set; }
        public ErrorSearchVehicle SearchError { get; set; }

        public SearchVehicleOutput()
        {
            Vehicles = new List<VehicleOutput>();
            SearchError = new ErrorSearchVehicle();
        }
    }
}
