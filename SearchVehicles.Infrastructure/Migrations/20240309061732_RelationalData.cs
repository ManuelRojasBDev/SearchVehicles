using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SearchVehicles.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RelationalData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
              .Sql("INSERT INTO VehiclesByLocality(IdVehicle, IdCollectionLocality, IdReturnLocality, Available) " +
                   "VALUES(1, 1, 2, 1);");
            migrationBuilder
              .Sql("INSERT INTO VehiclesByLocality(IdVehicle, IdCollectionLocality, IdReturnLocality, Available) " +
                   "VALUES(2, 4, 1, 1);");
            migrationBuilder
              .Sql("INSERT INTO VehiclesByLocality(IdVehicle, IdCollectionLocality, IdReturnLocality, Available) " +
                   "VALUES(3, 2, 4, 1);");
            migrationBuilder
              .Sql("INSERT INTO VehiclesByLocality(IdVehicle, IdCollectionLocality, IdReturnLocality, Available) " +
                   "VALUES(4, 1, 2, 1);");
            migrationBuilder
              .Sql("INSERT INTO VehiclesByLocality(IdVehicle, IdCollectionLocality, IdReturnLocality, Available) " +
                   "VALUES(5, 1, 2, 1);");
            migrationBuilder
              .Sql("INSERT INTO VehiclesByLocality(IdVehicle, IdCollectionLocality, IdReturnLocality, Available) " +
                   "VALUES(6, 4, 1, 1);");
            migrationBuilder
              .Sql("INSERT INTO VehiclesByLocality(IdVehicle, IdCollectionLocality, IdReturnLocality, Available) " +
                   "VALUES(7, 2, 3, 1);");
            migrationBuilder
              .Sql("INSERT INTO VehiclesByLocality(IdVehicle, IdCollectionLocality, IdReturnLocality, Available) " +
                   "VALUES(8, 3, 3, 1);");
            migrationBuilder
              .Sql("INSERT INTO VehiclesByLocality(IdVehicle, IdCollectionLocality, IdReturnLocality, Available) " +
                   "VALUES(9, 3, 3, 1);");
            migrationBuilder
              .Sql("INSERT INTO VehiclesByLocality(IdVehicle, IdCollectionLocality, IdReturnLocality, Available) " +
                   "VALUES(10, 1, 4, 1);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
