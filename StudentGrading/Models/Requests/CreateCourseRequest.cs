﻿namespace GradeBook.Models.Requests;
public class CreateCourseRequest
{
    public string Name { get; set; }
    public string Description { get; set; }
    public TimeOnly Hours { get; set; }
}