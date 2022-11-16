using Microsoft.EntityFrameworkCore.Migrations;

namespace last_test_tech.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "CD");

            migrationBuilder.CreateTable(
                name: "Candidatures",
                schema: "CD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "varchar(50)", nullable: false),
                    prenom = table.Column<string>(type: "varchar(50)", nullable: false),
                    mail = table.Column<string>(type: "varchar(200)", nullable: false),
                    tele = table.Column<int>(type: "int", nullable: false),
                    niveau_detude = table.Column<string>(type: "varchar(25)", nullable: false),
                    nbr_anne_exp = table.Column<int>(type: "int", nullable: false),
                    dn_employeur = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidatures", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidatures",
                schema: "CD");
        }
    }
}
