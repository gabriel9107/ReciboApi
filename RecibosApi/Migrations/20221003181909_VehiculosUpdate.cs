using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecibosApi.Migrations
{
    public partial class VehiculosUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vehiculos_Miembros_propietarioiD",
                table: "vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_vehiculos_propietarioiD",
                table: "vehiculos");

            migrationBuilder.DropColumn(
                name: "propietarioiD",
                table: "vehiculos");

            migrationBuilder.AddColumn<int>(
                name: "miembrosId",
                table: "vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_vehiculos_miembrosId",
                table: "vehiculos",
                column: "miembrosId");

            migrationBuilder.AddForeignKey(
                name: "FK_vehiculos_Miembros_miembrosId",
                table: "vehiculos",
                column: "miembrosId",
                principalTable: "Miembros",
                principalColumn: "iD",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vehiculos_Miembros_miembrosId",
                table: "vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_vehiculos_miembrosId",
                table: "vehiculos");

            migrationBuilder.DropColumn(
                name: "miembrosId",
                table: "vehiculos");

            migrationBuilder.AddColumn<int>(
                name: "propietarioiD",
                table: "vehiculos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_vehiculos_propietarioiD",
                table: "vehiculos",
                column: "propietarioiD");

            migrationBuilder.AddForeignKey(
                name: "FK_vehiculos_Miembros_propietarioiD",
                table: "vehiculos",
                column: "propietarioiD",
                principalTable: "Miembros",
                principalColumn: "iD");
        }
    }
}
