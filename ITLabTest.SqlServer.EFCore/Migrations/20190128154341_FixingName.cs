using Microsoft.EntityFrameworkCore.Migrations;

namespace ITLabTest.SqlServer.EFCore.Migrations
{
    public partial class FixingName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BornDate",
                table: "Person",
                newName: "BirthDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Person",
                newName: "BornDate");
        }
    }
}
