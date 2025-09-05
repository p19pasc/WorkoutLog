using System;
using WorkoutLog.Dtos;
using WorkoutLog.Models;

namespace WorkoutLog.Mapping;

public static class ExerciseMapping
{
    public static Exercise ToEntity(this ExerciseDto exercise)
    {
        return new()
        {
            Id = exercise.Id,
            ExerciseName = exercise.ExerciseName,
            BodyPart = exercise.BodyPart,
            CreatedAt = exercise.CreatedAt,
            UpdatedAt = exercise.UpdatedAt,
            DeletedAt = exercise.DeletedAt
        };
    }

    public static ExerciseDto ToDto(this Exercise exercise)
    {
        return new(
            exercise.Id,
            exercise.ExerciseName,
            exercise.BodyPart,
            exercise.CreatedAt,
            exercise.UpdatedAt,
            exercise.DeletedAt
        );
    }
}
