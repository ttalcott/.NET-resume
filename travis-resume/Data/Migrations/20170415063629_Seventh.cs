using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace travis_resume.Data.Migrations
{
    public partial class Seventh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Education_Person_PersonId",
            //    table: "Education");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Education",
                nullable: true);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Education_Person_PersonId",
            //    table: "Education",
            //    column: "PersonId",
            //    principalTable: "Person",
            //    principalColumn: "PersonId",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Education_Person_PersonId",
            //    table: "Education");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Education",
                nullable: false);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Education_Person_PersonId",
            //    table: "Education",
            //    column: "PersonId",
            //    principalTable: "Person",
            //    principalColumn: "PersonId",
            //    onDelete: ReferentialAction.Cascade);
        }
    }
}
