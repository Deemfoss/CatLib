using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CatLib.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryNames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatGeneratorTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatGeneratorTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    History = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shedding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Playfulness = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Affection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Intelligence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hypoallergenic = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.Id);
                });

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
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Views = table.Column<int>(type: "int", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WariorColores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WariorColorId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WariorColores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WariorColores_WariorColores_ColorId",
                        column: x => x.ColorId,
                        principalTable: "WariorColores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WariorSuffixes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WariorSuffixes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personality",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desctiption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryNameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personality", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personality_CategoryNames_CategoryNameId",
                        column: x => x.CategoryNameId,
                        principalTable: "CategoryNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompatibilityDescription",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Friendliness_To_Dog_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Friendliness_To_Cat_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Friendliness_To_Old_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Friendliness_To_Childern_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grooming_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vocality_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompatibilityDescription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompatibilityDescription_Cats_CatId",
                        column: x => x.CatId,
                        principalTable: "Cats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MainSpecifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Colors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Life_Expectancy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Heigh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Litter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainSpecifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MainSpecifications_Cats_CatId",
                        column: x => x.CatId,
                        principalTable: "Cats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtherSpecifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Friendliness_To_Dog = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Friendliness_To_Cat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Friendliness_To_Old = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Friendliness_To_Childern = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grooming = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vocality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Choosing_Kitten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Health = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Care_Maintenance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Short_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other_Names = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nicknames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kitty_Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherSpecifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtherSpecifications_Cats_CatId",
                        column: x => x.CatId,
                        principalTable: "Cats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalSpecifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Head = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ears = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eyes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Legs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalSpecifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhysicalSpecifications_Cats_CatId",
                        column: x => x.CatId,
                        principalTable: "Cats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TemperamentDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Activity_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Playfulness_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Affection_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Intelligence_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemperamentDescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TemperamentDescriptions_Cats_CatId",
                        column: x => x.CatId,
                        principalTable: "Cats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    CatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Cats_CatId",
                        column: x => x.CatId,
                        principalTable: "Cats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WariorPrefixes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WariorColorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WariorPrefixes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WariorPrefixes_WariorColores_WariorColorId",
                        column: x => x.WariorColorId,
                        principalTable: "WariorColores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatGeneratorNames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    HairId = table.Column<int>(type: "int", nullable: false),
                    PersonalityId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatGeneratorNames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatGeneratorNames_Color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CatGeneratorNames_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CatGeneratorNames_Hair_HairId",
                        column: x => x.HairId,
                        principalTable: "Hair",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CatGeneratorNames_Personality_PersonalityId",
                        column: x => x.PersonalityId,
                        principalTable: "Personality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CatGeneratorNameCatGeneratorType",
                columns: table => new
                {
                    CatGeneratorNamesId = table.Column<int>(type: "int", nullable: false),
                    CatGeneratorTypesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatGeneratorNameCatGeneratorType", x => new { x.CatGeneratorNamesId, x.CatGeneratorTypesId });
                    table.ForeignKey(
                        name: "FK_CatGeneratorNameCatGeneratorType_CatGeneratorNames_CatGeneratorNamesId",
                        column: x => x.CatGeneratorNamesId,
                        principalTable: "CatGeneratorNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CatGeneratorNameCatGeneratorType_CatGeneratorTypes_CatGeneratorTypesId",
                        column: x => x.CatGeneratorTypesId,
                        principalTable: "CatGeneratorTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_CatId",
                table: "Answers",
                column: "CatId");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_CatGeneratorNameCatGeneratorType_CatGeneratorTypesId",
                table: "CatGeneratorNameCatGeneratorType",
                column: "CatGeneratorTypesId");

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

            migrationBuilder.CreateIndex(
                name: "IX_CompatibilityDescription_CatId",
                table: "CompatibilityDescription",
                column: "CatId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MainSpecifications_CatId",
                table: "MainSpecifications",
                column: "CatId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OtherSpecifications_CatId",
                table: "OtherSpecifications",
                column: "CatId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personality_CategoryNameId",
                table: "Personality",
                column: "CategoryNameId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalSpecifications_CatId",
                table: "PhysicalSpecifications",
                column: "CatId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TemperamentDescriptions_CatId",
                table: "TemperamentDescriptions",
                column: "CatId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WariorColores_ColorId",
                table: "WariorColores",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_WariorPrefixes_WariorColorId",
                table: "WariorPrefixes",
                column: "WariorColorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "CatGeneratorNameCatGeneratorType");

            migrationBuilder.DropTable(
                name: "CompatibilityDescription");

            migrationBuilder.DropTable(
                name: "MainSpecifications");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "OtherSpecifications");

            migrationBuilder.DropTable(
                name: "PhysicalSpecifications");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "TemperamentDescriptions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "WariorPrefixes");

            migrationBuilder.DropTable(
                name: "WariorSuffixes");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "CatGeneratorNames");

            migrationBuilder.DropTable(
                name: "CatGeneratorTypes");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Cats");

            migrationBuilder.DropTable(
                name: "WariorColores");

            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "Hair");

            migrationBuilder.DropTable(
                name: "Personality");

            migrationBuilder.DropTable(
                name: "CategoryNames");
        }
    }
}
