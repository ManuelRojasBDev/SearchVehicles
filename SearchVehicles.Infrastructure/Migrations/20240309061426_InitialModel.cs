using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SearchVehicles.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    IdCategory = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.IdCategory);
                });

            migrationBuilder.CreateTable(
                name: "Localities",
                columns: table => new
                {
                    IdLocality = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocalityName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LocalityAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FreeCapacity = table.Column<int>(type: "int", nullable: false),
                    TotalCapacity = table.Column<int>(type: "int", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localities", x => x.IdLocality);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    IdVehicle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCategory = table.Column<int>(type: "int", nullable: false),
                    VehicleDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Plate = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.IdVehicle);
                    table.ForeignKey(
                        name: "FK_Vehicles_Categories_IdCategory",
                        column: x => x.IdCategory,
                        principalTable: "Categories",
                        principalColumn: "IdCategory",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehiclesByLocality",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdVehicle = table.Column<int>(type: "int", nullable: false),
                    IdCollectionLocality = table.Column<int>(type: "int", nullable: false),
                    IdReturnLocality = table.Column<int>(type: "int", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiclesByLocality", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehiclesByLocality_Localities_IdCollectionLocality",
                        column: x => x.IdCollectionLocality,
                        principalTable: "Localities",
                        principalColumn: "IdLocality",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehiclesByLocality_Localities_IdReturnLocality",
                        column: x => x.IdReturnLocality,
                        principalTable: "Localities",
                        principalColumn: "IdLocality",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VehiclesByLocality_Vehicles_IdVehicle",
                        column: x => x.IdVehicle,
                        principalTable: "Vehicles",
                        principalColumn: "IdVehicle",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_IdCategory",
                table: "Vehicles",
                column: "IdCategory");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclesByLocality_IdCollectionLocality",
                table: "VehiclesByLocality",
                column: "IdCollectionLocality");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclesByLocality_IdReturnLocality",
                table: "VehiclesByLocality",
                column: "IdReturnLocality");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclesByLocality_IdVehicle",
                table: "VehiclesByLocality",
                column: "IdVehicle");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehiclesByLocality");

            migrationBuilder.DropTable(
                name: "Localities");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
