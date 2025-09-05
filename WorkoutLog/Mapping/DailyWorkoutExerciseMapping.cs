using System;
using WorkoutLog.Dtos;
using WorkoutLog.Models;

namespace WorkoutLog.Mapping;

public static class DailyWorkoutExerciseMapping
{
    public static DailyWorkoutExercise ToEntity(this DailyWorkoutExerciseDto dailyWorkoutExercise)
    {
        return new()
        {
            DailyWorkoutId = dailyWorkoutExercise.DailyWorkoutId,
            ExerciseId = dailyWorkoutExercise.ExerciseId,
            Sets = dailyWorkoutExercise.Sets,
            Reps = dailyWorkoutExercise.Reps,
            Weight = dailyWorkoutExercise.Weight
        };
    }

    public static DailyWorkoutExerciseDto ToDto(this DailyWorkoutExercise dailyWorkoutExercise)
    {
        return new(
        dailyWorkoutExercise.DailyWorkoutId,
        dailyWorkoutExercise.ExerciseId,
        dailyWorkoutExercise.Sets,
        dailyWorkoutExercise.Reps,
        dailyWorkoutExercise.Weight
        );
    }
}
