using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesShowSearcher.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Show",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShowName = table.Column<string>(maxLength: 60, nullable: false),
                    ShowDescription = table.Column<string>(maxLength: 100, nullable: true),
                    ShowRate = table.Column<double>(nullable: false),
                    NumOfSeasons = table.Column<int>(nullable: false),
                    YearShowBegan = table.Column<int>(nullable: false),
                    Genre = table.Column<string>(maxLength: 30, nullable: false),
                    OriginalNetwork = table.Column<string>(maxLength: 60, nullable: false),
                    numOfLike = table.Column<string>(nullable: true),
                    numOfDislike = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Show", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Show");
        }
    }
}
