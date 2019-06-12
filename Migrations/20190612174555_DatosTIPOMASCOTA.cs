using Microsoft.EntityFrameworkCore.Migrations;

namespace AA.Migrations
{
    public partial class DatosTIPOMASCOTA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tipos",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 1, "Perro" });

            migrationBuilder.InsertData(
                table: "Tipos",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 2, "Gato" });

            migrationBuilder.InsertData(
                table: "Tipos",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 3, "Tapir" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
