using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgAPI.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoArma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_ARMAS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ARMAS", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TB_ARMAS",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 35, "Arco e Flecha" },
                    { 2, 33, "Espada" },
                    { 3, 31, "Machado" },
                    { 4, 30, "Punho" },
                    { 5, 34, "Chicote" },
                    { 6, 33, "Foice" },
                    { 7, 32, "Cajado" }
                });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 6, 145, 58, 242, 200, 166, 133, 164, 92, 117, 34, 91, 132, 101, 109, 209, 163, 155, 173, 90, 243, 212, 161, 215, 76, 168, 113, 192, 97, 248, 176, 232, 249, 40, 73, 0, 211, 202, 28, 205, 53, 25, 234, 109, 191, 203, 75, 132, 190, 178, 203, 50, 46, 199, 97, 35, 87, 210, 156, 39, 96, 94, 1 }, new byte[] { 236, 165, 141, 121, 255, 176, 200, 112, 86, 212, 246, 146, 226, 137, 130, 193, 230, 223, 176, 237, 78, 58, 103, 186, 40, 205, 4, 97, 33, 244, 194, 57, 149, 206, 219, 118, 45, 29, 176, 51, 182, 175, 245, 152, 17, 176, 56, 31, 56, 22, 252, 34, 78, 246, 137, 145, 177, 207, 108, 5, 225, 47, 242, 146, 35, 51, 122, 179, 70, 122, 81, 10, 36, 153, 57, 250, 115, 4, 189, 188, 148, 14, 92, 138, 81, 225, 165, 195, 77, 19, 98, 102, 205, 40, 246, 181, 44, 94, 163, 102, 56, 127, 43, 250, 27, 27, 160, 231, 60, 140, 182, 118, 48, 223, 254, 157, 6, 213, 135, 169, 139, 23, 9, 176, 193, 156, 234, 140 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_ARMAS");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 57, 105, 29, 203, 12, 109, 114, 88, 128, 40, 126, 29, 90, 165, 82, 115, 79, 96, 90, 173, 252, 53, 60, 221, 226, 241, 213, 54, 251, 238, 126, 216, 0, 225, 171, 56, 48, 180, 181, 204, 72, 99, 118, 201, 150, 222, 102, 246, 195, 8, 147, 163, 203, 161, 171, 71, 11, 147, 193, 193, 82, 5, 130, 7 }, new byte[] { 101, 55, 121, 27, 116, 38, 26, 152, 245, 212, 214, 159, 177, 182, 212, 32, 180, 116, 62, 48, 148, 246, 64, 204, 80, 159, 163, 92, 205, 208, 178, 224, 6, 102, 113, 6, 144, 38, 22, 143, 213, 192, 22, 176, 251, 250, 20, 208, 182, 63, 91, 70, 148, 193, 41, 47, 11, 156, 148, 254, 112, 201, 90, 148, 235, 32, 82, 179, 185, 135, 96, 149, 122, 180, 55, 38, 224, 119, 71, 77, 119, 96, 102, 141, 110, 140, 29, 166, 29, 143, 88, 0, 50, 200, 26, 192, 111, 87, 108, 245, 219, 195, 208, 47, 17, 230, 1, 196, 142, 144, 38, 217, 37, 82, 181, 124, 42, 9, 24, 9, 153, 155, 17, 12, 72, 124, 196, 111 } });
        }
    }
}
