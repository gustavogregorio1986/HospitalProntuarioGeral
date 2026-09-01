using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalProntuario.Infra.Migrations
{
    /// <inheritdoc />
    public partial class tabelasCriadas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Medico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CRM = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Especialidade = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Medico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_PlanoSaude",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RegistroANS = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_PlanoSaude", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_Paciente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    PlanoSaudeId = table.Column<int>(type: "int", nullable: true),
                    PacienteId = table.Column<int>(type: "int", nullable: false),
                    PlanoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Paciente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Paciente_tb_PlanoSaude_PlanoId",
                        column: x => x.PlanoId,
                        principalTable: "tb_PlanoSaude",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tb_Paciente_tb_PlanoSaude_PlanoSaudeId",
                        column: x => x.PlanoSaudeId,
                        principalTable: "tb_PlanoSaude",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tb_Agendamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    PacienteId = table.Column<int>(type: "int", nullable: false),
                    MedicoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Agendamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Agendamento_tb_Medico_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "tb_Medico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_Agendamento_tb_Paciente_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "tb_Paciente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Cirurgia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    PacienteId = table.Column<int>(type: "int", nullable: false),
                    MedicoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Cirurgia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Cirurgia_tb_Medico_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "tb_Medico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_Cirurgia_tb_Paciente_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "tb_Paciente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Internacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataSaida = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Quarto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PacienteId = table.Column<int>(type: "int", nullable: false),
                    PacienteId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Internacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Internacao_tb_Paciente_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "tb_Paciente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_Internacao_tb_Paciente_PacienteId1",
                        column: x => x.PacienteId1,
                        principalTable: "tb_Paciente",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tb_Pagamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FormaPagamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PacienteId = table.Column<int>(type: "int", nullable: false),
                    PacienteId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Pagamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Pagamento_tb_Paciente_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "tb_Paciente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_Pagamento_tb_Paciente_PacienteId1",
                        column: x => x.PacienteId1,
                        principalTable: "tb_Paciente",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Agendamento_MedicoId",
                table: "tb_Agendamento",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Agendamento_PacienteId",
                table: "tb_Agendamento",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Cirurgia_MedicoId",
                table: "tb_Cirurgia",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Cirurgia_PacienteId",
                table: "tb_Cirurgia",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Internacao_PacienteId",
                table: "tb_Internacao",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Internacao_PacienteId1",
                table: "tb_Internacao",
                column: "PacienteId1");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Paciente_PlanoId",
                table: "tb_Paciente",
                column: "PlanoId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Paciente_PlanoSaudeId",
                table: "tb_Paciente",
                column: "PlanoSaudeId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Pagamento_PacienteId",
                table: "tb_Pagamento",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Pagamento_PacienteId1",
                table: "tb_Pagamento",
                column: "PacienteId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Agendamento");

            migrationBuilder.DropTable(
                name: "tb_Cirurgia");

            migrationBuilder.DropTable(
                name: "tb_Internacao");

            migrationBuilder.DropTable(
                name: "tb_Pagamento");

            migrationBuilder.DropTable(
                name: "tb_Medico");

            migrationBuilder.DropTable(
                name: "tb_Paciente");

            migrationBuilder.DropTable(
                name: "tb_PlanoSaude");
        }
    }
}
