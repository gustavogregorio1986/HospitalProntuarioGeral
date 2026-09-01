using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalProntuario.Infra.Migrations
{
    /// <inheritdoc />
    public partial class modificarFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Internacao_tb_Paciente_PacienteId1",
                table: "tb_Internacao");

            migrationBuilder.DropIndex(
                name: "IX_tb_Internacao_PacienteId1",
                table: "tb_Internacao");

            migrationBuilder.DropColumn(
                name: "PacienteId1",
                table: "tb_Internacao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PacienteId1",
                table: "tb_Internacao",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_Internacao_PacienteId1",
                table: "tb_Internacao",
                column: "PacienteId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Internacao_tb_Paciente_PacienteId1",
                table: "tb_Internacao",
                column: "PacienteId1",
                principalTable: "tb_Paciente",
                principalColumn: "Id");
        }
    }
}
