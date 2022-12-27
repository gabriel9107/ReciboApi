using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecibosApi.Migrations
{
    /// <inheritdoc />
    public partial class codigoPago : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CodigoDePagos_empleados_EmpleadoId",
                table: "CodigoDePagos");

            migrationBuilder.DropIndex(
                name: "IX_CodigoDePagos_EmpleadoId",
                table: "CodigoDePagos");

            migrationBuilder.DropColumn(
                name: "EmpleadoId",
                table: "CodigoDePagos");

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "CodigoDePagos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "CodigoDePagos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "detalleCodigoDePagos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoDePagoId = table.Column<int>(type: "int", nullable: true),
                    EmpleadoId = table.Column<int>(type: "int", nullable: true),
                    Primario = table.Column<bool>(type: "bit", nullable: false),
                    DescuentoSFS = table.Column<bool>(type: "bit", nullable: false),
                    DescuentoAFP = table.Column<bool>(type: "bit", nullable: false),
                    DescuentoTSS = table.Column<bool>(type: "bit", nullable: false),
                    DescuentoISR = table.Column<bool>(type: "bit", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCrecion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalleCodigoDePagos", x => x.id);
                    table.ForeignKey(
                        name: "FK_detalleCodigoDePagos_CodigoDePagos_CodigoDePagoId",
                        column: x => x.CodigoDePagoId,
                        principalTable: "CodigoDePagos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_detalleCodigoDePagos_empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "empleados",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_detalleCodigoDePagos_CodigoDePagoId",
                table: "detalleCodigoDePagos",
                column: "CodigoDePagoId");

            migrationBuilder.CreateIndex(
                name: "IX_detalleCodigoDePagos_EmpleadoId",
                table: "detalleCodigoDePagos",
                column: "EmpleadoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "detalleCodigoDePagos");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "CodigoDePagos");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "CodigoDePagos");

            migrationBuilder.AddColumn<int>(
                name: "EmpleadoId",
                table: "CodigoDePagos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CodigoDePagos_EmpleadoId",
                table: "CodigoDePagos",
                column: "EmpleadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_CodigoDePagos_empleados_EmpleadoId",
                table: "CodigoDePagos",
                column: "EmpleadoId",
                principalTable: "empleados",
                principalColumn: "Id");
        }
    }
}
