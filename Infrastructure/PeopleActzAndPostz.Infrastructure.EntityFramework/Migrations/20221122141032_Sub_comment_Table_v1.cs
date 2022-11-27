using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeopleActzAndPostz.Infrastructure.EntityFramework.Migrations
{
    public partial class Sub_comment_Table_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubComment_AspNetUsers_AppUserId",
                table: "SubComment");

            migrationBuilder.DropForeignKey(
                name: "FK_SubComment_Comments_CommentId",
                table: "SubComment");

            migrationBuilder.DropForeignKey(
                name: "FK_SubComment_Posts_PostId",
                table: "SubComment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubComment",
                table: "SubComment");

            migrationBuilder.RenameTable(
                name: "SubComment",
                newName: "SubComments");

            migrationBuilder.RenameIndex(
                name: "IX_SubComment_PostId",
                table: "SubComments",
                newName: "IX_SubComments_PostId");

            migrationBuilder.RenameIndex(
                name: "IX_SubComment_CommentId",
                table: "SubComments",
                newName: "IX_SubComments_CommentId");

            migrationBuilder.RenameIndex(
                name: "IX_SubComment_AppUserId",
                table: "SubComments",
                newName: "IX_SubComments_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubComments",
                table: "SubComments",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_SubComments_AspNetUsers_AppUserId",
                table: "SubComments",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubComments_Comments_CommentId",
                table: "SubComments",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubComments_Posts_PostId",
                table: "SubComments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubComments_AspNetUsers_AppUserId",
                table: "SubComments");

            migrationBuilder.DropForeignKey(
                name: "FK_SubComments_Comments_CommentId",
                table: "SubComments");

            migrationBuilder.DropForeignKey(
                name: "FK_SubComments_Posts_PostId",
                table: "SubComments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubComments",
                table: "SubComments");

            migrationBuilder.RenameTable(
                name: "SubComments",
                newName: "SubComment");

            migrationBuilder.RenameIndex(
                name: "IX_SubComments_PostId",
                table: "SubComment",
                newName: "IX_SubComment_PostId");

            migrationBuilder.RenameIndex(
                name: "IX_SubComments_CommentId",
                table: "SubComment",
                newName: "IX_SubComment_CommentId");

            migrationBuilder.RenameIndex(
                name: "IX_SubComments_AppUserId",
                table: "SubComment",
                newName: "IX_SubComment_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubComment",
                table: "SubComment",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_SubComment_AspNetUsers_AppUserId",
                table: "SubComment",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubComment_Comments_CommentId",
                table: "SubComment",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubComment_Posts_PostId",
                table: "SubComment",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id");
        }
    }
}
