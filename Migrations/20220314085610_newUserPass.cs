using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend_projekt.Migrations
{
    public partial class newUserPass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "User_Book",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User_Password",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "User_Book",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "User_Password",
                table: "Users");
        }
    }
}
