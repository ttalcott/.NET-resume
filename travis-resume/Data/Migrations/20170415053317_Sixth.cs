using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace travis_resume.Data.Migrations
{
    public partial class Sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContactPersonId",
                table: "ResumeViewModel",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ResumeViewModel_ContactPersonId",
                table: "ResumeViewModel",
                column: "ContactPersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeViewModel_Person_ContactPersonId",
                table: "ResumeViewModel",
                column: "ContactPersonId",
                principalTable: "Person",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResumeViewModel_Person_ContactPersonId",
                table: "ResumeViewModel");

            migrationBuilder.DropIndex(
                name: "IX_ResumeViewModel_ContactPersonId",
                table: "ResumeViewModel");

            migrationBuilder.DropColumn(
                name: "ContactPersonId",
                table: "ResumeViewModel");
        }
    }
}
