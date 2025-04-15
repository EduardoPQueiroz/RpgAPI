using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgAPI.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "TB_ARMAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 71, 151, 33, 66, 135, 183, 199, 163, 111, 68, 33, 67, 243, 205, 90, 230, 53, 54, 202, 110, 86, 123, 1, 14, 79, 5, 248, 135, 125, 204, 180, 42, 138, 143, 4, 110, 197, 211, 40, 76, 87, 245, 53, 230, 7, 165, 73, 120, 18, 156, 49, 123, 31, 242, 176, 149, 194, 10, 217, 42, 158, 80, 84, 203 }, new byte[] { 208, 156, 112, 143, 235, 100, 75, 64, 40, 25, 123, 226, 153, 107, 11, 110, 10, 253, 5, 112, 226, 166, 52, 92, 153, 88, 242, 160, 4, 66, 71, 90, 231, 199, 199, 2, 52, 232, 210, 189, 204, 218, 173, 242, 4, 20, 236, 215, 178, 91, 83, 115, 235, 41, 170, 177, 98, 169, 133, 231, 44, 61, 59, 228, 130, 29, 115, 135, 105, 76, 97, 67, 132, 149, 153, 230, 178, 81, 70, 9, 247, 90, 43, 84, 203, 144, 232, 176, 213, 155, 210, 28, 84, 216, 163, 123, 155, 148, 10, 236, 160, 1, 24, 247, 145, 76, 179, 144, 54, 75, 253, 0, 225, 11, 157, 158, 83, 156, 177, 54, 168, 179, 155, 227, 186, 235, 102, 240 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 6, 145, 58, 242, 200, 166, 133, 164, 92, 117, 34, 91, 132, 101, 109, 209, 163, 155, 173, 90, 243, 212, 161, 215, 76, 168, 113, 192, 97, 248, 176, 232, 249, 40, 73, 0, 211, 202, 28, 205, 53, 25, 234, 109, 191, 203, 75, 132, 190, 178, 203, 50, 46, 199, 97, 35, 87, 210, 156, 39, 96, 94, 1 }, new byte[] { 236, 165, 141, 121, 255, 176, 200, 112, 86, 212, 246, 146, 226, 137, 130, 193, 230, 223, 176, 237, 78, 58, 103, 186, 40, 205, 4, 97, 33, 244, 194, 57, 149, 206, 219, 118, 45, 29, 176, 51, 182, 175, 245, 152, 17, 176, 56, 31, 56, 22, 252, 34, 78, 246, 137, 145, 177, 207, 108, 5, 225, 47, 242, 146, 35, 51, 122, 179, 70, 122, 81, 10, 36, 153, 57, 250, 115, 4, 189, 188, 148, 14, 92, 138, 81, 225, 165, 195, 77, 19, 98, 102, 205, 40, 246, 181, 44, 94, 163, 102, 56, 127, 43, 250, 27, 27, 160, 231, 60, 140, 182, 118, 48, 223, 254, 157, 6, 213, 135, 169, 139, 23, 9, 176, 193, 156, 234, 140 } });
        }
    }
}
