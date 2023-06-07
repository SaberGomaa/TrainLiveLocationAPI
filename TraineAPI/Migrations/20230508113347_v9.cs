using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TraineAPI.Migrations
{
    /// <inheritdoc />
    public partial class v9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_stations_StationId",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_StationId",
                table: "users");

            migrationBuilder.DropColumn(
                name: "StationId",
                table: "users");

            migrationBuilder.AddColumn<int>(
                name: "StationArrivalId",
                table: "tickets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tickets_StationArrivalId",
                table: "tickets",
                column: "StationArrivalId");

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_stations_StationArrivalId",
                table: "tickets",
                column: "StationArrivalId",
                principalTable: "stations",
                principalColumn: "StationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tickets_stations_StationArrivalId",
                table: "tickets");

            migrationBuilder.DropIndex(
                name: "IX_tickets_StationArrivalId",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "StationArrivalId",
                table: "tickets");

            migrationBuilder.AddColumn<int>(
                name: "StationId",
                table: "users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_users_StationId",
                table: "users",
                column: "StationId");

            migrationBuilder.AddForeignKey(
                name: "FK_users_stations_StationId",
                table: "users",
                column: "StationId",
                principalTable: "stations",
                principalColumn: "StationId");
        }
    }
}
