using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeguiAcademico.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MateriasInscritas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcudienteDesignadoId = table.Column<int>(type: "int", nullable: true),
                    Materia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorreoInstitucional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CursoACargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstudianteId = table.Column<int>(type: "int", nullable: true),
                    MateriaTutoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HorasLaborales = table.Column<int>(type: "int", nullable: true),
                    Tutor_CorreoInstitucional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tutor_EstudianteId = table.Column<int>(type: "int", nullable: true)
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
                        name: "FK_Personas_Personas_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_Tutor_EstudianteId",
                        column: x => x.Tutor_EstudianteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Historiales",
                columns: table => new
                {
                    HistorialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstudianteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historiales", x => x.HistorialId);
                    table.ForeignKey(
                        name: "FK_Historiales_Personas_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recomendacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaPublicacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Materia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tematica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoActividad = table.Column<int>(type: "int", nullable: false),
                    EstadoAvance = table.Column<int>(type: "int", nullable: false),
                    HistorialId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recomendacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recomendacion_Historiales_HistorialId",
                        column: x => x.HistorialId,
                        principalTable: "Historiales",
                        principalColumn: "HistorialId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Historiales_EstudianteId",
                table: "Historiales",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_AcudienteDesignadoId",
                table: "Personas",
                column: "AcudienteDesignadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_EstudianteId",
                table: "Personas",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Tutor_EstudianteId",
                table: "Personas",
                column: "Tutor_EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_Recomendacion_HistorialId",
                table: "Recomendacion",
                column: "HistorialId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recomendacion");

            migrationBuilder.DropTable(
                name: "Historiales");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
