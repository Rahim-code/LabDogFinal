using Microsoft.EntityFrameworkCore.Migrations;

namespace _29042021.Migrations
{
    public partial class PlanIdAddedIntoPlanFeaturesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlanId",
                table: "PlanFeatures",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PlanFeatures_PlanId",
                table: "PlanFeatures",
                column: "PlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlanFeatures_Plans_PlanId",
                table: "PlanFeatures",
                column: "PlanId",
                principalTable: "Plans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlanFeatures_Plans_PlanId",
                table: "PlanFeatures");

            migrationBuilder.DropIndex(
                name: "IX_PlanFeatures_PlanId",
                table: "PlanFeatures");

            migrationBuilder.DropColumn(
                name: "PlanId",
                table: "PlanFeatures");
        }
    }
}
