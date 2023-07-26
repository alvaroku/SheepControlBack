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
            migrationBuilder.DropColumn(
                name: "DifferenceWithPreviousWeight",
                table: "SheepHistoricWeights");

            migrationBuilder.DropColumn(
                name: "PreviousWeight",
                table: "SheepHistoricWeights");

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1665), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1669), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1670), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1671), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1672), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1674), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1674) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1675), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1676), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1676), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1677) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1475), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1486) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1492), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1492) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1493), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1493) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1493), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1494) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1535), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1535) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1538), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1539) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1539), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1540), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1541), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1543), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1544), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1545), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1546), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1705), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1713), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1714) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1715), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1715) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1716), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1718), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1718) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1721), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1722), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1724), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1727), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1730), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1732), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1734), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1734) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1735), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1735) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1737), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1738), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1739) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1740), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1742), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1744), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1744) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1745), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1772), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1773) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1774), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1776), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1777), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1778), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1780), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1782), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1784), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1785), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1785) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1786), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1787) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1788), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1789), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1791), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1793), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1793) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1795), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1796) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1797), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1798), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1800), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1800) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1801), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1802) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1803), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1804), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1805) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1806), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1807) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1808), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1808) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1809), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1809) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1811), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1812), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1812) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1814), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1815), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1815) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1816), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1817) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1843), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1845), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1846) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1847), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1847) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1848), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1848) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1850), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1851), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1852), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1854), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1854) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1856), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1857), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1859), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1859) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1860), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1862), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1862) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1863), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1864), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1866), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1868), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1901), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1901) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1902), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1904), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1904) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1905), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1906) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1907), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1907) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1908), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1910), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1911), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1937), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1938), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1940), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1941), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1943), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1944), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1946), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1947), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1948) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1949), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1951), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1951) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1952), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1953), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1955), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1956), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1958), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1959), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1961), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1963), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1964), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1965), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1967), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1968), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1970), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1970) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1971), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1971) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1973), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1973) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1975), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1976), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1976) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1978), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1978) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1979), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(1979) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2003), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2004) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2005), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2005) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2007), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2007) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2078), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2090), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2092), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2094), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2095) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2096), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2097) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2099), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2101), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2101) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2103), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2105), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2107), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2108) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2109), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2111), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2113), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2115), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2115) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2117), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2117) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2118), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2120), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2123), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2123) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2125), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2125) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2127), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2127) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2128), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2130), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2132), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2134), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2134) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2161), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2163), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2166), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2168), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2169), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2170) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2171), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2173), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2175), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2177), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2180), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2181), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2183), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2185), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2187), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2189), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2191), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2192), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2194), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2196), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2198), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2200), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2201), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2203), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2205), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2207), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2209), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2211), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2213), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2213) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2215), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2217), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2218), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2220), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2222), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2224), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2224) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2226), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2227), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2229), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2231), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2233), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2235), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2236), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2239), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2241), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2243), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2245), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2247), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2249), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2249) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2250), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2251) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2277), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2279), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2281), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2283), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2285), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2287), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2287) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2289), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2290), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2292), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2293) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2294), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2296), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2298), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2299), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2301), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2302) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2303), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2304) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2305), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2305) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2307), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2307) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2309), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2309) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2310), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2312), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2312) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2314), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2316), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2318), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2318) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2319), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2321), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2321) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2323), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2325), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2327), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2328), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2329) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2330), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2332), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2334), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2336), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2615), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2616) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2921), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2921) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(3220), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(3221) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(3514), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(3825), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(3825) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(4122), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(4123) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(4418), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(4419) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(4715), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(4715) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(4898), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(4899) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(5155), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(5402), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(5654), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(5914), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(6200), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(6440), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(6441) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(6694), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(6694) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(6966), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(6966) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(7087), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(7270), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(7476), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(7661), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(7855), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(7855) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(8048), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(8220), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(8414), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(8415) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(8685), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(8940), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(9222), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(9480), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(9750), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(9751) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(16), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(268), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(526), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(818), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(1097), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(1379), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(1668), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(1965), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(2252), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(2252) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(2527), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(2528) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(2810), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(3047), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(3310), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(3581), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(3899), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(4181), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(4464), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(4465) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(4723), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(5009), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(5715), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(5715) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(6021), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(6021) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(6333), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(6918), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(7384), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(7701), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(7991), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(8297), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(8298) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(8562), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(8563) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(8859), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(9174), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(9504), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(9505) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(9785), new DateTime(2023, 7, 25, 22, 28, 10, 830, DateTimeKind.Local).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(79), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(226), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(226) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(473), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(473) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(747), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(1016), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(1254), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(1254) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(1512), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(1512) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(1795), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(1795) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(2046), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(2303), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(2304) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(2560), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(2842), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(3091), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(3353), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(3650), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(3927), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(3927) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(4227), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(4527), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(4528) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(4805), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(5086), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(5321), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(5597), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(5598) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(5868), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(6157), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(6157) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(6414), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(6687), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(6687) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(7026), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(7332), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(7333) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(7640), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(7641) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(7976), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(7976) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(8270), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(8270) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(8607), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(8607) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(8873), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(9200), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(9201) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(9484), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(9630), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(9631) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(9929), new DateTime(2023, 7, 25, 22, 28, 10, 831, DateTimeKind.Local).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(173), new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(173) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(444), new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(691), new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(971), new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(1222), new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(1222) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(1519), new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(1519) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(1826), new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(2110), new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(2349), new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(2634), new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(2894), new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(3253), new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(3578), new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(3876), new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(3876) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2052), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2055), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2055) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2056), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2057), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2057) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2058), new DateTime(2023, 7, 25, 22, 28, 10, 829, DateTimeKind.Local).AddTicks(2058) });

            migrationBuilder.UpdateData(
                table: "RolesUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(4059), new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(4059) });

            migrationBuilder.UpdateData(
                table: "RolesUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(4099), new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(4099) });

            migrationBuilder.UpdateData(
                table: "RolesUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(4104), new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "RolesUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(4108), new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(4109) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(4023), new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(4023) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(4037), new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(4047), new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(4055), new DateTime(2023, 7, 25, 22, 28, 10, 832, DateTimeKind.Local).AddTicks(4056) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "DifferenceWithPreviousWeight",
                table: "SheepHistoricWeights",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PreviousWeight",
                table: "SheepHistoricWeights",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4018), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4019) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4024), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4025), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4026) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4027), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4027) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4028), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4031), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4031) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4032), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4033) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4033), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4035), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4035) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3802), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3822), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3823) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3824), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3824) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3825), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3826) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3827), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3828) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3833), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3834) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3834), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3835) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3836), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3837), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3837) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3840), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3841), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3841) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3842), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3844), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4084), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4084) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4098), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4098) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4100), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4101) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4146), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4146) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4149), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4153), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4154) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4156), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4157) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4159), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4163), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4164) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4168), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4171), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4173), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4174) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4176), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4179), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4182), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4185), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4188), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4192), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4195), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4195) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4198), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4198) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4200), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4203), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4206), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4209), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4213), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4215), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4216) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4218), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4221), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4221) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4224), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4224) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4226), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4229), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4282), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4287), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4287) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4291), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4292) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4294), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4294) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4297), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4299), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4302), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4305), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4308), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4308) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4311), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4314), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4314) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4316), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4317) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4319), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4322), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4325), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4327), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4328) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4330), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4333), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4334) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4336), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4337) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4339), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4341), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4344), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4344) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4347), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4347) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4349), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4352), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4355), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4358), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4358) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4360), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4362), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4400), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4401) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4404), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4407), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4407) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4409), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4413), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4414) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4453), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4456), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4456) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4467), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4468) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4469), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4472), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4474), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4474) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4476), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4479), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4479) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4482), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4484), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4485) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4487), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4487) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4489), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4492), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4492) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4494), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4494) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4496), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4497) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4499), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4502), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4502) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4504), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4504) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4507), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4507) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4543), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4546), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4547) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4549), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4551), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4552) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4554), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4554) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4557), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4557) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4560), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4560) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4562), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4565), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4565) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4567), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4570), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4572), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4575), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4575) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4578), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4581), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4584), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4584) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4586), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4587) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4589), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4592), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4595), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4595) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4598), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4598) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4806), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4807) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4825), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4825) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4829), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4832), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4836), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4840), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4844), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4847), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4848) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4851), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4851) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4855), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4858), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4862), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4862) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4865), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4866) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4869), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4869) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4872), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4872) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4875), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4876) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4879), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4879) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4883), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4884) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4887), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4887) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4890), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4893), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4894) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4896), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4897) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4900), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4903), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4903) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4906), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4907) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4909), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4913), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4916), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4916) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4919), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4922), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4923) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4926), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4929), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4932), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4933) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4937), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4940), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4944), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4944) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4947), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4950), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4951) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4954), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4954) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4957), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4957) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4960), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4961) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4963), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4964) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4967), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4967) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5033), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5033) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5037), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5037) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5040), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5041) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5044), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5044) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5047), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5048) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5051), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5051) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5054), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5054) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5057), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5060), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5061) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5064), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5067), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5070), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5073), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5076), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5077) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5080), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5083), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5083) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5086), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5087) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5090), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5093), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5096), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5100), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5103), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5108), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5108) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5111), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5112) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5114), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5118), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5118) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5121), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5121) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5124), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5125) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5128), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5128) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5131), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5134), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5135) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5138), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5141), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5141) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5144), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5145) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5148), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5148) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5151), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5151) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5154), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5155) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5157), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5158) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5161), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5164), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5167), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5170), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5173), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5176), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5179), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5182), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5182) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5185), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5185) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5188), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5188) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5191), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5192) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5194), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5195) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5197), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5198) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5201), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5201) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5204), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5204) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5264), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5268), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5271), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5274), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5274) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5277), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5280), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5283), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5283) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5286), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5289), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5289) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5786), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(5787) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(6369), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(6946), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(6947) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(7515), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(8102), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(8102) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(8643), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(8643) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(9186), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(9738), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(45), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(45) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(496), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(943), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(943) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(1419), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(1901), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(2437), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(2437) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(2897), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(2898) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(3385), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(3902), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(4182), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(4532), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(4532) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(4900), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(5273), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(5274) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(5660), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(6037), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(6366), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(6367) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(6754), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(7296), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(7768), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(7768) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(8265), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(8266) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(8732), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(9239), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(9740), new DateTime(2023, 7, 22, 0, 12, 52, 90, DateTimeKind.Local).AddTicks(9741) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(246), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(246) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(759), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(760) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(1350), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(1351) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(1888), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(2487), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(3008), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(3009) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(3582), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(4124), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(4621), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(5165), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(5165) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(5603), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(5603) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(6095), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(6603), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(6604) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(7618), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(8162), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(8667), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(8667) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(9196), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(9197) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(9886), new DateTime(2023, 7, 22, 0, 12, 52, 91, DateTimeKind.Local).AddTicks(9886) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(460), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(1044), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(1636), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(2246), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(2846), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(2846) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(3400), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(3963), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(3964) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(4434), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(4965), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(5483), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(5484) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(6055), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(6567), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(6567) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(7096), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(7416), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(7416) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(7853), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(8313), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(8801), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(9221), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(9676), new DateTime(2023, 7, 22, 0, 12, 52, 92, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(183), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(631), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(632) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(1091), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(1565), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(2063), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(2514), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(2989), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(3506), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(3507) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(4061), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(4061) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(4618), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(5200), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(5201) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(5727), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(6265), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(6695), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(6695) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(7202), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(7710), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(8250), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(8736), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(9243), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(9244) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(9844), new DateTime(2023, 7, 22, 0, 12, 52, 93, DateTimeKind.Local).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(381), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(382) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(944), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(945) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(1538), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(1539) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(2059), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(2059) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(2643), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(3151), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(3752), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(3753) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(4270), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(4590), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(5076), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(5077) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(5525), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(6009), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(6472), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(6473) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(7034), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(7494), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(7495) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(8052), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(8617), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(9132), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(9615), new DateTime(2023, 7, 22, 0, 12, 52, 94, DateTimeKind.Local).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(189), new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(189) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(708), new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(1372), new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2006), new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2007) });

            migrationBuilder.UpdateData(
                table: "PermissionsRoles",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2506), new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4753), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4755) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4760), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4762), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4762) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4763), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4764) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4764), new DateTime(2023, 7, 22, 0, 12, 52, 89, DateTimeKind.Local).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "RolesUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2858), new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "RolesUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2867), new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2868) });

            migrationBuilder.UpdateData(
                table: "RolesUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2871), new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "RolesUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2876), new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2812), new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2813) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2834), new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2844), new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2845) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2853), new DateTime(2023, 7, 22, 0, 12, 52, 95, DateTimeKind.Local).AddTicks(2854) });
        }
    }
}
