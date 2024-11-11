using GradeBook.Models.Requests;
using GradeBook.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GradeBook.Controllers
{
    [ApiController]
    [Route("api/courses")]
    public class CoursesController : ControllerBase
    {
        // POST api/<CoursesController>
        [HttpPost]
        public ActionResult<Guid> CreateCourse([FromBody] string value)
        {
            var addedCourseId = Guid.NewGuid();
            return Ok(addedCourseId);
        }

        // GET: api/<CoursesController>
        [HttpGet]
        public ActionResult<List<CourseResponse>> GetCourses()
        {
            var course = new List<CourseResponse>();
            return course.ToList();
        }

        // GET api/<CoursesController>/5
        [HttpGet("{id}")]
        public ActionResult<List<UserWithCourseResponse>> GetCourseByUserId([FromRoute] Guid id)
        {
            var course = new UserWithCourseResponse();
            return Ok(course);
        }

        // PUT api/<CoursesController>/5
        [HttpPut("{id}")]
        public IActionResult UpdateCourse([FromRoute] Guid id, [FromBody] UpdateUserRequest request)
        {
            return NoContent();
        }

        // PATCH api/<UsersController>/5
        [HttpPatch("{id}/deactivate")]
        public IActionResult DeactivateCourse([FromRoute] Guid id)
        {
            return NoContent();
        }

        // DELETE api/<CoursesController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCourse([FromRoute] Guid id)
        {
            return NoContent();
        }
    }
}