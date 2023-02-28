using Microsoft.EntityFrameworkCore.Migrations;

namespace CatLib.Migrations
{
    public partial class news : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatGeneratorNames_Personality_PersonalityId",
                table: "CatGeneratorNames");

            migrationBuilder.DropIndex(
                name: "IX_CatGeneratorNames_PersonalityId",
                table: "CatGeneratorNames");

            migrationBuilder.DropColumn(
                name: "PersonalityId",
                table: "CatGeneratorNames");

            migrationBuilder.AddColumn<bool>(
                name: "IsCharacter",
                table: "Personality",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "CatGeneratorNamePersonality",
                columns: table => new
                {
                    CatGeneratorNamesId = table.Column<int>(type: "int", nullable: false),
                    PersonalitiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatGeneratorNamePersonality", x => new { x.CatGeneratorNamesId, x.PersonalitiesId });
                    table.ForeignKey(
                        name: "FK_CatGeneratorNamePersonality_CatGeneratorNames_CatGeneratorNamesId",
                        column: x => x.CatGeneratorNamesId,
                        principalTable: "CatGeneratorNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CatGeneratorNamePersonality_Personality_PersonalitiesId",
                        column: x => x.PersonalitiesId,
                        principalTable: "Personality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductArticles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductArticles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductReviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pros = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cons = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductArticleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductReviews_ProductArticles_ProductArticleId",
                        column: x => x.ProductArticleId,
                        principalTable: "ProductArticles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatGeneratorNamePersonality_PersonalitiesId",
                table: "CatGeneratorNamePersonality",
                column: "PersonalitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviews_ProductArticleId",
                table: "ProductReviews",
                column: "ProductArticleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatGeneratorNamePersonality");

            migrationBuilder.DropTable(
                name: "ProductReviews");

            migrationBuilder.DropTable(
                name: "ProductArticles");

            migrationBuilder.DropColumn(
                name: "IsCharacter",
                table: "Personality");

            migrationBuilder.AddColumn<int>(
                name: "PersonalityId",
                table: "CatGeneratorNames",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CatGeneratorNames_PersonalityId",
                table: "CatGeneratorNames",
                column: "PersonalityId");

            migrationBuilder.AddForeignKey(
                name: "FK_CatGeneratorNames_Personality_PersonalityId",
                table: "CatGeneratorNames",
                column: "PersonalityId",
                principalTable: "Personality",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
