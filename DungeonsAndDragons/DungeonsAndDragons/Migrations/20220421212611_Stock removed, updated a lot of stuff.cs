using Microsoft.EntityFrameworkCore.Migrations;

namespace DungeonsAndDragons.Migrations
{
    public partial class Stockremovedupdatedalotofstuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Stocks_StockId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Shops_Stocks_StockId",
                table: "Shops");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_Shops_StockId",
                table: "Shops");

            migrationBuilder.DropIndex(
                name: "IX_Items_StockId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "StockId",
                table: "Items",
                newName: "Quantity");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Shops",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Gold",
                table: "Shops",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "GeneralStoreId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_GeneralStoreId",
                table: "Items",
                column: "GeneralStoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Shops_GeneralStoreId",
                table: "Items",
                column: "GeneralStoreId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Shops_GeneralStoreId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_GeneralStoreId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Shops");

            migrationBuilder.DropColumn(
                name: "Gold",
                table: "Shops");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "GeneralStoreId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Items",
                newName: "StockId");

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gold = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shops_StockId",
                table: "Shops",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_StockId",
                table: "Items",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_Id",
                table: "Stocks",
                column: "Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Stocks_StockId",
                table: "Items",
                column: "StockId",
                principalTable: "Stocks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shops_Stocks_StockId",
                table: "Shops",
                column: "StockId",
                principalTable: "Stocks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
