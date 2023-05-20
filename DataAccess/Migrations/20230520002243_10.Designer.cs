﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(SheepControlDbContext))]
    [Migration("20230520002243_10")]
    partial class _10
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Action", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            CreationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(262),
                            ModificationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(264),
                            Name = "Create"
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            CreationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(270),
                            ModificationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(271),
                            Name = "Read"
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            CreationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(273),
                            ModificationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(274),
                            Name = "Update"
                        },
                        new
                        {
                            Id = 4,
                            Active = true,
                            CreationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(275),
                            ModificationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(276),
                            Name = "Delete"
                        },
                        new
                        {
                            Id = 5,
                            Active = true,
                            CreationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(277),
                            ModificationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(278),
                            Name = "ToggleActive"
                        },
                        new
                        {
                            Id = 6,
                            Active = true,
                            CreationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(282),
                            ModificationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(283),
                            Name = "GetById"
                        },
                        new
                        {
                            Id = 7,
                            Active = true,
                            CreationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(284),
                            ModificationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(285),
                            Name = "DeleteAll"
                        });
                });

            modelBuilder.Entity("Entities.Controller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Controllers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            CreationDate = new DateTime(2023, 5, 19, 18, 22, 42, 850, DateTimeKind.Local).AddTicks(9986),
                            ModificationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(5),
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            CreationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(18),
                            ModificationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(19),
                            Name = "Controller"
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            CreationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(20),
                            ModificationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(21),
                            Name = "Permission"
                        },
                        new
                        {
                            Id = 4,
                            Active = true,
                            CreationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(23),
                            ModificationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(24),
                            Name = "User"
                        },
                        new
                        {
                            Id = 5,
                            Active = true,
                            CreationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(25),
                            ModificationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(26),
                            Name = "PermissionRole"
                        },
                        new
                        {
                            Id = 6,
                            Active = true,
                            CreationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(32),
                            ModificationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(33),
                            Name = "Role"
                        },
                        new
                        {
                            Id = 7,
                            Active = true,
                            CreationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(34),
                            ModificationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(35),
                            Name = "RoleUser"
                        },
                        new
                        {
                            Id = 8,
                            Active = true,
                            CreationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(37),
                            ModificationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(38),
                            Name = "Sheep"
                        },
                        new
                        {
                            Id = 9,
                            Active = true,
                            CreationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(39),
                            ModificationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(40),
                            Name = "Vaccine"
                        },
                        new
                        {
                            Id = 10,
                            Active = true,
                            CreationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(44),
                            ModificationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(44),
                            Name = "VaccineSheep"
                        },
                        new
                        {
                            Id = 11,
                            Active = true,
                            CreationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(46),
                            ModificationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(46),
                            Name = "SaleSheep"
                        });
                });

            modelBuilder.Entity("Entities.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActionId")
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ControllerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ActionId");

                    b.HasIndex("ControllerId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("Entities.PermissionRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("RoleId");

                    b.ToTable("PermissionsRoles");
                });

            modelBuilder.Entity("Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            CreationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(360),
                            ModificationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(361),
                            Name = "SuperAdmin"
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            CreationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(367),
                            ModificationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(368),
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            CreationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(369),
                            ModificationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(370),
                            Name = "User"
                        },
                        new
                        {
                            Id = 4,
                            Active = true,
                            CreationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(372),
                            ModificationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(373),
                            Name = "Invited"
                        },
                        new
                        {
                            Id = 5,
                            Active = true,
                            CreationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(374),
                            ModificationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(375),
                            Name = "Custom"
                        });
                });

            modelBuilder.Entity("Entities.RoleUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("RolesUsers");
                });

            modelBuilder.Entity("Entities.SaleSheep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("KiloPrice")
                        .HasColumnType("real");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("SaleProfit")
                        .HasColumnType("real");

                    b.Property<int>("SheepId")
                        .HasColumnType("int");

                    b.Property<float>("TotalCharged")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("SheepId");

                    b.ToTable("SaleSheeps");
                });

            modelBuilder.Entity("Entities.Sheep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("AcquisitionCost")
                        .HasColumnType("real");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAcquisition")
                        .HasColumnType("bit");

                    b.Property<float>("KiloPrice")
                        .HasColumnType("real");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Sold")
                        .HasColumnType("bit");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Sheeps");
                });

            modelBuilder.Entity("Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(461),
                            Email = "sa@gmail.com",
                            LastName = "sa",
                            ModificationDate = new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(463),
                            Name = "sa",
                            Password = "sa",
                            PhoneNumber = "9919596720"
                        });
                });

            modelBuilder.Entity("Entities.Vaccine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("AcquisitionCost")
                        .HasColumnType("real");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IndicatedDose")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("NetContent")
                        .HasColumnType("real");

                    b.Property<string>("Observations")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("UnitPrice")
                        .HasColumnType("real");

                    b.Property<int>("Unities")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Vaccines");
                });

            modelBuilder.Entity("Entities.VaccineSheep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ApplicationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DoseApplied")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SheepId")
                        .HasColumnType("int");

                    b.Property<int>("VaccineId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SheepId");

                    b.HasIndex("VaccineId");

                    b.ToTable("VaccinesSheeps");
                });

            modelBuilder.Entity("Entities.Permission", b =>
                {
                    b.HasOne("Entities.Action", "Action")
                        .WithMany()
                        .HasForeignKey("ActionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Controller", "Controller")
                        .WithMany()
                        .HasForeignKey("ControllerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Action");

                    b.Navigation("Controller");
                });

            modelBuilder.Entity("Entities.PermissionRole", b =>
                {
                    b.HasOne("Entities.Permission", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Entities.RoleUser", b =>
                {
                    b.HasOne("Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.SaleSheep", b =>
                {
                    b.HasOne("Entities.Sheep", "Sheep")
                        .WithMany()
                        .HasForeignKey("SheepId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sheep");
                });

            modelBuilder.Entity("Entities.VaccineSheep", b =>
                {
                    b.HasOne("Entities.Sheep", "Sheep")
                        .WithMany()
                        .HasForeignKey("SheepId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Vaccine", "Vaccine")
                        .WithMany()
                        .HasForeignKey("VaccineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sheep");

                    b.Navigation("Vaccine");
                });
#pragma warning restore 612, 618
        }
    }
}
