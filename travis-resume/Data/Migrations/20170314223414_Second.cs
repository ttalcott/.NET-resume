using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace travis_resume.Data.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "companyName",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "dateHired",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "dateOver",
                table: "Jobs");

            migrationBuilder.AddColumn<string>(
                name: "AddressCity",
                table: "Jobs",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Jobs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AddressLineOne",
                table: "Jobs",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AddressLineTwo",
                table: "Jobs",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AddressState",
                table: "Jobs",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AddressZip",
                table: "Jobs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "jobDateHired",
                table: "Jobs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "jobDateOver",
                table: "Jobs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "jobName",
                table: "Jobs",
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressCity",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "AddressLineOne",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "AddressLineTwo",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "AddressState",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "AddressZip",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "jobDateHired",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "jobDateOver",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "jobName",
                table: "Jobs");

            migrationBuilder.AddColumn<string>(
                name: "companyName",
                table: "Jobs",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "dateHired",
                table: "Jobs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "dateOver",
                table: "Jobs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
