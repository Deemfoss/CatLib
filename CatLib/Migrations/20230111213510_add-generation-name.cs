using Microsoft.EntityFrameworkCore.Migrations;

namespace CatLib.Migrations
{
    public partial class addgenerationname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Activity",
                table: "CatGeneratorNames");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "CatGeneratorNames");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "CatGeneratorNames");

            migrationBuilder.DropColumn(
                name: "Hair",
                table: "CatGeneratorNames");

            migrationBuilder.RenameColumn(
                name: "Personality",
                table: "CatGeneratorNames",
                newName: "Description");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CatGeneratorTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "CatGeneratorNames",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "CatGeneratorNames",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HairId",
                table: "CatGeneratorNames",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonalityId",
                table: "CatGeneratorNames",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hair",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hair", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personality",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personality", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatGeneratorNames_ColorId",
                table: "CatGeneratorNames",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_CatGeneratorNames_GenderId",
                table: "CatGeneratorNames",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_CatGeneratorNames_HairId",
                table: "CatGeneratorNames",
                column: "HairId");

            migrationBuilder.CreateIndex(
                name: "IX_CatGeneratorNames_PersonalityId",
                table: "CatGeneratorNames",
                column: "PersonalityId");

            migrationBuilder.AddForeignKey(
                name: "FK_CatGeneratorNames_Color_ColorId",
                table: "CatGeneratorNames",
                column: "ColorId",
                principalTable: "Color",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CatGeneratorNames_Gender_GenderId",
                table: "CatGeneratorNames",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CatGeneratorNames_Hair_HairId",
                table: "CatGeneratorNames",
                column: "HairId",
                principalTable: "Hair",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CatGeneratorNames_Personality_PersonalityId",
                table: "CatGeneratorNames",
                column: "PersonalityId",
                principalTable: "Personality",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatGeneratorNames_Color_ColorId",
                table: "CatGeneratorNames");

            migrationBuilder.DropForeignKey(
                name: "FK_CatGeneratorNames_Gender_GenderId",
                table: "CatGeneratorNames");

            migrationBuilder.DropForeignKey(
                name: "FK_CatGeneratorNames_Hair_HairId",
                table: "CatGeneratorNames");

            migrationBuilder.DropForeignKey(
                name: "FK_CatGeneratorNames_Personality_PersonalityId",
                table: "CatGeneratorNames");

            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "Hair");

            migrationBuilder.DropTable(
                name: "Personality");

            migrationBuilder.DropIndex(
                name: "IX_CatGeneratorNames_ColorId",
                table: "CatGeneratorNames");

            migrationBuilder.DropIndex(
                name: "IX_CatGeneratorNames_GenderId",
                table: "CatGeneratorNames");

            migrationBuilder.DropIndex(
                name: "IX_CatGeneratorNames_HairId",
                table: "CatGeneratorNames");

            migrationBuilder.DropIndex(
                name: "IX_CatGeneratorNames_PersonalityId",
                table: "CatGeneratorNames");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CatGeneratorTypes");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "CatGeneratorNames");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "CatGeneratorNames");

            migrationBuilder.DropColumn(
                name: "HairId",
                table: "CatGeneratorNames");

            migrationBuilder.DropColumn(
                name: "PersonalityId",
                table: "CatGeneratorNames");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "CatGeneratorNames",
                newName: "Personality");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Activity",
                table: "CatGeneratorNames",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "CatGeneratorNames",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "CatGeneratorNames",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hair",
                table: "CatGeneratorNames",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
