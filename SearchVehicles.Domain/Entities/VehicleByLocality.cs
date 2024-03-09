
/*
 * File: VehiclesByLocality.cs
 * Creatio Date: March 07, 2023
 * Created By: Ing. Manuel Rojas | marojas@pichincha.com
 *
 * Copyright (c) 2024 Browser Travel Solutions
 */

namespace SearchVehicles.Domain.Entities
{
    public class VehicleByLocality
    {
        public int Id { get; set; }
        public int IdVehicle { get; set; }
        public int IdCollectionLocality { get; set; }
        public int IdReturnLocality { get; set; }
        public bool Available { get; set; }
        public Vehicle? Vehicle { get; set; }
        public Locality? LocalityCollection { get; set; }
        public Locality? LocalityReturn { get; set; }

        public VehicleByLocality()
        {
            Vehicle = new();
            LocalityCollection = new();
            LocalityReturn = new();
        }
    }
}