using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thread_.NET.DAL.Migrations
{
    public partial class postsAndCommentsSoftDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Posts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Comments",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 20, new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(2840), new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(3300), 2 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 17, new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(3937), new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(3949), 6 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 4, new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(3991), false, new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(3999), 19 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4034), new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4040), 10 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 19, new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4075), new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4081), 6 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 20, new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4116), new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4122), 16 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 4, new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4156), new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4162), 12 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 9, new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4196), true, new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4202), 5 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 2, new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4237), false, new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4243), 10 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 15, new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4275), false, new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4281), 12 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 2, new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4314), new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4320), 11 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 15, new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4473), new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4481), 4 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 11, new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4521), new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4527), 15 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 17, new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4561), true, new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4567), 15 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt" },
                values: new object[] { 13, new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4601), true, new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 9, new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4640), new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4646), 10 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 4, new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4680), new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4686), 5 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 2, new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4718), new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4724), 10 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 18, new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4758), new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4764), 20 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 17, new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4797), new DateTime(2019, 6, 11, 14, 9, 30, 953, DateTimeKind.Local).AddTicks(4803), 21 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 9, "Libero provident ut unde occaecati qui vel.", new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(4559), 5, new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 5, "Voluptatum ab quo.", new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(6133), 20, new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 5, "Facere odio provident nobis ducimus saepe quod doloribus.", new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(6292), 16, new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 12, "Nemo sapiente quia.", new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(6408), 3, new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 16, "Voluptas reiciendis doloribus ea optio ducimus perferendis asperiores est.", new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(6536), 7, new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(6543) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 1, "Magnam cupiditate dolorum magnam nihil voluptate expedita exercitationem.", new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(6702), 3, new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 8, "Autem ex enim placeat fugit quasi odio accusantium ut.", new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(6799), 6, new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 2, "Ut reiciendis nemo.", new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(6873), 20, new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 9, "Eligendi tempore quia quam ut maiores dolore.", new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(6958), 2, new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(6965) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 5, "Assumenda rerum vel possimus et.", new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(7038), 4, new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(7046) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 20, "Eum cumque ut.", new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(7111), 7, new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Dolor minima sapiente ducimus eum enim in aliquid.", new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(7219), 16, new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(7226) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 11, "Odio id quis aut quia.", new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(7303), 15, new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(7311) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 12, "Sit quaerat expedita.", new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(7374), 11, new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(7381) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 17, "Aperiam dolor ullam tempore quis dolorum.", new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(7454), 7, new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(7462) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { "Quidem et accusantium quibusdam doloremque repellendus.", new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(7542), 9, new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 18, "Eaque ducimus numquam animi.", new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(7617), 20, new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(7624) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 4, "Adipisci velit et.", new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(7691), 9, new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(7698) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 11, "Est molestiae doloremque ut.", new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(7783), 2, new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Vel sequi sed aut quia minus earum ullam.", new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(7874), 14, new DateTime(2019, 6, 11, 14, 9, 30, 937, DateTimeKind.Local).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(1462), "https://s3.amazonaws.com/uifaces/faces/twitter/andysolomon/128.jpg", new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(8141) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9105), "https://s3.amazonaws.com/uifaces/faces/twitter/krystalfister/128.jpg", new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9118) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9158), "https://s3.amazonaws.com/uifaces/faces/twitter/jonsgotwood/128.jpg", new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9287), "https://s3.amazonaws.com/uifaces/faces/twitter/jefffis/128.jpg", new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9294) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9330), "https://s3.amazonaws.com/uifaces/faces/twitter/karlkanall/128.jpg", new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9368), "https://s3.amazonaws.com/uifaces/faces/twitter/rawdiggie/128.jpg", new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9406), "https://s3.amazonaws.com/uifaces/faces/twitter/constantx/128.jpg", new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9443), "https://s3.amazonaws.com/uifaces/faces/twitter/dmitriychuta/128.jpg", new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9449) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9479), "https://s3.amazonaws.com/uifaces/faces/twitter/cboller1/128.jpg", new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9514), "https://s3.amazonaws.com/uifaces/faces/twitter/felipeapiress/128.jpg", new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9549), "https://s3.amazonaws.com/uifaces/faces/twitter/badlittleduck/128.jpg", new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9586), "https://s3.amazonaws.com/uifaces/faces/twitter/kinday/128.jpg", new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9592) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9620), "https://s3.amazonaws.com/uifaces/faces/twitter/mattlat/128.jpg", new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9655), "https://s3.amazonaws.com/uifaces/faces/twitter/balintorosz/128.jpg", new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9661) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9690), "https://s3.amazonaws.com/uifaces/faces/twitter/wintopia/128.jpg", new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9727), "https://s3.amazonaws.com/uifaces/faces/twitter/dshster/128.jpg", new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9733) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9763), "https://s3.amazonaws.com/uifaces/faces/twitter/silv3rgvn/128.jpg", new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9768) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9798), "https://s3.amazonaws.com/uifaces/faces/twitter/meelford/128.jpg", new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9834), "https://s3.amazonaws.com/uifaces/faces/twitter/dgclegg/128.jpg", new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9869), "https://s3.amazonaws.com/uifaces/faces/twitter/randomlies/128.jpg", new DateTime(2019, 6, 11, 14, 9, 30, 733, DateTimeKind.Local).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(4958), "https://picsum.photos/640/480/?image=24", new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(5427) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(5597), "https://picsum.photos/640/480/?image=434", new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(5645), "https://picsum.photos/640/480/?image=484", new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(5652) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(5682), "https://picsum.photos/640/480/?image=532", new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(5688) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(5773), "https://picsum.photos/640/480/?image=355", new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(5779) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(5810), "https://picsum.photos/640/480/?image=213", new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(5845), "https://picsum.photos/640/480/?image=445", new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(5851) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(5879), "https://picsum.photos/640/480/?image=832", new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(5913), "https://picsum.photos/640/480/?image=788", new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(5946), "https://picsum.photos/640/480/?image=777", new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(5979), "https://picsum.photos/640/480/?image=401", new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(6012), "https://picsum.photos/640/480/?image=622", new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(6044), "https://picsum.photos/640/480/?image=552", new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(6077), "https://picsum.photos/640/480/?image=71", new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(6112), "https://picsum.photos/640/480/?image=1077", new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(6117) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(6145), "https://picsum.photos/640/480/?image=248", new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(6151) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(6259), "https://picsum.photos/640/480/?image=8", new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(6298), "https://picsum.photos/640/480/?image=846", new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(6304) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(6332), "https://picsum.photos/640/480/?image=92", new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(6337) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(6366), "https://picsum.photos/640/480/?image=95", new DateTime(2019, 6, 11, 14, 9, 30, 739, DateTimeKind.Local).AddTicks(6371) });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(2457), 17, new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(2937), 7 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(3673), 2, new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(3688), 11 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(3731), 20, new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(3738), 10 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(3829), 2, new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(3836), 13 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(3875), true, 4, new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(3917), true, 7, new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(3923) });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(3957), false, 14, new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(3963), 17 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(3996), true, 15, new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(4002), 16 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(4036), false, 19, new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(4042), 19 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(4074), true, 2, new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(4079), 11 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(4114), new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(4119), 17 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(4152), false, 17, new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(4158), 15 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(4191), false, 5, new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(4230), true, 19, new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(4236), 18 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(4268), false, 2, new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(4273), 17 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(4308), true, 14, new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(4314), 16 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(4348), 5, new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(4353), 2 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(4388), false, 19, new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(4394), 15 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(4427), false, 12, new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(4433), 20 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(4465), 13, new DateTime(2019, 6, 11, 14, 9, 30, 946, DateTimeKind.Local).AddTicks(4471), 13 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 11, @"Explicabo ducimus odio hic voluptas asperiores.
