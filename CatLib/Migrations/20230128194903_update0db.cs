using Microsoft.EntityFrameworkCore.Migrations;

namespace CatLib.Migrations
{
    public partial class update0db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Cats");

            migrationBuilder.DropColumn(
                name: "History",
                table: "Cats");

            migrationBuilder.RenameColumn(
                name: "Health",
                table: "OtherSpecifications",
                newName: "Summary_desc");

            migrationBuilder.RenameColumn(
                name: "Choosing_Kitten",
                table: "OtherSpecifications",
                newName: "Size_desc");

            migrationBuilder.RenameColumn(
                name: "Care_Maintenance",
                table: "OtherSpecifications",
                newName: "Price_desc");

            migrationBuilder.AddColumn<string>(
                name: "Care_desc",
                table: "OtherSpecifications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Characteristics_desc",
                table: "OtherSpecifications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Choosing_Kitten_desc",
                table: "OtherSpecifications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color_desc",
                table: "OtherSpecifications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Grooming_desc",
                table: "OtherSpecifications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Health_desc",
                table: "OtherSpecifications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "History_desc",
                table: "OtherSpecifications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Live_desc",
                table: "OtherSpecifications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Persinality_desc",
                table: "OtherSpecifications",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Care_desc",
                table: "OtherSpecifications");

            migrationBuilder.DropColumn(
                name: "Characteristics_desc",
                table: "OtherSpecifications");

            migrationBuilder.DropColumn(
                name: "Choosing_Kitten_desc",
                table: "OtherSpecifications");

            migrationBuilder.DropColumn(
                name: "Color_desc",
                table: "OtherSpecifications");

            migrationBuilder.DropColumn(
                name: "Grooming_desc",
                table: "OtherSpecifications");

            migrationBuilder.DropColumn(
                name: "Health_desc",
                table: "OtherSpecifications");

            migrationBuilder.DropColumn(
                name: "History_desc",
                table: "OtherSpecifications");

            migrationBuilder.DropColumn(
                name: "Live_desc",
                table: "OtherSpecifications");

            migrationBuilder.DropColumn(
                name: "Persinality_desc",
                table: "OtherSpecifications");

            migrationBuilder.RenameColumn(
                name: "Summary_desc",
                table: "OtherSpecifications",
                newName: "Health");

            migrationBuilder.RenameColumn(
                name: "Size_desc",
                table: "OtherSpecifications",
                newName: "Choosing_Kitten");

            migrationBuilder.RenameColumn(
                name: "Price_desc",
                table: "OtherSpecifications",
                newName: "Care_Maintenance");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Cats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "History",
                table: "Cats",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
