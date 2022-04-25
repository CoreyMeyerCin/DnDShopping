using Microsoft.EntityFrameworkCore.Migrations;

namespace DungeonsAndDragons.Migrations
{
    public partial class Fixedgeneralstore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Campaigns_CampaignId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_CampaignId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "CampaignId",
                table: "Characters");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CampaignId",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Characters_CampaignId",
                table: "Characters",
                column: "CampaignId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Campaigns_CampaignId",
                table: "Characters",
                column: "CampaignId",
                principalTable: "Campaigns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
