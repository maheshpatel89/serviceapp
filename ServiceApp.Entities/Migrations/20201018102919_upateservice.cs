using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceApp.Entities.Migrations
{
    public partial class upateservice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Service",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StateId",
                table: "Service",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "Service");
        }
    }
}
