using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EnterPrice_E_Commerece_System.Migrations
{
    /// <inheritdoc />
    public partial class InventoryModuleMigartion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierID);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    ProductVariantId = table.Column<int>(type: "int", nullable: false),
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    QuantityAvailable = table.Column<int>(type: "int", nullable: false),
                    ReorderLevel = table.Column<int>(type: "int", nullable: true, defaultValue: 10)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => new { x.ProductVariantId, x.WarehouseId });
                    table.ForeignKey(
                        name: "FK_Ineventory_ProductVarient",
                        column: x => x.ProductVariantId,
                        principalTable: "ProductVariants",
                        principalColumn: "ProductVariantID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Warehouse_Inventory",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandID", "LogoUrl", "Name" },
                values: new object[,]
                {
                    { 1, "/images/brands/samsung.png", "Samsung" },
                    { 2, "/images/brands/apple.png", "Apple" },
                    { 3, "/images/brands/dell.png", "Dell" },
                    { 4, "/images/brands/hp.png", "HP" },
                    { 5, "/images/brands/nike.png", "Nike" },
                    { 6, "/images/brands/adidas.png", "Adidas" },
                    { 7, "/images/brands/lg.png", "LG" },
                    { 8, "/images/brands/zara.png", "Zara" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Description", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { 1, "Modern devices and technologies", "Electronics", null },
                    { 4, "Clothing for all ages", "Fashion & Clothing", null },
                    { 7, "Refrigerators, washing machines, and TVs", "Home Appliances", null },
                    { 8, "Novels, engineering, and computer science", "Books & Publications", null }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "ID", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "5th Settlement, Industrial Zone", "Main Warehouse - Cairo" },
                    { 2, "Nasr City, Makram Ebeid Ext.", "Logistics Center - Cairo" },
                    { 3, "Zagazig, Belbeis Road", "Sharqia Distribution Center" },
                    { 4, "Borg El Arab", "Alexandria Warehouse" },
                    { 5, "Mansoura", "Delta Warehouse" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Description", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { 2, "Latest smartphones and tablets", "Mobiles & Tablets", 1 },
                    { 3, "Computers and hardware equipment", "Laptops & Computers", 1 },
                    { 5, "T-shirts, shirts, and pants", "Men's Clothing", 4 },
                    { 6, "Gym equipment and sports apparel", "Sports Equipment", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_ProductVariantId",
                table: "Inventories",
                column: "ProductVariantId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_WarehouseId",
                table: "Inventories",
                column: "WarehouseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4);

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Brands",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
