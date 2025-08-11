using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkoutLog.Migrations
{
    /// <inheritdoc />
    public partial class _3Tablesv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DailyWorkoutExercises",
                table: "DailyWorkoutExercises");

            migrationBuilder.DropIndex(
                name: "IX_DailyWorkoutExercises_DailyWorkoutId",
                table: "DailyWorkoutExercises");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "DailyWorkoutExercises");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DailyWorkoutExercises",
                table: "DailyWorkoutExercises",
                columns: new[] { "DailyWorkoutId", "ExerciseId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DailyWorkoutExercises",
                table: "DailyWorkoutExercises");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "DailyWorkoutExercises",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DailyWorkoutExercises",
                table: "DailyWorkoutExercises",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_DailyWorkoutExercises_DailyWorkoutId",
                table: "DailyWorkoutExercises",
                column: "DailyWorkoutId");
        }
    }
}
