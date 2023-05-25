using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class _002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "WeighingDayWeight",
                table: "VaccinesSheeps",
                type: "real",
                nullable: false,
                defaultValue: 0f);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WeighingDayWeight",
                table: "VaccinesSheeps");

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9886), new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9890), new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9891), new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9892), new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9893), new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9895), new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9895), new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9896), new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9897) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9897), new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9897) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9757), new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9768) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9773), new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9774), new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9775), new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9776), new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9778), new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9779), new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9780), new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9781), new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9781) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9783), new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9783), new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9784), new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9785) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9922), new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9923) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9925), new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9926), new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9927), new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9928), new DateTime(2023, 5, 23, 22, 30, 24, 277, DateTimeKind.Local).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 30, 24, 278, DateTimeKind.Local).AddTicks(13), new DateTime(2023, 5, 23, 22, 30, 24, 278, DateTimeKind.Local).AddTicks(14) });
        }
    }
}
