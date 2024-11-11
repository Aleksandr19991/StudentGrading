namespace GradeBook.Models.Responses;
public class UserWithCourseResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public enum UserRole { Student, Teacher }
    public List<CourseResponse> Courses { get; set; }
}