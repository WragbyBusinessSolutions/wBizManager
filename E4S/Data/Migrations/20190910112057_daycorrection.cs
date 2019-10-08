using Microsoft.EntityFrameworkCore.Migrations;

namespace E4S.Data.Migrations
{
    public partial class daycorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NoOfDays",
                table: "BatchLKs",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NoOfLicense",
                table: "BatchLKs",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoOfLicense",
                table: "BatchLKs");

            migrationBuilder.AlterColumn<string>(
                name: "NoOfDays",
                table: "BatchLKs",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
