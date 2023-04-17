﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace app.Migrations
{
    /// <inheritdoc />
    public partial class userRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CaseStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Status = table.Column<string>(type: "TEXT", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Code = table.Column<string>(type: "TEXT", maxLength: 3, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StoreName = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    StoreCode = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransactionType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TransactionTypeName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitOfMeasure",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UnitOfMeasureName = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Isocode = table.Column<string>(type: "TEXT", maxLength: 3, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitOfMeasure", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 40, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Surname = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: true),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false),
                    StoreId = table.Column<int>(type: "INTEGER", nullable: true),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: true),
                    EmployeeTypeId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_User_EmployeeType_EmployeeTypeId",
                        column: x => x.EmployeeTypeId,
                        principalTable: "EmployeeType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_User_Store_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Store",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TransactionCode = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    StoreId = table.Column<int>(type: "INTEGER", nullable: false),
                    ToStoreId = table.Column<int>(type: "INTEGER", nullable: true),
                    TransactionTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transaction_Store_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Store",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transaction_Store_ToStoreId",
                        column: x => x.ToStoreId,
                        principalTable: "Store",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Transaction_TransactionType_TransactionTypeId",
                        column: x => x.TransactionTypeId,
                        principalTable: "TransactionType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Barcode = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Image = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: true),
                    UnitOfMeasureId = table.Column<int>(type: "INTEGER", nullable: false),
                    StatusId = table.Column<int>(type: "INTEGER", nullable: true),
                    Status = table.Column<string>(type: "TEXT", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Product_UnitOfMeasure_UnitOfMeasureId",
                        column: x => x.UnitOfMeasureId,
                        principalTable: "UnitOfMeasure",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleUser",
                columns: table => new
                {
                    RolesId = table.Column<int>(type: "INTEGER", nullable: false),
                    UsersId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => new { x.RolesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_RoleUser_Role_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUser_User_UsersId",
                        column: x => x.UsersId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StoreStock",
                columns: table => new
                {
                    StoreId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Stock = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreStock", x => new { x.StoreId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_StoreStock_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoreStock_Store_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Store",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransactionDetail",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    TransactionId = table.Column<int>(type: "INTEGER", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionDetail", x => new { x.TransactionId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_TransactionDetail_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransactionDetail_Transaction_TransactionId",
                        column: x => x.TransactionId,
                        principalTable: "Transaction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CaseStatus",
                columns: new[] { "Id", "CreateDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(8075), "CREATED" },
                    { 2, new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(8098), "REJECTED" },
                    { 3, new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(8100), "CLOSED" },
                    { 4, new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(8103), "ASSIGNED" },
                    { 5, new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(8105), "INVESTIGATING" },
                    { 6, new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(8107), "PENDING" },
                    { 7, new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(8109), "APPROVED" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryName", "CreateDate" },
                values: new object[] { 1, "Example Agency", new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(2589) });

            migrationBuilder.InsertData(
                table: "EmployeeType",
                columns: new[] { "Id", "CreateDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(8400), "Permanent" },
                    { 2, new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(8403), "Contract" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Code", "CreateDate", "Name" },
                values: new object[,]
                {
                    { 1, "POA", new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(1783), "portal-admin" },
                    { 2, "CAM", new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(1786), "client-admin" },
                    { 3, "CCR", new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(1788), "client-creator" },
                    { 4, "CAS", new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(1790), "client-assigner" },
                    { 5, "CSS", new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(1792), "client-assessor" },
                    { 6, "AAM", new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(1794), "agency-admin" },
                    { 7, "AAS", new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(1796), "agency-supervisor" },
                    { 8, "AAA", new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(1798), "agency-agent" }
                });

            migrationBuilder.InsertData(
                table: "Store",
                columns: new[] { "Id", "CreateDate", "StoreCode", "StoreName" },
                values: new object[] { 1, new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(2511), "EX01", "Example Client Company" });

            migrationBuilder.InsertData(
                table: "TransactionType",
                columns: new[] { "Id", "CreateDate", "TransactionTypeName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(1467), "Stock Receipt" },
                    { 2, new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(1521), "Stock Out" },
                    { 3, new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(1523), "Transfer" }
                });

            migrationBuilder.InsertData(
                table: "UnitOfMeasure",
                columns: new[] { "Id", "CreateDate", "Isocode", "UnitOfMeasureName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(1691), "CC", "Comprehensive" },
                    { 2, new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(1699), "NC", "Non-Comprehensive" },
                    { 3, new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(1702), "OC", "Other" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Barcode", "CategoryId", "CreateDate", "Description", "Image", "Price", "ProductName", "Status", "StatusId", "UnitOfMeasureId" },
                values: new object[] { 1, "EX01", null, new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(2663), null, null, 1m, "Example Claim case", "CREATED", 1, 1 });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Active", "CategoryId", "CreateDate", "Email", "EmployeeTypeId", "Image", "Name", "Password", "StoreId", "Surname" },
                values: new object[,]
                {
                    { 1, false, null, new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(2239), "portal-admin@admin.com", 1, null, "Portal", "827ccb0eea8a706c4c34a16891f84e7b", 1, "Admin" },
                    { 2, false, null, new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(2292), "client-admin@company.com", 1, null, "Client", "827ccb0eea8a706c4c34a16891f84e7b", 1, "Admin" },
                    { 3, false, null, new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(2312), "client-creator@company.com", 1, null, "Client", "827ccb0eea8a706c4c34a16891f84e7b", 1, "Creator" },
                    { 4, false, null, new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(2330), "client-assigner@company.com", 1, null, "Client", "827ccb0eea8a706c4c34a16891f84e7b", 1, "Assigner" },
                    { 5, false, null, new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(2348), "client-assessor@company.com", 1, null, "Client", "827ccb0eea8a706c4c34a16891f84e7b", 1, "Assessor" },
                    { 6, false, 1, new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(2365), "agency-admin@agency.com", 1, null, "Agency", "827ccb0eea8a706c4c34a16891f84e7b", null, "Admin" },
                    { 7, false, 1, new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(2383), "agency-supervisor@agency.com", 1, null, "Agency", "827ccb0eea8a706c4c34a16891f84e7b", null, "Supervisor" },
                    { 8, false, 1, new DateTime(2023, 4, 17, 21, 25, 10, 869, DateTimeKind.Local).AddTicks(2425), "agency-agent@agency.com", 1, null, "Agency", "827ccb0eea8a706c4c34a16891f84e7b", null, "Supervisor" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_UnitOfMeasureId",
                table: "Product",
                column: "UnitOfMeasureId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUser_UsersId",
                table: "RoleUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreStock_ProductId",
                table: "StoreStock",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_StoreId",
                table: "Transaction",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_ToStoreId",
                table: "Transaction",
                column: "ToStoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_TransactionTypeId",
                table: "Transaction",
                column: "TransactionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionDetail_ProductId",
                table: "TransactionDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_User_CategoryId",
                table: "User",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_EmployeeTypeId",
                table: "User",
                column: "EmployeeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_User_StoreId",
                table: "User",
                column: "StoreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaseStatus");

            migrationBuilder.DropTable(
                name: "RoleUser");

            migrationBuilder.DropTable(
                name: "StoreStock");

            migrationBuilder.DropTable(
                name: "TransactionDetail");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "EmployeeType");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "UnitOfMeasure");

            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropTable(
                name: "TransactionType");
        }
    }
}