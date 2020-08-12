using Microsoft.EntityFrameworkCore.Migrations;

namespace MasterChannelMap.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CallSign",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CallLetters = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ChannelListingID = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CallSign", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ChannelListing",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChannelMapName = table.Column<string>(nullable: true),
                    TunerPosition = table.Column<int>(nullable: false),
                    CallSignID = table.Column<int>(nullable: false),
                    ServiceCollectionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChannelListing", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ServiceCollection",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceCollectionName = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceCollection", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CallSign");

            migrationBuilder.DropTable(
                name: "ChannelListing");

            migrationBuilder.DropTable(
                name: "ServiceCollection");
        }
    }
}
