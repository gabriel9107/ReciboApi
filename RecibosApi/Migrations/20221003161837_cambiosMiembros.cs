using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecibosApi.Migrations
{
    public partial class cambiosMiembros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreadoPor",
                table: "Miembros",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "Miembros",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModificacion",
                table: "Miembros",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModificadoPor",
                table: "Miembros",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreadoPor",
                table: "Miembros");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "Miembros");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "Miembros");

            migrationBuilder.DropColumn(
                name: "ModificadoPor",
                table: "Miembros");
        }
    }
}
