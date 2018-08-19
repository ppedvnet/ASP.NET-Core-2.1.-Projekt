using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookshop.DAL.Migrations
{
    public partial class UpdateEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Added",
                table: "People",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "People",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "People",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Added",
                table: "Libraries",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "Libraries",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Libraries",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Added",
                table: "Categories",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "Categories",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Added",
                table: "Books",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "Books",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Books",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Added",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "People");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Added",
                table: "Libraries");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "Libraries");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Libraries");

            migrationBuilder.DropColumn(
                name: "Added",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Added",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Books");
        }
    }
}
