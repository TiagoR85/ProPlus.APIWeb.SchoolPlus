using Microsoft.EntityFrameworkCore.Migrations;

namespace ProPlus.APIWeb.SchoolPlus.Migrations
{
    public partial class AddQuestionarioeResposta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questionarios",
                columns: table => new
                {
                    QuestionarioID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Questao = table.Column<string>(nullable: true),
                    Cabecalho = table.Column<string>(nullable: true),
                    UsuarioID = table.Column<int>(nullable: false),
                    ProfessorID = table.Column<int>(nullable: false),
                    RespostaCorretaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionarios", x => x.QuestionarioID);
                });

            migrationBuilder.CreateTable(
                name: "Respostas",
                columns: table => new
                {
                    RespostaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RespostaCorreta = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Respostas", x => x.RespostaID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questionarios");

            migrationBuilder.DropTable(
                name: "Respostas");
        }
    }
}
