using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leitner_Systems.Migrations
{
    /// <inheritdoc />
    public partial class InitialLeitnerSystems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BoxFives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BgWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoxFives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BoxFours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BgWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoxFours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BoxOnes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BgWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoxOnes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BoxThrees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BgWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoxThrees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BoxTwos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BgWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoxTwos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnBgWords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BgWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnBgWords", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoxFives");

            migrationBuilder.DropTable(
                name: "BoxFours");

            migrationBuilder.DropTable(
                name: "BoxOnes");

            migrationBuilder.DropTable(
                name: "BoxThrees");

            migrationBuilder.DropTable(
                name: "BoxTwos");

            migrationBuilder.DropTable(
                name: "EnBgWords");
        }
    }
}
