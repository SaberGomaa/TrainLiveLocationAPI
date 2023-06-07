using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TraineAPI.Migrations
{
    /// <inheritdoc />
    public partial class v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TrainId",
                table: "tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tickets_TrainId",
                table: "tickets",
                column: "TrainId");

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_trains_TrainId",
                table: "tickets",
                column: "TrainId",
                principalTable: "trains",
                principalColumn: "TrainId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tickets_trains_TrainId",
                table: "tickets");

            migrationBuilder.DropIndex(
                name: "IX_tickets_TrainId",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "TrainId",
                table: "tickets");
        }
    }
}
