using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkoutLog.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedMainTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "DailyWorkouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "DailyWorkouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "DailyWorkouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "WorkoutDate",
                table: "DailyWorkouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "WorkoutDuration",
                table: "DailyWorkouts",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "DailyWorkouts");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "DailyWorkouts");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "DailyWorkouts");

            migrationBuilder.DropColumn(
                name: "WorkoutDate",
                table: "DailyWorkouts");

            migrationBuilder.DropColumn(
                name: "WorkoutDuration",
                table: "DailyWorkouts");
        }
    }
}
