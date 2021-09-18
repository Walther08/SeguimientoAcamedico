using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeguiAcademico.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Informe",
                columns: table => new
                {
                    InformeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Materia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Asunto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Informe", x => x.InformeId);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parentesco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Curso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitud = table.Column<float>(type: "real", nullable: true),
                    Longitud = table.Column<float>(type: "real", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MateriasInscritas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcudienteDesignadoId = table.Column<int>(type: "int", nullable: true),
                    MaestroId = table.Column<int>(type: "int", nullable: true),
                    TutorId = table.Column<int>(type: "int", nullable: true),
                    HistorialId = table.Column<int>(type: "int", nullable: true),
                    Materia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorreoInstitucional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CursoACargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MateriaTutoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HorasLaborales = table.Column<int>(type: "int", nullable: true),
                    Tutor_CorreoInstitucional = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_AcudienteDesignadoId",
                        column: x => x.AcudienteDesignadoId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_MaestroId",
                        column: x => x.MaestroId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RecomendacionAcademica",
                columns: table => new
                {
                    RecomendacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaPublicacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Materia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tematica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaestroEncargadoId = table.Column<int>(type: "int", nullable: true),
                    TipoActividad = table.Column<int>(type: "int", nullable: false),
                    EstadoAvance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecomendacionAcademica", x => x.RecomendacionId);
                    table.ForeignKey(
                        name: "FK_RecomendacionAcademica_Personas_MaestroEncargadoId",
                        column: x => x.MaestroEncargadoId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Historial",
                columns: table => new
                {
                    HistorialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecomendacionAcademicaRecomendacionId = table.Column<int>(type: "int", nullable: true),
                    InformeSeguimientoInformeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historial", x => x.HistorialId);
                    table.ForeignKey(
                        name: "FK_Historial_Informe_InformeSeguimientoInformeId",
                        column: x => x.InformeSeguimientoInformeId,
                        principalTable: "Informe",
                        principalColumn: "InformeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Historial_RecomendacionAcademica_RecomendacionAcademicaRecomendacionId",
                        column: x => x.RecomendacionAcademicaRecomendacionId,
                        principalTable: "RecomendacionAcademica",
                        principalColumn: "RecomendacionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Historial_InformeSeguimientoInformeId",
                table: "Historial",
                column: "InformeSeguimientoInformeId");

            migrationBuilder.CreateIndex(
                name: "IX_Historial_RecomendacionAcademicaRecomendacionId",
                table: "Historial",
                column: "RecomendacionAcademicaRecomendacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_AcudienteDesignadoId",
                table: "Personas",
                column: "AcudienteDesignadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_HistorialId",
                table: "Personas",
                column: "HistorialId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_MaestroId",
                table: "Personas",
                column: "MaestroId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_TutorId",
                table: "Personas",
                column: "TutorId");

            migrationBuilder.CreateIndex(
                name: "IX_RecomendacionAcademica_MaestroEncargadoId",
                table: "RecomendacionAcademica",
                column: "MaestroEncargadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Historial_HistorialId",
                table: "Personas",
                column: "HistorialId",
                principalTable: "Historial",
                principalColumn: "HistorialId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Historial_Informe_InformeSeguimientoInformeId",
                table: "Historial");

            migrationBuilder.DropForeignKey(
                name: "FK_Historial_RecomendacionAcademica_RecomendacionAcademicaRecomendacionId",
                table: "Historial");

            migrationBuilder.DropTable(
                name: "Informe");

            migrationBuilder.DropTable(
                name: "RecomendacionAcademica");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Historial");
        }
    }
}
