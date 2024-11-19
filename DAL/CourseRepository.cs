using GradeBook.Models.Responses;
using Microsoft.EntityFrameworkCore;
using StudentGrading.Models.Dtos;

namespace DAL
{
    public class CourseRepository
    {
        Context context = new();

        public void AddCourse(CourseDto course)
        {
            context.Courses.Add(course);
            context.SaveChanges();
        }

        public CourseDto GetCourseById(Guid CourseId)
        {
            var courseId = context.Courses.Where(c => c.Id == CourseId).FirstOrDefault();
            return courseId;
        }

        //public void EnrollStudentInCourse(StudentDto student, Guid userId) 
        //{
        //    student.Courses = context.Users.Where(u => u.Id == userId).Select(c => c.Courses).SingleOrDefault();
        //    context.Students.Add(student);
        //    context.SaveChanges();
        //}

        public IEnumerable<StudentDto> GetStudentsByCourseId(Guid courseId)
        {
            var students = context.Students.Include(s => s.Course).Where(c => c.Course.Id == courseId).FirstOrDefault();
            return context.Students.ToList();
        }
    }
}
