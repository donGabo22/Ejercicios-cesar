using Microsoft.EntityFrameworkCore.Migrations;

namespace U3_EXAMEN_PASTELERIA.Migrations
{
    public partial class mmigracion3creo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombredelCliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirecciondelCliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumerodeCelular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipodePastel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pedidos");
        }
    }
}
