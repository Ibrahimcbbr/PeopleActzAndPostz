using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeopleActzAndPostz.Infrastructure.EntityFramework.Migrations
{
    public partial class Comment_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BodyContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comment_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3DF53752-2022-47E8-898E-0CEA6206A47E",
                column: "ConcurrencyStamp",
                value: "a2f59075-6038-4548-acc9-9b3e8b4c4b31");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E4E7B010-DEB1-4BC9-BB59-572332E969D7",
                column: "ConcurrencyStamp",
                value: "7eb1326f-c500-4d69-aa63-211c77001c83");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EE72CC84-0CFB-4BA5-8A51-55C3C85D23F2",
                column: "ConcurrencyStamp",
                value: "2c2a94e2-38ea-4d23-8a24-323830a25e68");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6eeeb2e-9361-44bf-b189-3ed9bb58e495",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "928bf319-aaea-4383-b263-e447231edead", "AQAAAAEAACcQAAAAEKk+C6w8gLmETXs99G55O72njRg2d8v1fIKUcrNRmhfD/VKlzXWvmwoGEJlBzIIW2A==", "3b731822-fc49-4e52-aa9b-bdd523560b9b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9c6085d-d150-43e0-b2e2-1b7d05477d1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be9cdce0-cdec-439f-8f2d-f7c1dc1988ed", "AQAAAAEAACcQAAAAEEbdw+qfB1Fpre6+hTY4DVW5Mej1dzVPJpnu3OzFK7U7i/C+3hh405WzbRWObbXtdA==", "ec731baf-0bee-4a6c-b733-c13e975b2191" });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_AppUserId",
                table: "Comment",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_PostId",
                table: "Comment",
                column: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

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
    }
}
