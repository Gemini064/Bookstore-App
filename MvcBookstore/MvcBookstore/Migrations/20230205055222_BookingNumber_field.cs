using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcBookstore.Migrations
{
    /// <inheritdoc />
    public partial class BookingNumberfield : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookingNumber",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookingNumber",
                table: "Book");
        }
    }
}
