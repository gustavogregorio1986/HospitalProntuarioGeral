using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalProntuario.Infra.Migrations
{
    /// <inheritdoc />
    public partial class TabelaUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perfil = table.Column<int>(type: "int", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    MedicoId = table.Column<int>(type: "int", nullable: true),
                    RecepcionistaId = table.Column<int>(type: "int", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Usuarios_tb_Medico_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "tb_Medico",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tb_Usuarios_tb_Recepcionista_RecepcionistaId",
                        column: x => x.RecepcionistaId,
                        principalTable: "tb_Recepcionista",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Usuarios_MedicoId",
                table: "tb_Usuarios",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Usuarios_RecepcionistaId",
                table: "tb_Usuarios",
                column: "RecepcionistaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Usuarios");
        }
    }
}
