
/*
 * File: Locality.cs
 * Creatio Date: March 07, 2023
 * Created By: Ing. Manuel Rojas | marojas@pichincha.com
 *
 * Copyright (c) 2024 Browser Travel Solutions
 */

using System.Collections.ObjectModel;

namespace SearchVehicles.Domain.Entities
{
    public class Locality
    {
        public int IdLocality { get; set; }
        public string LocalityName { get; set; } = string.Empty;
        public string LocalityAddress { get; set; } = string.Empty;
        public int FreeCapacity { get; set; }
        public int TotalCapacity { get; set; }
        public bool Available { get; set; }
        public ICollection<VehicleByLocality> VehiclesByLocalityCollection { get; set; }
        public ICollection<VehicleByLocality> VehiclesByLocalityReturn { get; set; }

        public Locality()
        {
            VehiclesByLocalityCollection = new Collection<VehicleByLocality>();
            VehiclesByLocalityReturn = new Collection<VehicleByLocality>();
        }
    }
}