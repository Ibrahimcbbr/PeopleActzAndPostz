using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeopleActzAndPostz.Infrastructure.EntityFramework.Migrations
{
    public partial class post_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_AspNetUsers_AppUserId",
                table: "Post");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Post",
                table: "Post");

            migrationBuilder.RenameTable(
                name: "Post",
                newName: "Posts");

            migrationBuilder.RenameIndex(
                name: "IX_Post_AppUserId",
                table: "Posts",
                newName: "IX_Posts_AppUserId");

            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "Posts",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_AppUserId",
                table: "Posts",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_AppUserId",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.RenameTable(
                name: "Posts",
                newName: "Post");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_AppUserId",
                table: "Post",
                newName: "IX_Post_AppUserId");

            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "Post",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Post",
                table: "Post",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3DF53752-2022-47E8-898E-0CEA6206A47E",
                column: "ConcurrencyStamp",
                value: "5de6bf05-04f8-4887-b287-d6ab53d351e7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E4E7B010-DEB1-4BC9-BB59-572332E969D7",
                column: "ConcurrencyStamp",
                value: "02603e73-185e-4d8b-94e5-ce9a0f2113d9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EE72CC84-0CFB-4BA5-8A51-55C3C85D23F2",
                column: "ConcurrencyStamp",
                value: "a99d057f-e1de-4f39-a2c2-288ae515daed");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6eeeb2e-9361-44bf-b189-3ed9bb58e495",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ac72535-d239-4724-8d49-77a8b4f8818f", "AQAAAAEAACcQAAAAEIh8A3/lTix2gnM6JJayYPX7NJzgqiU+NmpVVSFPG0Gq7uzwAc3/YFMYQ3s53RjhRQ==", "8a5872fd-57f1-4741-9cff-1e26485c0a20" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9c6085d-d150-43e0-b2e2-1b7d05477d1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcb47f9b-67b8-452b-af24-b112008de937", "AQAAAAEAACcQAAAAEN534upEnnoM1ien9MwIteejRwX0+3FccCoNP737Gkm9Rbv4PyYKcSroe7Vjge5nSA==", "c62b2796-c18e-4c3f-a15a-9f2d85ede546" });

            migrationBuilder.AddForeignKey(
                name: "FK_Post_AspNetUsers_AppUserId",
                table: "Post",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
