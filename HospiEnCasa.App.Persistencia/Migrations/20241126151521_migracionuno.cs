using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospiEnCasa.App.Persistencia.Migrations
{
    public partial class migracionuno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SignosVitales",
                columns: table => new
                {
                    IdSignoVital = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Signo = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignosVitales", x => x.IdSignoVital);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TargetaProfesional = table.Column<int>(type: "int", nullable: true),
                    HorasLaborales = table.Column<int>(type: "int", nullable: true),
                    Parentesco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Especialidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistroRhetus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medico_EnfermeraId = table.Column<int>(type: "int", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitud = table.Column<float>(type: "real", nullable: true),
                    Longitud = table.Column<float>(type: "real", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FamiliarDesignadoId = table.Column<int>(type: "int", nullable: true),
                    HistoriaIdHistoria = table.Column<int>(type: "int", nullable: true),
                    SignoVitalIdSignoVital = table.Column<int>(type: "int", nullable: true),
                    EnfermeraId = table.Column<int>(type: "int", nullable: true),
                    MedicoId = table.Column<int>(type: "int", nullable: true),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Descripcion = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_EnfermeraId",
                        column: x => x.EnfermeraId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_FamiliarDesignadoId",
                        column: x => x.FamiliarDesignadoId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_Medico_EnfermeraId",
                        column: x => x.Medico_EnfermeraId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_SignosVitales_SignoVitalIdSignoVital",
                        column: x => x.SignoVitalIdSignoVital,
                        principalTable: "SignosVitales",
                        principalColumn: "IdSignoVital",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Historias",
                columns: table => new
                {
                    IdHistoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Diagnostico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Entorno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SugerenciaCuidadoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historias", x => x.IdHistoria);
                    table.ForeignKey(
                        name: "FK_Historias_Personas_SugerenciaCuidadoId",
                        column: x => x.SugerenciaCuidadoId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Historias_SugerenciaCuidadoId",
                table: "Historias",
                column: "SugerenciaCuidadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_EnfermeraId",
                table: "Personas",
                column: "EnfermeraId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_FamiliarDesignadoId",
                table: "Personas",
                column: "FamiliarDesignadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_HistoriaIdHistoria",
                table: "Personas",
                column: "HistoriaIdHistoria");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Medico_EnfermeraId",
                table: "Personas",
                column: "Medico_EnfermeraId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_MedicoId",
                table: "Personas",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_SignoVitalIdSignoVital",
                table: "Personas",
                column: "SignoVitalIdSignoVital");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Historias_HistoriaIdHistoria",
                table: "Personas",
                column: "HistoriaIdHistoria",
                principalTable: "Historias",
                principalColumn: "IdHistoria",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Historias_Personas_SugerenciaCuidadoId",
                table: "Historias");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Historias");

            migrationBuilder.DropTable(
                name: "SignosVitales");
        }
    }
}
