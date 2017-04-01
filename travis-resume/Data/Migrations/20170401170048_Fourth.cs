using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace travis_resume.Data.Migrations
{
    public partial class Fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AddressZip",
                table: "Jobs",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLineTwo",
                table: "Jobs",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressZip",
                table: "Education",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLineTwo",
                table: "Education",
                maxLength: 60,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "AddressZip",
                table: "Jobs",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLineTwo",
                table: "Jobs",
                maxLength: 60,
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "AddressZip",
                table: "Education",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLineTwo",
                table: "Education",
                maxLength: 60,
                nullable: false);
        }
    }
}