Id est quas nihil neque quia.
Quo ipsam est tempore ullam voluptatibus.", new DateTime(2019, 6, 11, 14, 9, 30, 929, DateTimeKind.Local).AddTicks(3492), 37, new DateTime(2019, 6, 11, 14, 9, 30, 929, DateTimeKind.Local).AddTicks(3972) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 8, "quis", new DateTime(2019, 6, 11, 14, 9, 30, 929, DateTimeKind.Local).AddTicks(5098), 22, new DateTime(2019, 6, 11, 14, 9, 30, 929, DateTimeKind.Local).AddTicks(5114) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 4, "Voluptatem voluptas natus et. Impedit modi voluptatem illum animi qui delectus deserunt voluptates. Tempore voluptate facere magnam. Consequatur repudiandae magnam voluptatem ea est id.", new DateTime(2019, 6, 11, 14, 9, 30, 929, DateTimeKind.Local).AddTicks(7686), 24, new DateTime(2019, 6, 11, 14, 9, 30, 929, DateTimeKind.Local).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 3, "Dolor dolores officia quia. Molestias nemo soluta corrupti illo temporibus architecto nulla perferendis. Qui sed et tempore. Id expedita et odit beatae ullam dolore.", new DateTime(2019, 6, 11, 14, 9, 30, 929, DateTimeKind.Local).AddTicks(7966), 25, new DateTime(2019, 6, 11, 14, 9, 30, 929, DateTimeKind.Local).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 3, "aut", new DateTime(2019, 6, 11, 14, 9, 30, 929, DateTimeKind.Local).AddTicks(8038), 39, new DateTime(2019, 6, 11, 14, 9, 30, 929, DateTimeKind.Local).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 4, "Aspernatur voluptatem a consequatur eveniet dignissimos similique magni possimus.", new DateTime(2019, 6, 11, 14, 9, 30, 929, DateTimeKind.Local).AddTicks(9669), 23, new DateTime(2019, 6, 11, 14, 9, 30, 929, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 11, "Voluptate sit vitae sed adipisci officiis.", new DateTime(2019, 6, 11, 14, 9, 30, 929, DateTimeKind.Local).AddTicks(9789), 31, new DateTime(2019, 6, 11, 14, 9, 30, 929, DateTimeKind.Local).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 12, "deleniti", new DateTime(2019, 6, 11, 14, 9, 30, 929, DateTimeKind.Local).AddTicks(9849), 22, new DateTime(2019, 6, 11, 14, 9, 30, 929, DateTimeKind.Local).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 21, "In totam earum.", new DateTime(2019, 6, 11, 14, 9, 30, 929, DateTimeKind.Local).AddTicks(9926), 37, new DateTime(2019, 6, 11, 14, 9, 30, 929, DateTimeKind.Local).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, @"Voluptatem neque consequatur omnis.
Aperiam non tempore voluptatibus.
Debitis vero consequatur dicta earum in possimus et omnis ut.", new DateTime(2019, 6, 11, 14, 9, 30, 930, DateTimeKind.Local).AddTicks(157), 21, new DateTime(2019, 6, 11, 14, 9, 30, 930, DateTimeKind.Local).AddTicks(164) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 12, "Ex asperiores nam vel veniam modi rerum neque. Possimus et est quam quo. Asperiores reprehenderit et sed nobis ea minima.", new DateTime(2019, 6, 11, 14, 9, 30, 930, DateTimeKind.Local).AddTicks(330), 30, new DateTime(2019, 6, 11, 14, 9, 30, 930, DateTimeKind.Local).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 9, "Quo possimus a.", new DateTime(2019, 6, 11, 14, 9, 30, 930, DateTimeKind.Local).AddTicks(453), 23, new DateTime(2019, 6, 11, 14, 9, 30, 930, DateTimeKind.Local).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 15, "Eos aut ipsa eos vero optio cum.", new DateTime(2019, 6, 11, 14, 9, 30, 930, DateTimeKind.Local).AddTicks(549), 40, new DateTime(2019, 6, 11, 14, 9, 30, 930, DateTimeKind.Local).AddTicks(556) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { @"Pariatur suscipit non.
Ad facilis laboriosam expedita iste.
Architecto et eos ducimus.", new DateTime(2019, 6, 11, 14, 9, 30, 930, DateTimeKind.Local).AddTicks(686), 24, new DateTime(2019, 6, 11, 14, 9, 30, 930, DateTimeKind.Local).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 7, "sed", new DateTime(2019, 6, 11, 14, 9, 30, 930, DateTimeKind.Local).AddTicks(743), 24, new DateTime(2019, 6, 11, 14, 9, 30, 930, DateTimeKind.Local).AddTicks(749) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 11, @"Et praesentium magni provident et.
Eligendi impedit quod neque et sint placeat.", new DateTime(2019, 6, 11, 14, 9, 30, 930, DateTimeKind.Local).AddTicks(919), 24, new DateTime(2019, 6, 11, 14, 9, 30, 930, DateTimeKind.Local).AddTicks(926) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 15, @"Est consequatur et.
Ut quisquam velit et dolorem eos quos quis.
Voluptate est inventore fuga vel ratione fugit sed magni eos.
Sit laboriosam rerum recusandae qui voluptas est.", new DateTime(2019, 6, 11, 14, 9, 30, 930, DateTimeKind.Local).AddTicks(1126), 31, new DateTime(2019, 6, 11, 14, 9, 30, 930, DateTimeKind.Local).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 8, "ut", new DateTime(2019, 6, 11, 14, 9, 30, 930, DateTimeKind.Local).AddTicks(1259), 24, new DateTime(2019, 6, 11, 14, 9, 30, 930, DateTimeKind.Local).AddTicks(1266) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 3, "et", new DateTime(2019, 6, 11, 14, 9, 30, 930, DateTimeKind.Local).AddTicks(1318), 29, new DateTime(2019, 6, 11, 14, 9, 30, 930, DateTimeKind.Local).AddTicks(1324) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 15, "Fugiat eius quis neque explicabo.", new DateTime(2019, 6, 11, 14, 9, 30, 930, DateTimeKind.Local).AddTicks(1400), 37, new DateTime(2019, 6, 11, 14, 9, 30, 930, DateTimeKind.Local).AddTicks(1407) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2019, 6, 11, 14, 9, 30, 769, DateTimeKind.Local).AddTicks(3207), "Reba.Runte26@yahoo.com", "MJ0bIDYeDKw9Au4snP/C+xeEEKWgcLcL5K6b5DERsa4=", "PXEQ14cme93rM3KPu2n78wa21EP1pvTMeYuxWQFvYjw=", new DateTime(2019, 6, 11, 14, 9, 30, 769, DateTimeKind.Local).AddTicks(3762), "Gillian.Gaylord67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 11, new DateTime(2019, 6, 11, 14, 9, 30, 776, DateTimeKind.Local).AddTicks(9915), "Ryan_Hoeger@hotmail.com", "9y4bIY5GTLJArHV0nOioKbwWPXqkwl5nQjJEIhqFYJM=", "bxzauW6OW6VK7VVsxYCu9uFRpLu5IH8lQUsaH5Mb3XE=", new DateTime(2019, 6, 11, 14, 9, 30, 776, DateTimeKind.Local).AddTicks(9931), "Reese.Schumm15" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 6, new DateTime(2019, 6, 11, 14, 9, 30, 784, DateTimeKind.Local).AddTicks(3819), "Eryn54@yahoo.com", "Zd8ooghyNe/GBDKKi5LwIqKUsP3ggNaqBdIqCbgXgwQ=", "fL+lx93j25gpOigYyUoJMUIu0Lu3CnxiV2BP8yLBpoA=", new DateTime(2019, 6, 11, 14, 9, 30, 784, DateTimeKind.Local).AddTicks(3828), "Finn.Rosenbaum55" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 6, new DateTime(2019, 6, 11, 14, 9, 30, 792, DateTimeKind.Local).AddTicks(341), "Alexander_Ebert@hotmail.com", "RJoncAnsiTXO1aSivQln/9zvUKrsk3An879R5F1Qg54=", "Q5j4u/95j1XPmk1IdeG4GhrdvK8JjIJNLC7dUWShKQQ=", new DateTime(2019, 6, 11, 14, 9, 30, 792, DateTimeKind.Local).AddTicks(352), "Dale58" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 7, new DateTime(2019, 6, 11, 14, 9, 30, 799, DateTimeKind.Local).AddTicks(4209), "Andreanne.Beer@hotmail.com", "3tw2/vGThYJX9tgCpEydqD7SwyyoDXv4RUjEBQ9wgBw=", "61jgkyaovyCRThyVbA0maM6UR0Y7+apjDaTQfgD6A8I=", new DateTime(2019, 6, 11, 14, 9, 30, 799, DateTimeKind.Local).AddTicks(4223), "Timmy56" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 10, new DateTime(2019, 6, 11, 14, 9, 30, 806, DateTimeKind.Local).AddTicks(8096), "Steve12@hotmail.com", "Yc0GvXblybGcr8YwiJRyovHzIAJ+IaDJ80sZDctmk+Q=", "kHwHu6fXPzeexOs1g3+Oj+QR63Pr3vfeQWwsZbztMZo=", new DateTime(2019, 6, 11, 14, 9, 30, 806, DateTimeKind.Local).AddTicks(8104), "Helena.Schneider68" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 6, new DateTime(2019, 6, 11, 14, 9, 30, 814, DateTimeKind.Local).AddTicks(4785), "King_Pfeffer@hotmail.com", "GmkReezYUQ9KjJ+rtdXap9BfqFxrmDnWDylhk9o6rW4=", "KKQJN9A4ZjhOi1p8tgFrHMacdXAMvnQBHbT0cJplpSM=", new DateTime(2019, 6, 11, 14, 9, 30, 814, DateTimeKind.Local).AddTicks(4797), "Kris.Sporer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 7, new DateTime(2019, 6, 11, 14, 9, 30, 821, DateTimeKind.Local).AddTicks(8779), "Sandra.Schumm53@yahoo.com", "lTItV6HkO3LRxkBzuASiMCwEGJBotVAx2mnQKH7GHc8=", "e9kpZkXixfbciwW1+ocwHyuw9fCfKiYpKZ+6mqYhTyg=", new DateTime(2019, 6, 11, 14, 9, 30, 821, DateTimeKind.Local).AddTicks(8793), "Dianna_Cummerata81" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 16, new DateTime(2019, 6, 11, 14, 9, 30, 829, DateTimeKind.Local).AddTicks(2919), "Albina_Schamberger21@hotmail.com", "IS+Pb1SngyhRO93aUeFqGZW/NgDKbnY7bcLHD/6+Og4=", "4OVN9g7/AH3bsvAZ6bshQSh9EKXJeNqXiIlsBCSHdXQ=", new DateTime(2019, 6, 11, 14, 9, 30, 829, DateTimeKind.Local).AddTicks(2928), "Korey.Feeney" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 16, new DateTime(2019, 6, 11, 14, 9, 30, 836, DateTimeKind.Local).AddTicks(6640), "Berniece37@yahoo.com", "4NUenjI6t/ro3e35S4ooFJ2rgswYofu/ffT00ncQRns=", "ahhCW0ahV63wDB4amuY8IktHcFUpRwdEFxCbzWzdKo8=", new DateTime(2019, 6, 11, 14, 9, 30, 836, DateTimeKind.Local).AddTicks(6647), "Elias.Erdman" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 7, new DateTime(2019, 6, 11, 14, 9, 30, 844, DateTimeKind.Local).AddTicks(1217), "Alphonso.Shields4@hotmail.com", "7KuiIW/g9mLfLi6GAhjttqwi/vFW4HZ98wiMWoZo4r0=", "V/bzW1uSbPm//veM0DP51yxXuELc2hNJJ8JEhiedT0s=", new DateTime(2019, 6, 11, 14, 9, 30, 844, DateTimeKind.Local).AddTicks(1230), "Fannie.Lindgren86" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 2, new DateTime(2019, 6, 11, 14, 9, 30, 851, DateTimeKind.Local).AddTicks(8471), "Karl_Veum@gmail.com", "uCJQggUVsM5WmER0ah8zsP4uSt+u8VVwEHdjlGj5yrw=", "i0tcHFMBGDIUcC4srG+1yzLZkN59gISEXbQB80g/xc0=", new DateTime(2019, 6, 11, 14, 9, 30, 851, DateTimeKind.Local).AddTicks(8487), "Kavon2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 5, new DateTime(2019, 6, 11, 14, 9, 30, 859, DateTimeKind.Local).AddTicks(2739), "Keara29@gmail.com", "7t/VU9F9W2cIoGXqzOYo9EaNz8/npCfVk9akAMwP6/Q=", "s3CCUU1AVkhTrj86a0+2/s0Zey8WaBna/vysDrEN2as=", new DateTime(2019, 6, 11, 14, 9, 30, 859, DateTimeKind.Local).AddTicks(2754), "Haylie.Kohler" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 11, new DateTime(2019, 6, 11, 14, 9, 30, 866, DateTimeKind.Local).AddTicks(6616), "Jerod63@yahoo.com", "of2z8DrHeqS81tDcATvUvky5+FlzOXF1cpQGyIS1JE4=", "A3hsWgkiC+eoJ4Ss7Man8j5jXLtIPt5ezdKzZznfbJo=", new DateTime(2019, 6, 11, 14, 9, 30, 866, DateTimeKind.Local).AddTicks(6626), "Will.Reilly25" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 1, new DateTime(2019, 6, 11, 14, 9, 30, 874, DateTimeKind.Local).AddTicks(3292), "Nolan.Smitham@yahoo.com", "baLOJ20WpAJxsNFsp2EyaqSPuy9Kh2kGbkL8xCwX1yw=", "a2EMp1mOIW05FHff0FInB42FifMw+tnuKn1BoKjGqJA=", new DateTime(2019, 6, 11, 14, 9, 30, 874, DateTimeKind.Local).AddTicks(3306), "Abigail_Hyatt10" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 18, new DateTime(2019, 6, 11, 14, 9, 30, 881, DateTimeKind.Local).AddTicks(7430), "Luigi_Wiegand23@hotmail.com", "4xvWI60nTeNYZAjND2Y1gX51lymU+RP+FLrWNdEaRLw=", "NF9tj4bDKCgDrYgxrseO3IuuvtkAoJhx9DrEpOomL7s=", new DateTime(2019, 6, 11, 14, 9, 30, 881, DateTimeKind.Local).AddTicks(7440), "Solon43" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2019, 6, 11, 14, 9, 30, 889, DateTimeKind.Local).AddTicks(1388), "Veronica67@hotmail.com", "NLy+Wj/IUAgV0gw2wbYP5rNmzG2JwG8HNvyqY0LMQKM=", "EJvj7ouu/UxqkckJYUyPDOGPuJNj9v3lGSbm3vGt4KE=", new DateTime(2019, 6, 11, 14, 9, 30, 889, DateTimeKind.Local).AddTicks(1396), "Alyson_Gleichner" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2019, 6, 11, 14, 9, 30, 896, DateTimeKind.Local).AddTicks(5157), "Laury1@hotmail.com", "mq8vefbIVP6a80sMKenXLsjOI3d0YSzcod0HcDFfrDI=", "CzEqL+BFo9VEaQkwVq2RfhLN2VlinalvZ7NCHLpTBdM=", new DateTime(2019, 6, 11, 14, 9, 30, 896, DateTimeKind.Local).AddTicks(5165), "Gerhard_Leuschke68" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2019, 6, 11, 14, 9, 30, 903, DateTimeKind.Local).AddTicks(8865), "Rick89@yahoo.com", "u/icI/cnSkMtsVkgNQ6uM/yNgYwdR+W1AJgwLWfQcDo=", "NYd/Co0qVapwwqRuRTQjS7vdLbB1diYaXp+KebgJGIo=", new DateTime(2019, 6, 11, 14, 9, 30, 903, DateTimeKind.Local).AddTicks(8873), "Marcus_Hyatt" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2019, 6, 11, 14, 9, 30, 911, DateTimeKind.Local).AddTicks(5742), "Jeremie_Moore@gmail.com", "CPIO7mLIg1mWaMGfCCtzlOod1qcR9OhAOb8MY2hhsZI=", "Nek+GfUohVEH20iYDcF1hEB4n8wTz+DnG2TyB4r66BI=", new DateTime(2019, 6, 11, 14, 9, 30, 911, DateTimeKind.Local).AddTicks(5757), "Carson.Anderson64" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Password", "Salt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 11, 14, 9, 30, 919, DateTimeKind.Local).AddTicks(343), "lN9L/KtmGjvgftDrvscxHcksq0o2965CZ7B0CCt4yFQ=", "spq8zvBc9E3RdPuPPfCFphen1Fx0+1X1PiAMUX7AuKk=", new DateTime(2019, 6, 11, 14, 9, 30, 919, DateTimeKind.Local).AddTicks(343) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 8, new DateTime(2019, 4, 10, 13, 42, 27, 539, DateTimeKind.Local).AddTicks(9429), new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(424), 8 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 12, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1237), new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1250), 1 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 20, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1291), true, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1296), 11 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1326), new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1331), 16 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 7, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1356), new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1361), 13 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 16, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1385), new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1390), 13 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 5, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1414), new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1418), 16 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 12, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1443), false, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1448), 4 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 5, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1476), true, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1481), 20 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 7, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1505), true, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1510), 15 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 16, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1534), new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1538), 1 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 18, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1563), new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1567), 9 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1614), new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1620), 10 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 20, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1646), false, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1651), 9 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1678), false, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1682) });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 7, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1707), new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1711), 18 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1735), new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1740), 18 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 4, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1763), new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1768), 9 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 4, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1791), new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1796), 15 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 2, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1825), new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1830), 17 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 10, "Odio earum expedita eos magnam voluptas quia aut ipsum.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(1617), 3, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(2611) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 17, "Illum et neque facilis.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3483), 14, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3498) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 8, "Ullam magnam quis nemo eum dolor quaerat eum.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3603), 10, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 16, "Fugiat delectus aspernatur soluta sit sed provident nostrum et.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3691), 19, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3698) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Modi in officiis itaque et et quas.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3759), 8, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3766) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Reiciendis quia perspiciatis et quidem.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3830), 8, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Et accusamus ea voluptatem harum dolorem eaque eos ducimus fuga.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3906), 10, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3913) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 16, "Rerum iure libero voluptatem.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3983), 11, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Possimus dolor fugiat modi voluptatum rem doloribus necessitatibus dolores.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4056), 19, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4063) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 19, "Recusandae molestias eius ipsa sit.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4120), 19, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4126) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 18, "Ut commodi sed aut ratione saepe sed doloremque.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4188), 18, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4194) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 4, "Et assumenda sint labore voluptatem eaque dolor nulla neque quia.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4281), 1, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4289) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 8, "Quisquam vero unde et qui.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4350), 10, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 21, "Repellendus quibusdam earum qui.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4420), 20, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 2, "Culpa enim a.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4479), 6, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4486) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { "Asperiores corrupti quam enim.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4538), 1, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 16, "Inventore dolor provident.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4593), 8, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 13, "Nesciunt nostrum ut unde corporis rem reprehenderit libero quia ut.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4665), 17, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 2, "Sunt odit voluptatem saepe eius.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4725), 15, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4732) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 18, "Est consequatur consequuntur eum.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4880), 7, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4888) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 288, DateTimeKind.Local).AddTicks(1098), "https://s3.amazonaws.com/uifaces/faces/twitter/belyaev_rs/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 288, DateTimeKind.Local).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(576), "https://s3.amazonaws.com/uifaces/faces/twitter/bpartridge/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(590) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(630), "https://s3.amazonaws.com/uifaces/faces/twitter/martip07/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(636) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(668), "https://s3.amazonaws.com/uifaces/faces/twitter/ricburton/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(674) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(697), "https://s3.amazonaws.com/uifaces/faces/twitter/sreejithexp/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(702) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(725), "https://s3.amazonaws.com/uifaces/faces/twitter/longlivemyword/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(754), "https://s3.amazonaws.com/uifaces/faces/twitter/ajaxy_ru/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(759) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(782), "https://s3.amazonaws.com/uifaces/faces/twitter/kalmerrautam/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(787) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(817), "https://s3.amazonaws.com/uifaces/faces/twitter/gonzalorobaina/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(844), "https://s3.amazonaws.com/uifaces/faces/twitter/vitor376/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(872), "https://s3.amazonaws.com/uifaces/faces/twitter/baumannzone/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(877) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(900), "https://s3.amazonaws.com/uifaces/faces/twitter/andreas_pr/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(928), "https://s3.amazonaws.com/uifaces/faces/twitter/rtgibbons/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(933) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(963), "https://s3.amazonaws.com/uifaces/faces/twitter/timothycd/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(968) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(991), "https://s3.amazonaws.com/uifaces/faces/twitter/adobi/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(1231), "https://s3.amazonaws.com/uifaces/faces/twitter/moynihan/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(1282), "https://s3.amazonaws.com/uifaces/faces/twitter/weavermedia/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(1312), "https://s3.amazonaws.com/uifaces/faces/twitter/nvkznemo/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(1340), "https://s3.amazonaws.com/uifaces/faces/twitter/exentrich/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(1345) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(1369), "https://s3.amazonaws.com/uifaces/faces/twitter/cbracco/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(906), "https://picsum.photos/640/480/?image=392", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2289), "https://picsum.photos/640/480/?image=425", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2301) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2335), "https://picsum.photos/640/480/?image=784", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2365), "https://picsum.photos/640/480/?image=758", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2370) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2392), "https://picsum.photos/640/480/?image=726", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2419), "https://picsum.photos/640/480/?image=866", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2445), "https://picsum.photos/640/480/?image=557", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2471), "https://picsum.photos/640/480/?image=263", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2475) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2498), "https://picsum.photos/640/480/?image=60", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2503) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2593), "https://picsum.photos/640/480/?image=222", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2625), "https://picsum.photos/640/480/?image=201", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2651), "https://picsum.photos/640/480/?image=217", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2656) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2678), "https://picsum.photos/640/480/?image=730", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2682) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2705), "https://picsum.photos/640/480/?image=1061", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2731), "https://picsum.photos/640/480/?image=52", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2758), "https://picsum.photos/640/480/?image=467", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2784), "https://picsum.photos/640/480/?image=385", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2810), "https://picsum.photos/640/480/?image=19", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2836), "https://picsum.photos/640/480/?image=341", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2862), "https://picsum.photos/640/480/?image=685", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(2442), 1, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(3481), 4 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4462), 1, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4478), 4 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4526), 16, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4531), 17 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4560), 14, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4565), 16 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4592), false, 11, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4624), false, 17, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4655), true, 19, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4660), 12 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4685), false, 18, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4690), 17 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4715), true, 13, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4720), 15 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4744), false, 19, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4749), 10 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4773), new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4778), 4 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4812), true, 10, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4818), 20 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4843), true, 8, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4848) });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4873), false, 6, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4878), 6 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4904), true, 4, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4909), 1 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4933), false, 18, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4938), 10 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4962), 17, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4967), 18 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4991), true, 6, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4996), 21 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(5021), true, 8, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(5026), 13 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(5049), 11, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(5054), 20 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 14, "molestiae", new DateTime(2019, 4, 10, 13, 42, 27, 514, DateTimeKind.Local).AddTicks(4538), 29, new DateTime(2019, 4, 10, 13, 42, 27, 514, DateTimeKind.Local).AddTicks(5593) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 9, @"Nisi quia sunt sapiente sapiente quia maiores iure.
Non rerum pariatur rem id autem.
Accusantium iure odio et possimus.
Rerum illum ut unde sed qui aperiam corrupti.
Et enim repellendus dolor inventore inventore unde cupiditate tempore.
Aut possimus temporibus pariatur at voluptas dolor minima.", new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(5149), 32, new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 9, "Sapiente itaque fuga sed ad.", new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(7346), 40, new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 20, "sed", new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(7457), 28, new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 17, @"Est nihil id corporis voluptatum eos voluptas.
Tenetur delectus pariatur ut.", new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(7654), 23, new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, "Rem aspernatur excepturi et.", new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(7754), 27, new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(7761) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 19, @"Iste aut et qui qui consequatur ipsa aut minima.
Ea perspiciatis aliquam.
Voluptate occaecati id voluptatibus expedita nobis nemo officiis harum quisquam.
Aut pariatur ut molestiae ut.", new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(7926), 37, new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 16, "sint", new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(7985), 39, new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 4, "vitae", new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(8036), 31, new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 21, "Cumque reiciendis et numquam sit aut explicabo sunt et. Quo deleniti nobis voluptatum eveniet dolor sunt a aut vel. Labore quos voluptas.", new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(1677), 35, new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 1, @"Voluptatum dolores officiis qui aperiam recusandae quod minus.
Libero dolores sit eligendi reiciendis delectus vel eaque.
Ad aliquam corporis recusandae.", new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(1890), 25, new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 8, "Corrupti corporis voluptatum sit dignissimos est. Iure ea sapiente laboriosam et perspiciatis nesciunt quae et quis. Quae voluptatem voluptatem non hic cumque voluptas vel. Ut perspiciatis exercitationem. Ex quia totam magnam et amet corrupti est est. Officia natus quam optio culpa minus aspernatur quaerat accusantium.", new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2146), 39, new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 21, @"Sapiente ex omnis quam.
Id sunt voluptas.
Explicabo voluptatibus dignissimos.
Et laborum quisquam.", new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2261), 37, new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2268) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { "Tempore delectus non consequatur sit est voluptatem.", new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2455), 22, new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 1, "Dolorum optio ut nostrum beatae velit et.", new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2541), 33, new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 7, "maxime", new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2591), 29, new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2597) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 17, @"Consectetur est nemo fugit ea exercitationem a non.
Dolorem assumenda ut quam qui corrupti voluptas qui error commodi.", new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2709), 35, new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2716) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 16, @"Minus ex odio aliquid molestiae.
Sed nostrum quae doloribus eum odio quia.
Ipsum quia quod id exercitationem.
Rerum fugiat quia esse impedit.", new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2846), 29, new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 19, "Pariatur in aut alias eum alias. Est id voluptatum fuga deleniti amet et facere quae. Totam reprehenderit ipsa. Quasi voluptatem veniam.", new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2984), 34, new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 11, "voluptatem", new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(3034), 33, new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(3041) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2019, 4, 10, 13, 42, 27, 354, DateTimeKind.Local).AddTicks(9279), "Eleanore78@hotmail.com", "JwhgJRWNi9KZ6HvsVC4o3ATXPKrIl6NpFs14Ywn6XcQ=", "1ZKXAVI9IEeT90K/cc4u5/9FM9h5NSvHrOT3p8VVgXk=", new DateTime(2019, 4, 10, 13, 42, 27, 355, DateTimeKind.Local).AddTicks(557), "Reanna.Berge" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 15, new DateTime(2019, 4, 10, 13, 42, 27, 362, DateTimeKind.Local).AddTicks(6332), "Noel37@gmail.com", "Ov/w2Ir6JjrZM+lrZWDJZQdRTyrjeX3kkEV1sNq5DLM=", "81E5KuSfD6Wy6OFVRVrzJi2uxOmPDeOHy31ZANgLikw=", new DateTime(2019, 4, 10, 13, 42, 27, 362, DateTimeKind.Local).AddTicks(6356), "Trevion.Konopelski" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 18, new DateTime(2019, 4, 10, 13, 42, 27, 370, DateTimeKind.Local).AddTicks(1374), "Tyree.Hettinger5@hotmail.com", "IFV9xQIA/JkXs2hSSZbxmkQc94MfDE6An6s8rISbMYo=", "lt+NT9Cw+2mitIPEmnHcp4xH3eoNtuwBukz7l2yl2Rg=", new DateTime(2019, 4, 10, 13, 42, 27, 370, DateTimeKind.Local).AddTicks(1394), "Raoul_Armstrong" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2019, 4, 10, 13, 42, 27, 377, DateTimeKind.Local).AddTicks(6273), "Landen82@gmail.com", "pel2LSd08C+t2mEhX1uBO7rVCWTaKiAjkqj43O1ytxo=", "W/OnJ8Ygem16yrXzV3ijvpYdye+/hgN2MeIiz/j9spM=", new DateTime(2019, 4, 10, 13, 42, 27, 377, DateTimeKind.Local).AddTicks(6291), "Tamara_Heaney59" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 13, new DateTime(2019, 4, 10, 13, 42, 27, 385, DateTimeKind.Local).AddTicks(1240), "Ashlee_Walker@gmail.com", "Ty1WmblkkeeehqZtK993rkptymgJ4HHmP3FtlQwggTQ=", "xmkPKualMGfdZNrMieig0XspCqfUdXIsiM9n+hH0BNM=", new DateTime(2019, 4, 10, 13, 42, 27, 385, DateTimeKind.Local).AddTicks(1258), "April.Baumbach63" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 5, new DateTime(2019, 4, 10, 13, 42, 27, 392, DateTimeKind.Local).AddTicks(4481), "Vern_Yost17@hotmail.com", "UrtG6PTWOuZN01Y0wJW2RXzWQztXetNZKLMXY2kPapU=", "nI8AsOHQ9rdpquComXIuzdUI83EJA5Ebtk53tHp8okM=", new DateTime(2019, 4, 10, 13, 42, 27, 392, DateTimeKind.Local).AddTicks(4494), "Jessy_Trantow70" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 11, new DateTime(2019, 4, 10, 13, 42, 27, 400, DateTimeKind.Local).AddTicks(1588), "Octavia.Breitenberg15@gmail.com", "JEPtNmc+xcRh6dRMz0XpW3YjPfo70dx6ghqpRbR7qZ8=", "QkAvLRdlO782y7r9/FQ5BeOVYPCV2OixVUgbJ0x0kZQ=", new DateTime(2019, 4, 10, 13, 42, 27, 400, DateTimeKind.Local).AddTicks(1618), "Brionna_Huel" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 20, new DateTime(2019, 4, 10, 13, 42, 27, 407, DateTimeKind.Local).AddTicks(5516), "Jaida.Robel@yahoo.com", "2sM5eXjzXM4rit4n0XznRgPXWrMUrkM2NEYIt8wWdM0=", "uZISArgxWHVs5sNqC3KY/zSN2GC6+cQ4PbSZXd2tY/w=", new DateTime(2019, 4, 10, 13, 42, 27, 407, DateTimeKind.Local).AddTicks(5528), "Idella67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2019, 4, 10, 13, 42, 27, 415, DateTimeKind.Local).AddTicks(286), "Merle3@hotmail.com", "vPqcCQvAy3m0ApPP9wTVPS+S6M+kffrzhI0KKY5byUE=", "73Y6XFrs5GNfbX3gEPnUriXG+09YbIzyLCyKeTM4d/4=", new DateTime(2019, 4, 10, 13, 42, 27, 415, DateTimeKind.Local).AddTicks(305), "Francesca_McClure" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2019, 4, 10, 13, 42, 27, 422, DateTimeKind.Local).AddTicks(5128), "Destin87@gmail.com", "3OzL76X0wfbkPwt7JQPH+/ebvc9xfBO3bcFQunQ0v4c=", "E4foLxFiXVPkgaoQ+Tr6Ge0g6OSnwWDa3eNX3Y0ExT4=", new DateTime(2019, 4, 10, 13, 42, 27, 422, DateTimeKind.Local).AddTicks(5147), "Ben.Legros80" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2019, 4, 10, 13, 42, 27, 430, DateTimeKind.Local).AddTicks(2390), "Finn84@gmail.com", "izsFaOQN3vHcHSvx8GGNmww7cWdIFOMBLISdizTYcw8=", "QwJmN2g2pIq3vU+epDXifJpLcfBOM84mE8O97MdJkzg=", new DateTime(2019, 4, 10, 13, 42, 27, 430, DateTimeKind.Local).AddTicks(2408), "Claudie_Von90" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 6, new DateTime(2019, 4, 10, 13, 42, 27, 437, DateTimeKind.Local).AddTicks(7089), "Brady24@yahoo.com", "fvm+iVG/i1teAwJu6gjd99cM3VzEf33Q4lZmpYa3gtA=", "qwNd4zHDb4xaQdyEy9lNs/c4y5rsfGTbauvyVwf8COc=", new DateTime(2019, 4, 10, 13, 42, 27, 437, DateTimeKind.Local).AddTicks(7102), "Bertha_Kuhic" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 13, new DateTime(2019, 4, 10, 13, 42, 27, 445, DateTimeKind.Local).AddTicks(471), "Amira84@yahoo.com", "OO/o8dRJNQHE/Cy5SsMuUoV59W4CfSqsYA1JYbnBbKA=", "BcFPRW2kgTsEIJrwMiZMtEJGYYttXjV8hE2B6jCKgSQ=", new DateTime(2019, 4, 10, 13, 42, 27, 445, DateTimeKind.Local).AddTicks(482), "Roxane.Bechtelar" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 17, new DateTime(2019, 4, 10, 13, 42, 27, 452, DateTimeKind.Local).AddTicks(5168), "Reagan_Gottlieb96@gmail.com", "8/CAtMOKHMOIgZYZyjfPyFgxlGUPh2TRexcrWcVuKR0=", "N4HTAz9evQh9HSBh4Ui10gobECk9Re8EzmJd04m9PKc=", new DateTime(2019, 4, 10, 13, 42, 27, 452, DateTimeKind.Local).AddTicks(5186), "Willow84" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 10, new DateTime(2019, 4, 10, 13, 42, 27, 460, DateTimeKind.Local).AddTicks(40), "Dane_Toy25@hotmail.com", "5ksghg+QRIoR4HCwib/D71e6GWEgIzgvHUy+/jIU8u4=", "YHCWI8ogFKXeVnbDjONhQnBcwOv9KTCv65i5aPHgxy4=", new DateTime(2019, 4, 10, 13, 42, 27, 460, DateTimeKind.Local).AddTicks(52), "Lyric_Powlowski" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2019, 4, 10, 13, 42, 27, 467, DateTimeKind.Local).AddTicks(7399), "Clyde.Kunze@gmail.com", "jN562rlj3Y4M9JiXhpaq22V9r5A0MCACnb8p5a03L24=", "PDjMLphnPnJG54zhHoLXWCW2Jr4kTqmaumBZuqRp0GM=", new DateTime(2019, 4, 10, 13, 42, 27, 467, DateTimeKind.Local).AddTicks(7433), "Kevon45" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 15, new DateTime(2019, 4, 10, 13, 42, 27, 475, DateTimeKind.Local).AddTicks(6227), "Chanel.Champlin68@hotmail.com", "AH5M8V4Q25IYweo/q/iVqQQ4h/xed8dxtZE0aeS5cWM=", "73owabAASkyG0Dvg2TnKlvWRX0FzS0ur49Ur3J5H3qM=", new DateTime(2019, 4, 10, 13, 42, 27, 475, DateTimeKind.Local).AddTicks(6272), "Jewell_Schmitt" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2019, 4, 10, 13, 42, 27, 483, DateTimeKind.Local).AddTicks(1289), "Watson.Bahringer@yahoo.com", "Q62jzI0XYrLxW7Vfi/yI+uS4YjSlRcUbQZxMQGfc8C0=", "vSbXm9StFleAMjE1o2oRvdW3lJHYt7hkHrsLCa7Dg4U=", new DateTime(2019, 4, 10, 13, 42, 27, 483, DateTimeKind.Local).AddTicks(1302), "Jazmin98" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 13, new DateTime(2019, 4, 10, 13, 42, 27, 490, DateTimeKind.Local).AddTicks(5812), "Aditya.Kerluke@yahoo.com", "7D2UgGVDo4CTiK0CFT/Cd2Kryi7caZwemc5a7f9Xus8=", "zUsIM0NUWcyfmuUZWfbZD/ip+Wl+JZe/hLUSru5/rSM=", new DateTime(2019, 4, 10, 13, 42, 27, 490, DateTimeKind.Local).AddTicks(5824), "Josefa_Brakus" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2019, 4, 10, 13, 42, 27, 498, DateTimeKind.Local).AddTicks(265), "Stewart.Kiehn@hotmail.com", "huLmL4GntVXBmnUFICkmowedAskr5IoAk5wW5424zqQ=", "AmgoIHeRfU91KKABVopqN9E6rEyTLpgLW9RqszTP2zc=", new DateTime(2019, 4, 10, 13, 42, 27, 498, DateTimeKind.Local).AddTicks(276), "Margaretta_Schaden" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Password", "Salt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 505, DateTimeKind.Local).AddTicks(3866), "C+XvvutUOnUo6U86oKynPexTPQkkhKfd4pYAf+LzYPE=", "wBQhcRU+Nh0iNrhTwxtzwOXjMhOxlLTx5BkVJ3h6sB4=", new DateTime(2019, 4, 10, 13, 42, 27, 505, DateTimeKind.Local).AddTicks(3866) });
        }
    }
}
