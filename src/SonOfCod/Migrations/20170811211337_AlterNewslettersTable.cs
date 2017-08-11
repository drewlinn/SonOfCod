using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SonOfCod.Migrations
{
    public partial class AlterNewslettersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "title",
                table: "Newsletters",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "authorId",
                table: "Newsletters",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "title",
                table: "Newsletters");

            migrationBuilder.AlterColumn<string>(
                name: "authorId",
                table: "Newsletters",
                nullable: true);
        }
    }
}
