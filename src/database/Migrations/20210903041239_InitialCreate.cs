using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipeApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "Ingredients",
                table => new
                {
                    Id = table.Column<int>("int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>("nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                "Recipes",
                table => new
                {
                    Id = table.Column<int>("int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>("nvarchar(max)", nullable: false),
                    TotalTime = table.Column<int>("int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                "RecipeIngredients",
                table => new
                {
                    RecipeId = table.Column<int>("int", nullable: false),
                    IngredientId = table.Column<int>("int", nullable: false),
                    Amount = table.Column<int>("int", nullable: false),
                    Measurement = table.Column<string>("nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredients", x => new { x.RecipeId, x.IngredientId });
                    table.ForeignKey(
                        "FK_RecipeIngredients_Ingredients_IngredientId",
                        x => x.IngredientId,
                        "Ingredients",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_RecipeIngredients_Recipes_RecipeId",
                        x => x.RecipeId,
                        "Recipes",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "Steps",
                table => new
                {
                    Id = table.Column<int>("int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>("nvarchar(max)", nullable: false),
                    RecipeId = table.Column<int>("int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Steps", x => x.Id);
                    table.ForeignKey(
                        "FK_Steps_Recipes_RecipeId",
                        x => x.RecipeId,
                        "Recipes",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                "IX_RecipeIngredients_IngredientId",
                "RecipeIngredients",
                "IngredientId");

            migrationBuilder.CreateIndex(
                "IX_Steps_RecipeId",
                "Steps",
                "RecipeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "RecipeIngredients");

            migrationBuilder.DropTable(
                "Steps");

            migrationBuilder.DropTable(
                "Ingredients");

            migrationBuilder.DropTable(
                "Recipes");
        }
    }
}
