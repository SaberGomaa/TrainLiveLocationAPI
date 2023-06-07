using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TraineAPI.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comments_admins_AdminId",
                table: "comments");

            migrationBuilder.DropForeignKey(
                name: "FK_posts_admins_AdminId",
                table: "posts");

            migrationBuilder.DropIndex(
                name: "IX_posts_AdminId",
                table: "posts");

            migrationBuilder.DropIndex(
                name: "IX_comments_AdminId",
                table: "comments");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "posts");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "comments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "posts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "comments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_posts_AdminId",
                table: "posts",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_comments_AdminId",
                table: "comments",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_comments_admins_AdminId",
                table: "comments",
                column: "AdminId",
                principalTable: "admins",
                principalColumn: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_posts_admins_AdminId",
                table: "posts",
                column: "AdminId",
                principalTable: "admins",
                principalColumn: "AdminId");
        }
    }
}
