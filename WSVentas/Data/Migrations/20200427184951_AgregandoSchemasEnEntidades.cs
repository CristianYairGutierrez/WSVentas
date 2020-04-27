using Microsoft.EntityFrameworkCore.Migrations;

namespace WSVentas.Migrations
{
    public partial class AgregandoSchemasEnEntidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Ingresos");

            migrationBuilder.RenameTable(
                name: "Ventas",
                newName: "Ventas",
                newSchema: "Ingresos");

            migrationBuilder.RenameTable(
                name: "Productos",
                newName: "Productos",
                newSchema: "Ingresos");

            migrationBuilder.RenameTable(
                name: "Conceptos",
                newName: "Conceptos",
                newSchema: "Ingresos");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "Clientes",
                newSchema: "Ingresos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Ventas",
                schema: "Ingresos",
                newName: "Ventas");

            migrationBuilder.RenameTable(
                name: "Productos",
                schema: "Ingresos",
                newName: "Productos");

            migrationBuilder.RenameTable(
                name: "Conceptos",
                schema: "Ingresos",
                newName: "Conceptos");

            migrationBuilder.RenameTable(
                name: "Clientes",
                schema: "Ingresos",
                newName: "Clientes");
        }
    }
}
