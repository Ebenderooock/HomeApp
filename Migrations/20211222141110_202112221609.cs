using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeApp.Migrations
{
    public partial class _202112221609 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InventoryItemAttachments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    UploadedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InventoryItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryItemAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventoryItemAttachments_InventoryItem_InventoryItemId",
                        column: x => x.InventoryItemId,
                        principalSchema: "Home",
                        principalTable: "InventoryItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InventoryItemPurchaseDetail",
                schema: "Home",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchasedOn = table.Column<DateTime>(type: "date", nullable: false),
                    StoreName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InventoryItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryItemPurchaseDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventoryItemPurchaseDetail_InventoryItem_InventoryItemId",
                        column: x => x.InventoryItemId,
                        principalSchema: "Home",
                        principalTable: "InventoryItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InventoryItemAttachments_InventoryItemId",
                table: "InventoryItemAttachments",
                column: "InventoryItemId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryItemPurchaseDetail_InventoryItemId",
                schema: "Home",
                table: "InventoryItemPurchaseDetail",
                column: "InventoryItemId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventoryItemAttachments");

            migrationBuilder.DropTable(
                name: "InventoryItemPurchaseDetail",
                schema: "Home");
        }
    }
}
