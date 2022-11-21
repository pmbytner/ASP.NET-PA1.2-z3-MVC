using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.NETPA1._2z3MVC.Migrations
{
    /// <inheritdoc />
    public partial class NowaKolumnaWojewództwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Województwo",
                table: "Miasta",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Województwo",
                table: "Miasta");
        }
    }
}
