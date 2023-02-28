using Microsoft.EntityFrameworkCore.Migrations;

namespace CatLib.Migrations
{
    public partial class Diasease : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "Used_in_Commercial_Food");

            migrationBuilder.AddColumn<bool>(
                name: "Allergenic",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Appropriate",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Good_for_Cats",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "How_Much_to_Feed",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "How_Much_to_Feed_description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "How_Often_to_Feed",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nutrition_Stats",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nutritional_Benefits",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Risks_for_Cats",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Summary",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Toxic",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Diseases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other_Names = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Symptoms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Causes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnosis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Treatment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prevention = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Living_Management = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diseases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductQuestions_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Disease_Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiseaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disease_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disease_Questions_Diseases_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Disease_Questions_DiseaseId",
                table: "Disease_Questions",
                column: "DiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductQuestions_ProductId",
                table: "ProductQuestions",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Disease_Questions");

            migrationBuilder.DropTable(
                name: "ProductQuestions");

            migrationBuilder.DropTable(
                name: "Diseases");

            migrationBuilder.DropColumn(
                name: "Allergenic",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Appropriate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Good_for_Cats",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "How_Much_to_Feed",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "How_Much_to_Feed_description",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "How_Often_to_Feed",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Nutrition_Stats",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Nutritional_Benefits",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Risks_for_Cats",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Summary",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Toxic",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Used_in_Commercial_Food",
                table: "Products",
                newName: "Description");
        }
    }
}
