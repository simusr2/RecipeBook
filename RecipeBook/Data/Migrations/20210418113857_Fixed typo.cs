using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipeBook.Data.Migrations
{
    public partial class Fixedtypo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Recipes_RecipeReceipeId",
                table: "Ingredients");

            migrationBuilder.RenameColumn(
                name: "ReceipeTime",
                table: "Recipes",
                newName: "RecipeTime");

            migrationBuilder.RenameColumn(
                name: "ReceipeProcedure",
                table: "Recipes",
                newName: "RecipeProcedure");

            migrationBuilder.RenameColumn(
                name: "ReceipeName",
                table: "Recipes",
                newName: "RecipeName");

            migrationBuilder.RenameColumn(
                name: "ReceipeDescription",
                table: "Recipes",
                newName: "RecipeDescription");

            migrationBuilder.RenameColumn(
                name: "ReceipeCookingTimeMeasurementUnit",
                table: "Recipes",
                newName: "RecipeCookingTimeMeasurementUnit");

            migrationBuilder.RenameColumn(
                name: "ReceipeCookingTime",
                table: "Recipes",
                newName: "RecipeCookingTime");

            migrationBuilder.RenameColumn(
                name: "ReceipeId",
                table: "Recipes",
                newName: "RecipeId");

            migrationBuilder.RenameColumn(
                name: "RecipeReceipeId",
                table: "Ingredients",
                newName: "RecipeId");

            migrationBuilder.RenameIndex(
                name: "IX_Ingredients_RecipeReceipeId",
                table: "Ingredients",
                newName: "IX_Ingredients_RecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Recipes_RecipeId",
                table: "Ingredients",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "RecipeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Recipes_RecipeId",
                table: "Ingredients");

            migrationBuilder.RenameColumn(
                name: "RecipeTime",
                table: "Recipes",
                newName: "ReceipeTime");

            migrationBuilder.RenameColumn(
                name: "RecipeProcedure",
                table: "Recipes",
                newName: "ReceipeProcedure");

            migrationBuilder.RenameColumn(
                name: "RecipeName",
                table: "Recipes",
                newName: "ReceipeName");

            migrationBuilder.RenameColumn(
                name: "RecipeDescription",
                table: "Recipes",
                newName: "ReceipeDescription");

            migrationBuilder.RenameColumn(
                name: "RecipeCookingTimeMeasurementUnit",
                table: "Recipes",
                newName: "ReceipeCookingTimeMeasurementUnit");

            migrationBuilder.RenameColumn(
                name: "RecipeCookingTime",
                table: "Recipes",
                newName: "ReceipeCookingTime");

            migrationBuilder.RenameColumn(
                name: "RecipeId",
                table: "Recipes",
                newName: "ReceipeId");

            migrationBuilder.RenameColumn(
                name: "RecipeId",
                table: "Ingredients",
                newName: "RecipeReceipeId");

            migrationBuilder.RenameIndex(
                name: "IX_Ingredients_RecipeId",
                table: "Ingredients",
                newName: "IX_Ingredients_RecipeReceipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Recipes_RecipeReceipeId",
                table: "Ingredients",
                column: "RecipeReceipeId",
                principalTable: "Recipes",
                principalColumn: "ReceipeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
