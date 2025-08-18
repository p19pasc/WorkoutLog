using System;
using System.Data;

namespace WorkoutLog.Models;

public class DailyWorkout
{
    public int Id { get; set; }
    public TimeSpan WorkoutDuration { get; set; }
    public DateTime WorkoutDate { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    // public List<Exercise> Exercises { get; } = [];
    public List<DailyWorkoutExercise> DailyWorkoutExercises { get;} = [];
}
