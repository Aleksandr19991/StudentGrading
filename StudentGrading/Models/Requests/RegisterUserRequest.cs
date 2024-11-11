namespace GradeBook.Models.Requests;
public class RegisterUserRequest
{
    public string Name { get; set; }
    public string Email { get; set; }
    public enum UserRole { Student, Teacher }
}