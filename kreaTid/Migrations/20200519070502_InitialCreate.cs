using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace kreaTid.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogPost",
                columns: table => new
                {
                    BlogPostId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogPostTitle = table.Column<string>(nullable: true),
                    BlogPostDate = table.Column<DateTime>(nullable: false),
                    BlogPostContent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPost", x => x.BlogPostId);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "BlogPostComment",
                columns: table => new
                {
                    BlogPostCommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogPostCommentUser = table.Column<string>(nullable: true),
                    BlogPostCommentText = table.Column<string>(nullable: true),
                    BlogPostCommentPublishDate = table.Column<DateTime>(nullable: false),
                    BlogPostCommentLastUpdated = table.Column<DateTime>(nullable: false),
                    BlogPostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostComment", x => x.BlogPostCommentId);
                    table.ForeignKey(
                        name: "FK_BlogPostComment_BlogPost_BlogPostId",
                        column: x => x.BlogPostId,
                        principalTable: "BlogPost",
                        principalColumn: "BlogPostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogPostImg",
                columns: table => new
                {
                    BlogPostImgId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImgFileUrl = table.Column<string>(nullable: true),
                    ImgAltText = table.Column<string>(nullable: true),
                    ImgType = table.Column<string>(nullable: true),
                    BlogPostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostImg", x => x.BlogPostImgId);
                    table.ForeignKey(
                        name: "FK_BlogPostImg_BlogPost_BlogPostId",
                        column: x => x.BlogPostId,
                        principalTable: "BlogPost",
                        principalColumn: "BlogPostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: true),
                    ProductPrice = table.Column<decimal>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductComment",
                columns: table => new
                {
                    ProductCommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCommentUser = table.Column<string>(nullable: true),
                    ProductCommentText = table.Column<string>(nullable: true),
                    ProductCommentDate = table.Column<DateTime>(nullable: false),
                    ProductCommentLastUpdated = table.Column<DateTime>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductComment", x => x.ProductCommentId);
                    table.ForeignKey(
                        name: "FK_ProductComment_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImg",
                columns: table => new
                {
                    ProductImgId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductImgFileUrl = table.Column<string>(nullable: true),
                    ProductImgAltText = table.Column<string>(nullable: true),
                    ProductImgType = table.Column<string>(nullable: true),
                    BlogPostId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImg", x => x.ProductImgId);
                    table.ForeignKey(
                        name: "FK_ProductImg_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BlogPost",
                columns: new[] { "BlogPostId", "BlogPostContent", "BlogPostDate", "BlogPostTitle" },
                values: new object[] { 1, "what th", new DateTime(2020, 5, 19, 9, 5, 1, 990, DateTimeKind.Local).AddTicks(7419), "maling er godt" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Papir" },
                    { 2, "xx" },
                    { 3, "xx" },
                    { 4, "xx" }
                });

            migrationBuilder.InsertData(
                table: "BlogPostComment",
                columns: new[] { "BlogPostCommentId", "BlogPostCommentLastUpdated", "BlogPostCommentPublishDate", "BlogPostCommentText", "BlogPostCommentUser", "BlogPostId" },
                values: new object[] { 1, new DateTime(2020, 5, 19, 9, 5, 1, 991, DateTimeKind.Local).AddTicks(5195), new DateTime(2020, 5, 19, 9, 5, 1, 991, DateTimeKind.Local).AddTicks(3400), "what", "who", 1 });

            migrationBuilder.InsertData(
                table: "BlogPostImg",
                columns: new[] { "BlogPostImgId", "BlogPostId", "ImgAltText", "ImgFileUrl", "ImgType" },
                values: new object[] { 1, 1, "ddd", "~/img/header.jpg", "blogbillede" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CategoryId", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { 1, 1, "bla bla bla", "Maling", 23.00m });

            migrationBuilder.InsertData(
                table: "ProductComment",
                columns: new[] { "ProductCommentId", "ProductCommentDate", "ProductCommentLastUpdated", "ProductCommentText", "ProductCommentUser", "ProductId" },
                values: new object[] { 1, new DateTime(2020, 5, 19, 9, 5, 1, 978, DateTimeKind.Local).AddTicks(8806), new DateTime(2020, 5, 19, 9, 5, 1, 989, DateTimeKind.Local).AddTicks(2971), "xxx", "xx", 1 });

            migrationBuilder.InsertData(
                table: "ProductImg",
                columns: new[] { "ProductImgId", "BlogPostId", "ProductId", "ProductImgAltText", "ProductImgFileUrl", "ProductImgType" },
                values: new object[] { 1, 0, 1, "test", "~/img/Logo.png", "productImg" });

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostComment_BlogPostId",
                table: "BlogPostComment",
                column: "BlogPostId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostImg_BlogPostId",
                table: "BlogPostImg",
                column: "BlogPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductComment_ProductId",
                table: "ProductComment",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImg_ProductId",
                table: "ProductImg",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogPostComment");

            migrationBuilder.DropTable(
                name: "BlogPostImg");

            migrationBuilder.DropTable(
                name: "ProductComment");

            migrationBuilder.DropTable(
                name: "ProductImg");

            migrationBuilder.DropTable(
                name: "BlogPost");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
