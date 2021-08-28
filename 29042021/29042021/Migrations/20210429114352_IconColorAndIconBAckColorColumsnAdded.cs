using Microsoft.EntityFrameworkCore.Migrations;

namespace _29042021.Migrations
{
    public partial class IconColorAndIconBAckColorColumsnAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IconBackColor",
                table: "Services",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IconColor",
                table: "Services",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconBackColor",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "IconColor",
                table: "Services");
        }
    }
}
