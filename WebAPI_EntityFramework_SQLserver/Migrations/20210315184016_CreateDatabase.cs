using Microsoft.EntityFrameworkCore.Migrations;

namespace Csharp_webapi_EntityFramework_SQLserver.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sucesso = table.Column<bool>(nullable: false),
                    MensagemErro = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    Cpf = table.Column<string>(maxLength: 11, nullable: false),
                    DataNascimento = table.Column<string>(nullable: false),
                    Sexo = table.Column<string>(maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pessoas");
        }
    }
}
