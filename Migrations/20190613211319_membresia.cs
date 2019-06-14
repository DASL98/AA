using Microsoft.EntityFrameworkCore.Migrations;

namespace AA.Migrations
{
    public partial class membresia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mascotas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Mascotas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Mascotas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Mascotas",
                keyColumn: "Id",
                keyValue: 4);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Mascotas",
                columns: new[] { "Id", "CodigoMascota", "Edad", "Foto", "NombreMascota", "Peso", "TipoId" },
                values: new object[,]
                {
                    { 1, "ACM2PL", 18, "https://estaticos.muyinteresante.es/media/cache/760x570_thumb/uploads/images/article/5c3871215bafe83b078adbe3/perro.jpg", "Julito", 1900, 1 },
                    { 2, "RGM2PL", 5, "https://mxcity.mx/wp-content/uploads/2017/08/1-9.jpg", "Ronina", 800, 1 },
                    { 3, "GAT001", 2, "https://www.notigatos.es/wp-content/uploads/2017/10/gatito-830x552.jpg", "Michi", 250, 2 },
                    { 4, "TAPIR590", 19, "https://www.elpopular.pe/sites/default/files/styles/img_620x465/public/imagen/2019/03/22/Noticia-232947-youtube_tapir_590_sufre_estafa_con_sus_redes_sociales_y_hace_pedido_a_seguidores.png?itok=NeTL_yoG", "Oliver", 590, 3 }
                });
        }
    }
}
