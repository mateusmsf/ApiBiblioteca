using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace biblioteca.WEBAPI.Migrations
{
    public partial class first_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(nullable: true),
                    curso = table.Column<string>(nullable: true),
                    periodo = table.Column<int>(nullable: false),
                    idade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Bibliotecarias",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(nullable: true),
                    idade = table.Column<int>(nullable: false),
                    dt_admissao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bibliotecarias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(nullable: true),
                    tema = table.Column<string>(nullable: true),
                    qtd_pg = table.Column<int>(nullable: false),
                    autor = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Emprestimos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data = table.Column<DateTime>(nullable: false),
                    devolucao = table.Column<DateTime>(nullable: false),
                    alunoId = table.Column<int>(nullable: false),
                    bibliotecariaid = table.Column<int>(nullable: true),
                    bibliotecaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emprestimos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Emprestimos_Alunos_alunoId",
                        column: x => x.alunoId,
                        principalTable: "Alunos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Emprestimos_Bibliotecarias_bibliotecariaid",
                        column: x => x.bibliotecariaid,
                        principalTable: "Bibliotecarias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Emprestimos_alunoId",
                table: "Emprestimos",
                column: "alunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Emprestimos_bibliotecariaid",
                table: "Emprestimos",
                column: "bibliotecariaid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emprestimos");

            migrationBuilder.DropTable(
                name: "Livros");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Bibliotecarias");
        }
    }
}
