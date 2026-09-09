using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalProntuario.Infra.Migrations
{
    /// <inheritdoc />
    public partial class MelhorarRelacionamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Paciente_tb_PlanoSaude_PlanoId",
                table: "tb_Paciente");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_Paciente_tb_PlanoSaude_PlanoSaudeId",
                table: "tb_Paciente");

            migrationBuilder.DropIndex(
                name: "IX_tb_Paciente_PlanoId",
                table: "tb_Paciente");

            migrationBuilder.DropColumn(
                name: "PlanoId",
                table: "tb_Paciente");

            migrationBuilder.RenameColumn(
                name: "PacienteId",
                table: "tb_Paciente",
                newName: "CirurgiaId");

            migrationBuilder.AlterColumn<int>(
                name: "PlanoSaudeId",
                table: "tb_Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Paciente_tb_PlanoSaude_PlanoSaudeId",
                table: "tb_Paciente",
                column: "PlanoSaudeId",
                principalTable: "tb_PlanoSaude",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Paciente_tb_PlanoSaude_PlanoSaudeId",
                table: "tb_Paciente");

            migrationBuilder.RenameColumn(
                name: "CirurgiaId",
                table: "tb_Paciente",
                newName: "PacienteId");

            migrationBuilder.AlterColumn<int>(
                name: "PlanoSaudeId",
                table: "tb_Paciente",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "PlanoId",
                table: "tb_Paciente",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_Paciente_PlanoId",
                table: "tb_Paciente",
                column: "PlanoId");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Paciente_tb_PlanoSaude_PlanoId",
                table: "tb_Paciente",
                column: "PlanoId",
                principalTable: "tb_PlanoSaude",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Paciente_tb_PlanoSaude_PlanoSaudeId",
                table: "tb_Paciente",
                column: "PlanoSaudeId",
                principalTable: "tb_PlanoSaude",
                principalColumn: "Id");
        }
    }
}
