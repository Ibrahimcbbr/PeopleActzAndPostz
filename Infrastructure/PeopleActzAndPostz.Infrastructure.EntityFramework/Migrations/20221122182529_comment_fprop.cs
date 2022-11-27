using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeopleActzAndPostz.Infrastructure.EntityFramework.Migrations
{
    public partial class comment_fprop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubComments_AspNetUsers_AppUserId",
                table: "SubComments");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "SubComments",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_SubComments_AppUserId",
                table: "SubComments",
                newName: "IX_SubComments_UserId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3DF53752-2022-47E8-898E-0CEA6206A47E",
                column: "ConcurrencyStamp",
                value: "118cb737-a354-4f83-a08f-b9b778b15b36");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E4E7B010-DEB1-4BC9-BB59-572332E969D7",
                column: "ConcurrencyStamp",
                value: "b878f983-6295-4427-8e17-fe3aba3b7317");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EE72CC84-0CFB-4BA5-8A51-55C3C85D23F2",
                column: "ConcurrencyStamp",
                value: "7c2162bf-f515-48ae-b5be-82b2e56c623b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6eeeb2e-9361-44bf-b189-3ed9bb58e495",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01ae3083-b942-4798-93b6-40b84ced8377", "AQAAAAEAACcQAAAAEGZ9L+Ig217IJ0FviTF9RBIrHHegxPXcZRRN1QRCK3uR0eMVU0SDi3TRYILUMO6F/g==", "98b84173-2679-48e0-bef9-eff6769c2930" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9c6085d-d150-43e0-b2e2-1b7d05477d1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a43b87b-52da-4ba4-aedc-272a542057f2", "AQAAAAEAACcQAAAAENlEkBnhGJIeshAv1zfaYBk6MepC4VuvN8NCgFB57cDk5Q4ISRflB5nCL+Qjt1dMig==", "4fae3fd6-9ef8-42c8-aa6d-3d94f2105083" });

            migrationBuilder.AddForeignKey(
                name: "FK_SubComments_AspNetUsers_UserId",
                table: "SubComments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubComments_AspNetUsers_UserId",
                table: "SubComments");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "SubComments",
                newName: "AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_SubComments_UserId",
                table: "SubComments",
                newName: "IX_SubComments_AppUserId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3DF53752-2022-47E8-898E-0CEA6206A47E",
                column: "ConcurrencyStamp",
                value: "604af14c-6c54-4f99-a071-f4465587e38b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E4E7B010-DEB1-4BC9-BB59-572332E969D7",
                column: "ConcurrencyStamp",
                value: "6ea0946e-d44f-49af-a903-c97d7897876e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EE72CC84-0CFB-4BA5-8A51-55C3C85D23F2",
                column: "ConcurrencyStamp",
                value: "bb8b1d07-b498-424e-bd7f-1f481ce67ff1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6eeeb2e-9361-44bf-b189-3ed9bb58e495",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f59476eb-9146-4981-8ea0-74eeba958d06", "AQAAAAEAACcQAAAAED6Zy6Pkin4VxDdoaU1ky6lQYnndNQu05OYPK5FsilSYO91Wog693NQdmgByUGhXWQ==", "2c17c2ea-b6ca-4767-8bd3-9f039780e9b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9c6085d-d150-43e0-b2e2-1b7d05477d1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a47ead07-a099-4ff1-9ada-9377a52495e6", "AQAAAAEAACcQAAAAEH3o6KDoZkkE2AEWJKZTduTVUDnB33cCkzT2+UQLJoRHPEgY5O/jgJIf17f1P83XBg==", "cce4ec9d-a623-40ed-95b3-51c8d72f979a" });

            migrationBuilder.AddForeignKey(
                name: "FK_SubComments_AspNetUsers_AppUserId",
                table: "SubComments",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
