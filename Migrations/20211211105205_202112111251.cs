using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeApp.Migrations
{
    public partial class _202112111251 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryItems_Categories_CategoryId",
                table: "InventoryItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InventoryItems",
                table: "InventoryItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.EnsureSchema(
                name: "Home");

            migrationBuilder.RenameTable(
                name: "InventoryItems",
                newName: "InventoryItem",
                newSchema: "Home");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category",
                newSchema: "Home");

            migrationBuilder.RenameIndex(
                name: "IX_InventoryItems_CategoryId",
                schema: "Home",
                table: "InventoryItem",
                newName: "IX_InventoryItem_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InventoryItem",
                schema: "Home",
                table: "InventoryItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                schema: "Home",
                table: "Category",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryItem_Category_CategoryId",
                schema: "Home",
                table: "InventoryItem",
                column: "CategoryId",
                principalSchema: "Home",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryItem_Category_CategoryId",
                schema: "Home",
                table: "InventoryItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InventoryItem",
                schema: "Home",
                table: "InventoryItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                schema: "Home",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "InventoryItem",
                schema: "Home",
                newName: "InventoryItems");

            migrationBuilder.RenameTable(
                name: "Category",
                schema: "Home",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_InventoryItem_CategoryId",
                table: "InventoryItems",
                newName: "IX_InventoryItems_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InventoryItems",
                table: "InventoryItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryItems_Categories_CategoryId",
                table: "InventoryItems",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
