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
                name: "IncomeExpenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOperation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeExpenses", x => x.Id);
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
                    NetContent = table.Column<float>(type: "real", nullable: false),
                    Unities = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<float>(type: "real", nullable: false),
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
                    { 1, true, new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8095), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8096), "Create" },
                    { 2, true, new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8098), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8098), "Read" },
                    { 3, true, new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8099), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8099), "Update" },
                    { 4, true, new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8100), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8100), "Delete" },
                    { 5, true, new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8101), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8101), "ToggleActive" },
                    { 6, true, new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8103), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8103), "GetById" },
                    { 7, true, new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8104), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8104), "DeleteAll" }
                });

            migrationBuilder.InsertData(
                table: "Controllers",
                columns: new[] { "Id", "Active", "CreationDate", "ModificationDate", "Name" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7888), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7900), "Action" },
                    { 2, true, new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7909), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7909), "Controller" },
                    { 3, true, new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7910), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7910), "Permission" },
                    { 4, true, new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7911), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7911), "User" },
                    { 5, true, new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7912), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7912), "PermissionRole" },
                    { 6, true, new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7914), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7915), "Role" },
                    { 7, true, new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7915), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7916), "RoleUser" },
                    { 8, true, new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7916), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7917), "Sheep" },
                    { 9, true, new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7917), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7917), "Vaccine" },
                    { 10, true, new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7919), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7919), "VaccineSheep" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Active", "CreationDate", "ModificationDate", "Name" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8134), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8135), "SuperAdmin" },
                    { 2, true, new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8137), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8138), "Admin" },
                    { 3, true, new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8138), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8139), "User" },
                    { 4, true, new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8139), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8140), "Invited" },
                    { 5, true, new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8140), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8141), "Custom" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "BirthDate", "CreationDate", "Email", "LastName", "ModificationDate", "Name", "Password", "PhoneNumber" },
                values: new object[] { 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8174), "sa@gmail.com", "sa", new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8175), "sa", "sa", "9919596720" });

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
                name: "IX_VaccinesSheeps_SheepId",
                table: "VaccinesSheeps",
                column: "SheepId");

            migrationBuilder.CreateIndex(
                name: "IX_VaccinesSheeps_VaccineId",
                table: "VaccinesSheeps",
                column: "VaccineId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IncomeExpenses");

            migrationBuilder.DropTable(
                name: "PermissionsRoles");

            migrationBuilder.DropTable(
                name: "RolesUsers");

            migrationBuilder.DropTable(
                name: "VaccinesSheeps");

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
