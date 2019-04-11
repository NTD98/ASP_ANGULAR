using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GSoft.AbpZeroTemplate.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "number",
                table: "TestModels",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "TestModels",
                newName: "Name");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "TestModels",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "TestModels",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    Area = table.Column<string>(nullable: true),
                    Unitcode = table.Column<string>(nullable: true),
                    Areacode = table.Column<string>(nullable: true),
                    Transaction = table.Column<string>(nullable: true),
                    Assetcode = table.Column<string>(nullable: true),
                    Assetname = table.Column<string>(nullable: true),
                    Serinumber = table.Column<string>(nullable: true),
                    Originalprice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "TestModels");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "TestModels");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "TestModels",
                newName: "number");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TestModels",
                newName: "name");
        }
    }
}
