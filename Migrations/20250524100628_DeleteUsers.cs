using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_Philoxenia.Migrations
{
    /// <inheritdoc />
    public partial class DeleteUsers : Migration
    {
        

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Users WHERE Id >= 1 AND Id <= 5;");
        }
    }
}
