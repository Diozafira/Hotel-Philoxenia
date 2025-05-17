using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_Philoxenia.Migrations
{
    /// <inheritdoc />
    public partial class AddHoteltoRoom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "telephone",
                table: "Customers",
                newName: "Telephone");

            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "Telephone",
                table: "Customers",
                newName: "telephone");
        }
    }
}
