using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SonOfCod.Migrations
{
    public partial class ChangeAuthorIdToAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "authorId",
                table: "Newsletters");

            migrationBuilder.AddColumn<int>(
                name: "Recipientid",
                table: "Newsletters",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "author",
                table: "Newsletters",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Newsletters_Recipientid",
                table: "Newsletters",
                column: "Recipientid");

            migrationBuilder.AddForeignKey(
                name: "FK_Newsletters_Recipients_Recipientid",
                table: "Newsletters",
                column: "Recipientid",
                principalTable: "Recipients",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Newsletters_Recipients_Recipientid",
                table: "Newsletters");

            migrationBuilder.DropIndex(
                name: "IX_Newsletters_Recipientid",
                table: "Newsletters");

            migrationBuilder.DropColumn(
                name: "Recipientid",
                table: "Newsletters");

            migrationBuilder.DropColumn(
                name: "author",
                table: "Newsletters");

            migrationBuilder.AddColumn<int>(
                name: "authorId",
                table: "Newsletters",
                nullable: false,
                defaultValue: 0);
        }
    }
}
