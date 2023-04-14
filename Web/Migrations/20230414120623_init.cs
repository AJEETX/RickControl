using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace app.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 12, 6, 23, 364, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 12, 6, 23, 364, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 12, 6, 23, 364, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 12, 6, 23, 364, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 12, 6, 23, 364, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 12, 6, 23, 364, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 12, 6, 23, 364, DateTimeKind.Local).AddTicks(7903));

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 12, 6, 23, 364, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 12, 6, 23, 364, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 12, 6, 23, 363, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 12, 6, 23, 363, DateTimeKind.Local).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 12, 6, 23, 363, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 12, 6, 23, 363, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 12, 6, 23, 363, DateTimeKind.Local).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 12, 6, 23, 363, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 12, 6, 23, 363, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 12, 6, 23, 363, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 12, 6, 23, 363, DateTimeKind.Local).AddTicks(7934));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 9, 0, 57, 58, 162, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 4, 9, 0, 57, 58, 162, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 4, 9, 0, 57, 58, 162, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 4, 9, 0, 57, 58, 162, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 4, 9, 0, 57, 58, 162, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 4, 9, 0, 57, 58, 162, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 4, 9, 0, 57, 58, 162, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 9, 0, 57, 58, 162, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 4, 9, 0, 57, 58, 162, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 9, 0, 57, 58, 161, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 9, 0, 57, 58, 161, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 9, 0, 57, 58, 161, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 4, 9, 0, 57, 58, 161, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 4, 9, 0, 57, 58, 161, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 9, 0, 57, 58, 161, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 4, 9, 0, 57, 58, 161, DateTimeKind.Local).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 4, 9, 0, 57, 58, 161, DateTimeKind.Local).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 9, 0, 57, 58, 161, DateTimeKind.Local).AddTicks(8839));
        }
    }
}
