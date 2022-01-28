using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeApp.Migrations
{
    public partial class _202112221613 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryItemAttachments_InventoryItem_InventoryItemId",
                table: "InventoryItemAttachments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InventoryItemAttachments",
                table: "InventoryItemAttachments");

            migrationBuilder.RenameTable(
                name: "InventoryItemAttachments",
                newName: "InventoryItemAttachment",
                newSchema: "Home");

            migrationBuilder.RenameIndex(
                name: "IX_InventoryItemAttachments_InventoryItemId",
                schema: "Home",
                table: "InventoryItemAttachment",
                newName: "IX_InventoryItemAttachment_InventoryItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InventoryItemAttachment",
                schema: "Home",
                table: "InventoryItemAttachment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryItemAttachment_InventoryItem_InventoryItemId",
                schema: "Home",
                table: "InventoryItemAttachment",
                column: "InventoryItemId",
                principalSchema: "Home",
                principalTable: "InventoryItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryItemAttachment_InventoryItem_InventoryItemId",
                schema: "Home",
                table: "InventoryItemAttachment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InventoryItemAttachment",
                schema: "Home",
                table: "InventoryItemAttachment");

            migrationBuilder.RenameTable(
                name: "InventoryItemAttachment",
                schema: "Home",
                newName: "InventoryItemAttachments");

            migrationBuilder.RenameIndex(
                name: "IX_InventoryItemAttachment_InventoryItemId",
                table: "InventoryItemAttachments",
                newName: "IX_InventoryItemAttachments_InventoryItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InventoryItemAttachments",
                table: "InventoryItemAttachments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryItemAttachments_InventoryItem_InventoryItemId",
                table: "InventoryItemAttachments",
                column: "InventoryItemId",
                principalSchema: "Home",
                principalTable: "InventoryItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
