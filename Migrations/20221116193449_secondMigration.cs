using Microsoft.EntityFrameworkCore.Migrations;

namespace last_test_tech.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CV_path",
                schema: "CD",
                table: "Candidatures",
                type: "varchar(200)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CV_path",
                schema: "CD",
                table: "Candidatures");
        }
    }
}
