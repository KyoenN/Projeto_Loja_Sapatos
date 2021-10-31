using Microsoft.EntityFrameworkCore.Migrations;

namespace SiteTeste.Migrations
{
    public partial class Migrations_add_Modelo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fornecedores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "tamanho",
                table: "Modelos",
                newName: "Tamanho");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Modelos",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "id_fornecedor",
                table: "Modelos",
                newName: "Id_fornecedor");

            migrationBuilder.RenameColumn(
                name: "cor",
                table: "Modelos",
                newName: "Cor");

            migrationBuilder.RenameColumn(
                name: "codReferencia",
                table: "Modelos",
                newName: "CodReferencia");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Modelos",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Modelos",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tamanho",
                table: "Modelos",
                newName: "tamanho");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Modelos",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Id_fornecedor",
                table: "Modelos",
                newName: "id_fornecedor");

            migrationBuilder.RenameColumn(
                name: "Cor",
                table: "Modelos",
                newName: "cor");

            migrationBuilder.RenameColumn(
                name: "CodReferencia",
                table: "Modelos",
                newName: "codReferencia");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Modelos",
                newName: "id");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Modelos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Fornecedores",
                columns: new[] { "Id", "CNPJ", "Endereco", "Nome" },
                values: new object[] { 1, "11155577788899", "Rua 1", "Batatinha" });
        }
    }
}
