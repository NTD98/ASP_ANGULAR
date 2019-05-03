using Microsoft.EntityFrameworkCore.Migrations;

namespace GSoft.AbpZeroTemplate.Migrations
{
    public partial class AddDepreciationCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DepreciationCategory",
                table: "Assets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MonthDepreciation",
                table: "Assets",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepreciationCategory",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "MonthDepreciation",
                table: "Assets");
        }
    }
}
