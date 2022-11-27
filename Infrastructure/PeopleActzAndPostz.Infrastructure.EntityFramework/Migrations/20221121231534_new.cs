using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeopleActzAndPostz.Infrastructure.EntityFramework.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3DF53752-2022-47E8-898E-0CEA6206A47E",
                column: "ConcurrencyStamp",
                value: "c3bc189c-b441-4187-bab5-c065932b338a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E4E7B010-DEB1-4BC9-BB59-572332E969D7",
                column: "ConcurrencyStamp",
                value: "609d3ae5-5472-4e40-af00-44d95ff8956e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EE72CC84-0CFB-4BA5-8A51-55C3C85D23F2",
                column: "ConcurrencyStamp",
                value: "a4b6273c-5c7b-4c2b-957d-5e15768663d5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6eeeb2e-9361-44bf-b189-3ed9bb58e495",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e956dd6-1dbc-4595-9a26-09fa98f9e57b", "AQAAAAEAACcQAAAAELCsCGIxp2vV9mB4fcIRSu95Ykobdwgy3ZixH1Jg2Ttey9ZJ3fhRtVKn0EpISP03+Q==", "1854c9c4-67ff-4ce3-b68e-e74acf813375" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9c6085d-d150-43e0-b2e2-1b7d05477d1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8544727f-71ec-420d-a900-e20b4442c198", "AQAAAAEAACcQAAAAEG+bzTTggIbo/5Ur0TGz1PtEYXIe18n2BxfT/xIdC/flWcrYNrStEn1PHiC8hmDWbA==", "8b01c3bc-07b3-45ad-8760-fe944978337f" });
        }
    }
}
