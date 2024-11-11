using GradeBook.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GradeBook.Controllers
{
    [ApiController]
    [Route("api/grades")]
    public class GradesController : ControllerBase
    {
        // GET api/<CoursesController>/5
        [HttpGet("{id}")]
        public ActionResult<List<GradeResponse>> GetGradeByStudentId([FromRoute] Guid id)
        {
            var gradeStudent = new GradeResponse();
            return Ok(gradeStudent);
        }

        // PATCH api/<UsersController>/5
        [HttpPatch("{id}")]
        public IActionResult UpdateGradeByCourseId([FromRoute] Guid id)
        {
            return NoContent();
        }
    }
}