using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgAPI.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_HABILIDADES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_HABILIDADES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PERSONAGENS_HABILIDADES",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PERSONAGENS_HABILIDADES", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_HABILIDADES_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "TB_HABILIDADES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_PERSONAGENS_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "TB_PERSONAGENS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TB_HABILIDADES",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 39, "Adormecer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnotizar" }
                });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 225, 144, 85, 170, 173, 236, 61, 117, 63, 146, 93, 165, 56, 208, 70, 202, 177, 163, 92, 124, 132, 71, 47, 135, 71, 214, 66, 118, 146, 160, 27, 214, 86, 87, 199, 49, 9, 231, 144, 116, 217, 122, 7, 222, 84, 187, 14, 73, 232, 176, 106, 102, 79, 180, 246, 0, 251, 66, 63, 131, 63, 169, 40, 124 }, new byte[] { 10, 85, 187, 164, 162, 245, 9, 178, 8, 132, 189, 189, 85, 27, 53, 170, 122, 171, 121, 160, 246, 111, 192, 132, 239, 228, 90, 33, 191, 162, 188, 149, 160, 248, 69, 140, 172, 102, 198, 23, 252, 159, 124, 91, 15, 43, 14, 202, 55, 55, 239, 161, 189, 89, 85, 225, 233, 71, 74, 243, 232, 30, 90, 60, 121, 157, 60, 158, 36, 226, 141, 113, 146, 4, 104, 247, 104, 103, 101, 229, 25, 26, 164, 112, 251, 204, 174, 158, 93, 126, 126, 54, 137, 28, 67, 43, 87, 74, 107, 75, 238, 5, 145, 118, 94, 196, 143, 210, 77, 20, 131, 110, 48, 122, 47, 98, 220, 191, 255, 193, 251, 197, 204, 189, 107, 97, 234, 40 } });

            migrationBuilder.InsertData(
                table: "TB_PERSONAGENS_HABILIDADES",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGENS_HABILIDADES_HabilidadeId",
                table: "TB_PERSONAGENS_HABILIDADES",
                column: "HabilidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PERSONAGENS_HABILIDADES");

            migrationBuilder.DropTable(
                name: "TB_HABILIDADES");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 71, 151, 33, 66, 135, 183, 199, 163, 111, 68, 33, 67, 243, 205, 90, 230, 53, 54, 202, 110, 86, 123, 1, 14, 79, 5, 248, 135, 125, 204, 180, 42, 138, 143, 4, 110, 197, 211, 40, 76, 87, 245, 53, 230, 7, 165, 73, 120, 18, 156, 49, 123, 31, 242, 176, 149, 194, 10, 217, 42, 158, 80, 84, 203 }, new byte[] { 208, 156, 112, 143, 235, 100, 75, 64, 40, 25, 123, 226, 153, 107, 11, 110, 10, 253, 5, 112, 226, 166, 52, 92, 153, 88, 242, 160, 4, 66, 71, 90, 231, 199, 199, 2, 52, 232, 210, 189, 204, 218, 173, 242, 4, 20, 236, 215, 178, 91, 83, 115, 235, 41, 170, 177, 98, 169, 133, 231, 44, 61, 59, 228, 130, 29, 115, 135, 105, 76, 97, 67, 132, 149, 153, 230, 178, 81, 70, 9, 247, 90, 43, 84, 203, 144, 232, 176, 213, 155, 210, 28, 84, 216, 163, 123, 155, 148, 10, 236, 160, 1, 24, 247, 145, 76, 179, 144, 54, 75, 253, 0, 225, 11, 157, 158, 83, 156, 177, 54, 168, 179, 155, 227, 186, 235, 102, 240 } });
        }
    }
}
