using GradeBook.Models.Responses;
using Microsoft.EntityFrameworkCore;

namespace StudentGrading.Models;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options)
    : base(options)
    {}
    public DbSet<CourseResponse> Courses { get; set; }
    public DbSet<UserResponse> Users { get; set; }
    public DbSet<UserWithCourseResponse> UserWithCourses { get; set; }
    
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("StudentGrading"));
    //}
}