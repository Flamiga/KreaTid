using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace kreaTid.Migrations
{
    public partial class OMFG : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 1,
                column: "BlogPostDate",
                value: new DateTime(2020, 5, 22, 11, 27, 33, 746, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 2,
                column: "BlogPostDate",
                value: new DateTime(2020, 5, 22, 11, 27, 33, 746, DateTimeKind.Local).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 3,
                column: "BlogPostDate",
                value: new DateTime(2020, 5, 22, 11, 27, 33, 746, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 4,
                column: "BlogPostDate",
                value: new DateTime(2020, 5, 22, 11, 27, 33, 746, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 5,
                column: "BlogPostDate",
                value: new DateTime(2020, 5, 22, 11, 27, 33, 746, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 6,
                column: "BlogPostDate",
                value: new DateTime(2020, 5, 22, 11, 27, 33, 746, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 7,
                column: "BlogPostDate",
                value: new DateTime(2020, 5, 22, 11, 27, 33, 746, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 8,
                column: "BlogPostDate",
                value: new DateTime(2020, 5, 22, 11, 27, 33, 746, DateTimeKind.Local).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 1,
                columns: new[] { "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate" },
                values: new object[] { new DateTime(2020, 5, 22, 11, 27, 33, 747, DateTimeKind.Local).AddTicks(2590), new DateTime(2020, 5, 22, 11, 27, 33, 747, DateTimeKind.Local).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 2,
                columns: new[] { "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate" },
                values: new object[] { new DateTime(2020, 5, 22, 11, 27, 33, 747, DateTimeKind.Local).AddTicks(6337), new DateTime(2020, 5, 22, 11, 27, 33, 747, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 3,
                columns: new[] { "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate" },
                values: new object[] { new DateTime(2020, 5, 22, 11, 27, 33, 747, DateTimeKind.Local).AddTicks(6498), new DateTime(2020, 5, 22, 11, 27, 33, 747, DateTimeKind.Local).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 4,
                columns: new[] { "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate" },
                values: new object[] { new DateTime(2020, 5, 22, 11, 27, 33, 747, DateTimeKind.Local).AddTicks(6613), new DateTime(2020, 5, 22, 11, 27, 33, 747, DateTimeKind.Local).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 5,
                columns: new[] { "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate" },
                values: new object[] { new DateTime(2020, 5, 22, 11, 27, 33, 747, DateTimeKind.Local).AddTicks(6726), new DateTime(2020, 5, 22, 11, 27, 33, 747, DateTimeKind.Local).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 6,
                columns: new[] { "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate" },
                values: new object[] { new DateTime(2020, 5, 22, 11, 27, 33, 747, DateTimeKind.Local).AddTicks(6833), new DateTime(2020, 5, 22, 11, 27, 33, 747, DateTimeKind.Local).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 7,
                columns: new[] { "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate" },
                values: new object[] { new DateTime(2020, 5, 22, 11, 27, 33, 747, DateTimeKind.Local).AddTicks(6947), new DateTime(2020, 5, 22, 11, 27, 33, 747, DateTimeKind.Local).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 8,
                columns: new[] { "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate" },
                values: new object[] { new DateTime(2020, 5, 22, 11, 27, 33, 747, DateTimeKind.Local).AddTicks(7048), new DateTime(2020, 5, 22, 11, 27, 33, 747, DateTimeKind.Local).AddTicks(7032) });

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 9,
                columns: new[] { "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate" },
                values: new object[] { new DateTime(2020, 5, 22, 11, 27, 33, 747, DateTimeKind.Local).AddTicks(7111), new DateTime(2020, 5, 22, 11, 27, 33, 747, DateTimeKind.Local).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 10,
                columns: new[] { "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate" },
                values: new object[] { new DateTime(2020, 5, 22, 11, 27, 33, 747, DateTimeKind.Local).AddTicks(7190), new DateTime(2020, 5, 22, 11, 27, 33, 747, DateTimeKind.Local).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 11,
                columns: new[] { "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate" },
                values: new object[] { new DateTime(2020, 5, 22, 11, 27, 33, 747, DateTimeKind.Local).AddTicks(7293), new DateTime(2020, 5, 22, 11, 27, 33, 747, DateTimeKind.Local).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 12,
                columns: new[] { "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate" },
                values: new object[] { new DateTime(2020, 5, 22, 11, 27, 33, 747, DateTimeKind.Local).AddTicks(7346), new DateTime(2020, 5, 22, 11, 27, 33, 747, DateTimeKind.Local).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 13,
                columns: new[] { "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate" },
                values: new object[] { new DateTime(2020, 5, 22, 11, 27, 33, 747, DateTimeKind.Local).AddTicks(7396), new DateTime(2020, 5, 22, 11, 27, 33, 747, DateTimeKind.Local).AddTicks(7388) });

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 14,
                columns: new[] { "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate" },
                values: new object[] { new DateTime(2020, 5, 22, 11, 27, 33, 747, DateTimeKind.Local).AddTicks(7543), new DateTime(2020, 5, 22, 11, 27, 33, 747, DateTimeKind.Local).AddTicks(7534) });

            migrationBuilder.UpdateData(
                table: "ProductComment",
                keyColumn: "ProductCommentId",
                keyValue: 1,
                columns: new[] { "ProductCommentDate", "ProductCommentLastUpdated" },
                values: new object[] { new DateTime(2020, 5, 22, 11, 27, 33, 739, DateTimeKind.Local).AddTicks(1902), new DateTime(2020, 5, 22, 11, 27, 33, 745, DateTimeKind.Local).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "ProductComment",
                keyColumn: "ProductCommentId",
                keyValue: 2,
                columns: new[] { "ProductCommentDate", "ProductCommentLastUpdated" },
                values: new object[] { new DateTime(2020, 5, 22, 11, 27, 33, 745, DateTimeKind.Local).AddTicks(4811), new DateTime(2020, 5, 22, 11, 27, 33, 745, DateTimeKind.Local).AddTicks(4914) });

            migrationBuilder.UpdateData(
                table: "ProductComment",
                keyColumn: "ProductCommentId",
                keyValue: 3,
                columns: new[] { "ProductCommentDate", "ProductCommentLastUpdated" },
                values: new object[] { new DateTime(2020, 5, 22, 11, 27, 33, 745, DateTimeKind.Local).AddTicks(5086), new DateTime(2020, 5, 22, 11, 27, 33, 745, DateTimeKind.Local).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "ProductComment",
                keyColumn: "ProductCommentId",
                keyValue: 4,
                columns: new[] { "ProductCommentDate", "ProductCommentLastUpdated" },
                values: new object[] { new DateTime(2020, 5, 22, 11, 27, 33, 745, DateTimeKind.Local).AddTicks(5149), new DateTime(2020, 5, 22, 11, 27, 33, 745, DateTimeKind.Local).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "ProductComment",
                keyColumn: "ProductCommentId",
                keyValue: 5,
                columns: new[] { "ProductCommentDate", "ProductCommentLastUpdated" },
                values: new object[] { new DateTime(2020, 5, 22, 11, 27, 33, 745, DateTimeKind.Local).AddTicks(5266), new DateTime(2020, 5, 22, 11, 27, 33, 745, DateTimeKind.Local).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "ProductComment",
                keyColumn: "ProductCommentId",
                keyValue: 6,
                columns: new[] { "ProductCommentDate", "ProductCommentLastUpdated" },
                values: new object[] { new DateTime(2020, 5, 22, 11, 27, 33, 745, DateTimeKind.Local).AddTicks(5390), new DateTime(2020, 5, 22, 11, 27, 33, 745, DateTimeKind.Local).AddTicks(5409) });

            migrationBuilder.UpdateData(
                table: "ProductComment",
                keyColumn: "ProductCommentId",
                keyValue: 7,
                columns: new[] { "ProductCommentDate", "ProductCommentLastUpdated" },
                values: new object[] { new DateTime(2020, 5, 22, 11, 27, 33, 745, DateTimeKind.Local).AddTicks(5468), new DateTime(2020, 5, 22, 11, 27, 33, 745, DateTimeKind.Local).AddTicks(5476) });

            migrationBuilder.UpdateData(
                table: "ProductComment",
                keyColumn: "ProductCommentId",
                keyValue: 8,
                columns: new[] { "ProductCommentDate", "ProductCommentLastUpdated" },
                values: new object[] { new DateTime(2020, 5, 22, 11, 27, 33, 745, DateTimeKind.Local).AddTicks(5519), new DateTime(2020, 5, 22, 11, 27, 33, 745, DateTimeKind.Local).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "ProductComment",
                keyColumn: "ProductCommentId",
                keyValue: 9,
                columns: new[] { "ProductCommentDate", "ProductCommentLastUpdated" },
                values: new object[] { new DateTime(2020, 5, 22, 11, 27, 33, 745, DateTimeKind.Local).AddTicks(5624), new DateTime(2020, 5, 22, 11, 27, 33, 745, DateTimeKind.Local).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "ProductComment",
                keyColumn: "ProductCommentId",
                keyValue: 10,
                columns: new[] { "ProductCommentDate", "ProductCommentLastUpdated" },
                values: new object[] { new DateTime(2020, 5, 22, 11, 27, 33, 745, DateTimeKind.Local).AddTicks(5750), new DateTime(2020, 5, 22, 11, 27, 33, 745, DateTimeKind.Local).AddTicks(5769) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 1,
                column: "BlogPostDate",
                value: new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 2,
                column: "BlogPostDate",
                value: new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 3,
                column: "BlogPostDate",
                value: new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 4,
                column: "BlogPostDate",
                value: new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 5,
                column: "BlogPostDate",
                value: new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 6,
                column: "BlogPostDate",
                value: new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 7,
                column: "BlogPostDate",
                value: new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 8,
                column: "BlogPostDate",
                value: new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 1,
                columns: new[] { "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate" },
                values: new object[] { new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(7545), new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 2,
                columns: new[] { "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate" },
                values: new object[] { new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(9148), new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 3,
                columns: new[] { "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate" },
                values: new object[] { new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(9236), new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 4,
                columns: new[] { "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate" },
                values: new object[] { new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(9275), new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(9269) });

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 5,
                columns: new[] { "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate" },
                values: new object[] { new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(9314), new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 6,
                columns: new[] { "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate" },
                values: new object[] { new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(9357), new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 7,
                columns: new[] { "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate" },
                values: new object[] { new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(9396), new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 8,
                columns: new[] { "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate" },
                values: new object[] { new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(9436), new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 9,
                columns: new[] { "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate" },
                values: new object[] { new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(9474), new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 10,
                columns: new[] { "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate" },
                values: new object[] { new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(9516), new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 11,
                columns: new[] { "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate" },
                values: new object[] { new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(9555), new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(9549) });

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 12,
                columns: new[] { "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate" },
                values: new object[] { new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(9595), new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 13,
                columns: new[] { "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate" },
                values: new object[] { new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(9635), new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 14,
                columns: new[] { "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate" },
                values: new object[] { new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(9675), new DateTime(2020, 5, 21, 15, 44, 6, 269, DateTimeKind.Local).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "ProductComment",
                keyColumn: "ProductCommentId",
                keyValue: 1,
                columns: new[] { "ProductCommentDate", "ProductCommentLastUpdated" },
                values: new object[] { new DateTime(2020, 5, 21, 15, 44, 6, 264, DateTimeKind.Local).AddTicks(3977), new DateTime(2020, 5, 21, 15, 44, 6, 268, DateTimeKind.Local).AddTicks(4954) });

            migrationBuilder.UpdateData(
                table: "ProductComment",
                keyColumn: "ProductCommentId",
                keyValue: 2,
                columns: new[] { "ProductCommentDate", "ProductCommentLastUpdated" },
                values: new object[] { new DateTime(2020, 5, 21, 15, 44, 6, 268, DateTimeKind.Local).AddTicks(6794), new DateTime(2020, 5, 21, 15, 44, 6, 268, DateTimeKind.Local).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "ProductComment",
                keyColumn: "ProductCommentId",
                keyValue: 3,
                columns: new[] { "ProductCommentDate", "ProductCommentLastUpdated" },
                values: new object[] { new DateTime(2020, 5, 21, 15, 44, 6, 268, DateTimeKind.Local).AddTicks(6933), new DateTime(2020, 5, 21, 15, 44, 6, 268, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "ProductComment",
                keyColumn: "ProductCommentId",
                keyValue: 4,
                columns: new[] { "ProductCommentDate", "ProductCommentLastUpdated" },
                values: new object[] { new DateTime(2020, 5, 21, 15, 44, 6, 268, DateTimeKind.Local).AddTicks(6977), new DateTime(2020, 5, 21, 15, 44, 6, 268, DateTimeKind.Local).AddTicks(6984) });

            migrationBuilder.UpdateData(
                table: "ProductComment",
                keyColumn: "ProductCommentId",
                keyValue: 5,
                columns: new[] { "ProductCommentDate", "ProductCommentLastUpdated" },
                values: new object[] { new DateTime(2020, 5, 21, 15, 44, 6, 268, DateTimeKind.Local).AddTicks(7020), new DateTime(2020, 5, 21, 15, 44, 6, 268, DateTimeKind.Local).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "ProductComment",
                keyColumn: "ProductCommentId",
                keyValue: 6,
                columns: new[] { "ProductCommentDate", "ProductCommentLastUpdated" },
                values: new object[] { new DateTime(2020, 5, 21, 15, 44, 6, 268, DateTimeKind.Local).AddTicks(7067), new DateTime(2020, 5, 21, 15, 44, 6, 268, DateTimeKind.Local).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "ProductComment",
                keyColumn: "ProductCommentId",
                keyValue: 7,
                columns: new[] { "ProductCommentDate", "ProductCommentLastUpdated" },
                values: new object[] { new DateTime(2020, 5, 21, 15, 44, 6, 268, DateTimeKind.Local).AddTicks(7108), new DateTime(2020, 5, 21, 15, 44, 6, 268, DateTimeKind.Local).AddTicks(7114) });

            migrationBuilder.UpdateData(
                table: "ProductComment",
                keyColumn: "ProductCommentId",
                keyValue: 8,
                columns: new[] { "ProductCommentDate", "ProductCommentLastUpdated" },
                values: new object[] { new DateTime(2020, 5, 21, 15, 44, 6, 268, DateTimeKind.Local).AddTicks(7149), new DateTime(2020, 5, 21, 15, 44, 6, 268, DateTimeKind.Local).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "ProductComment",
                keyColumn: "ProductCommentId",
                keyValue: 9,
                columns: new[] { "ProductCommentDate", "ProductCommentLastUpdated" },
                values: new object[] { new DateTime(2020, 5, 21, 15, 44, 6, 268, DateTimeKind.Local).AddTicks(7190), new DateTime(2020, 5, 21, 15, 44, 6, 268, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "ProductComment",
                keyColumn: "ProductCommentId",
                keyValue: 10,
                columns: new[] { "ProductCommentDate", "ProductCommentLastUpdated" },
                values: new object[] { new DateTime(2020, 5, 21, 15, 44, 6, 268, DateTimeKind.Local).AddTicks(7233), new DateTime(2020, 5, 21, 15, 44, 6, 268, DateTimeKind.Local).AddTicks(7239) });
        }
    }
}
