using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TraineAPI.Migrations
{
    /// <inheritdoc />
    public partial class v12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "TrainTime",
                table: "trains",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "stations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 21200,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 188120,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 212022,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 1145100,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 1331520,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 1821021,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 2018020,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 2102120,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 3302120,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 10100120,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 10405120,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 11145600,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 11225600,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 11723120,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 14510534,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 14512002,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 14512345,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 14512400,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 14514520,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 15132120,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 18821230,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 18872121,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 24052120,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 33021020,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 33021101,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 45002129,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 45002450,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 45021020,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 90902120,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 99021020,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 105433120,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 125021020,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 130313120,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 145114580,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 145123487,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 145124505,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 145127400,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 145127445,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 182154220,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 201021020,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 210212210,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 302002120,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 303021200,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 330211203,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 330302120,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 404002120,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 413020120,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 451021020,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 1004875120,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 1045452120,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 1303202120,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 1331201210,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "StationId",
                keyValue: 1478913620,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "trains",
                keyColumn: "TrainId",
                keyValue: 18,
                column: "TrainTime",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "trains",
                keyColumn: "TrainId",
                keyValue: 24,
                column: "TrainTime",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "trains",
                keyColumn: "TrainId",
                keyValue: 164,
                column: "TrainTime",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "trains",
                keyColumn: "TrainId",
                keyValue: 914,
                column: "TrainTime",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "trains",
                keyColumn: "TrainId",
                keyValue: 916,
                column: "TrainTime",
                value: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrainTime",
                table: "trains");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "stations");
        }
    }
}
