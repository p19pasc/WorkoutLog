using System;
using Microsoft.EntityFrameworkCore;

namespace WorkoutLog.Models;

[Index(nameof(ExerciseName), IsUnique = true)]
public class Exercise
{
    public int Id { get; set; }
    public String ExerciseName { get; set; } = string.Empty;
    public String BodyPart { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime DeletedAt { get; set; }
    // public List<DailyWorkout> DailyWorkouts { get;} = [];
    public List<DailyWorkoutExercise> DailyWorkoutExercises { get;} = [];
}
