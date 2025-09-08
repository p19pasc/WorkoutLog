namespace WorkoutLog.Dtos;

public record class DailyWorkoutDto
(
    int Id, 
    int WorkoutDuration, 
    DateTime WorkoutDate, 
    DateTime CreatedAt, 
    DateTime UpdatedAt, 
    DateTime? DeletedAt,
    List<DailyWorkoutExerciseDto> DailyWorkoutExercises
);