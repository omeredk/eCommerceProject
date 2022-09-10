using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerceProject.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserRoleID = table.Column<byte>(type: "tinyint", nullable: false),
                    UserRoleName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.UserRoleID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    ProductBarcode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    BrandID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandID",
                        column: x => x.BrandID,
                        principalTable: "Brands",
                        principalColumn: "BrandID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WebUsers",
                columns: table => new
                {
                    WebUserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WebUserFullName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    WebUserEmail = table.Column<string>(type: "nvarchar(52)", maxLength: 52, nullable: false),
                    WebUserPassword = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UserRoleID = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebUsers", x => x.WebUserID);
                    table.ForeignKey(
                        name: "FK_WebUsers_UserRoles_UserRoleID",
                        column: x => x.UserRoleID,
                        principalTable: "UserRoles",
                        principalColumn: "UserRoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    CartID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    WebUserID = table.Column<int>(type: "int", nullable: false),
                    CartPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CartCount = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.CartID);
                    table.ForeignKey(
                        name: "FK_Carts_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carts_WebUsers_WebUserID",
                        column: x => x.WebUserID,
                        principalTable: "WebUsers",
                        principalColumn: "WebUserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CellPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebUserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebUserID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_WebUsers_WebUserID1",
                        column: x => x.WebUserID1,
                        principalTable: "WebUsers",
                        principalColumn: "WebUserID");
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandID", "BrandName" },
                values: new object[,]
                {
                    { 1, "H&M" },
                    { 2, "Gucci" },
                    { 3, "Prada" },
                    { 4, "Tommy Hilfiger" },
                    { 5, "Bershka" },
                    { 6, "Beymen" },
                    { 7, "Nike" },
                    { 8, "Adidas" },
                    { 9, "Puma" },
                    { 10, "Vakko" },
                    { 11, "Louis Vuitton" },
                    { 12, "Dior" },
                    { 13, "Givenchy" },
                    { 14, "Hugo Boss" },
                    { 15, "Chanel" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Shoes" },
                    { 2, "Clothing" },
                    { 3, "Accessories" },
                    { 4, "Sports" },
                    { 5, "Bags" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserRoleID", "UserRoleName" },
                values: new object[,]
                {
                    { (byte)1, "Admin" },
                    { (byte)2, "ShopOwner" },
                    { (byte)3, "Customer" },
                    { (byte)4, "Candidate" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "BrandID", "CategoryID", "ProductBarcode", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 1, 1, 1, "testbarcode", "Resolution frequently apartments off all discretion devonshire. Saw sir fat spirit seeing valley. He looked or valley lively. If learn woody spoil of taken he cause.", "Product 1", 50m },
                    { 2, 2, 3, "testbarcode", "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection an in. Mr excellence inquietude conviction is in unreserved particular.", "Product 2", 34m },
                    { 3, 3, 5, "testbarcode", "Announcing of invitation principles in. Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance.", "Product 3", 21m },
                    { 4, 4, 1, "testbarcode", "Pianoforte solicitude so decisively unpleasing conviction is partiality he. Or particular so diminution entreaties oh do.", "Product 4", 44m },
                    { 5, 5, 2, "testbarcode", "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.", "Product 5", 61m },
                    { 6, 6, 5, "testbarcode", "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.", "Product 6", 22m },
                    { 7, 7, 4, "testbarcode", "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.", "Product 7", 41m },
                    { 8, 8, 2, "testbarcode", "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.", "Product 8", 200m },
                    { 9, 9, 4, "testbarcode", "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.", "Product 9", 100m },
                    { 10, 10, 3, "testbarcode", "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.", "Product 10", 99m },
                    { 11, 11, 2, "testbarcode", "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.", "Product 11", 799m },
                    { 12, 12, 2, "testbarcode", "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.", "Product 12", 34m },
                    { 13, 13, 1, "testbarcode", "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.", "Product 13", 55m },
                    { 14, 14, 4, "testbarcode", "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.", "Product 14", 77.21m },
                    { 15, 15, 2, "testbarcode", "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.", "Product 15", 22.99m },
                    { 16, 1, 3, "testbarcode", "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.", "Product 16", 799.99m },
                    { 17, 2, 3, "testbarcode", "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.", "Product 17", 100.50m },
                    { 18, 3, 5, "testbarcode", "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.", "Product 18", 2000.50m },
                    { 19, 4, 4, "testbarcode", "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.", "Product 19", 1100.99m },
                    { 20, 5, 5, "testbarcode", "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.", "Product 20", 9999.99m }
                });

            migrationBuilder.InsertData(
                table: "WebUsers",
                columns: new[] { "WebUserID", "UserRoleID", "WebUserEmail", "WebUserFullName", "WebUserPassword" },
                values: new object[,]
                {
                    { 1, (byte)1, "omeredk@gmail.com", "admin", "deneme" },
                    { 2, (byte)2, "demo@demo.com", "shopowner", "deneme" },
                    { 3, (byte)3, "omeredk@gmail.com", "customer", "deneme" },
                    { 4, (byte)4, "omeredk@gmail.com", "demo", "deneme" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ProductID",
                table: "Carts",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_WebUserID",
                table: "Carts",
                column: "WebUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_WebUserID1",
                table: "Orders",
                column: "WebUserID1");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandID",
                table: "Products",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_WebUsers_UserRoleID",
                table: "WebUsers",
                column: "UserRoleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "WebUsers");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "UserRoles");
        }
    }
}
