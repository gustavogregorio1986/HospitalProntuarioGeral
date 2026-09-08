using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalProntuario.Infra.Migrations
{
    /// <inheritdoc />
    public partial class IncluirCampoStatusPagamwentoEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "tb_Pagamento",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "tb_Pagamento");
        }
    }
}
