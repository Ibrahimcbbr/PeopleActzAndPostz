using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeopleActzAndPostz.Infrastructure.EntityFramework.Migrations
{
    public partial class s : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3DF53752-2022-47E8-898E-0CEA6206A47E",
                column: "ConcurrencyStamp",
                value: "18eac3fd-ccfb-4803-9c47-9171b5b72b42");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E4E7B010-DEB1-4BC9-BB59-572332E969D7",
                column: "ConcurrencyStamp",
                value: "47c9a9f3-1aa5-40f8-8450-a8994131f7a5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EE72CC84-0CFB-4BA5-8A51-55C3C85D23F2",
                column: "ConcurrencyStamp",
                value: "7d9be3a6-2ffc-4655-9d8c-7b778ffc7f67");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6eeeb2e-9361-44bf-b189-3ed9bb58e495",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "327dbc0a-6168-41d5-b783-55454a790a3c", "AQAAAAEAACcQAAAAECmjORexHgpbrnPhU3eakmRdWKv2DNo4bHdN0CrNAVcXZUo9PHh9C3qmghsOeANO8Q==", "09b9528b-8c5e-4eec-8821-bd7950835886" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9c6085d-d150-43e0-b2e2-1b7d05477d1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a13e6a3-4136-46b0-8b6f-c07ff0c965c9", "AQAAAAEAACcQAAAAEF+QKhFgjkYKSWac87eNOWNjrFVeUV+ov7CaLl7bwpGb5buEgtDlM6ALu5CW8p+AQg==", "9cfa04cb-0476-4c9d-9d0d-8e6871ec8bd7" });
        }
    }
}
