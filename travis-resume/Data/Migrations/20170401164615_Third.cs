using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace travis_resume.Data.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    EducationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressCity = table.Column<string>(maxLength: 30, nullable: false),
                    AddressId = table.Column<int>(nullable: false),
                    AddressLineOne = table.Column<string>(maxLength: 60, nullable: false),
                    AddressLineTwo = table.Column<string>(maxLength: 60, nullable: false),
                    AddressState = table.Column<string>(maxLength: 2, nullable: false),
                    AddressZip = table.Column<int>(nullable: false),
                    EducationDescription = table.Column<string>(nullable: true),
                    EducationLevel = table.Column<string>(maxLength: 30, nullable: false),
                    EducationName = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.EducationId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Education");
        }
    }
}
