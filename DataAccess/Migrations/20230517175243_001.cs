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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    { 1, true, new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4480), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4482), "Create" },
                    { 2, true, new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4490), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4490), "Read" },
                    { 3, true, new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4492), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4493), "Update" },
                    { 4, true, new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4494), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4494), "Delete" },
                    { 5, true, new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4496), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4497), "ToggleActive" },
                    { 6, true, new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4500), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4500), "GetById" },
                    { 7, true, new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4501), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4502), "DeleteAll" }
                });

            migrationBuilder.InsertData(
                table: "Controllers",
                columns: new[] { "Id", "Active", "CreationDate", "ModificationDate", "Name" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4213), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4228), "Action" },
                    { 2, true, new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4237), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4237), "Controller" },
                    { 3, true, new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4239), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4239), "Permission" },
                    { 4, true, new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4240), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4241), "User" },
                    { 5, true, new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4242), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4242), "PermissionRole" },
                    { 6, true, new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4248), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4249), "Role" },
                    { 7, true, new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4250), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4250), "RoleUser" },
                    { 8, true, new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4251), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4252), "Sheep" },
                    { 9, true, new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4253), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4253), "Vaccine" },
                    { 10, true, new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4256), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4256), "VaccineSheep" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Active", "CreationDate", "ModificationDate", "Name" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4546), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4547), "SuperAdmin" },
                    { 2, true, new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4552), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4552), "Admin" },
                    { 3, true, new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4554), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4554), "User" },
                    { 4, true, new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4555), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4556), "Invited" },
                    { 5, true, new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4557), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4558), "Custom" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "BirthDate", "CreationDate", "Email", "LastName", "ModificationDate", "Name", "Password", "PhoneNumber" },
                values: new object[] { 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4765), "sa@gmail.com", "sa", new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4766), "sa", "sa", "9919596720" });

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
