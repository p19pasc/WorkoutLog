using Microsoft.EntityFrameworkCore;
using WorkoutLog.Models;

public class WorkoutLogDbContext : DbContext
{
    public WorkoutLogDbContext(DbContextOptions<WorkoutLogDbContext> options)
        : base(options) { }

    // Parameterless constructor for EF Core tools (design-time)
    public WorkoutLogDbContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            // THOMAS-NSQS\\SQLEXPRESS
            "Server=DESKTOP-LDDF8CN;Database=WorkoutLogDb;Trusted_Connection=True;TrustServerCertificate=True;");
    }

    public DbSet<DailyWorkout> DailyWorkouts { get; set; }
    public DbSet<Exercise> Exercises { get; set; }
    public DbSet<DailyWorkoutExercise> DailyWorkoutExercises { get; set; }
}
