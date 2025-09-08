namespace WorkoutLog.Dtos;

public record class ExerciseDto
(
    int Id, 
    String ExerciseName,
    String BodyPart,
    DateTime CreatedAt, 
    DateTime UpdatedAt, 
    DateTime DeletedAt,
    List<DailyWorkoutExerciseDto> DailyExercise
); 
