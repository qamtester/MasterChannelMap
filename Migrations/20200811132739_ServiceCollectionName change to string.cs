using Microsoft.EntityFrameworkCore.Migrations;

namespace MasterChannelMap.Migrations
{
    public partial class ServiceCollectionNamechangetostring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ServiceCollectionName",
                table: "ServiceCollection",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ServiceCollectionName",
                table: "ServiceCollection",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
