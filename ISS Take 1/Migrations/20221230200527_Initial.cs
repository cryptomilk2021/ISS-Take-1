using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ISSTake1.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Satelites",
                columns: table => new
                {
                    SatID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NORADId = table.Column<string>(type: "TEXT", nullable: true),
                    SatName = table.Column<string>(type: "TEXT", nullable: true),
                    LaunchDate = table.Column<string>(type: "TEXT", nullable: true),
                    Country = table.Column<string>(type: "TEXT", nullable: true),
                    Picture = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Satelites", x => x.SatID);
                });

            migrationBuilder.CreateTable(
                name: "SatHistory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SatID = table.Column<int>(type: "INTEGER", nullable: false),
                    Longitude = table.Column<string>(type: "TEXT", nullable: true),
                    Latitude = table.Column<string>(type: "TEXT", nullable: true),
                    TimeStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SatHistory", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Satelites");

            migrationBuilder.DropTable(
                name: "SatHistory");
        }
    }
}
