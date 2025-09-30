using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vizallas.Migrations
{
    /// <inheritdoc />
    public partial class sqlitelocal_migration_892 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    datum = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    vizallas = table.Column<int>(type: "INTEGER", nullable: false),
                    varos = table.Column<string>(type: "TEXT", nullable: false),
                    folyo = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Classes");
        }
    }
}
