using Microsoft.EntityFrameworkCore.Migrations;

namespace Assign5_Books.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ISBN = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Author = table.Column<string>(nullable: false),
                    Publisher = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    PageNumber = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
