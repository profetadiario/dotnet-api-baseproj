using Microsoft.EntityFrameworkCore.Migrations;

namespace Boilerplate.Presentation.Data.Migrations
{
    public partial class fornecedor2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Fornecedor",
                table: "Fornecedor");

            migrationBuilder.RenameTable(
                name: "Fornecedor",
                newName: "TBL_FORNECEDOR");

            migrationBuilder.RenameColumn(
                name: "Vertical",
                table: "TBL_FORNECEDOR",
                newName: "VERTICAL");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "TBL_FORNECEDOR",
                newName: "NOME");

            migrationBuilder.RenameColumn(
                name: "Link",
                table: "TBL_FORNECEDOR",
                newName: "LINK");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TBL_FORNECEDOR",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "MantemHistorico",
                table: "TBL_FORNECEDOR",
                newName: "HAS_HISTORICO");

            migrationBuilder.AlterColumn<string>(
                name: "NOME",
                table: "TBL_FORNECEDOR",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LINK",
                table: "TBL_FORNECEDOR",
                type: "varchar(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "HAS_HISTORICO",
                table: "TBL_FORNECEDOR",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_FORNECEDOR",
                table: "TBL_FORNECEDOR",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_FORNECEDOR",
                table: "TBL_FORNECEDOR");

            migrationBuilder.RenameTable(
                name: "TBL_FORNECEDOR",
                newName: "Fornecedor");

            migrationBuilder.RenameColumn(
                name: "VERTICAL",
                table: "Fornecedor",
                newName: "Vertical");

            migrationBuilder.RenameColumn(
                name: "NOME",
                table: "Fornecedor",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "LINK",
                table: "Fornecedor",
                newName: "Link");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Fornecedor",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "HAS_HISTORICO",
                table: "Fornecedor",
                newName: "MantemHistorico");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Fornecedor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Link",
                table: "Fornecedor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)");

            migrationBuilder.AlterColumn<bool>(
                name: "MantemHistorico",
                table: "Fornecedor",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fornecedor",
                table: "Fornecedor",
                column: "Id");
        }
    }
}
