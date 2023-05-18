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
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Vaccines",
                newName: "Observations");

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6735), new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6736) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6739), new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6740), new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6741) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6741), new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6742) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6742), new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6742) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6744), new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6745), new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6598), new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6615), new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6615) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6616), new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6617), new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6617) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6618), new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6622), new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6623), new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6624), new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6624) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6625), new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6626), new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6627) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6775), new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6778), new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6779) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6780), new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6780), new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6781), new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6866), new DateTime(2023, 5, 18, 10, 58, 4, 874, DateTimeKind.Local).AddTicks(6867) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Observations",
                table: "Vaccines",
                newName: "Description");

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4480), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4490), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4492), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4493) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4494), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4494) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4496), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4497) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4500), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4501), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4502) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4213), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4228) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4237), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4239), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4239) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4240), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4242), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4242) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4248), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4249) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4250), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4251), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4252) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4253), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4253) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4256), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4546), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4547) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4552), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4552) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4554), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4554) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4555), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4557), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4558) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4765), new DateTime(2023, 5, 17, 11, 52, 42, 937, DateTimeKind.Local).AddTicks(4766) });
        }
    }
}
