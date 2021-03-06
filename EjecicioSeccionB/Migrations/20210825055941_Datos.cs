using Microsoft.EntityFrameworkCore.Migrations;

namespace EjecicioSeccionB.Migrations
{
    public partial class Datos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_personas",
                columns: table => new
                {
                    CodigoPersona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePersona = table.Column<string>(type: "varchar(35)", nullable: false),
                    ApellidoPersona = table.Column<string>(type: "varchar(35)", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    EstadoPersona = table.Column<string>(type: "varchar(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_personas", x => x.CodigoPersona);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_personas");
        }
    }
}
