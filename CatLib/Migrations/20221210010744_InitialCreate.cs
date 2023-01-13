using Microsoft.EntityFrameworkCore.Migrations;

namespace CatLib.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CompatibilityDescription_CatId",
                table: "CompatibilityDescription");

            migrationBuilder.DropColumn(
                name: "Litter_Size",
                table: "MainSpecifications");

            migrationBuilder.DropColumn(
                name: "Origin",
                table: "MainSpecifications");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CompatibilityDescription",
                newName: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_CompatibilityDescription_CatId",
                table: "CompatibilityDescription",
                column: "CatId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CompatibilityDescription_CatId",
                table: "CompatibilityDescription");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CompatibilityDescription",
                newName: "id");

            migrationBuilder.AddColumn<string>(
                name: "Litter_Size",
                table: "MainSpecifications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Origin",
                table: "MainSpecifications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CompatibilityDescription_CatId",
                table: "CompatibilityDescription",
                column: "CatId");
        }
    }
}
