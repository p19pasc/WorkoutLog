namespace WorkoutLog.Dtos;

public record class DailyWorkoutExerciseDto
(   
    int DailyWorkoutId, 
    int ExerciseId, 
    int Sets, 
    int Reps, 
    double Weight
);
