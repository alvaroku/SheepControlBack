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
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    NewWeight = table.Column<float>(type: "real", nullable: false),
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
                    { 1, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2750), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2752), "Create" },
                    { 2, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2758), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2759), "Read" },
                    { 3, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2760), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2761), "Update" },
                    { 4, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2763), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2763), "Delete" },
                    { 5, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2765), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2765), "ToggleActive" },
                    { 6, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2770), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2770), "GetById" },
                    { 7, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2772), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2772), "DeleteAll" },
                    { 8, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2774), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2774), "GetWithFilters" },
                    { 9, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2776), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2776), "GetSheepWithFinalWeight" },
                    { 10, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2779), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2780), "UpdateProfile" }
                });

            migrationBuilder.InsertData(
                table: "Controllers",
                columns: new[] { "Id", "Active", "CreationDate", "ModificationDate", "Name" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2259), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2278), "Action" },
                    { 2, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2294), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2295), "Controller" },
                    { 3, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2296), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2297), "Permission" },
                    { 4, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2298), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2299), "User" },
                    { 5, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2300), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2301), "PermissionRole" },
                    { 6, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2311), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2312), "Role" },
                    { 7, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2313), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2314), "RoleUser" },
                    { 8, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2316), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2316), "Sheep" },
                    { 9, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2318), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2319), "Vaccine" },
                    { 10, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2323), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2324), "VaccineStock" },
                    { 11, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2325), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2326), "VaccineSheep" },
                    { 12, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2327), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2328), "SaleSheep" },
                    { 13, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2330), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2331), "SheepHistoricWeight" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Active", "CreationDate", "ModificationDate", "Name" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4096), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4098), "SuperAdmin" },
                    { 2, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4106), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4106), "Admin" },
                    { 3, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4108), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4109), "User" },
                    { 4, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4111), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4112), "Invited" },
                    { 5, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4113), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4114), "Custom" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "BirthDate", "CreationDate", "Email", "LastName", "ModificationDate", "Name", "Password", "PhoneNumber", "Photo" },
                values: new object[,]
                {
                    { 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(8538), "sa@gmail.com", "sa", new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(8540), "sa", "sa", "9919596720", null },
                    { 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(8611), "admin@gmail.com", "admin", new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(8612), "admin", "admin", "9919596720", null },
                    { 3, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(8642), "alvaroku123@gmail.com", "Kú", new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(8643), "Alvaro", "12345", "9919596720", null },
                    { 4, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(8671), "invitado@gmail.com", "Invitado", new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(8673), "Invitado", "12345", "9919596720", null }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "ActionId", "Active", "Clave", "ControllerId", "CreationDate", "Description", "ModificationDate" },
                values: new object[,]
                {
                    { 1, 1, true, "Action_Create", 1, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2885), "Permiso para el módulo Action y la acción Create", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2886) },
                    { 2, 2, true, "Action_Read", 1, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2909), "Permiso para el módulo Action y la acción Read", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2909) },
                    { 3, 3, true, "Action_Update", 1, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2915), "Permiso para el módulo Action y la acción Update", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2916) },
                    { 4, 4, true, "Action_Delete", 1, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2919), "Permiso para el módulo Action y la acción Delete", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2920) },
                    { 5, 5, true, "Action_ToggleActive", 1, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2924), "Permiso para el módulo Action y la acción ToggleActive", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2925) },
                    { 6, 6, true, "Action_GetById", 1, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2932), "Permiso para el módulo Action y la acción GetById", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2933) },
                    { 7, 7, true, "Action_DeleteAll", 1, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2937), "Permiso para el módulo Action y la acción DeleteAll", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2938) },
                    { 8, 8, true, "Action_GetWithFilters", 1, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2942), "Permiso para el módulo Action y la acción GetWithFilters", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2943) },
                    { 9, 1, true, "Controller_Create", 2, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2951), "Permiso para el módulo Controller y la acción Create", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2952) },
                    { 10, 2, true, "Controller_Read", 2, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2960), "Permiso para el módulo Controller y la acción Read", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2961) },
                    { 11, 3, true, "Controller_Update", 2, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2965), "Permiso para el módulo Controller y la acción Update", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2966) },
                    { 12, 4, true, "Controller_Delete", 2, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2969), "Permiso para el módulo Controller y la acción Delete", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2971) },
                    { 13, 5, true, "Controller_ToggleActive", 2, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2974), "Permiso para el módulo Controller y la acción ToggleActive", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(2975) },
                    { 14, 6, true, "Controller_GetById", 2, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3063), "Permiso para el módulo Controller y la acción GetById", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3064) },
                    { 15, 7, true, "Controller_DeleteAll", 2, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3069), "Permiso para el módulo Controller y la acción DeleteAll", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3070) },
                    { 16, 8, true, "Controller_GetWithFilters", 2, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3073), "Permiso para el módulo Controller y la acción GetWithFilters", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3074) },
                    { 17, 1, true, "Permission_Create", 3, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3081), "Permiso para el módulo Permission y la acción Create", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3082) },
                    { 18, 2, true, "Permission_Read", 3, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3089), "Permiso para el módulo Permission y la acción Read", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3090) },
                    { 19, 3, true, "Permission_Update", 3, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3093), "Permiso para el módulo Permission y la acción Update", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3094) },
                    { 20, 4, true, "Permission_Delete", 3, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3097), "Permiso para el módulo Permission y la acción Delete", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3098) },
                    { 21, 5, true, "Permission_ToggleActive", 3, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3102), "Permiso para el módulo Permission y la acción ToggleActive", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3103) },
                    { 22, 6, true, "Permission_GetById", 3, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3106), "Permiso para el módulo Permission y la acción GetById", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3107) },
                    { 23, 7, true, "Permission_DeleteAll", 3, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3111), "Permiso para el módulo Permission y la acción DeleteAll", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3112) },
                    { 24, 8, true, "Permission_GetWithFilters", 3, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3115), "Permiso para el módulo Permission y la acción GetWithFilters", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3116) },
                    { 25, 1, true, "User_Create", 4, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3121), "Permiso para el módulo User y la acción Create", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3122) },
                    { 26, 2, true, "User_Read", 4, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3126), "Permiso para el módulo User y la acción Read", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3127) },
                    { 27, 3, true, "User_Update", 4, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3130), "Permiso para el módulo User y la acción Update", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3131) },
                    { 28, 4, true, "User_Delete", 4, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3135), "Permiso para el módulo User y la acción Delete", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3136) },
                    { 29, 5, true, "User_ToggleActive", 4, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3139), "Permiso para el módulo User y la acción ToggleActive", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3140) },
                    { 30, 6, true, "User_GetById", 4, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3144), "Permiso para el módulo User y la acción GetById", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3145) },
                    { 31, 7, true, "User_DeleteAll", 4, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3148), "Permiso para el módulo User y la acción DeleteAll", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3149) },
                    { 32, 8, true, "User_GetWithFilters", 4, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3152), "Permiso para el módulo User y la acción GetWithFilters", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3153) },
                    { 33, 10, true, "User_UpdateProfile", 4, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3159), "Permiso para el módulo User y la acción UpdateProfile", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3160) },
                    { 34, 1, true, "PermissionRole_Create", 5, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3258), "Permiso para el módulo PermissionRole y la acción Create", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3259) },
                    { 35, 2, true, "PermissionRole_Read", 5, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3264), "Permiso para el módulo PermissionRole y la acción Read", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3265) },
                    { 36, 3, true, "PermissionRole_Update", 5, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3269), "Permiso para el módulo PermissionRole y la acción Update", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3270) },
                    { 37, 4, true, "PermissionRole_Delete", 5, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3273), "Permiso para el módulo PermissionRole y la acción Delete", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3275) },
                    { 38, 5, true, "PermissionRole_ToggleActive", 5, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3278), "Permiso para el módulo PermissionRole y la acción ToggleActive", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3279) },
                    { 39, 6, true, "PermissionRole_GetById", 5, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3283), "Permiso para el módulo PermissionRole y la acción GetById", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3284) },
                    { 40, 7, true, "PermissionRole_DeleteAll", 5, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3354), "Permiso para el módulo PermissionRole y la acción DeleteAll", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3354) },
                    { 41, 8, true, "PermissionRole_GetWithFilters", 5, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3359), "Permiso para el módulo PermissionRole y la acción GetWithFilters", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3360) },
                    { 42, 1, true, "Role_Create", 6, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3367), "Permiso para el módulo Role y la acción Create", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3368) },
                    { 43, 2, true, "Role_Read", 6, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3371), "Permiso para el módulo Role y la acción Read", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3372) },
                    { 44, 3, true, "Role_Update", 6, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3376), "Permiso para el módulo Role y la acción Update", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3377) },
                    { 45, 4, true, "Role_Delete", 6, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3381), "Permiso para el módulo Role y la acción Delete", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3382) },
                    { 46, 5, true, "Role_ToggleActive", 6, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3385), "Permiso para el módulo Role y la acción ToggleActive", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3386) },
                    { 47, 6, true, "Role_GetById", 6, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3390), "Permiso para el módulo Role y la acción GetById", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3391) },
                    { 48, 7, true, "Role_DeleteAll", 6, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3395), "Permiso para el módulo Role y la acción DeleteAll", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3395) },
                    { 49, 8, true, "Role_GetWithFilters", 6, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3400), "Permiso para el módulo Role y la acción GetWithFilters", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3400) },
                    { 50, 1, true, "RoleUser_Create", 7, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3412), "Permiso para el módulo RoleUser y la acción Create", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3412) },
                    { 51, 2, true, "RoleUser_Read", 7, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3416), "Permiso para el módulo RoleUser y la acción Read", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3417) },
                    { 52, 3, true, "RoleUser_Update", 7, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3421), "Permiso para el módulo RoleUser y la acción Update", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3422) },
                    { 53, 4, true, "RoleUser_Delete", 7, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3426), "Permiso para el módulo RoleUser y la acción Delete", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3426) },
                    { 54, 5, true, "RoleUser_ToggleActive", 7, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3430), "Permiso para el módulo RoleUser y la acción ToggleActive", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3431) },
                    { 55, 6, true, "RoleUser_GetById", 7, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3436), "Permiso para el módulo RoleUser y la acción GetById", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3437) },
                    { 56, 7, true, "RoleUser_DeleteAll", 7, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3441), "Permiso para el módulo RoleUser y la acción DeleteAll", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3441) },
                    { 57, 8, true, "RoleUser_GetWithFilters", 7, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3445), "Permiso para el módulo RoleUser y la acción GetWithFilters", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3446) },
                    { 58, 1, true, "Sheep_Create", 8, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3452), "Permiso para el módulo Sheep y la acción Create", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3453) },
                    { 59, 2, true, "Sheep_Read", 8, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3457), "Permiso para el módulo Sheep y la acción Read", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3458) },
                    { 60, 3, true, "Sheep_Update", 8, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3462), "Permiso para el módulo Sheep y la acción Update", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3462) },
                    { 61, 4, true, "Sheep_Delete", 8, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3466), "Permiso para el módulo Sheep y la acción Delete", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3467) },
                    { 62, 5, true, "Sheep_ToggleActive", 8, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3471), "Permiso para el módulo Sheep y la acción ToggleActive", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3471) },
                    { 63, 6, true, "Sheep_GetById", 8, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3475), "Permiso para el módulo Sheep y la acción GetById", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3476) },
                    { 64, 7, true, "Sheep_DeleteAll", 8, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3479), "Permiso para el módulo Sheep y la acción DeleteAll", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3480) },
                    { 65, 8, true, "Sheep_GetWithFilters", 8, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3484), "Permiso para el módulo Sheep y la acción GetWithFilters", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3485) },
                    { 66, 9, true, "Sheep_GetSheepWithFinalWeight", 8, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3495), "Permiso para el módulo Sheep y la acción GetSheepWithFinalWeight", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3496) },
                    { 67, 1, true, "Vaccine_Create", 9, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3608), "Permiso para el módulo Vaccine y la acción Create", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3610) },
                    { 68, 2, true, "Vaccine_Read", 9, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3614), "Permiso para el módulo Vaccine y la acción Read", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3615) },
                    { 69, 3, true, "Vaccine_Update", 9, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3618), "Permiso para el módulo Vaccine y la acción Update", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3619) },
                    { 70, 4, true, "Vaccine_Delete", 9, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3623), "Permiso para el módulo Vaccine y la acción Delete", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3624) },
                    { 71, 5, true, "Vaccine_ToggleActive", 9, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3628), "Permiso para el módulo Vaccine y la acción ToggleActive", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3629) },
                    { 72, 6, true, "Vaccine_GetById", 9, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3634), "Permiso para el módulo Vaccine y la acción GetById", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3634) },
                    { 73, 7, true, "Vaccine_DeleteAll", 9, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3638), "Permiso para el módulo Vaccine y la acción DeleteAll", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3639) },
                    { 74, 8, true, "Vaccine_GetWithFilters", 9, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3643), "Permiso para el módulo Vaccine y la acción GetWithFilters", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3644) },
                    { 75, 1, true, "VaccineStock_Create", 10, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3650), "Permiso para el módulo VaccineStock y la acción Create", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3651) },
                    { 76, 2, true, "VaccineStock_Read", 10, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3655), "Permiso para el módulo VaccineStock y la acción Read", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3656) },
                    { 77, 3, true, "VaccineStock_Update", 10, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3661), "Permiso para el módulo VaccineStock y la acción Update", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3662) },
                    { 78, 4, true, "VaccineStock_Delete", 10, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3666), "Permiso para el módulo VaccineStock y la acción Delete", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3666) },
                    { 79, 5, true, "VaccineStock_ToggleActive", 10, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3670), "Permiso para el módulo VaccineStock y la acción ToggleActive", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3672) },
                    { 80, 6, true, "VaccineStock_GetById", 10, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3676), "Permiso para el módulo VaccineStock y la acción GetById", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3677) },
                    { 81, 7, true, "VaccineStock_DeleteAll", 10, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3681), "Permiso para el módulo VaccineStock y la acción DeleteAll", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3682) },
                    { 82, 8, true, "VaccineStock_GetWithFilters", 10, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3686), "Permiso para el módulo VaccineStock y la acción GetWithFilters", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3687) },
                    { 83, 1, true, "VaccineSheep_Create", 11, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3693), "Permiso para el módulo VaccineSheep y la acción Create", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3694) },
                    { 84, 2, true, "VaccineSheep_Read", 11, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3698), "Permiso para el módulo VaccineSheep y la acción Read", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3699) },
                    { 85, 3, true, "VaccineSheep_Update", 11, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3704), "Permiso para el módulo VaccineSheep y la acción Update", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3705) },
                    { 86, 4, true, "VaccineSheep_Delete", 11, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3708), "Permiso para el módulo VaccineSheep y la acción Delete", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3709) },
                    { 87, 5, true, "VaccineSheep_ToggleActive", 11, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3713), "Permiso para el módulo VaccineSheep y la acción ToggleActive", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3715) },
                    { 88, 6, true, "VaccineSheep_GetById", 11, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3719), "Permiso para el módulo VaccineSheep y la acción GetById", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3719) },
                    { 89, 7, true, "VaccineSheep_DeleteAll", 11, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3723), "Permiso para el módulo VaccineSheep y la acción DeleteAll", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3724) },
                    { 90, 8, true, "VaccineSheep_GetWithFilters", 11, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3728), "Permiso para el módulo VaccineSheep y la acción GetWithFilters", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3729) },
                    { 91, 1, true, "SaleSheep_Create", 12, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3734), "Permiso para el módulo SaleSheep y la acción Create", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3735) },
                    { 92, 2, true, "SaleSheep_Read", 12, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3738), "Permiso para el módulo SaleSheep y la acción Read", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3739) },
                    { 93, 3, true, "SaleSheep_Update", 12, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3742), "Permiso para el módulo SaleSheep y la acción Update", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3743) },
                    { 94, 4, true, "SaleSheep_Delete", 12, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3746), "Permiso para el módulo SaleSheep y la acción Delete", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3747) },
                    { 95, 5, true, "SaleSheep_ToggleActive", 12, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3847), "Permiso para el módulo SaleSheep y la acción ToggleActive", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3849) },
                    { 96, 6, true, "SaleSheep_GetById", 12, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3853), "Permiso para el módulo SaleSheep y la acción GetById", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3854) },
                    { 97, 7, true, "SaleSheep_DeleteAll", 12, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3858), "Permiso para el módulo SaleSheep y la acción DeleteAll", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3859) },
                    { 98, 8, true, "SaleSheep_GetWithFilters", 12, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3862), "Permiso para el módulo SaleSheep y la acción GetWithFilters", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3863) },
                    { 99, 1, true, "SheepHistoricWeight_Create", 13, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3869), "Permiso para el módulo SheepHistoricWeight y la acción Create", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3870) },
                    { 100, 2, true, "SheepHistoricWeight_Read", 13, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3875), "Permiso para el módulo SheepHistoricWeight y la acción Read", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3876) },
                    { 101, 3, true, "SheepHistoricWeight_Update", 13, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3880), "Permiso para el módulo SheepHistoricWeight y la acción Update", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3881) },
                    { 102, 4, true, "SheepHistoricWeight_Delete", 13, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3885), "Permiso para el módulo SheepHistoricWeight y la acción Delete", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3886) },
                    { 103, 5, true, "SheepHistoricWeight_ToggleActive", 13, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3890), "Permiso para el módulo SheepHistoricWeight y la acción ToggleActive", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3891) },
                    { 104, 6, true, "SheepHistoricWeight_GetById", 13, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3894), "Permiso para el módulo SheepHistoricWeight y la acción GetById", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3895) },
                    { 105, 7, true, "SheepHistoricWeight_DeleteAll", 13, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3899), "Permiso para el módulo SheepHistoricWeight y la acción DeleteAll", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3900) },
                    { 106, 8, true, "SheepHistoricWeight_GetWithFilters", 13, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3904), "Permiso para el módulo SheepHistoricWeight y la acción GetWithFilters", new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(3905) }
                });

            migrationBuilder.InsertData(
                table: "RolesUsers",
                columns: new[] { "Id", "Active", "CreationDate", "ModificationDate", "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(8689), new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(8690), 1, 1 },
                    { 2, true, new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(8731), new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(8732), 2, 2 },
                    { 3, true, new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(8746), new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(8747), 3, 3 },
                    { 4, true, new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(8759), new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(8761), 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "PermissionsRoles",
                columns: new[] { "Id", "Active", "CreationDate", "ModificationDate", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4194), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4195), 1, 1 },
                    { 2, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4231), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4231), 2, 1 },
                    { 3, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4239), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4240), 3, 1 },
                    { 4, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4245), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4246), 4, 1 },
                    { 5, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4251), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4252), 5, 1 },
                    { 6, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4259), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4260), 6, 1 },
                    { 7, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4265), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4266), 7, 1 },
                    { 8, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4333), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4334), 8, 1 },
                    { 9, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4341), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4342), 9, 1 },
                    { 10, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4351), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4352), 10, 1 },
                    { 11, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4357), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4358), 11, 1 },
                    { 12, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4364), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4365), 12, 1 },
                    { 13, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4370), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4371), 13, 1 },
                    { 14, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4376), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4377), 14, 1 },
                    { 15, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4382), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4383), 15, 1 },
                    { 16, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4388), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4388), 16, 1 },
                    { 17, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4393), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4394), 17, 1 },
                    { 18, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4401), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4401), 18, 1 },
                    { 19, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4406), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4407), 19, 1 },
                    { 20, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4412), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4413), 20, 1 },
                    { 21, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4417), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4418), 21, 1 },
                    { 22, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4423), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4424), 22, 1 },
                    { 23, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4428), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4429), 23, 1 },
                    { 24, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4433), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4434), 24, 1 },
                    { 25, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4438), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4438), 25, 1 },
                    { 26, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4443), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4443), 26, 1 },
                    { 27, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4448), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4449), 27, 1 },
                    { 28, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4453), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4453), 28, 1 },
                    { 29, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4457), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4458), 29, 1 },
                    { 30, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4462), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4463), 30, 1 },
                    { 31, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4467), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4468), 31, 1 },
                    { 32, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4473), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4474), 32, 1 },
                    { 33, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4479), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4479), 33, 1 },
                    { 34, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4487), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4488), 34, 1 },
                    { 35, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4493), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4493), 35, 1 },
                    { 36, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4499), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4500), 36, 1 },
                    { 37, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4505), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4505), 37, 1 },
                    { 38, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4510), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4511), 38, 1 },
                    { 39, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4515), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4516), 39, 1 },
                    { 40, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4520), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4521), 40, 1 },
                    { 41, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4526), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4527), 41, 1 },
                    { 42, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4531), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4532), 42, 1 },
                    { 43, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4536), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4537), 43, 1 },
                    { 44, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4542), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4543), 44, 1 },
                    { 45, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4548), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4549), 45, 1 },
                    { 46, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4554), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4554), 46, 1 },
                    { 47, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4559), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4560), 47, 1 },
                    { 48, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4565), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4566), 48, 1 },
                    { 49, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4572), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4572), 49, 1 },
                    { 50, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4578), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4579), 50, 1 },
                    { 51, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4583), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4584), 51, 1 },
                    { 52, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4588), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4589), 52, 1 },
                    { 53, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4593), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4594), 53, 1 },
                    { 54, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4598), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4599), 54, 1 },
                    { 55, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4604), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4604), 55, 1 },
                    { 56, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4609), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4610), 56, 1 },
                    { 57, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4614), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4614), 57, 1 },
                    { 58, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4618), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4619), 58, 1 },
                    { 59, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4623), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4624), 59, 1 },
                    { 60, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4629), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4629), 60, 1 },
                    { 61, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4690), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4692), 61, 1 },
                    { 62, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4700), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4701), 62, 1 },
                    { 63, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4705), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4706), 63, 1 },
                    { 64, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4710), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4711), 64, 1 },
                    { 65, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4716), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4717), 65, 1 },
                    { 66, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4726), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4726), 66, 1 },
                    { 67, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4732), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4732), 67, 1 },
                    { 68, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4737), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4738), 68, 1 },
                    { 69, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4744), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4744), 69, 1 },
                    { 70, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4749), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4750), 70, 1 },
                    { 71, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4754), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4755), 71, 1 },
                    { 72, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4759), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4760), 72, 1 },
                    { 73, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4764), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4765), 73, 1 },
                    { 74, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4769), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4770), 74, 1 },
                    { 75, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4774), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4775), 75, 1 },
                    { 76, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4779), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4779), 76, 1 },
                    { 77, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4784), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4785), 77, 1 },
                    { 78, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4789), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4790), 78, 1 },
                    { 79, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4794), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4795), 79, 1 },
                    { 80, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4800), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4800), 80, 1 },
                    { 81, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4806), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4806), 81, 1 },
                    { 82, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4811), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4812), 82, 1 },
                    { 83, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4817), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4817), 83, 1 },
                    { 84, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4822), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4823), 84, 1 },
                    { 85, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4828), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4829), 85, 1 },
                    { 86, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4834), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4834), 86, 1 },
                    { 87, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4838), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4839), 87, 1 },
                    { 88, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4844), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4845), 88, 1 },
                    { 89, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4849), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4850), 89, 1 },
                    { 90, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4854), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4855), 90, 1 },
                    { 91, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4859), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4860), 91, 1 },
                    { 92, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4864), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4865), 92, 1 },
                    { 93, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4870), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4871), 93, 1 },
                    { 94, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4876), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4877), 94, 1 },
                    { 95, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4882), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4882), 95, 1 },
                    { 96, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4887), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4888), 96, 1 },
                    { 97, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4893), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4894), 97, 1 },
                    { 98, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4899), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4900), 98, 1 },
                    { 99, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4906), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4907), 99, 1 },
                    { 100, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4912), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4913), 100, 1 },
                    { 101, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4917), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4918), 101, 1 },
                    { 102, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4923), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4924), 102, 1 },
                    { 103, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4929), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4930), 103, 1 },
                    { 104, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4934), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4935), 104, 1 },
                    { 105, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4940), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4941), 105, 1 },
                    { 106, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4946), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(4947), 106, 1 },
                    { 107, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(5854), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(5857), 91, 2 },
                    { 108, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(6767), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(6770), 92, 2 },
                    { 109, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(7691), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(7695), 93, 2 },
                    { 110, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(8676), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(8679), 94, 2 },
                    { 111, true, new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(9659), new DateTime(2023, 7, 26, 22, 1, 32, 228, DateTimeKind.Local).AddTicks(9662), 97, 2 },
                    { 112, true, new DateTime(2023, 7, 26, 22, 1, 32, 229, DateTimeKind.Local).AddTicks(565), new DateTime(2023, 7, 26, 22, 1, 32, 229, DateTimeKind.Local).AddTicks(569), 98, 2 },
                    { 113, true, new DateTime(2023, 7, 26, 22, 1, 32, 229, DateTimeKind.Local).AddTicks(1483), new DateTime(2023, 7, 26, 22, 1, 32, 229, DateTimeKind.Local).AddTicks(1485), 95, 2 },
                    { 114, true, new DateTime(2023, 7, 26, 22, 1, 32, 229, DateTimeKind.Local).AddTicks(2394), new DateTime(2023, 7, 26, 22, 1, 32, 229, DateTimeKind.Local).AddTicks(2397), 96, 2 },
                    { 115, true, new DateTime(2023, 7, 26, 22, 1, 32, 229, DateTimeKind.Local).AddTicks(2922), new DateTime(2023, 7, 26, 22, 1, 32, 229, DateTimeKind.Local).AddTicks(2924), 58, 2 },
                    { 116, true, new DateTime(2023, 7, 26, 22, 1, 32, 229, DateTimeKind.Local).AddTicks(3712), new DateTime(2023, 7, 26, 22, 1, 32, 229, DateTimeKind.Local).AddTicks(3716), 59, 2 },
                    { 117, true, new DateTime(2023, 7, 26, 22, 1, 32, 229, DateTimeKind.Local).AddTicks(4490), new DateTime(2023, 7, 26, 22, 1, 32, 229, DateTimeKind.Local).AddTicks(4495), 60, 2 },
                    { 118, true, new DateTime(2023, 7, 26, 22, 1, 32, 229, DateTimeKind.Local).AddTicks(5280), new DateTime(2023, 7, 26, 22, 1, 32, 229, DateTimeKind.Local).AddTicks(5283), 61, 2 },
                    { 119, true, new DateTime(2023, 7, 26, 22, 1, 32, 229, DateTimeKind.Local).AddTicks(6105), new DateTime(2023, 7, 26, 22, 1, 32, 229, DateTimeKind.Local).AddTicks(6109), 64, 2 },
                    { 120, true, new DateTime(2023, 7, 26, 22, 1, 32, 229, DateTimeKind.Local).AddTicks(6961), new DateTime(2023, 7, 26, 22, 1, 32, 229, DateTimeKind.Local).AddTicks(6965), 65, 2 },
                    { 121, true, new DateTime(2023, 7, 26, 22, 1, 32, 229, DateTimeKind.Local).AddTicks(7736), new DateTime(2023, 7, 26, 22, 1, 32, 229, DateTimeKind.Local).AddTicks(7739), 62, 2 },
                    { 122, true, new DateTime(2023, 7, 26, 22, 1, 32, 229, DateTimeKind.Local).AddTicks(8522), new DateTime(2023, 7, 26, 22, 1, 32, 229, DateTimeKind.Local).AddTicks(8526), 63, 2 },
                    { 123, true, new DateTime(2023, 7, 26, 22, 1, 32, 229, DateTimeKind.Local).AddTicks(9378), new DateTime(2023, 7, 26, 22, 1, 32, 229, DateTimeKind.Local).AddTicks(9381), 66, 2 },
                    { 124, true, new DateTime(2023, 7, 26, 22, 1, 32, 230, DateTimeKind.Local).AddTicks(143), new DateTime(2023, 7, 26, 22, 1, 32, 230, DateTimeKind.Local).AddTicks(147), 67, 2 },
                    { 125, true, new DateTime(2023, 7, 26, 22, 1, 32, 230, DateTimeKind.Local).AddTicks(1004), new DateTime(2023, 7, 26, 22, 1, 32, 230, DateTimeKind.Local).AddTicks(1006), 68, 2 },
                    { 126, true, new DateTime(2023, 7, 26, 22, 1, 32, 230, DateTimeKind.Local).AddTicks(1797), new DateTime(2023, 7, 26, 22, 1, 32, 230, DateTimeKind.Local).AddTicks(1802), 69, 2 },
                    { 127, true, new DateTime(2023, 7, 26, 22, 1, 32, 230, DateTimeKind.Local).AddTicks(2657), new DateTime(2023, 7, 26, 22, 1, 32, 230, DateTimeKind.Local).AddTicks(2660), 70, 2 },
                    { 128, true, new DateTime(2023, 7, 26, 22, 1, 32, 230, DateTimeKind.Local).AddTicks(3566), new DateTime(2023, 7, 26, 22, 1, 32, 230, DateTimeKind.Local).AddTicks(3569), 73, 2 },
                    { 129, true, new DateTime(2023, 7, 26, 22, 1, 32, 230, DateTimeKind.Local).AddTicks(4385), new DateTime(2023, 7, 26, 22, 1, 32, 230, DateTimeKind.Local).AddTicks(4388), 74, 2 },
                    { 130, true, new DateTime(2023, 7, 26, 22, 1, 32, 230, DateTimeKind.Local).AddTicks(5199), new DateTime(2023, 7, 26, 22, 1, 32, 230, DateTimeKind.Local).AddTicks(5202), 71, 2 },
                    { 131, true, new DateTime(2023, 7, 26, 22, 1, 32, 230, DateTimeKind.Local).AddTicks(6033), new DateTime(2023, 7, 26, 22, 1, 32, 230, DateTimeKind.Local).AddTicks(6036), 72, 2 },
                    { 132, true, new DateTime(2023, 7, 26, 22, 1, 32, 230, DateTimeKind.Local).AddTicks(6952), new DateTime(2023, 7, 26, 22, 1, 32, 230, DateTimeKind.Local).AddTicks(6956), 83, 2 },
                    { 133, true, new DateTime(2023, 7, 26, 22, 1, 32, 230, DateTimeKind.Local).AddTicks(7851), new DateTime(2023, 7, 26, 22, 1, 32, 230, DateTimeKind.Local).AddTicks(7856), 84, 2 },
                    { 134, true, new DateTime(2023, 7, 26, 22, 1, 32, 230, DateTimeKind.Local).AddTicks(8838), new DateTime(2023, 7, 26, 22, 1, 32, 230, DateTimeKind.Local).AddTicks(8842), 85, 2 },
                    { 135, true, new DateTime(2023, 7, 26, 22, 1, 32, 230, DateTimeKind.Local).AddTicks(9755), new DateTime(2023, 7, 26, 22, 1, 32, 230, DateTimeKind.Local).AddTicks(9758), 86, 2 },
                    { 136, true, new DateTime(2023, 7, 26, 22, 1, 32, 231, DateTimeKind.Local).AddTicks(706), new DateTime(2023, 7, 26, 22, 1, 32, 231, DateTimeKind.Local).AddTicks(709), 89, 2 },
                    { 137, true, new DateTime(2023, 7, 26, 22, 1, 32, 231, DateTimeKind.Local).AddTicks(1687), new DateTime(2023, 7, 26, 22, 1, 32, 231, DateTimeKind.Local).AddTicks(1691), 90, 2 },
                    { 138, true, new DateTime(2023, 7, 26, 22, 1, 32, 231, DateTimeKind.Local).AddTicks(2533), new DateTime(2023, 7, 26, 22, 1, 32, 231, DateTimeKind.Local).AddTicks(2538), 87, 2 },
                    { 139, true, new DateTime(2023, 7, 26, 22, 1, 32, 231, DateTimeKind.Local).AddTicks(3467), new DateTime(2023, 7, 26, 22, 1, 32, 231, DateTimeKind.Local).AddTicks(3471), 88, 2 },
                    { 140, true, new DateTime(2023, 7, 26, 22, 1, 32, 231, DateTimeKind.Local).AddTicks(4219), new DateTime(2023, 7, 26, 22, 1, 32, 231, DateTimeKind.Local).AddTicks(4221), 75, 2 },
                    { 141, true, new DateTime(2023, 7, 26, 22, 1, 32, 231, DateTimeKind.Local).AddTicks(5093), new DateTime(2023, 7, 26, 22, 1, 32, 231, DateTimeKind.Local).AddTicks(5096), 76, 2 },
                    { 142, true, new DateTime(2023, 7, 26, 22, 1, 32, 231, DateTimeKind.Local).AddTicks(5949), new DateTime(2023, 7, 26, 22, 1, 32, 231, DateTimeKind.Local).AddTicks(5952), 77, 2 },
                    { 143, true, new DateTime(2023, 7, 26, 22, 1, 32, 231, DateTimeKind.Local).AddTicks(6822), new DateTime(2023, 7, 26, 22, 1, 32, 231, DateTimeKind.Local).AddTicks(6824), 78, 2 },
                    { 144, true, new DateTime(2023, 7, 26, 22, 1, 32, 231, DateTimeKind.Local).AddTicks(7761), new DateTime(2023, 7, 26, 22, 1, 32, 231, DateTimeKind.Local).AddTicks(7762), 81, 2 },
                    { 145, true, new DateTime(2023, 7, 26, 22, 1, 32, 231, DateTimeKind.Local).AddTicks(8621), new DateTime(2023, 7, 26, 22, 1, 32, 231, DateTimeKind.Local).AddTicks(8623), 82, 2 },
                    { 146, true, new DateTime(2023, 7, 26, 22, 1, 32, 231, DateTimeKind.Local).AddTicks(9429), new DateTime(2023, 7, 26, 22, 1, 32, 231, DateTimeKind.Local).AddTicks(9432), 79, 2 },
                    { 147, true, new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(285), new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(287), 80, 2 },
                    { 148, true, new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(1323), new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(1328), 99, 2 },
                    { 149, true, new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(2295), new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(2300), 100, 2 },
                    { 150, true, new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(3311), new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(3314), 101, 2 },
                    { 151, true, new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(4326), new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(4329), 102, 2 },
                    { 152, true, new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(5341), new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(5345), 105, 2 },
                    { 153, true, new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(6357), new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(6361), 106, 2 },
                    { 154, true, new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(7264), new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(7269), 103, 2 },
                    { 155, true, new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(8259), new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(8264), 104, 2 },
                    { 156, true, new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(8460), new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(8463), 25, 2 },
                    { 157, true, new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(8643), new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(8645), 26, 2 },
                    { 158, true, new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(8934), new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(8936), 27, 2 },
                    { 159, true, new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(9166), new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(9168), 32, 2 },
                    { 160, true, new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(9425), new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(9427), 29, 2 },
                    { 161, true, new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(9634), new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(9636), 30, 2 },
                    { 162, true, new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(9880), new DateTime(2023, 7, 26, 22, 1, 32, 232, DateTimeKind.Local).AddTicks(9882), 33, 2 },
                    { 163, true, new DateTime(2023, 7, 26, 22, 1, 32, 233, DateTimeKind.Local).AddTicks(651), new DateTime(2023, 7, 26, 22, 1, 32, 233, DateTimeKind.Local).AddTicks(655), 91, 3 },
                    { 164, true, new DateTime(2023, 7, 26, 22, 1, 32, 233, DateTimeKind.Local).AddTicks(1575), new DateTime(2023, 7, 26, 22, 1, 32, 233, DateTimeKind.Local).AddTicks(1580), 92, 3 },
                    { 165, true, new DateTime(2023, 7, 26, 22, 1, 32, 233, DateTimeKind.Local).AddTicks(2723), new DateTime(2023, 7, 26, 22, 1, 32, 233, DateTimeKind.Local).AddTicks(2727), 93, 3 },
                    { 166, true, new DateTime(2023, 7, 26, 22, 1, 32, 233, DateTimeKind.Local).AddTicks(3797), new DateTime(2023, 7, 26, 22, 1, 32, 233, DateTimeKind.Local).AddTicks(3802), 98, 3 },
                    { 167, true, new DateTime(2023, 7, 26, 22, 1, 32, 233, DateTimeKind.Local).AddTicks(4664), new DateTime(2023, 7, 26, 22, 1, 32, 233, DateTimeKind.Local).AddTicks(4666), 95, 3 },
                    { 168, true, new DateTime(2023, 7, 26, 22, 1, 32, 233, DateTimeKind.Local).AddTicks(5640), new DateTime(2023, 7, 26, 22, 1, 32, 233, DateTimeKind.Local).AddTicks(5642), 96, 3 },
                    { 169, true, new DateTime(2023, 7, 26, 22, 1, 32, 233, DateTimeKind.Local).AddTicks(6147), new DateTime(2023, 7, 26, 22, 1, 32, 233, DateTimeKind.Local).AddTicks(6149), 58, 3 },
                    { 170, true, new DateTime(2023, 7, 26, 22, 1, 32, 233, DateTimeKind.Local).AddTicks(6995), new DateTime(2023, 7, 26, 22, 1, 32, 233, DateTimeKind.Local).AddTicks(6997), 59, 3 },
                    { 171, true, new DateTime(2023, 7, 26, 22, 1, 32, 233, DateTimeKind.Local).AddTicks(7768), new DateTime(2023, 7, 26, 22, 1, 32, 233, DateTimeKind.Local).AddTicks(7771), 60, 3 },
                    { 172, true, new DateTime(2023, 7, 26, 22, 1, 32, 233, DateTimeKind.Local).AddTicks(8625), new DateTime(2023, 7, 26, 22, 1, 32, 233, DateTimeKind.Local).AddTicks(8627), 65, 3 },
                    { 173, true, new DateTime(2023, 7, 26, 22, 1, 32, 233, DateTimeKind.Local).AddTicks(9468), new DateTime(2023, 7, 26, 22, 1, 32, 233, DateTimeKind.Local).AddTicks(9470), 62, 3 },
                    { 174, true, new DateTime(2023, 7, 26, 22, 1, 32, 234, DateTimeKind.Local).AddTicks(316), new DateTime(2023, 7, 26, 22, 1, 32, 234, DateTimeKind.Local).AddTicks(320), 63, 3 },
                    { 175, true, new DateTime(2023, 7, 26, 22, 1, 32, 234, DateTimeKind.Local).AddTicks(1190), new DateTime(2023, 7, 26, 22, 1, 32, 234, DateTimeKind.Local).AddTicks(1192), 66, 3 },
                    { 176, true, new DateTime(2023, 7, 26, 22, 1, 32, 234, DateTimeKind.Local).AddTicks(2004), new DateTime(2023, 7, 26, 22, 1, 32, 234, DateTimeKind.Local).AddTicks(2006), 67, 3 },
                    { 177, true, new DateTime(2023, 7, 26, 22, 1, 32, 234, DateTimeKind.Local).AddTicks(2887), new DateTime(2023, 7, 26, 22, 1, 32, 234, DateTimeKind.Local).AddTicks(2889), 68, 3 },
                    { 178, true, new DateTime(2023, 7, 26, 22, 1, 32, 234, DateTimeKind.Local).AddTicks(3697), new DateTime(2023, 7, 26, 22, 1, 32, 234, DateTimeKind.Local).AddTicks(3701), 69, 3 },
                    { 179, true, new DateTime(2023, 7, 26, 22, 1, 32, 234, DateTimeKind.Local).AddTicks(4590), new DateTime(2023, 7, 26, 22, 1, 32, 234, DateTimeKind.Local).AddTicks(4593), 74, 3 },
                    { 180, true, new DateTime(2023, 7, 26, 22, 1, 32, 234, DateTimeKind.Local).AddTicks(5348), new DateTime(2023, 7, 26, 22, 1, 32, 234, DateTimeKind.Local).AddTicks(5352), 71, 3 },
                    { 181, true, new DateTime(2023, 7, 26, 22, 1, 32, 234, DateTimeKind.Local).AddTicks(6190), new DateTime(2023, 7, 26, 22, 1, 32, 234, DateTimeKind.Local).AddTicks(6194), 72, 3 },
                    { 182, true, new DateTime(2023, 7, 26, 22, 1, 32, 234, DateTimeKind.Local).AddTicks(7213), new DateTime(2023, 7, 26, 22, 1, 32, 234, DateTimeKind.Local).AddTicks(7216), 83, 3 },
                    { 183, true, new DateTime(2023, 7, 26, 22, 1, 32, 234, DateTimeKind.Local).AddTicks(8127), new DateTime(2023, 7, 26, 22, 1, 32, 234, DateTimeKind.Local).AddTicks(8131), 84, 3 },
                    { 184, true, new DateTime(2023, 7, 26, 22, 1, 32, 234, DateTimeKind.Local).AddTicks(9063), new DateTime(2023, 7, 26, 22, 1, 32, 234, DateTimeKind.Local).AddTicks(9066), 85, 3 },
                    { 185, true, new DateTime(2023, 7, 26, 22, 1, 32, 235, DateTimeKind.Local).AddTicks(99), new DateTime(2023, 7, 26, 22, 1, 32, 235, DateTimeKind.Local).AddTicks(102), 90, 3 },
                    { 186, true, new DateTime(2023, 7, 26, 22, 1, 32, 235, DateTimeKind.Local).AddTicks(1283), new DateTime(2023, 7, 26, 22, 1, 32, 235, DateTimeKind.Local).AddTicks(1293), 87, 3 },
                    { 187, true, new DateTime(2023, 7, 26, 22, 1, 32, 235, DateTimeKind.Local).AddTicks(2281), new DateTime(2023, 7, 26, 22, 1, 32, 235, DateTimeKind.Local).AddTicks(2283), 88, 3 },
                    { 188, true, new DateTime(2023, 7, 26, 22, 1, 32, 235, DateTimeKind.Local).AddTicks(3071), new DateTime(2023, 7, 26, 22, 1, 32, 235, DateTimeKind.Local).AddTicks(3072), 75, 3 },
                    { 189, true, new DateTime(2023, 7, 26, 22, 1, 32, 235, DateTimeKind.Local).AddTicks(3950), new DateTime(2023, 7, 26, 22, 1, 32, 235, DateTimeKind.Local).AddTicks(3951), 76, 3 },
                    { 190, true, new DateTime(2023, 7, 26, 22, 1, 32, 235, DateTimeKind.Local).AddTicks(6821), new DateTime(2023, 7, 26, 22, 1, 32, 235, DateTimeKind.Local).AddTicks(6826), 77, 3 },
                    { 191, true, new DateTime(2023, 7, 26, 22, 1, 32, 235, DateTimeKind.Local).AddTicks(8602), new DateTime(2023, 7, 26, 22, 1, 32, 235, DateTimeKind.Local).AddTicks(8606), 82, 3 },
                    { 192, true, new DateTime(2023, 7, 26, 22, 1, 32, 235, DateTimeKind.Local).AddTicks(9468), new DateTime(2023, 7, 26, 22, 1, 32, 235, DateTimeKind.Local).AddTicks(9469), 79, 3 },
                    { 193, true, new DateTime(2023, 7, 26, 22, 1, 32, 236, DateTimeKind.Local).AddTicks(368), new DateTime(2023, 7, 26, 22, 1, 32, 236, DateTimeKind.Local).AddTicks(369), 80, 3 },
                    { 194, true, new DateTime(2023, 7, 26, 22, 1, 32, 236, DateTimeKind.Local).AddTicks(1841), new DateTime(2023, 7, 26, 22, 1, 32, 236, DateTimeKind.Local).AddTicks(1849), 99, 3 },
                    { 195, true, new DateTime(2023, 7, 26, 22, 1, 32, 249, DateTimeKind.Local).AddTicks(5258), new DateTime(2023, 7, 26, 22, 1, 32, 249, DateTimeKind.Local).AddTicks(5277), 100, 3 },
                    { 196, true, new DateTime(2023, 7, 26, 22, 1, 32, 249, DateTimeKind.Local).AddTicks(6274), new DateTime(2023, 7, 26, 22, 1, 32, 249, DateTimeKind.Local).AddTicks(6277), 101, 3 },
                    { 197, true, new DateTime(2023, 7, 26, 22, 1, 32, 249, DateTimeKind.Local).AddTicks(7257), new DateTime(2023, 7, 26, 22, 1, 32, 249, DateTimeKind.Local).AddTicks(7259), 106, 3 },
                    { 198, true, new DateTime(2023, 7, 26, 22, 1, 32, 249, DateTimeKind.Local).AddTicks(8137), new DateTime(2023, 7, 26, 22, 1, 32, 249, DateTimeKind.Local).AddTicks(8139), 103, 3 },
                    { 199, true, new DateTime(2023, 7, 26, 22, 1, 32, 249, DateTimeKind.Local).AddTicks(9080), new DateTime(2023, 7, 26, 22, 1, 32, 249, DateTimeKind.Local).AddTicks(9083), 104, 3 },
                    { 200, true, new DateTime(2023, 7, 26, 22, 1, 32, 249, DateTimeKind.Local).AddTicks(9401), new DateTime(2023, 7, 26, 22, 1, 32, 249, DateTimeKind.Local).AddTicks(9403), 33, 3 },
                    { 201, true, new DateTime(2023, 7, 26, 22, 1, 32, 250, DateTimeKind.Local).AddTicks(212), new DateTime(2023, 7, 26, 22, 1, 32, 250, DateTimeKind.Local).AddTicks(215), 92, 4 },
                    { 202, true, new DateTime(2023, 7, 26, 22, 1, 32, 250, DateTimeKind.Local).AddTicks(1236), new DateTime(2023, 7, 26, 22, 1, 32, 250, DateTimeKind.Local).AddTicks(1239), 98, 4 },
                    { 203, true, new DateTime(2023, 7, 26, 22, 1, 32, 250, DateTimeKind.Local).AddTicks(2154), new DateTime(2023, 7, 26, 22, 1, 32, 250, DateTimeKind.Local).AddTicks(2156), 96, 4 },
                    { 204, true, new DateTime(2023, 7, 26, 22, 1, 32, 250, DateTimeKind.Local).AddTicks(2674), new DateTime(2023, 7, 26, 22, 1, 32, 250, DateTimeKind.Local).AddTicks(2676), 59, 4 },
                    { 205, true, new DateTime(2023, 7, 26, 22, 1, 32, 250, DateTimeKind.Local).AddTicks(3524), new DateTime(2023, 7, 26, 22, 1, 32, 250, DateTimeKind.Local).AddTicks(3526), 65, 4 },
                    { 206, true, new DateTime(2023, 7, 26, 22, 1, 32, 250, DateTimeKind.Local).AddTicks(5982), new DateTime(2023, 7, 26, 22, 1, 32, 250, DateTimeKind.Local).AddTicks(5984), 63, 4 },
                    { 207, true, new DateTime(2023, 7, 26, 22, 1, 32, 250, DateTimeKind.Local).AddTicks(6690), new DateTime(2023, 7, 26, 22, 1, 32, 250, DateTimeKind.Local).AddTicks(6691), 66, 4 },
                    { 208, true, new DateTime(2023, 7, 26, 22, 1, 32, 250, DateTimeKind.Local).AddTicks(7390), new DateTime(2023, 7, 26, 22, 1, 32, 250, DateTimeKind.Local).AddTicks(7392), 68, 4 },
                    { 209, true, new DateTime(2023, 7, 26, 22, 1, 32, 250, DateTimeKind.Local).AddTicks(8194), new DateTime(2023, 7, 26, 22, 1, 32, 250, DateTimeKind.Local).AddTicks(8196), 74, 4 },
                    { 210, true, new DateTime(2023, 7, 26, 22, 1, 32, 250, DateTimeKind.Local).AddTicks(8941), new DateTime(2023, 7, 26, 22, 1, 32, 250, DateTimeKind.Local).AddTicks(8944), 72, 4 },
                    { 211, true, new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(297), new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(302), 84, 4 },
                    { 212, true, new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(1253), new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(1257), 90, 4 },
                    { 213, true, new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(2086), new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(2111), 88, 4 },
                    { 214, true, new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(2826), new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(2830), 76, 4 },
                    { 215, true, new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(3733), new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(3737), 82, 4 },
                    { 216, true, new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(4494), new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(4498), 80, 4 },
                    { 217, true, new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(5546), new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(5549), 100, 4 },
                    { 218, true, new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(6564), new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(6568), 106, 4 },
                    { 219, true, new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(7525), new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(7528), 104, 4 },
                    { 220, true, new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(7810), new DateTime(2023, 7, 26, 22, 1, 32, 251, DateTimeKind.Local).AddTicks(7811), 33, 4 }
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
