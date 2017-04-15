using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace travis_resume.Data.Migrations
{
    public partial class Fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonEmail = table.Column<string>(nullable: true),
                    PersonFirstName = table.Column<string>(maxLength: 60, nullable: false),
                    PersonLastName = table.Column<string>(maxLength: 30, nullable: false),
                    PersonPhone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "ResumeViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeViewModel", x => x.Id);
                });

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Jobs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ResumeViewModelId",
                table: "Jobs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Education",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ResumeViewModelId",
                table: "Education",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_PersonId",
                table: "Jobs",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_ResumeViewModelId",
                table: "Jobs",
                column: "ResumeViewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Education_PersonId",
                table: "Education",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Education_ResumeViewModelId",
                table: "Education",
                column: "ResumeViewModelId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Education_Person_PersonId",
            //    table: "Education",
            //    column: "PersonId",
            //    principalTable: "Person",
            //    principalColumn: "PersonId",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Education_ResumeViewModel_ResumeViewModelId",
            //    table: "Education",
            //    column: "ResumeViewModelId",
            //    principalTable: "ResumeViewModel",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Jobs_Person_PersonId",
            //    table: "Jobs",
            //    column: "PersonId",
            //    principalTable: "Person",
            //    principalColumn: "PersonId",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Jobs_ResumeViewModel_ResumeViewModelId",
            //    table: "Jobs",
            //    column: "ResumeViewModelId",
            //    principalTable: "ResumeViewModel",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Education_Person_PersonId",
                table: "Education");

            migrationBuilder.DropForeignKey(
                name: "FK_Education_ResumeViewModel_ResumeViewModelId",
                table: "Education");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Person_PersonId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_ResumeViewModel_ResumeViewModelId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_PersonId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_ResumeViewModelId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Education_PersonId",
                table: "Education");

            migrationBuilder.DropIndex(
                name: "IX_Education_ResumeViewModelId",
                table: "Education");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "ResumeViewModelId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Education");

            migrationBuilder.DropColumn(
                name: "ResumeViewModelId",
                table: "Education");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "ResumeViewModel");
        }
    }
}
