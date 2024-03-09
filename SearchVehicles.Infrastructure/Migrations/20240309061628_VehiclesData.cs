using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SearchVehicles.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class VehiclesData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
              .Sql("INSERT INTO Vehicles(IdCategory, VehicleDescription, Plate, Model, Available) " +
                   "VALUES(2, 'Chevrolet SparkGt', 'FGS425', '2015', 1);");
            migrationBuilder
              .Sql("INSERT INTO Vehicles(IdCategory, VehicleDescription, Plate, Model, Available) " +
                   "VALUES(1, 'Mazda 3 Touring', 'IJV225', '2020', 1);");
            migrationBuilder
              .Sql("INSERT INTO Vehicles(IdCategory, VehicleDescription, Plate, Model, Available) " +
                   "VALUES(3, 'Ford Escape', 'BCD723', '2018', 1);");
            migrationBuilder
              .Sql("INSERT INTO Vehicles(IdCategory, VehicleDescription, Plate, Model, Available) " +
                   "VALUES(3, 'Renault Duster', 'CVM489', '2015', 1);");
            migrationBuilder
              .Sql("INSERT INTO Vehicles(IdCategory, VehicleDescription, Plate, Model, Available) " +
                   "VALUES(3, 'Toyota Daris', 'JIE5874', '2018', 1);");
            migrationBuilder
              .Sql("INSERT INTO Vehicles(IdCategory, VehicleDescription, Plate, Model, Available) " +
                   "VALUES(1, 'BMW Serie 5', 'ASE147', '2020', 1);");
            migrationBuilder
              .Sql("INSERT INTO Vehicles(IdCategory, VehicleDescription, Plate, Model, Available) " +
                   "VALUES(2, 'Volkswagen Jetta', 'VCX785', '2012', 1);");
            migrationBuilder
              .Sql("INSERT INTO Vehicles(IdCategory, VehicleDescription, Plate, Model, Available) " +
                   "VALUES(1, 'Chevrolet Sail', 'MHS375', '2015', 1);");
            migrationBuilder
              .Sql("INSERT INTO Vehicles(IdCategory, VehicleDescription, Plate, Model, Available) " +
                   "VALUES(3, 'Ford Ranger', 'HGB024', '2015', 1);");
            migrationBuilder
              .Sql("INSERT INTO Vehicles(IdCategory, VehicleDescription, Plate, Model, Available) " +
                   "VALUES(2, 'Kia Picanto', 'JGK247', '2012', 1);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
