using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospiEnCasa.App.Persistencia.Migrations
{
    public partial class migraciodos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Historias_Personas_SugerenciaCuidadoId",
                table: "Historias");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "FechaHora",
                table: "Personas");

            migrationBuilder.AlterColumn<int>(
                name: "Genero",
                table: "Personas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "SugerenciasCuidados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SugerenciasCuidados", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Historias_SugerenciasCuidados_SugerenciaCuidadoId",
                table: "Historias",
                column: "SugerenciaCuidadoId",
                principalTable: "SugerenciasCuidados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Historias_SugerenciasCuidados_SugerenciaCuidadoId",
                table: "Historias");

            migrationBuilder.DropTable(
                name: "SugerenciasCuidados");

            migrationBuilder.AlterColumn<string>(
                name: "Genero",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Descripcion",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaHora",
                table: "Personas",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Historias_Personas_SugerenciaCuidadoId",
                table: "Historias",
                column: "SugerenciaCuidadoId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
