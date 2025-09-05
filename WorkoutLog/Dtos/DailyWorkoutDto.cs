namespace WorkoutLog.Dtos;

public record class DailyWorkoutDto
(
    int Id, 
    TimeSpan WorkoutDuration, 
    DateTime WorkoutDate, 
    DateTime CreatedAt, 
    DateTime UpdatedAt, 
    DateTime? DeletedAt
);