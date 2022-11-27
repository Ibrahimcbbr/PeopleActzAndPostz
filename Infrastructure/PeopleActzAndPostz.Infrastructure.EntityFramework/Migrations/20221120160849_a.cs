using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeopleActzAndPostz.Infrastructure.EntityFramework.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3DF53752-2022-47E8-898E-0CEA6206A47E",
                column: "ConcurrencyStamp",
                value: "5904f35a-a121-4834-b583-4c2b6ab79635");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E4E7B010-DEB1-4BC9-BB59-572332E969D7",
                column: "ConcurrencyStamp",
                value: "184fa10b-69c5-4084-ae2a-8e25fb11b13f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EE72CC84-0CFB-4BA5-8A51-55C3C85D23F2",
                column: "ConcurrencyStamp",
                value: "5ba49de5-0563-4827-9f19-cf3205566a4a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6eeeb2e-9361-44bf-b189-3ed9bb58e495",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91d6ce13-8c5f-48a1-88eb-265c09c4fa2b", "AQAAAAEAACcQAAAAEAI618b49Tc25ELfKafFENfgBiwDEn2RGJgCRQVLx8RR2VjfhD+N+meJZAWhuzD2bg==", "ebc211d3-9a1b-44e5-ae41-b71188a897a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9c6085d-d150-43e0-b2e2-1b7d05477d1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05d5267a-3bcf-4b47-b5da-558203f3f5f6", "AQAAAAEAACcQAAAAEDVAVYJxKmYm8LmJv+XTq3Vz0xR32J2Sbd8pst9fEO0lIFllrU2AADnyx1/0Tdh53g==", "2b5ea2db-96a9-4331-80a1-57346725a863" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3DF53752-2022-47E8-898E-0CEA6206A47E",
                column: "ConcurrencyStamp",
                value: "a01e92b2-6e42-4753-99ed-5c95dc506c23");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E4E7B010-DEB1-4BC9-BB59-572332E969D7",
                column: "ConcurrencyStamp",
                value: "20bf6f01-e0d4-4a53-aabb-5eaccb855b5a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EE72CC84-0CFB-4BA5-8A51-55C3C85D23F2",
                column: "ConcurrencyStamp",
                value: "9764e1c3-2b8a-40eb-9866-3e3b9c1f0dc6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6eeeb2e-9361-44bf-b189-3ed9bb58e495",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1447fe8a-4aab-4137-a36f-b4dede23f58b", "AQAAAAEAACcQAAAAEOj8Q4yxQMpAmXoQRu4J/arrgVBRTqm8Yxuq4OIeDDwon4WTgNnBRima4IQvRCJfSw==", "7fcdefc1-3320-45a9-a681-335312a9da3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9c6085d-d150-43e0-b2e2-1b7d05477d1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17291023-6d0a-4517-b52f-5fa89352d45f", "AQAAAAEAACcQAAAAEPClrh6aHg/EyF6HK55DjtyBFdAVMZXkv1kxJMlwxcFyFh213ArqqyWPqXrjLhoyyA==", "e360dfac-3ec9-4a66-bc83-cfd876ae94ec" });
        }
    }
}
