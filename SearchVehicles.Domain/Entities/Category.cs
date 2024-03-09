
/*
 * File: Category.cs
 * Creatio Date: March 07, 2023
 * Created By: Ing. Manuel Rojas | marojas@pichincha.com
 *
 * Copyright (c) 2024 Browser Travel Solutions
 */

using System.Collections.ObjectModel;

namespace SearchVehicles.Domain.Entities
{
    public class Category
    {
        public int IdCategory { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public bool Available { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }

        public Category()
        {
            Vehicles = new Collection<Vehicle>();
        }
    }
}