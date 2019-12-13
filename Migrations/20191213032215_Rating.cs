using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantRate.Migrations
{
    public partial class Rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "AllVotes",
                table: "Restaurant",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "NumVotes",
                table: "Restaurant",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Restaurant",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AllVotes",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "NumVotes",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Restaurant");
        }
    }
}
