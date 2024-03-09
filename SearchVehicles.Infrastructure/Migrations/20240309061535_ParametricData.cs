using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SearchVehicles.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ParametricData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
               .Sql("INSERT INTO Categories(CategoryName, Available) VALUES('Sedan', 1);");
            migrationBuilder
               .Sql("INSERT INTO Categories(CategoryName, Available) VALUES('Coupe', 1);");
            migrationBuilder
               .Sql("INSERT INTO Categories(CategoryName, Available) VALUES('Truck', 1);");

            migrationBuilder
               .Sql("INSERT INTO Localities(LocalityName, LocalityAddress, FreeCapacity, TotalCapacity, Available) " +
                    "VALUES('Suba', 'Cr 110 # 85-19', 30, 50, 1);");
            migrationBuilder
               .Sql("INSERT INTO Localities(LocalityName, LocalityAddress, FreeCapacity, TotalCapacity, Available) " +
                    "VALUES('Chapinero', 'Cr 13 # 67-32', 20, 40, 1);");
            migrationBuilder
               .Sql("INSERT INTO Localities(LocalityName, LocalityAddress, FreeCapacity, TotalCapacity, Available) " +
                    "VALUES('Usaquen', 'Calle 127 # 9-12', 10, 30, 1);");
            migrationBuilder
               .Sql("INSERT INTO Localities(LocalityName, LocalityAddress, FreeCapacity, TotalCapacity, Available) " +
                    "VALUES('Fontibon', 'Cr 99 # 20-86', 25, 50, 1);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
