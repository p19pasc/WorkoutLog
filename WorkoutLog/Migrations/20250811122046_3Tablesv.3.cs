using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkoutLog.Migrations
{
    /// <inheritdoc />
    public partial class _3Tablesv3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyWorkoutExercise");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DailyWorkoutExercise",
                columns: table => new
                {
                    DailyWorkoutsId = table.Column<int>(type: "int", nullable: false),
                    ExercisesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyWorkoutExercise", x => new { x.DailyWorkoutsId, x.ExercisesId });
                    table.ForeignKey(
                        name: "FK_DailyWorkoutExercise_DailyWorkouts_DailyWorkoutsId",
                        column: x => x.DailyWorkoutsId,
                        principalTable: "DailyWorkouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DailyWorkoutExercise_Exercises_ExercisesId",
                        column: x => x.ExercisesId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DailyWorkoutExercise_ExercisesId",
                table: "DailyWorkoutExercise",
                column: "ExercisesId");
        }
    }
}
