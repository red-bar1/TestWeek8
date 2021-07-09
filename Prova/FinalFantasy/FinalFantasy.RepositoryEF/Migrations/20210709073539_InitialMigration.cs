using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalFantasy.RepositoryEF.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arma",
                columns: table => new
                {
                    Nome = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Danno = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arma", x => x.Nome);
                });

            migrationBuilder.CreateTable(
                name: "Giocatore",
                columns: table => new
                {
                    Nickname = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Giocatore", x => x.Nickname);
                });

            migrationBuilder.CreateTable(
                name: "Mostro",
                columns: table => new
                {
                    Nome = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoriaMostro = table.Column<int>(type: "int", nullable: false),
                    Livello = table.Column<int>(type: "int", nullable: false),
                    ArmaNome = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mostro", x => x.Nome);
                    table.ForeignKey(
                        name: "FK_Mostro_Arma_ArmaNome",
                        column: x => x.ArmaNome,
                        principalTable: "Arma",
                        principalColumn: "Nome",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Eroe",
                columns: table => new
                {
                    Nome = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoriaEroe = table.Column<int>(type: "int", nullable: false),
                    GiocatoreNickname = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PuntiEsperienza = table.Column<int>(type: "int", nullable: false),
                    Livello = table.Column<int>(type: "int", nullable: false),
                    ArmaNome = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eroe", x => x.Nome);
                    table.ForeignKey(
                        name: "FK_Eroe_Arma_ArmaNome",
                        column: x => x.ArmaNome,
                        principalTable: "Arma",
                        principalColumn: "Nome",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Eroe_Giocatore_GiocatoreNickname",
                        column: x => x.GiocatoreNickname,
                        principalTable: "Giocatore",
                        principalColumn: "Nickname",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Arma",
                columns: new[] { "Nome", "Danno" },
                values: new object[,]
                {
                    { "Ascia", 8 },
                    { "Mazza", 5 },
                    { "Spada", 10 },
                    { "Bastone Magico", 10 },
                    { "Bacchetta", 5 },
                    { "Arco e Frecce", 8 },
                    { "Arco", 7 },
                    { "Clava", 5 },
                    { "Divinazione", 15 },
                    { "Fulmine", 10 },
                    { "Tempesta", 8 },
                    { "Tempesta Oscura", 15 }
                });

            migrationBuilder.InsertData(
                table: "Mostro",
                columns: new[] { "Nome", "ArmaNome", "CategoriaMostro", "Livello" },
                values: new object[] { "Qwerty", "Arco", 0, 1 });

            migrationBuilder.InsertData(
                table: "Mostro",
                columns: new[] { "Nome", "ArmaNome", "CategoriaMostro", "Livello" },
                values: new object[] { "Satan", "Fulmine", 1, 2 });

            migrationBuilder.InsertData(
                table: "Mostro",
                columns: new[] { "Nome", "ArmaNome", "CategoriaMostro", "Livello" },
                values: new object[] { "Mefisto", "Tempesta Oscura", 1, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Eroe_ArmaNome",
                table: "Eroe",
                column: "ArmaNome");

            migrationBuilder.CreateIndex(
                name: "IX_Eroe_GiocatoreNickname",
                table: "Eroe",
                column: "GiocatoreNickname");

            migrationBuilder.CreateIndex(
                name: "IX_Mostro_ArmaNome",
                table: "Mostro",
                column: "ArmaNome");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eroe");

            migrationBuilder.DropTable(
                name: "Mostro");

            migrationBuilder.DropTable(
                name: "Giocatore");

            migrationBuilder.DropTable(
                name: "Arma");
        }
    }
}
