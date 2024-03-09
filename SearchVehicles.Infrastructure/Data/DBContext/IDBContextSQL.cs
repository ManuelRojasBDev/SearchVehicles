using Microsoft.EntityFrameworkCore;
using SearchVehicles.Domain.Entities;
using SearchVehicles.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchVehicles.Infrastructure.Data.DBContext
{
    public interface IDBContextSQL
    {
        DbSet<Category> Category { get; set; }
        DbSet<Locality> Locality { get; set; }
        DbSet<Vehicle> Vehicle { get; set; }
        DbSet<VehicleByLocality> VehiclesByLocality { get; set; }
    }
}
