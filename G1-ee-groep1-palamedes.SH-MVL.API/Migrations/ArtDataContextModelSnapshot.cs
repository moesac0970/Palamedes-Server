﻿// <auto-generated />
using System;
using G1_ee_groep1_palamedes.SH_MVL.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Migrations
{
    [DbContext(typeof(ArtDataContext))]
    partial class ArtDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("G1_ee_groep1_palamedes.SH_MVL.Lib.Models.Art", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.ToTable("Arts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtistId = 1,
                            Category = 0,
                            CategoryId = 1,
                            Created = new DateTime(2019, 10, 21, 21, 17, 5, 581, DateTimeKind.Local).AddTicks(4143),
                            Description = "Een schilderij van een vogel.",
                            ImageName = "devogel.jpg",
                            Name = "De Nachtegaal",
                            Price = 300m,
                            Updated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            ArtistId = 1,
                            Category = 0,
                            CategoryId = 2,
                            Created = new DateTime(2019, 10, 21, 21, 17, 5, 585, DateTimeKind.Local).AddTicks(9442),
                            Description = "Een schilderij van een Vaas.",
                            ImageName = "devaas.jpg",
                            Name = "De Vaas",
                            Price = 1m,
                            Updated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            ArtistId = 1,
                            Category = 0,
                            CategoryId = 2,
                            Created = new DateTime(2019, 10, 21, 21, 17, 5, 585, DateTimeKind.Local).AddTicks(9555),
                            Description = "Een schilderij van een Egel.",
                            ImageName = "deegel.jpg",
                            Name = "De Egel",
                            Price = 5m,
                            Updated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            ArtistId = 1,
                            Category = 0,
                            CategoryId = 2,
                            Created = new DateTime(2019, 10, 21, 21, 17, 5, 585, DateTimeKind.Local).AddTicks(9563),
                            Description = "Een schilderij van een trap.",
                            ImageName = "trap.jpg",
                            Name = "De Trap",
                            Price = 150m,
                            Updated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            ArtistId = 2,
                            Category = 0,
                            CategoryId = 0,
                            Created = new DateTime(2019, 10, 21, 21, 17, 5, 585, DateTimeKind.Local).AddTicks(9570),
                            Description = "messen",
                            ImageName = "messen.jpg",
                            Name = "Messen",
                            Price = 500m,
                            Updated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            ArtistId = 2,
                            Category = 0,
                            CategoryId = 0,
                            Created = new DateTime(2019, 10, 21, 21, 17, 5, 585, DateTimeKind.Local).AddTicks(9574),
                            Description = "steinen",
                            ImageName = "stenen.jpg",
                            Name = "Stenen",
                            Price = 500m,
                            Updated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            ArtistId = 2,
                            Category = 0,
                            CategoryId = 0,
                            Created = new DateTime(2019, 10, 21, 21, 17, 5, 585, DateTimeKind.Local).AddTicks(9578),
                            Description = "steinen",
                            ImageName = "abstract.jpg",
                            Name = "Abstract",
                            Price = 500m,
                            Updated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            ArtistId = 2,
                            Category = 0,
                            CategoryId = 0,
                            Created = new DateTime(2019, 10, 21, 21, 17, 5, 585, DateTimeKind.Local).AddTicks(9582),
                            Description = "steinen",
                            ImageName = "sloten.jpg",
                            Name = "Sloten",
                            Price = 500m,
                            Updated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            ArtistId = 2,
                            Category = 0,
                            CategoryId = 0,
                            Created = new DateTime(2019, 10, 21, 21, 17, 5, 585, DateTimeKind.Local).AddTicks(9797),
                            Description = "steinen",
                            ImageName = "boor.jpg",
                            Name = "Boor",
                            Price = 500m,
                            Updated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            ArtistId = 2,
                            Category = 0,
                            CategoryId = 0,
                            Created = new DateTime(2019, 10, 21, 21, 17, 5, 585, DateTimeKind.Local).AddTicks(9804),
                            Description = "steinen",
                            ImageName = "circle.jpg",
                            Name = "Circle",
                            Price = 500m,
                            Updated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("G1_ee_groep1_palamedes.SH_MVL.Lib.Models.Artists", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArtistName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtistName = "Pablito",
                            Dob = new DateTime(2019, 10, 21, 21, 17, 5, 587, DateTimeKind.Local).AddTicks(7943),
                            UserId = 6
                        },
                        new
                        {
                            Id = 2,
                            ArtistName = "Jenny",
                            Dob = new DateTime(2019, 10, 21, 21, 17, 5, 587, DateTimeKind.Local).AddTicks(9427),
                            UserId = 5
                        });
                });

            modelBuilder.Entity("G1_ee_groep1_palamedes.SH_MVL.Lib.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HashPasw")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TelNr")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Dob = new DateTime(1980, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "random@mailinator.com",
                            FirstName = "jos",
                            LastName = "doenikni",
                            TelNr = 48484848
                        },
                        new
                        {
                            Id = 2,
                            Dob = new DateTime(1980, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "random@mailinator.com",
                            FirstName = "carlos",
                            LastName = "taco",
                            TelNr = 48484848
                        },
                        new
                        {
                            Id = 3,
                            Dob = new DateTime(1980, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "random@mailinator.com",
                            FirstName = "donald",
                            LastName = "cunk",
                            TelNr = 48484848
                        },
                        new
                        {
                            Id = 4,
                            Dob = new DateTime(1980, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "random@mailinator.com",
                            FirstName = "Leoplod",
                            LastName = "II",
                            TelNr = 48484848
                        },
                        new
                        {
                            Id = 5,
                            Dob = new DateTime(1960, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "manu09ice@gmail.com",
                            FirstName = "Jenny",
                            LastName = "VanGimst",
                            TelNr = 491080115
                        },
                        new
                        {
                            Id = 6,
                            Dob = new DateTime(1980, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "random@mailinator.com",
                            FirstName = "Pablito",
                            LastName = "escobar",
                            TelNr = 48484848
                        });
                });

            modelBuilder.Entity("G1_ee_groep1_palamedes.SH_MVL.Lib.Models.Art", b =>
                {
                    b.HasOne("G1_ee_groep1_palamedes.SH_MVL.Lib.Models.Artists", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("G1_ee_groep1_palamedes.SH_MVL.Lib.Models.Artists", b =>
                {
                    b.HasOne("G1_ee_groep1_palamedes.SH_MVL.Lib.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
