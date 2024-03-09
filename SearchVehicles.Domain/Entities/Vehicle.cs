
/*
 * File: Vehicle.cs
 * Creatio Date: March 07, 2023
 * Created By: Ing. Manuel Rojas | marojas@pichincha.com
 *
 * Copyright (c) 2024 Browser Travel Solutions
 */

using System.Collections.ObjectModel;

namespace SearchVehicles.Domain.Entities
{
    public class Vehicle
    {
        public int IdVehicle { get; set; }
        public int IdCategory { get; set; }
        public string VehicleDescription { get; set; } = string.Empty;
        public string Plate { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public bool Available { get; set; }
        public Category? Category { get; set; }
        public ICollection<VehicleByLocality> VehiclesByLocality { get; set; }

        public Vehicle()
        {
            Category = new Category();
            VehiclesByLocality = new Collection<VehicleByLocality>();
        }
    }
}