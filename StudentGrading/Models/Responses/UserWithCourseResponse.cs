﻿using StudentGrading.Models;

namespace GradeBook.Models.Responses;
public class UserWithCourseResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public UserRole Role { get; set; }
    public List<CourseResponse> Courses { get; set; }
}