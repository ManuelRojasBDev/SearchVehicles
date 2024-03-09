﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SearchVehicles.Infrastructure.Data.DBContext;

#nullable disable

namespace SearchVehicles.Infrastructure.Migrations
{
    [DbContext(typeof(DBContextSQL))]
    partial class DBContextSQLModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SearchVehicles.Domain.Entities.Category", b =>
                {
                    b.Property<int>("IdCategory")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCategory"));

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("IdCategory");

                    b.ToTable("Categories", (string)null);
                });

            modelBuilder.Entity("SearchVehicles.Domain.Entities.Locality", b =>
                {
                    b.Property<int>("IdLocality")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLocality"));

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<int>("FreeCapacity")
                        .HasColumnType("int");

                    b.Property<string>("LocalityAddress")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LocalityName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("TotalCapacity")
                        .HasColumnType("int");

                    b.HasKey("IdLocality");

                    b.ToTable("Localities", (string)null);
                });

            modelBuilder.Entity("SearchVehicles.Domain.Entities.Vehicle", b =>
                {
                    b.Property<int>("IdVehicle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVehicle"));

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<int>("IdCategory")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Plate")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("VehicleDescription")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("IdVehicle");

                    b.HasIndex("IdCategory");

                    b.ToTable("Vehicles", (string)null);
                });

            modelBuilder.Entity("SearchVehicles.Domain.Entities.VehicleByLocality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<int>("IdCollectionLocality")
                        .HasColumnType("int");

                    b.Property<int>("IdReturnLocality")
                        .HasColumnType("int");

                    b.Property<int>("IdVehicle")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCollectionLocality");

                    b.HasIndex("IdReturnLocality");

                    b.HasIndex("IdVehicle");

                    b.ToTable("VehiclesByLocality", (string)null);
                });

            modelBuilder.Entity("SearchVehicles.Domain.Entities.Vehicle", b =>
                {
                    b.HasOne("SearchVehicles.Domain.Entities.Category", "Category")
                        .WithMany("Vehicles")
                        .HasForeignKey("IdCategory")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("SearchVehicles.Domain.Entities.VehicleByLocality", b =>
                {
                    b.HasOne("SearchVehicles.Domain.Entities.Locality", "LocalityCollection")
                        .WithMany("VehiclesByLocalityCollection")
                        .HasForeignKey("IdCollectionLocality")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SearchVehicles.Domain.Entities.Locality", "LocalityReturn")
                        .WithMany("VehiclesByLocalityReturn")
                        .HasForeignKey("IdReturnLocality")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SearchVehicles.Domain.Entities.Vehicle", "Vehicle")
                        .WithMany("VehiclesByLocality")
                        .HasForeignKey("IdVehicle")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LocalityCollection");

                    b.Navigation("LocalityReturn");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("SearchVehicles.Domain.Entities.Category", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("SearchVehicles.Domain.Entities.Locality", b =>
                {
                    b.Navigation("VehiclesByLocalityCollection");

                    b.Navigation("VehiclesByLocalityReturn");
                });

            modelBuilder.Entity("SearchVehicles.Domain.Entities.Vehicle", b =>
                {
                    b.Navigation("VehiclesByLocality");
                });
#pragma warning restore 612, 618
        }
    }
}
