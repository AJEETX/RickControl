using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace app.Migrations
{
    /// <inheritdoc />
    public partial class newinit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Case",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 10, 32, 52, 501, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "Case",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 10, 32, 52, 501, DateTimeKind.Local).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "Case",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 10, 32, 52, 501, DateTimeKind.Local).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "Case",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 10, 32, 52, 501, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Case",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 10, 32, 52, 501, DateTimeKind.Local).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "Case",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 10, 32, 52, 501, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "Case",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 10, 32, 52, 501, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 10, 32, 52, 501, DateTimeKind.Local).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 10, 32, 52, 501, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 10, 32, 52, 501, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 10, 32, 52, 501, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 10, 32, 52, 501, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 10, 32, 52, 501, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 10, 32, 52, 501, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 10, 32, 52, 501, DateTimeKind.Local).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EmployeeType" },
                values: new object[] { new DateTime(2023, 4, 8, 10, 32, 52, 501, DateTimeKind.Local).AddTicks(5569), 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Case",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 0, 58, 46, 689, DateTimeKind.Local).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "Case",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 0, 58, 46, 689, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "Case",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 0, 58, 46, 689, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Case",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 0, 58, 46, 689, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Case",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 0, 58, 46, 689, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "Case",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 0, 58, 46, 689, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Case",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 0, 58, 46, 689, DateTimeKind.Local).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 0, 58, 46, 689, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 0, 58, 46, 689, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 0, 58, 46, 689, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 0, 58, 46, 689, DateTimeKind.Local).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 0, 58, 46, 689, DateTimeKind.Local).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 0, 58, 46, 689, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 0, 58, 46, 689, DateTimeKind.Local).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 4, 8, 0, 58, 46, 689, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EmployeeType" },
                values: new object[] { new DateTime(2023, 4, 8, 0, 58, 46, 689, DateTimeKind.Local).AddTicks(6942), null });
        }
    }
}
