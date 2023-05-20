using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class _10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "AcquisitionCost",
                table: "Vaccines",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(262), new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(270), new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(273), new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(275), new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(277), new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(282), new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(283) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(284), new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(285) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 18, 22, 42, 850, DateTimeKind.Local).AddTicks(9986), new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(5) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(18), new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(20), new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(23), new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(25), new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(26) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(32), new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(34), new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(37), new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(38) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(39), new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(40) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(44), new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(46), new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(46) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(360), new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(361) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(367), new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(369), new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(372), new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(373) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(374), new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(461), new DateTime(2023, 5, 19, 18, 22, 42, 851, DateTimeKind.Local).AddTicks(463) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcquisitionCost",
                table: "Vaccines");

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

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6736), new DateTime(2023, 5, 19, 13, 23, 43, 667, DateTimeKind.Local).AddTicks(6736) });

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
        }
    }
}
