using Microsoft.EntityFrameworkCore.Migrations;

namespace _29042021.Migrations
{
    public partial class TestimonialsTablecreatede : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(maxLength: 100, nullable: true),
                    FullName = table.Column<string>(maxLength: 50, nullable: false),
                    Position = table.Column<string>(maxLength: 20, nullable: true),
                    CompanyName = table.Column<string>(maxLength: 30, nullable: true),
                    Text = table.Column<string>(maxLength: 500, nullable: true),
                    Rate = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Testimonials");
        }
    }
}
