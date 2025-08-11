using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkoutLog.Migrations
{
    /// <inheritdoc />
    public partial class AddedJoinTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "DailyWorkoutExercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DailyWorkoutId = table.Column<int>(type: "int", nullable: false),
                    ExerciseId = table.Column<int>(type: "int", nullable: false),
                    Sets = table.Column<int>(type: "int", nullable: false),
                    Reps = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyWorkoutExercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DailyWorkoutExercises_DailyWorkouts_DailyWorkoutId",
                        column: x => x.DailyWorkoutId,
                        principalTable: "DailyWorkouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DailyWorkoutExercises_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DailyWorkoutExercise_ExercisesId",
                table: "DailyWorkoutExercise",
                column: "ExercisesId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyWorkoutExercises_DailyWorkoutId",
                table: "DailyWorkoutExercises",
                column: "DailyWorkoutId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyWorkoutExercises_ExerciseId",
                table: "DailyWorkoutExercises",
                column: "ExerciseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyWorkoutExercise");

            migrationBuilder.DropTable(
                name: "DailyWorkoutExercises");
        }
    }
}
