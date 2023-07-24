using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class _001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Controllers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Controllers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sheeps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sold = table.Column<bool>(type: "bit", nullable: false),
                    IsAcquisition = table.Column<bool>(type: "bit", nullable: false),
                    KiloPrice = table.Column<float>(type: "real", nullable: false),
                    AcquisitionCost = table.Column<float>(type: "real", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sheeps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vaccines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observations = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndicatedDose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Clave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ControllerId = table.Column<int>(type: "int", nullable: false),
                    ActionId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permissions_Actions_ActionId",
                        column: x => x.ActionId,
                        principalTable: "Actions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Permissions_Controllers_ControllerId",
                        column: x => x.ControllerId,
                        principalTable: "Controllers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleSheeps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SheepId = table.Column<int>(type: "int", nullable: false),
                    KiloPrice = table.Column<float>(type: "real", nullable: false),
                    TotalCharged = table.Column<float>(type: "real", nullable: false),
                    SaleProfit = table.Column<float>(type: "real", nullable: false),
                    SaleDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleSheeps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleSheeps_Sheeps_SheepId",
                        column: x => x.SheepId,
                        principalTable: "Sheeps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SheepHistoricWeights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SheepId = table.Column<int>(type: "int", nullable: false),
                    PreviousWeight = table.Column<float>(type: "real", nullable: false),
                    NewWeight = table.Column<float>(type: "real", nullable: false),
                    DifferenceWithPreviousWeight = table.Column<float>(type: "real", nullable: false),
                    WeighingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SheepHistoricWeights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SheepHistoricWeights_Sheeps_SheepId",
                        column: x => x.SheepId,
                        principalTable: "Sheeps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RolesUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolesUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolesUsers_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolesUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VaccinesSheeps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VaccineId = table.Column<int>(type: "int", nullable: false),
                    SheepId = table.Column<int>(type: "int", nullable: false),
                    WeightVaccinationDay = table.Column<float>(type: "real", nullable: false),
                    ApplicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DoseApplied = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccinesSheeps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VaccinesSheeps_Sheeps_SheepId",
                        column: x => x.SheepId,
                        principalTable: "Sheeps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VaccinesSheeps_Vaccines_VaccineId",
                        column: x => x.VaccineId,
                        principalTable: "Vaccines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VaccinesStock",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcquisitionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VaccineId = table.Column<int>(type: "int", nullable: false),
                    NetContent = table.Column<float>(type: "real", nullable: false),
                    Unities = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<float>(type: "real", nullable: false),
                    AcquisitionCost = table.Column<float>(type: "real", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccinesStock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VaccinesStock_Vaccines_VaccineId",
                        column: x => x.VaccineId,
                        principalTable: "Vaccines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PermissionsRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermissionId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionsRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PermissionsRoles_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PermissionsRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actions",
                columns: new[] { "Id", "Active", "CreationDate", "ModificationDate", "Name" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4018), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4019), "Create" },
                    { 2, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4024), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4024), "Read" },
                    { 3, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4025), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4026), "Update" },
                    { 4, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4027), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4027), "Delete" },
                    { 5, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4028), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4029), "ToggleActive" },
                    { 6, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4031), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4031), "GetById" },
                    { 7, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4032), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4033), "DeleteAll" },
                    { 8, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4033), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4034), "GetWithFilters" },
                    { 9, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4035), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4035), "GetSheepWithFinalWeight" }
                });

            migrationBuilder.InsertData(
                table: "Controllers",
                columns: new[] { "Id", "Active", "CreationDate", "ModificationDate", "Name" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3802), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3815), "Action" },
                    { 2, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3822), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3823), "Controller" },
                    { 3, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3824), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3824), "Permission" },
                    { 4, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3825), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3826), "User" },
                    { 5, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3827), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3828), "PermissionRole" },
                    { 6, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3833), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3834), "Role" },
                    { 7, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3834), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3835), "RoleUser" },
                    { 8, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3836), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3836), "Sheep" },
                    { 9, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3837), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3837), "Vaccine" },
                    { 10, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3840), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3840), "VaccineStock" },
                    { 11, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3841), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3841), "VaccineSheep" },
                    { 12, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3842), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3843), "SaleSheep" },
                    { 13, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3844), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3844), "SheepHistoricWeight" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Active", "CreationDate", "ModificationDate", "Name" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4753), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4755), "SuperAdmin" },
                    { 2, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4760), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4761), "Admin" },
                    { 3, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4762), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4762), "User" },
                    { 4, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4763), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4764), "Invited" },
                    { 5, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4764), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4765), "Custom" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "BirthDate", "CreationDate", "Email", "LastName", "ModificationDate", "Name", "Password", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2812), "sa@gmail.com", "sa", new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2813), "sa", "sa", "9919596720" },
                    { 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2834), "admin@gmail.com", "admin", new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2835), "admin", "admin", "9919596720" },
                    { 3, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2844), "alvaroku123@gmail.com", "Kú", new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2845), "Alvaro", "12345", "9919596720" },
                    { 4, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2853), "invitado@gmail.com", "Invitado", new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2854), "Invitado", "12345", "9919596720" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "ActionId", "Active", "Clave", "ControllerId", "CreationDate", "Description", "ModificationDate" },
                values: new object[,]
                {
                    { 1, 1, true, "Action_Create", 1, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4084), "Permiso para el módulo Action y la acción Create", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4084) },
                    { 2, 2, true, "Action_Read", 1, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4098), "Permiso para el módulo Action y la acción Read", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4098) },
                    { 3, 3, true, "Action_Update", 1, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4100), "Permiso para el módulo Action y la acción Update", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4101) },
                    { 4, 4, true, "Action_Delete", 1, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4146), "Permiso para el módulo Action y la acción Delete", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4146) },
                    { 5, 5, true, "Action_ToggleActive", 1, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4149), "Permiso para el módulo Action y la acción ToggleActive", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4149) },
                    { 6, 6, true, "Action_GetById", 1, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4153), "Permiso para el módulo Action y la acción GetById", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4154) },
                    { 7, 7, true, "Action_DeleteAll", 1, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4156), "Permiso para el módulo Action y la acción DeleteAll", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4157) },
                    { 8, 8, true, "Action_GetWithFilters", 1, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4159), "Permiso para el módulo Action y la acción GetWithFilters", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4160) },
                    { 9, 1, true, "Controller_Create", 2, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4163), "Permiso para el módulo Controller y la acción Create", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4164) },
                    { 10, 2, true, "Controller_Read", 2, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4168), "Permiso para el módulo Controller y la acción Read", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4168) },
                    { 11, 3, true, "Controller_Update", 2, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4171), "Permiso para el módulo Controller y la acción Update", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4171) },
                    { 12, 4, true, "Controller_Delete", 2, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4173), "Permiso para el módulo Controller y la acción Delete", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4174) },
                    { 13, 5, true, "Controller_ToggleActive", 2, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4176), "Permiso para el módulo Controller y la acción ToggleActive", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4177) },
                    { 14, 6, true, "Controller_GetById", 2, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4179), "Permiso para el módulo Controller y la acción GetById", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4180) },
                    { 15, 7, true, "Controller_DeleteAll", 2, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4182), "Permiso para el módulo Controller y la acción DeleteAll", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4182) },
                    { 16, 8, true, "Controller_GetWithFilters", 2, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4185), "Permiso para el módulo Controller y la acción GetWithFilters", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4185) },
                    { 17, 1, true, "Permission_Create", 3, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4188), "Permiso para el módulo Permission y la acción Create", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4188) },
                    { 18, 2, true, "Permission_Read", 3, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4192), "Permiso para el módulo Permission y la acción Read", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4192) },
                    { 19, 3, true, "Permission_Update", 3, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4195), "Permiso para el módulo Permission y la acción Update", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4195) },
                    { 20, 4, true, "Permission_Delete", 3, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4198), "Permiso para el módulo Permission y la acción Delete", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4198) },
                    { 21, 5, true, "Permission_ToggleActive", 3, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4200), "Permiso para el módulo Permission y la acción ToggleActive", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4201) },
                    { 22, 6, true, "Permission_GetById", 3, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4203), "Permiso para el módulo Permission y la acción GetById", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4204) },
                    { 23, 7, true, "Permission_DeleteAll", 3, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4206), "Permiso para el módulo Permission y la acción DeleteAll", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4207) },
                    { 24, 8, true, "Permission_GetWithFilters", 3, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4209), "Permiso para el módulo Permission y la acción GetWithFilters", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4209) },
                    { 25, 1, true, "User_Create", 4, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4213), "Permiso para el módulo User y la acción Create", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4213) },
                    { 26, 2, true, "User_Read", 4, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4215), "Permiso para el módulo User y la acción Read", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4216) },
                    { 27, 3, true, "User_Update", 4, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4218), "Permiso para el módulo User y la acción Update", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4219) },
                    { 28, 4, true, "User_Delete", 4, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4221), "Permiso para el módulo User y la acción Delete", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4221) },
                    { 29, 5, true, "User_ToggleActive", 4, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4224), "Permiso para el módulo User y la acción ToggleActive", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4224) },
                    { 30, 6, true, "User_GetById", 4, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4226), "Permiso para el módulo User y la acción GetById", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4227) },
                    { 31, 7, true, "User_DeleteAll", 4, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4229), "Permiso para el módulo User y la acción DeleteAll", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4230) },
                    { 32, 8, true, "User_GetWithFilters", 4, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4282), "Permiso para el módulo User y la acción GetWithFilters", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4283) },
                    { 33, 1, true, "PermissionRole_Create", 5, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4287), "Permiso para el módulo PermissionRole y la acción Create", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4287) },
                    { 34, 2, true, "PermissionRole_Read", 5, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4291), "Permiso para el módulo PermissionRole y la acción Read", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4292) },
                    { 35, 3, true, "PermissionRole_Update", 5, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4294), "Permiso para el módulo PermissionRole y la acción Update", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4294) },
                    { 36, 4, true, "PermissionRole_Delete", 5, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4297), "Permiso para el módulo PermissionRole y la acción Delete", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4297) },
                    { 37, 5, true, "PermissionRole_ToggleActive", 5, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4299), "Permiso para el módulo PermissionRole y la acción ToggleActive", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4300) },
                    { 38, 6, true, "PermissionRole_GetById", 5, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4302), "Permiso para el módulo PermissionRole y la acción GetById", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4303) },
                    { 39, 7, true, "PermissionRole_DeleteAll", 5, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4305), "Permiso para el módulo PermissionRole y la acción DeleteAll", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4305) },
                    { 40, 8, true, "PermissionRole_GetWithFilters", 5, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4308), "Permiso para el módulo PermissionRole y la acción GetWithFilters", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4308) },
                    { 41, 1, true, "Role_Create", 6, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4311), "Permiso para el módulo Role y la acción Create", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4311) },
                    { 42, 2, true, "Role_Read", 6, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4314), "Permiso para el módulo Role y la acción Read", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4314) },
                    { 43, 3, true, "Role_Update", 6, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4316), "Permiso para el módulo Role y la acción Update", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4317) },
                    { 44, 4, true, "Role_Delete", 6, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4319), "Permiso para el módulo Role y la acción Delete", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4320) },
                    { 45, 5, true, "Role_ToggleActive", 6, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4322), "Permiso para el módulo Role y la acción ToggleActive", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4322) },
                    { 46, 6, true, "Role_GetById", 6, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4325), "Permiso para el módulo Role y la acción GetById", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4325) },
                    { 47, 7, true, "Role_DeleteAll", 6, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4327), "Permiso para el módulo Role y la acción DeleteAll", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4328) },
                    { 48, 8, true, "Role_GetWithFilters", 6, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4330), "Permiso para el módulo Role y la acción GetWithFilters", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4331) },
                    { 49, 1, true, "RoleUser_Create", 7, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4333), "Permiso para el módulo RoleUser y la acción Create", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4334) },
                    { 50, 2, true, "RoleUser_Read", 7, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4336), "Permiso para el módulo RoleUser y la acción Read", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4337) },
                    { 51, 3, true, "RoleUser_Update", 7, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4339), "Permiso para el módulo RoleUser y la acción Update", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4339) },
                    { 52, 4, true, "RoleUser_Delete", 7, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4341), "Permiso para el módulo RoleUser y la acción Delete", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4342) },
                    { 53, 5, true, "RoleUser_ToggleActive", 7, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4344), "Permiso para el módulo RoleUser y la acción ToggleActive", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4344) },
                    { 54, 6, true, "RoleUser_GetById", 7, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4347), "Permiso para el módulo RoleUser y la acción GetById", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4347) },
                    { 55, 7, true, "RoleUser_DeleteAll", 7, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4349), "Permiso para el módulo RoleUser y la acción DeleteAll", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4350) },
                    { 56, 8, true, "RoleUser_GetWithFilters", 7, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4352), "Permiso para el módulo RoleUser y la acción GetWithFilters", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4352) },
                    { 57, 1, true, "Sheep_Create", 8, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4355), "Permiso para el módulo Sheep y la acción Create", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4356) },
                    { 58, 2, true, "Sheep_Read", 8, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4358), "Permiso para el módulo Sheep y la acción Read", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4358) },
                    { 59, 3, true, "Sheep_Update", 8, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4360), "Permiso para el módulo Sheep y la acción Update", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4360) },
                    { 60, 4, true, "Sheep_Delete", 8, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4362), "Permiso para el módulo Sheep y la acción Delete", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4362) },
                    { 61, 5, true, "Sheep_ToggleActive", 8, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4400), "Permiso para el módulo Sheep y la acción ToggleActive", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4401) },
                    { 62, 6, true, "Sheep_GetById", 8, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4404), "Permiso para el módulo Sheep y la acción GetById", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4404) },
                    { 63, 7, true, "Sheep_DeleteAll", 8, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4407), "Permiso para el módulo Sheep y la acción DeleteAll", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4407) },
                    { 64, 8, true, "Sheep_GetWithFilters", 8, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4409), "Permiso para el módulo Sheep y la acción GetWithFilters", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4410) },
                    { 65, 9, true, "Sheep_GetSheepWithFinalWeight", 8, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4413), "Permiso para el módulo Sheep y la acción GetSheepWithFinalWeight", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4414) },
                    { 66, 1, true, "Vaccine_Create", 9, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4453), "Permiso para el módulo Vaccine y la acción Create", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4453) },
                    { 67, 2, true, "Vaccine_Read", 9, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4456), "Permiso para el módulo Vaccine y la acción Read", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4456) },
                    { 68, 3, true, "Vaccine_Update", 9, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4467), "Permiso para el módulo Vaccine y la acción Update", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4468) },
                    { 69, 4, true, "Vaccine_Delete", 9, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4469), "Permiso para el módulo Vaccine y la acción Delete", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4470) },
                    { 70, 5, true, "Vaccine_ToggleActive", 9, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4472), "Permiso para el módulo Vaccine y la acción ToggleActive", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4472) },
                    { 71, 6, true, "Vaccine_GetById", 9, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4474), "Permiso para el módulo Vaccine y la acción GetById", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4474) },
                    { 72, 7, true, "Vaccine_DeleteAll", 9, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4476), "Permiso para el módulo Vaccine y la acción DeleteAll", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4477) },
                    { 73, 8, true, "Vaccine_GetWithFilters", 9, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4479), "Permiso para el módulo Vaccine y la acción GetWithFilters", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4479) },
                    { 74, 1, true, "VaccineStock_Create", 10, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4482), "Permiso para el módulo VaccineStock y la acción Create", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4482) },
                    { 75, 2, true, "VaccineStock_Read", 10, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4484), "Permiso para el módulo VaccineStock y la acción Read", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4485) },
                    { 76, 3, true, "VaccineStock_Update", 10, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4487), "Permiso para el módulo VaccineStock y la acción Update", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4487) },
                    { 77, 4, true, "VaccineStock_Delete", 10, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4489), "Permiso para el módulo VaccineStock y la acción Delete", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4490) },
                    { 78, 5, true, "VaccineStock_ToggleActive", 10, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4492), "Permiso para el módulo VaccineStock y la acción ToggleActive", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4492) },
                    { 79, 6, true, "VaccineStock_GetById", 10, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4494), "Permiso para el módulo VaccineStock y la acción GetById", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4494) },
                    { 80, 7, true, "VaccineStock_DeleteAll", 10, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4496), "Permiso para el módulo VaccineStock y la acción DeleteAll", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4497) },
                    { 81, 8, true, "VaccineStock_GetWithFilters", 10, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4499), "Permiso para el módulo VaccineStock y la acción GetWithFilters", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4499) },
                    { 82, 1, true, "VaccineSheep_Create", 11, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4502), "Permiso para el módulo VaccineSheep y la acción Create", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4502) },
                    { 83, 2, true, "VaccineSheep_Read", 11, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4504), "Permiso para el módulo VaccineSheep y la acción Read", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4504) },
                    { 84, 3, true, "VaccineSheep_Update", 11, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4507), "Permiso para el módulo VaccineSheep y la acción Update", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4507) },
                    { 85, 4, true, "VaccineSheep_Delete", 11, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4543), "Permiso para el módulo VaccineSheep y la acción Delete", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4544) },
                    { 86, 5, true, "VaccineSheep_ToggleActive", 11, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4546), "Permiso para el módulo VaccineSheep y la acción ToggleActive", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4547) },
                    { 87, 6, true, "VaccineSheep_GetById", 11, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4549), "Permiso para el módulo VaccineSheep y la acción GetById", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4549) },
                    { 88, 7, true, "VaccineSheep_DeleteAll", 11, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4551), "Permiso para el módulo VaccineSheep y la acción DeleteAll", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4552) },
                    { 89, 8, true, "VaccineSheep_GetWithFilters", 11, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4554), "Permiso para el módulo VaccineSheep y la acción GetWithFilters", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4554) },
                    { 90, 1, true, "SaleSheep_Create", 12, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4557), "Permiso para el módulo SaleSheep y la acción Create", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4557) },
                    { 91, 2, true, "SaleSheep_Read", 12, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4560), "Permiso para el módulo SaleSheep y la acción Read", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4560) },
                    { 92, 3, true, "SaleSheep_Update", 12, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4562), "Permiso para el módulo SaleSheep y la acción Update", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4563) },
                    { 93, 4, true, "SaleSheep_Delete", 12, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4565), "Permiso para el módulo SaleSheep y la acción Delete", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4565) },
                    { 94, 5, true, "SaleSheep_ToggleActive", 12, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4567), "Permiso para el módulo SaleSheep y la acción ToggleActive", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4568) },
                    { 95, 6, true, "SaleSheep_GetById", 12, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4570), "Permiso para el módulo SaleSheep y la acción GetById", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4570) },
                    { 96, 7, true, "SaleSheep_DeleteAll", 12, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4572), "Permiso para el módulo SaleSheep y la acción DeleteAll", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4573) },
                    { 97, 8, true, "SaleSheep_GetWithFilters", 12, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4575), "Permiso para el módulo SaleSheep y la acción GetWithFilters", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4575) },
                    { 98, 1, true, "SheepHistoricWeight_Create", 13, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4578), "Permiso para el módulo SheepHistoricWeight y la acción Create", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4579) },
                    { 99, 2, true, "SheepHistoricWeight_Read", 13, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4581), "Permiso para el módulo SheepHistoricWeight y la acción Read", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4582) },
                    { 100, 3, true, "SheepHistoricWeight_Update", 13, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4584), "Permiso para el módulo SheepHistoricWeight y la acción Update", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4584) },
                    { 101, 4, true, "SheepHistoricWeight_Delete", 13, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4586), "Permiso para el módulo SheepHistoricWeight y la acción Delete", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4587) },
                    { 102, 5, true, "SheepHistoricWeight_ToggleActive", 13, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4589), "Permiso para el módulo SheepHistoricWeight y la acción ToggleActive", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4590) },
                    { 103, 6, true, "SheepHistoricWeight_GetById", 13, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4592), "Permiso para el módulo SheepHistoricWeight y la acción GetById", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4593) },
                    { 104, 7, true, "SheepHistoricWeight_DeleteAll", 13, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4595), "Permiso para el módulo SheepHistoricWeight y la acción DeleteAll", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4595) },
                    { 105, 8, true, "SheepHistoricWeight_GetWithFilters", 13, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4598), "Permiso para el módulo SheepHistoricWeight y la acción GetWithFilters", new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4598) }
                });

            migrationBuilder.InsertData(
                table: "RolesUsers",
                columns: new[] { "Id", "Active", "CreationDate", "ModificationDate", "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2858), new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2858), 1, 1 },
                    { 2, true, new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2867), new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2868), 2, 2 },
                    { 3, true, new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2871), new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2872), 3, 3 },
                    { 4, true, new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2876), new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2876), 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "PermissionsRoles",
                columns: new[] { "Id", "Active", "CreationDate", "ModificationDate", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4806), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4807), 1, 1 },
                    { 2, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4825), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4825), 2, 1 },
                    { 3, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4829), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4829), 3, 1 },
                    { 4, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4832), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4833), 4, 1 },
                    { 5, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4836), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4836), 5, 1 },
                    { 6, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4840), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4841), 6, 1 },
                    { 7, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4844), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4844), 7, 1 },
                    { 8, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4847), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4848), 8, 1 },
                    { 9, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4851), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4851), 9, 1 },
                    { 10, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4855), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4856), 10, 1 },
                    { 11, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4858), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4859), 11, 1 },
                    { 12, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4862), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4862), 12, 1 },
                    { 13, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4865), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4866), 13, 1 },
                    { 14, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4869), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4869), 14, 1 },
                    { 15, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4872), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4872), 15, 1 },
                    { 16, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4875), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4876), 16, 1 },
                    { 17, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4879), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4879), 17, 1 },
                    { 18, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4883), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4884), 18, 1 },
                    { 19, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4887), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4887), 19, 1 },
                    { 20, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4890), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4890), 20, 1 },
                    { 21, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4893), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4894), 21, 1 },
                    { 22, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4896), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4897), 22, 1 },
                    { 23, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4900), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4900), 23, 1 },
                    { 24, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4903), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4903), 24, 1 },
                    { 25, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4906), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4907), 25, 1 },
                    { 26, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4909), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4910), 26, 1 },
                    { 27, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4913), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4913), 27, 1 },
                    { 28, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4916), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4916), 28, 1 },
                    { 29, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4919), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4920), 29, 1 },
                    { 30, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4922), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4923), 30, 1 },
                    { 31, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4926), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4926), 31, 1 },
                    { 32, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4929), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4929), 32, 1 },
                    { 33, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4932), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4933), 33, 1 },
                    { 34, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4937), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4937), 34, 1 },
                    { 35, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4940), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4941), 35, 1 },
                    { 36, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4944), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4944), 36, 1 },
                    { 37, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4947), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4947), 37, 1 },
                    { 38, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4950), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4951), 38, 1 },
                    { 39, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4954), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4954), 39, 1 },
                    { 40, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4957), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4957), 40, 1 },
                    { 41, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4960), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4961), 41, 1 },
                    { 42, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4963), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4964), 42, 1 },
                    { 43, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4967), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4967), 43, 1 },
                    { 44, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5033), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5033), 44, 1 },
                    { 45, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5037), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5037), 45, 1 },
                    { 46, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5040), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5041), 46, 1 },
                    { 47, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5044), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5044), 47, 1 },
                    { 48, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5047), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5048), 48, 1 },
                    { 49, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5051), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5051), 49, 1 },
                    { 50, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5054), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5054), 50, 1 },
                    { 51, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5057), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5058), 51, 1 },
                    { 52, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5060), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5061), 52, 1 },
                    { 53, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5064), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5064), 53, 1 },
                    { 54, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5067), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5067), 54, 1 },
                    { 55, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5070), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5071), 55, 1 },
                    { 56, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5073), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5074), 56, 1 },
                    { 57, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5076), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5077), 57, 1 },
                    { 58, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5080), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5080), 58, 1 },
                    { 59, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5083), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5083), 59, 1 },
                    { 60, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5086), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5087), 60, 1 },
                    { 61, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5090), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5090), 61, 1 },
                    { 62, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5093), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5093), 62, 1 },
                    { 63, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5096), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5097), 63, 1 },
                    { 64, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5100), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5100), 64, 1 },
                    { 65, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5103), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5103), 65, 1 },
                    { 66, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5108), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5108), 66, 1 },
                    { 67, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5111), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5112), 67, 1 },
                    { 68, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5114), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5115), 68, 1 },
                    { 69, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5118), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5118), 69, 1 },
                    { 70, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5121), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5121), 70, 1 },
                    { 71, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5124), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5125), 71, 1 },
                    { 72, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5128), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5128), 72, 1 },
                    { 73, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5131), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5132), 73, 1 },
                    { 74, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5134), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5135), 74, 1 },
                    { 75, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5138), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5138), 75, 1 },
                    { 76, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5141), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5141), 76, 1 },
                    { 77, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5144), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5145), 77, 1 },
                    { 78, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5148), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5148), 78, 1 },
                    { 79, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5151), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5151), 79, 1 },
                    { 80, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5154), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5155), 80, 1 },
                    { 81, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5157), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5158), 81, 1 },
                    { 82, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5161), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5161), 82, 1 },
                    { 83, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5164), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5164), 83, 1 },
                    { 84, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5167), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5168), 84, 1 },
                    { 85, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5170), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5171), 85, 1 },
                    { 86, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5173), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5174), 86, 1 },
                    { 87, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5176), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5177), 87, 1 },
                    { 88, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5179), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5180), 88, 1 },
                    { 89, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5182), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5182), 89, 1 },
                    { 90, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5185), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5185), 90, 1 },
                    { 91, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5188), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5188), 91, 1 },
                    { 92, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5191), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5192), 92, 1 },
                    { 93, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5194), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5195), 93, 1 },
                    { 94, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5197), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5198), 94, 1 },
                    { 95, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5201), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5201), 95, 1 },
                    { 96, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5204), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5204), 96, 1 },
                    { 97, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5264), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5265), 97, 1 },
                    { 98, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5268), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5268), 98, 1 },
                    { 99, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5271), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5271), 99, 1 },
                    { 100, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5274), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5274), 100, 1 },
                    { 101, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5277), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5277), 101, 1 },
                    { 102, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5280), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5280), 102, 1 },
                    { 103, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5283), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5283), 103, 1 },
                    { 104, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5286), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5286), 104, 1 },
                    { 105, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5289), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5289), 105, 1 },
                    { 106, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5786), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5787), 90, 2 },
                    { 107, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(6369), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(6370), 91, 2 },
                    { 108, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(6946), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(6947), 92, 2 },
                    { 109, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(7515), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(7516), 93, 2 },
                    { 110, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(8102), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(8102), 96, 2 },
                    { 111, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(8643), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(8643), 97, 2 },
                    { 112, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(9186), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(9186), 94, 2 },
                    { 113, true, new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(9738), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(9738), 95, 2 },
                    { 114, true, new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(45), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(45), 57, 2 },
                    { 115, true, new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(496), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(497), 58, 2 },
                    { 116, true, new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(943), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(943), 59, 2 },
                    { 117, true, new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(1419), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(1420), 60, 2 },
                    { 118, true, new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(1901), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(1902), 63, 2 },
                    { 119, true, new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(2437), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(2437), 64, 2 },
                    { 120, true, new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(2897), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(2898), 61, 2 },
                    { 121, true, new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(3385), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(3386), 62, 2 },
                    { 122, true, new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(3902), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(3903), 65, 2 },
                    { 123, true, new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(4182), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(4182), 25, 2 },
                    { 124, true, new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(4532), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(4532), 26, 2 },
                    { 125, true, new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(4900), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(4901), 27, 2 },
                    { 126, true, new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(5273), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(5274), 28, 2 },
                    { 127, true, new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(5660), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(5660), 31, 2 },
                    { 128, true, new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(6037), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(6037), 32, 2 },
                    { 129, true, new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(6366), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(6367), 29, 2 },
                    { 130, true, new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(6754), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(6755), 30, 2 },
                    { 131, true, new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(7296), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(7296), 66, 2 },
                    { 132, true, new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(7768), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(7768), 67, 2 },
                    { 133, true, new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(8265), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(8266), 68, 2 },
                    { 134, true, new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(8732), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(8733), 69, 2 },
                    { 135, true, new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(9239), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(9240), 72, 2 },
                    { 136, true, new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(9740), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(9741), 73, 2 },
                    { 137, true, new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(246), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(246), 70, 2 },
                    { 138, true, new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(759), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(760), 71, 2 },
                    { 139, true, new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(1350), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(1351), 82, 2 },
                    { 140, true, new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(1888), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(1889), 83, 2 },
                    { 141, true, new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(2487), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(2488), 84, 2 },
                    { 142, true, new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(3008), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(3009), 85, 2 },
                    { 143, true, new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(3582), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(3582), 88, 2 },
                    { 144, true, new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(4124), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(4124), 89, 2 },
                    { 145, true, new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(4621), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(4622), 86, 2 },
                    { 146, true, new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(5165), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(5165), 87, 2 },
                    { 147, true, new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(5603), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(5603), 74, 2 },
                    { 148, true, new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(6095), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(6096), 75, 2 },
                    { 149, true, new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(6603), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(6604), 76, 2 },
                    { 150, true, new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(7101), 77, 2 },
                    { 151, true, new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(7618), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(7619), 80, 2 },
                    { 152, true, new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(8162), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(8163), 81, 2 },
                    { 153, true, new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(8667), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(8667), 78, 2 },
                    { 154, true, new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(9196), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(9197), 79, 2 },
                    { 155, true, new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(9886), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(9886), 98, 2 },
                    { 156, true, new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(460), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(461), 99, 2 },
                    { 157, true, new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(1044), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(1045), 100, 2 },
                    { 158, true, new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(1636), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(1637), 101, 2 },
                    { 159, true, new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(2246), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(2247), 104, 2 },
                    { 160, true, new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(2846), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(2846), 105, 2 },
                    { 161, true, new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(3400), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(3400), 102, 2 },
                    { 162, true, new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(3963), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(3964), 103, 2 },
                    { 163, true, new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(4434), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(4434), 90, 3 },
                    { 164, true, new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(4965), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(4966), 91, 3 },
                    { 165, true, new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(5483), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(5484), 92, 3 },
                    { 166, true, new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(6055), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(6056), 97, 3 },
                    { 167, true, new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(6567), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(6567), 94, 3 },
                    { 168, true, new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(7096), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(7097), 95, 3 },
                    { 169, true, new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(7416), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(7416), 57, 3 },
                    { 170, true, new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(7853), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(7854), 58, 3 },
                    { 171, true, new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(8313), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(8314), 59, 3 },
                    { 172, true, new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(8801), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(8802), 64, 3 },
                    { 173, true, new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(9221), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(9222), 61, 3 },
                    { 174, true, new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(9676), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(9677), 62, 3 },
                    { 175, true, new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(183), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(184), 65, 3 },
                    { 176, true, new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(631), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(632), 66, 3 },
                    { 177, true, new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(1091), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(1092), 67, 3 },
                    { 178, true, new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(1565), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(1566), 68, 3 },
                    { 179, true, new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(2063), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(2064), 73, 3 },
                    { 180, true, new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(2514), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(2514), 70, 3 },
                    { 181, true, new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(2989), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(2990), 71, 3 },
                    { 182, true, new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(3506), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(3507), 82, 3 },
                    { 183, true, new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(4061), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(4061), 83, 3 },
                    { 184, true, new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(4618), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(4620), 84, 3 },
                    { 185, true, new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(5200), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(5201), 89, 3 },
                    { 186, true, new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(5727), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(5727), 86, 3 },
                    { 187, true, new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(6265), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(6266), 87, 3 },
                    { 188, true, new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(6695), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(6695), 74, 3 },
                    { 189, true, new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(7202), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(7203), 75, 3 },
                    { 190, true, new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(7710), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(7711), 76, 3 },
                    { 191, true, new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(8250), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(8250), 81, 3 },
                    { 192, true, new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(8736), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(8736), 78, 3 },
                    { 193, true, new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(9243), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(9244), 79, 3 },
                    { 194, true, new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(9844), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(9845), 98, 3 },
                    { 195, true, new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(381), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(382), 99, 3 },
                    { 196, true, new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(944), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(945), 100, 3 },
                    { 197, true, new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(1538), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(1539), 105, 3 },
                    { 198, true, new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(2059), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(2059), 102, 3 },
                    { 199, true, new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(2643), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(2643), 103, 3 },
                    { 200, true, new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(3151), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(3152), 91, 4 },
                    { 201, true, new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(3752), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(3753), 97, 4 },
                    { 202, true, new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(4270), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(4271), 95, 4 },
                    { 203, true, new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(4590), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(4591), 58, 4 },
                    { 204, true, new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(5076), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(5077), 64, 4 },
                    { 205, true, new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(5525), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(5525), 62, 4 },
                    { 206, true, new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(6009), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(6010), 65, 4 },
                    { 207, true, new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(6472), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(6473), 67, 4 },
                    { 208, true, new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(7034), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(7035), 73, 4 },
                    { 209, true, new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(7494), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(7495), 71, 4 },
                    { 210, true, new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(8052), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(8053), 83, 4 },
                    { 211, true, new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(8617), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(8617), 89, 4 },
                    { 212, true, new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(9132), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(9133), 87, 4 },
                    { 213, true, new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(9615), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(9616), 75, 4 },
                    { 214, true, new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(189), new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(189), 81, 4 },
                    { 215, true, new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(708), new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(709), 79, 4 },
                    { 216, true, new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(1372), new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(1372), 99, 4 },
                    { 217, true, new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2006), new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2007), 105, 4 },
                    { 218, true, new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2506), new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2510), 103, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_ActionId",
                table: "Permissions",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_ControllerId",
                table: "Permissions",
                column: "ControllerId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionsRoles_PermissionId",
                table: "PermissionsRoles",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionsRoles_RoleId",
                table: "PermissionsRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RolesUsers_RoleId",
                table: "RolesUsers",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RolesUsers_UserId",
                table: "RolesUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleSheeps_SheepId",
                table: "SaleSheeps",
                column: "SheepId");

            migrationBuilder.CreateIndex(
                name: "IX_SheepHistoricWeights_SheepId",
                table: "SheepHistoricWeights",
                column: "SheepId");

            migrationBuilder.CreateIndex(
                name: "IX_VaccinesSheeps_SheepId",
                table: "VaccinesSheeps",
                column: "SheepId");

            migrationBuilder.CreateIndex(
                name: "IX_VaccinesSheeps_VaccineId",
                table: "VaccinesSheeps",
                column: "VaccineId");

            migrationBuilder.CreateIndex(
                name: "IX_VaccinesStock_VaccineId",
                table: "VaccinesStock",
                column: "VaccineId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PermissionsRoles");

            migrationBuilder.DropTable(
                name: "RolesUsers");

            migrationBuilder.DropTable(
                name: "SaleSheeps");

            migrationBuilder.DropTable(
                name: "SheepHistoricWeights");

            migrationBuilder.DropTable(
                name: "VaccinesSheeps");

            migrationBuilder.DropTable(
                name: "VaccinesStock");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Sheeps");

            migrationBuilder.DropTable(
                name: "Vaccines");

            migrationBuilder.DropTable(
                name: "Actions");

            migrationBuilder.DropTable(
                name: "Controllers");
        }
    }
}
