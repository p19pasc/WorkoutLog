using System;
using WorkoutLog.Dtos;
using WorkoutLog.Models;

namespace WorkoutLog.Mapping;

public static class DailyWorkoutMapping
{
    public static DailyWorkout ToEntity(this DailyWorkoutDto dailyWorkout)
    {
        return new DailyWorkout()
        {
            Id = dailyWorkout.Id,
            WorkoutDuration = dailyWorkout.WorkoutDuration,
            WorkoutDate = dailyWorkout.WorkoutDate,
            CreatedAt = dailyWorkout.CreatedAt,
            UpdatedAt = dailyWorkout.UpdatedAt,
            DeletedAt = dailyWorkout.DeletedAt,
            DailyWorkoutExercises = dailyWorkout.DailyWorkoutExercises.Select(e =>e.ToEntity()).ToList()
        };
    }

    public static DailyWorkoutDto ToDto(this DailyWorkout dailyWorkout)
    {
        return new (
            dailyWorkout.Id,
            dailyWorkout.WorkoutDuration,
            dailyWorkout.WorkoutDate,
            dailyWorkout.CreatedAt,
            dailyWorkout.UpdatedAt,
            dailyWorkout.DeletedAt,
            dailyWorkout.DailyWorkoutExercises.Select(e =>e.ToDto()).ToList()
        );
    }
}
