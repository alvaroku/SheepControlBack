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
            migrationBuilder.RenameColumn(
                name: "WeighingDayWeight",
                table: "VaccinesSheeps",
                newName: "WeightVaccinationDay");

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8128), new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8133), new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8134) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8135), new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8136), new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8137) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8138), new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8139) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8141), new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8143), new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8144) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8145), new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8147), new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8147) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(7932), new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(7955), new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(7956) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(7957), new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(7959), new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(7960), new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(7966), new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(7967), new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(7969), new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(7971), new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(7971) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(7974), new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(7974) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(7975), new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(7976) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(7977), new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(7978) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8190), new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8191) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8195), new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8196) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8197), new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8198) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8199), new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8199) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8200), new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8251), new DateTime(2023, 5, 25, 8, 27, 11, 90, DateTimeKind.Local).AddTicks(8252) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WeightVaccinationDay",
                table: "VaccinesSheeps",
                newName: "WeighingDayWeight");

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3442), new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3444), new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3445), new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3446), new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3447), new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3448), new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3449), new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3450), new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3451), new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3331), new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3344), new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3345), new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3346), new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3346) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3347), new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3349), new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3350), new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3374), new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3375), new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3376), new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3377), new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3378), new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3476), new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3479), new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3479), new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3480), new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3481), new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3505), new DateTime(2023, 5, 24, 15, 9, 27, 543, DateTimeKind.Local).AddTicks(3505) });
        }
    }
}
