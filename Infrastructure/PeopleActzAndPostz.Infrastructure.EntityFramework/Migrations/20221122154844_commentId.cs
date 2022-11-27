using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeopleActzAndPostz.Infrastructure.EntityFramework.Migrations
{
    public partial class commentId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3DF53752-2022-47E8-898E-0CEA6206A47E",
                column: "ConcurrencyStamp",
                value: "430654b0-2eb3-42bc-a573-1616aa792821");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E4E7B010-DEB1-4BC9-BB59-572332E969D7",
                column: "ConcurrencyStamp",
                value: "f9b404a6-cdc6-40da-b421-30e35b7be0b9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EE72CC84-0CFB-4BA5-8A51-55C3C85D23F2",
                column: "ConcurrencyStamp",
                value: "56669e81-7e61-47b0-86dd-69a8e6cffafa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6eeeb2e-9361-44bf-b189-3ed9bb58e495",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1775855f-014f-4b28-b020-b6a66e25e447", "AQAAAAEAACcQAAAAEG37QR8201a4za+2xUgFpo4jVhDzL7SUpftfvb748m5mBy0yQszI9/wh6kFUuyE9Mw==", "74b780e5-9dcc-4535-90f3-db08b7c63a99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9c6085d-d150-43e0-b2e2-1b7d05477d1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7410f707-b404-4977-a969-119c6bf65b7a", "AQAAAAEAACcQAAAAEDyc4xsOvsbELElcj5BZvAq4RfxuzW4DS7JU0ulgHWbf90zGLvLbpcEIpBF+UwiHRQ==", "af2207f5-ece5-4354-a28f-191d6f413e5a" });
        }
    }
}
