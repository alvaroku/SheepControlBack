using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class _003 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IncomeExpenses");

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

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6856), new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6859), new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6860), new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6861), new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6862), new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6864), new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6864) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6865), new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6703), new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6724), new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6725) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6725), new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6726) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6726), new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6727) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6727), new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6727) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6730), new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6731), new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6732), new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6733) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6733), new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6735), new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6735) });

            migrationBuilder.InsertData(
                table: "Controllers",
                columns: new[] { "Id", "Active", "CreationDate", "ModificationDate", "Name" },
                values: new object[] { 11, true, new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6736), new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6736), "SaleSheep" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6898), new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6899) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6902), new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6903), new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6904) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6905), new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6906), new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6906) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6953), new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6954) });

            migrationBuilder.CreateIndex(
                name: "IX_SaleSheeps_SheepId",
                table: "SaleSheeps",
                column: "SheepId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaleSheeps");

            migrationBuilder.DeleteData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.CreateTable(
                name: "IncomeExpenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOperation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeExpenses", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(6041), new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(6045), new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(6046), new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(6047), new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(6048), new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(6049), new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(6050), new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(5901), new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(5912) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(5917), new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(5918), new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(5919), new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(5920), new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(5922), new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(5923), new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(5924), new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(5925), new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(5927), new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(6073), new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(6076), new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(6077), new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(6078), new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(6078) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(6079), new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(6107), new DateTime(2023, 5, 19, 11, 49, 2, 378, DateTimeKind.Local).AddTicks(6107) });
        }
    }
}
