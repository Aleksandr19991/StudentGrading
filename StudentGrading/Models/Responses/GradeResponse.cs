namespace GradeBook.Models.Responses;
public class GradeResponse
{
    public Guid Id { get; set; }
    public CourseResponse Course { get; set; }
    public StudentResponse Student { get; set; }
    public double Grade { get; set; }
}