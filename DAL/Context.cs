using Microsoft.EntityFrameworkCore;
using StudentGrading.Models.Dtos;

namespace DAL;

public class Context : DbContext
{
    public DbSet<UserDto> Users { get; set; }
    public DbSet<UserRoleDto> UserRoles { get; set; }
    public DbSet<CourseDto> Courses { get; set; }
    public DbSet<StudentDto> Students { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("StudentGrading"));
    }
}
