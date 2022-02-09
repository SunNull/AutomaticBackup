using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomaticBackup.Migrations
{
    public partial class _2022020901 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IsAuto",
                columns: table => new
                {
                    ID = table.Column<string>(type: "TEXT", nullable: false),
                    Auto = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsAuto", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IsAuto");
        }
    }
}
