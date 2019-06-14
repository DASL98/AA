using Microsoft.EntityFrameworkCore.Migrations;

namespace AA.Migrations
{
    public partial class usuariosiniciales10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoginModel",
                columns: table => new
                {
                    Usuario = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginModel", x => x.Usuario);
                });

            migrationBuilder.InsertData(
                table: "LoginModel",
                columns: new[] { "Usuario", "Password" },
                values: new object[] { "admin", "admin" });

            migrationBuilder.InsertData(
                table: "LoginModel",
                columns: new[] { "Usuario", "Password" },
                values: new object[] { "diego", "diego" });

            migrationBuilder.InsertData(
                table: "LoginModel",
                columns: new[] { "Usuario", "Password" },
                values: new object[] { "giacomo", "giacomo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoginModel");
        }
    }
}
