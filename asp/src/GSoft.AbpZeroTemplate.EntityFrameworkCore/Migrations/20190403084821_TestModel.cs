using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GSoft.AbpZeroTemplate.Migrations
{
    public partial class TestModel : Migration
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
