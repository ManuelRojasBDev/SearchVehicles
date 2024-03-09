
/*
 * File: VehicleOutput.cs
 * Creatio Date: March 08, 2023
 * Created By: Ing. Manuel Rojas | marojas@pichincha.com
 *
 * Copyright (c) 2024 Browser Travel Solutions
 */

using SearchVehicles.Domain.Entities;

namespace SearchVehicles.Domain.DTO.SearchVehicles.Output
{
    public class VehicleOutput
    {
        public string VehicleDescription { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
    }
}
