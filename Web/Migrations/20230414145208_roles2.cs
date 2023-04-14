using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace app.Migrations
{
    /// <inheritdoc />
    public partial class roles2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 52, 8, 648, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 52, 8, 648, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 52, 8, 648, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 52, 8, 648, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 52, 8, 648, DateTimeKind.Local).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 52, 8, 648, DateTimeKind.Local).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 52, 8, 648, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 52, 8, 648, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 52, 8, 648, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 52, 8, 648, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "CreateDate" },
                values: new object[] { "PAM", new DateTime(2023, 4, 14, 14, 52, 8, 648, DateTimeKind.Local).AddTicks(727) });

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 52, 8, 648, DateTimeKind.Local).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 52, 8, 648, DateTimeKind.Local).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 52, 8, 648, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 52, 8, 648, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 52, 8, 648, DateTimeKind.Local).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 52, 8, 648, DateTimeKind.Local).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 52, 8, 648, DateTimeKind.Local).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 52, 8, 648, DateTimeKind.Local).AddTicks(1516));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 42, 41, 98, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 42, 41, 98, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 42, 41, 98, DateTimeKind.Local).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 42, 41, 98, DateTimeKind.Local).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 42, 41, 98, DateTimeKind.Local).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 42, 41, 98, DateTimeKind.Local).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 42, 41, 98, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 42, 41, 98, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 42, 41, 98, DateTimeKind.Local).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 42, 41, 97, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "CreateDate" },
                values: new object[] { "PORTAL-ADMIN", new DateTime(2023, 4, 14, 14, 42, 41, 97, DateTimeKind.Local).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 42, 41, 97, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 42, 41, 97, DateTimeKind.Local).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 42, 41, 97, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 42, 41, 97, DateTimeKind.Local).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 42, 41, 97, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 42, 41, 97, DateTimeKind.Local).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 42, 41, 97, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 14, 42, 41, 97, DateTimeKind.Local).AddTicks(5126));
        }
    }
}
