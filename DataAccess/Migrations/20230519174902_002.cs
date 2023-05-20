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
            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "IncomeExpenses",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "IncomeExpenses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8095), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8096) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8098), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8098) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8099), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8100), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8101), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8101) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8103), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8103) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8104), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7888), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7909), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7910), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7911), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7912), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7914), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7915), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7916) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7916), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7917), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7919), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8134), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8137), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8138) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8138), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8139) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8139), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8140), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8141) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8174), new DateTime(2023, 5, 19, 9, 31, 1, 110, DateTimeKind.Local).AddTicks(8175) });
        }
    }
}
