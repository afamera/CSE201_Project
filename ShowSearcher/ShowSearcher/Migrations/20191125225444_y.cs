using Microsoft.EntityFrameworkCore.Migrations;

namespace ShowSearcher.Migrations
{
    public partial class y : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WikiLink",
                table: "Show",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WikiLink",
                table: "Show");
        }
    }
}
