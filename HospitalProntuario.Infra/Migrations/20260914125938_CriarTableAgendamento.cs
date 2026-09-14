using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalProntuario.Infra.Migrations
{
    /// <inheritdoc />
    public partial class CriarTableAgendamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RecepcionistaId",
                table: "tb_Agendamento",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "tb_Recepcionista",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    CPF = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false),
                    Turno = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Recepcionista", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Agendamento_RecepcionistaId",
                table: "tb_Agendamento",
                column: "RecepcionistaId");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Agendamento_tb_Recepcionista_RecepcionistaId",
                table: "tb_Agendamento",
                column: "RecepcionistaId",
                principalTable: "tb_Recepcionista",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Agendamento_tb_Recepcionista_RecepcionistaId",
                table: "tb_Agendamento");

            migrationBuilder.DropTable(
                name: "tb_Recepcionista");

            migrationBuilder.DropIndex(
                name: "IX_tb_Agendamento_RecepcionistaId",
                table: "tb_Agendamento");

            migrationBuilder.DropColumn(
                name: "RecepcionistaId",
                table: "tb_Agendamento");
        }
    }
}
