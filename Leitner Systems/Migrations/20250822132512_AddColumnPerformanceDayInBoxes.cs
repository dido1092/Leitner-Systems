using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leitner_Systems.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnPerformanceDayInBoxes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PerformanceTime",
                table: "BoxTwos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PerformanceTime",
                table: "BoxThrees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PerformanceTime",
                table: "BoxOnes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PerformanceTime",
                table: "BoxFours",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PerformanceTime",
                table: "BoxFives",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PerformanceTime",
                table: "BoxTwos");

            migrationBuilder.DropColumn(
                name: "PerformanceTime",
                table: "BoxThrees");

            migrationBuilder.DropColumn(
                name: "PerformanceTime",
                table: "BoxOnes");

            migrationBuilder.DropColumn(
                name: "PerformanceTime",
                table: "BoxFours");

            migrationBuilder.DropColumn(
                name: "PerformanceTime",
                table: "BoxFives");
        }
    }
}
