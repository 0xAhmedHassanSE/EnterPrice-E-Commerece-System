using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnterPrice_E_Commerece_System.Migrations
{
    /// <inheritdoc />
    public partial class FixingBugs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_ProductVariants_ProductVariantID",
                table: "CartItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_FK_ProductBrand",
                table: "Products");

            migrationBuilder.DropTable(
                name: "RoleUser");

            migrationBuilder.DropIndex(
                name: "IX_Products_FK_ProductBrand",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_CartItem_ProductVariantID",
                table: "CartItem");

            migrationBuilder.DropColumn(
                name: "FK_ProductBrand",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductVariantID",
                table: "CartItem");

            migrationBuilder.RenameColumn(
                name: "USerID",
                table: "Users",
                newName: "UserID");

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.RoleId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserId",
                table: "UserRole",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_ProductVariants_ProudctVariantID",
                table: "CartItem",
                column: "ProudctVariantID",
                principalTable: "ProductVariants",
                principalColumn: "ProductVariantID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_BrandID",
                table: "Products",
                column: "BrandID",
                principalTable: "Brands",
                principalColumn: "BrandID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_ProductVariants_ProudctVariantID",
                table: "CartItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_BrandID",
                table: "Products");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Users",
                newName: "USerID");

            migrationBuilder.AddColumn<int>(
                name: "FK_ProductBrand",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductVariantID",
                table: "CartItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "RoleUser",
                columns: table => new
                {
                    RolesId = table.Column<int>(type: "int", nullable: false),
                    UsersUSerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => new { x.RolesId, x.UsersUSerID });
                    table.ForeignKey(
                        name: "FK_RoleUser_Role_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUser_Users_UsersUSerID",
                        column: x => x.UsersUSerID,
                        principalTable: "Users",
                        principalColumn: "USerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_FK_ProductBrand",
                table: "Products",
                column: "FK_ProductBrand");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_ProductVariantID",
                table: "CartItem",
                column: "ProductVariantID");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUser_UsersUSerID",
                table: "RoleUser",
                column: "UsersUSerID");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_ProductVariants_ProductVariantID",
                table: "CartItem",
                column: "ProductVariantID",
                principalTable: "ProductVariants",
                principalColumn: "ProductVariantID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_FK_ProductBrand",
                table: "Products",
                column: "FK_ProductBrand",
                principalTable: "Brands",
                principalColumn: "BrandID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
