using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeopleActzAndPostz.Infrastructure.EntityFramework.Migrations
{
    public partial class SubComment_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubComment",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentBody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PostId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubComment_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubComment_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubComment_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3DF53752-2022-47E8-898E-0CEA6206A47E",
                column: "ConcurrencyStamp",
                value: "98542006-8c86-4743-a81e-16752fdb238b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E4E7B010-DEB1-4BC9-BB59-572332E969D7",
                column: "ConcurrencyStamp",
                value: "f1257841-86f6-48f6-8a4b-8d6ba785a646");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EE72CC84-0CFB-4BA5-8A51-55C3C85D23F2",
                column: "ConcurrencyStamp",
                value: "80ce90cf-9516-43e3-9879-4ef854f733c7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6eeeb2e-9361-44bf-b189-3ed9bb58e495",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2a2da66-bafe-44fe-8167-f77a3dbf4e74", "AQAAAAEAACcQAAAAEE0Kbjw9UuLEBUSUAuF67oPV0okVUu1fbsbxX5shVhY1mfMU3gWQMvJ3JSy/OVHZoA==", "9f336561-7354-474e-a4d9-5f97596d2d5a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9c6085d-d150-43e0-b2e2-1b7d05477d1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1926acc1-a781-4281-8182-8bd0574fd250", "AQAAAAEAACcQAAAAEAcUYogxsJuNBgJtgYTfBhqPYThffKBkMhDHZ3x+o2rtUcZR1Iso+uwCQHTJNqSO+A==", "8ad8b20b-eadc-4ecb-a7fa-8b0d01848f99" });

            migrationBuilder.CreateIndex(
                name: "IX_SubComment_AppUserId",
                table: "SubComment",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubComment_CommentId",
                table: "SubComment",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_SubComment_PostId",
                table: "SubComment",
                column: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubComment");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3DF53752-2022-47E8-898E-0CEA6206A47E",
                column: "ConcurrencyStamp",
                value: "cadcdcec-4fbf-49be-978a-93ee704c04f2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E4E7B010-DEB1-4BC9-BB59-572332E969D7",
                column: "ConcurrencyStamp",
                value: "330f4344-d78c-4bf5-8a7d-ef2f264f56b0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EE72CC84-0CFB-4BA5-8A51-55C3C85D23F2",
                column: "ConcurrencyStamp",
                value: "0598352a-4d1a-48ae-b8fe-95f0ac717947");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6eeeb2e-9361-44bf-b189-3ed9bb58e495",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5fc658e5-a048-4e6e-abdb-19ccba3c927f", "AQAAAAEAACcQAAAAEMlyGyjgYgj9GbWwC8JGd5bQapdRT5ao9NLcBJYqkC9qMkTPCcyW9y8KpH/UfNZ0CQ==", "d8a26b2e-5586-45a4-ac95-e47017504dff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9c6085d-d150-43e0-b2e2-1b7d05477d1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "851ae86d-d593-4b53-8905-07d48b9555e2", "AQAAAAEAACcQAAAAEPTwEpV8AV+85sEmDSraAEsmJPoFdVbEYaqygILVkRREZswT4VvHZpF7Uc+eqxK9TA==", "747ae695-2e14-415c-b140-b7543ee58322" });
        }
    }
}
