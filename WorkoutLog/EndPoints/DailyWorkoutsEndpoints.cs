using System;
using Microsoft.EntityFrameworkCore;
using WorkoutLog.Models;

namespace WorkoutLog.EndPoints;

public static class DailyWorkoutsEndPoints
{
    public static void MapDailyWorkoutEndPoints(this WebApplication app)
    {
        app.MapPost("/api/AddNewDailyWorkout", async (WorkoutLogDbContext db) =>
        {
            var now = DateTime.UtcNow;
            List<DailyWorkout> dailyWorkouts = new List<DailyWorkout>
            {
                new() {WorkoutDuration = TimeSpan.FromMinutes(60), WorkoutDate = DateTime.Today, CreatedAt = now, UpdatedAt = now},
            };
            db.DailyWorkouts.AddRange(dailyWorkouts);
            await db.SaveChangesAsync();

            return Results.Ok(dailyWorkouts);
        });



        app.MapGet("/api/DailyWorkouts", async (WorkoutLogDbContext db) =>
        {
            var workouts = await db.DailyWorkouts.ToListAsync();
            return Results.Ok(workouts);
        });

          app.MapGet("/api/DailyWorkout/{id}", async (int id, WorkoutLogDbContext db) =>
        {
            var workouts = await db.DailyWorkouts.ToListAsync();
            return Results.Ok(workouts);
        });
    }
}
