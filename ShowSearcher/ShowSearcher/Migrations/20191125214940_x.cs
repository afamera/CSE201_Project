using Microsoft.EntityFrameworkCore.Migrations;

namespace ShowSearcher.Migrations
{
    public partial class x : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Show",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShowName = table.Column<string>(nullable: false),
                    ShowDescription = table.Column<string>(nullable: true),
                    ShowRate = table.Column<double>(nullable: false),
                    NumOfSeasons = table.Column<int>(nullable: false),
                    YearShowBegan = table.Column<int>(nullable: false),
                    Genre = table.Column<string>(nullable: false),
                    OriginalNetwork = table.Column<string>(nullable: false),
                    NumOfLike = table.Column<int>(nullable: false),
                    NumOfDislike = table.Column<int>(nullable: false)
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
