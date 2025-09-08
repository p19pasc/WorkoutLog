using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkoutLog.Migrations
{
    /// <inheritdoc />
    public partial class ChangeWorkoutDurationToInt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Step 1: Add temporary int column
            migrationBuilder.AddColumn<int>(
                name: "WorkoutDuration_Temp",
                table: "DailyWorkouts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            // Step 2: Convert TimeSpan data to int (total minutes)
            migrationBuilder.Sql(@"
                UPDATE DailyWorkouts 
                SET WorkoutDuration_Temp = DATEPART(HOUR, WorkoutDuration) * 60 + DATEPART(MINUTE, WorkoutDuration)");

            // Step 3: Drop the original TimeSpan column
            migrationBuilder.DropColumn(
                name: "WorkoutDuration",
                table: "DailyWorkouts");

            // Step 4: Rename temp column to original name
            migrationBuilder.RenameColumn(
                name: "WorkoutDuration_Temp",
                table: "DailyWorkouts",
                newName: "WorkoutDuration");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "WorkoutDuration_Temp",
                table: "DailyWorkouts",
                type: "time",
                nullable: false);

            migrationBuilder.Sql(@"
                UPDATE DailyWorkouts 
                SET WorkoutDuration_Temp = CAST(DATEADD(MINUTE, WorkoutDuration, '00:00:00') AS TIME)");

            migrationBuilder.DropColumn(
                name: "WorkoutDuration",
                table: "DailyWorkouts");

            migrationBuilder.RenameColumn(
                name: "WorkoutDuration_Temp",
                table: "DailyWorkouts",
                newName: "WorkoutDuration");
        }
    }
}