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
                name: "FK_tickets_payments_PaymentId",
                table: "tickets");

            migrationBuilder.DropIndex(
                name: "IX_tickets_PaymentId",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "tickets");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tickets_PaymentId",
                table: "tickets",
                column: "PaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_payments_PaymentId",
                table: "tickets",
                column: "PaymentId",
                principalTable: "payments",
                principalColumn: "PaymentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
