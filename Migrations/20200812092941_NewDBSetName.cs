using Microsoft.EntityFrameworkCore.Migrations;

namespace MasterChannelMap.Migrations
{
    public partial class NewDBSetName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceCollection",
                table: "ServiceCollection");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChannelListing",
                table: "ChannelListing");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CallSign",
                table: "CallSign");

            migrationBuilder.RenameTable(
                name: "ServiceCollection",
                newName: "ServiceCollections");

            migrationBuilder.RenameTable(
                name: "ChannelListing",
                newName: "ChannelListings");

            migrationBuilder.RenameTable(
                name: "CallSign",
                newName: "CallSigns");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceCollections",
                table: "ServiceCollections",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChannelListings",
                table: "ChannelListings",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CallSigns",
                table: "CallSigns",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceCollections",
                table: "ServiceCollections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChannelListings",
                table: "ChannelListings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CallSigns",
                table: "CallSigns");

            migrationBuilder.RenameTable(
                name: "ServiceCollections",
                newName: "ServiceCollection");

            migrationBuilder.RenameTable(
                name: "ChannelListings",
                newName: "ChannelListing");

            migrationBuilder.RenameTable(
                name: "CallSigns",
                newName: "CallSign");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceCollection",
                table: "ServiceCollection",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChannelListing",
                table: "ChannelListing",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CallSign",
                table: "CallSign",
                column: "ID");
        }
    }
}
