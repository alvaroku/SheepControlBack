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
                    { 1, true, new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4087), new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4088), "Create" },
                    { 2, true, new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4091), new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4091), "Read" },
                    { 3, true, new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4092), new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4092), "Update" },
                    { 4, true, new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4093), new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4093), "Delete" },
                    { 5, true, new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4094), new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4094), "ToggleActive" },
                    { 6, true, new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4095), new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4096), "GetById" },
                    { 7, true, new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4096), new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4097), "DeleteAll" },
                    { 8, true, new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4097), new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4097), "GetWithFilters" },
                    { 9, true, new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4098), new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4098), "GetSheepWithFinalWeight" }
                });

            migrationBuilder.InsertData(
                table: "Controllers",
                columns: new[] { "Id", "Active", "CreationDate", "ModificationDate", "Name" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(3945), new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(3954), "Action" },
                    { 2, true, new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(3959), new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(3959), "Controller" },
                    { 3, true, new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(3960), new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(3960), "Permission" },
                    { 4, true, new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(3960), new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(3961), "User" },
                    { 5, true, new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(3961), new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(3962), "PermissionRole" },
                    { 6, true, new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(3965), new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(3965), "Role" },
                    { 7, true, new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(3966), new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(3966), "RoleUser" },
                    { 8, true, new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(3967), new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(3967), "Sheep" },
                    { 9, true, new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(3968), new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(3968), "Vaccine" },
                    { 10, true, new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(3970), new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(3970), "VaccineStock" },
                    { 11, true, new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(3970), new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(3971), "VaccineSheep" },
                    { 12, true, new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(3971), new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(3972), "SaleSheep" },
                    { 13, true, new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(3972), new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(3972), "SheepHistoricWeight" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Active", "CreationDate", "ModificationDate", "Name" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4188), new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4188), "SuperAdmin" },
                    { 2, true, new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4191), new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4191), "Admin" },
                    { 3, true, new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4192), new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4192), "User" },
                    { 4, true, new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4193), new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4193), "Invited" },
                    { 5, true, new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4194), new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4194), "Custom" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "BirthDate", "CreationDate", "Email", "LastName", "ModificationDate", "Name", "Password", "PhoneNumber" },
                values: new object[] { 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4231), "sa@gmail.com", "sa", new DateTime(2023, 6, 4, 18, 25, 21, 425, DateTimeKind.Local).AddTicks(4231), "sa", "sa", "9919596720" });

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
