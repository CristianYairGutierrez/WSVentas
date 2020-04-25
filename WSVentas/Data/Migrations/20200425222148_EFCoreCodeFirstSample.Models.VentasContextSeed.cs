using Microsoft.EntityFrameworkCore.Migrations;

namespace WSVentas.Migrations
{
    public partial class EFCoreCodeFirstSampleModelsVentasContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 1, "Cristian" });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 2, "Fister" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
