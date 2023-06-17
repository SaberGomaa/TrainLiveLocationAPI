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
                name: "RailwayId",
                table: "trains",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RailwayId",
                table: "stations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "railway",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartStation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastStation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_railway", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_trains_RailwayId",
                table: "trains",
                column: "RailwayId");

            migrationBuilder.CreateIndex(
                name: "IX_stations_RailwayId",
                table: "stations",
                column: "RailwayId");

            migrationBuilder.AddForeignKey(
                name: "FK_stations_railway_RailwayId",
                table: "stations",
                column: "RailwayId",
                principalTable: "railway",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_trains_railway_RailwayId",
                table: "trains",
                column: "RailwayId",
                principalTable: "railway",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_stations_railway_RailwayId",
                table: "stations");

            migrationBuilder.DropForeignKey(
                name: "FK_trains_railway_RailwayId",
                table: "trains");

            migrationBuilder.DropTable(
                name: "railway");

            migrationBuilder.DropIndex(
                name: "IX_trains_RailwayId",
                table: "trains");

            migrationBuilder.DropIndex(
                name: "IX_stations_RailwayId",
                table: "stations");

            migrationBuilder.DropColumn(
                name: "RailwayId",
                table: "trains");

            migrationBuilder.DropColumn(
                name: "RailwayId",
                table: "stations");
        }
    }
}
