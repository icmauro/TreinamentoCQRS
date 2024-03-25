using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TreinamentoCQRS.Data.Migrations
{
    /// <inheritdoc />
    public partial class AjustandoCampo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "FornecedorId",
                table: "Produtos",
                type: "int",
                nullable: true,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "FornecedorId",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: false);
        }
    }
}
