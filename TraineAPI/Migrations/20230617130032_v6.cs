using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TraineAPI.Migrations
{
    /// <inheritdoc />
    public partial class v6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "trainInStationTime",
                columns: table => new
                {
                    StationId = table.Column<int>(type: "int", nullable: false),
                    TrainId = table.Column<int>(type: "int", nullable: false),
                    TrainTime = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trainInStationTime", x => new { x.TrainId, x.StationId });
                    table.ForeignKey(
                        name: "FK_trainInStationTime_stations_StationId",
                        column: x => x.StationId,
                        principalTable: "stations",
                        principalColumn: "StationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trainInStationTime_trains_TrainId",
                        column: x => x.TrainId,
                        principalTable: "trains",
                        principalColumn: "TrainId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_trainInStationTime_StationId",
                table: "trainInStationTime",
                column: "StationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "trainInStationTime");
        }
    }
}
