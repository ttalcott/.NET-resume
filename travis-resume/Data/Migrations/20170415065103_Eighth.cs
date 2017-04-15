using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace travis_resume.Data.Migrations
{
    public partial class Eighth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Jobs_Person_PersonId",
            //    table: "Jobs");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Jobs",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Person_PersonId",
                table: "Jobs",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Person_PersonId",
                table: "Jobs");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Jobs",
                nullable: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Person_PersonId",
                table: "Jobs",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
