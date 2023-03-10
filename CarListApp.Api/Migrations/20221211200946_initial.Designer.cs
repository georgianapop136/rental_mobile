// <auto-generated />
using CarListApp.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarListApp.Api.Migrations
{
    [DbContext(typeof(CarListDbContext))]
    [Migration("20221211200946_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("CarListApp.Api.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Honda",
                            Model = "Fit",
                            Year = "ABC"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Honda",
                            Model = "Civic",
                            Year = "ABC2"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Honda",
                            Model = "Stream",
                            Year = "ABC1"
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Nissan",
                            Model = "Note",
                            Year = "ABC4"
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Nissan",
                            Model = "Atlas",
                            Year = "ABC5"
                        },
                        new
                        {
                            Id = 6,
                            Brand = "Nissan",
                            Model = "Dualis",
                            Year = "ABC6"
                        },
                        new
                        {
                            Id = 7,
                            Brand = "Nissan",
                            Model = "Murano",
                            Year = "ABC7"
                        },
                        new
                        {
                            Id = 8,
                            Brand = "Audi",
                            Model = "A5",
                            Year = "ABC8"
                        },
                        new
                        {
                            Id = 9,
                            Brand = "BMW",
                            Model = "M3",
                            Year = "ABC9"
                        },
                        new
                        {
                            Id = 10,
                            Brand = "Jaguar",
                            Model = "F-Pace",
                            Year = "ABC10"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
