using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WorkoutLog.Models;
[PrimaryKey(nameof(DailyWorkoutId), nameof(ExerciseId))]
public class DailyWorkoutExercise
{
    public int DailyWorkoutId { get; set; }
    public int ExerciseId { get; set; }
    public int Sets { get; set; }
    public int Reps { get; set; }
    public double Weight { get; set; }
    public DailyWorkout DailyWorkout { get; set; } = null!;
    public Exercise Exercise { get; set; } = null!;
}
