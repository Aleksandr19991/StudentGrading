using GradeBook.Models.Requests;
using GradeBook.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GradeBook.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        // POST api/<UsersController>
        [HttpPost]
        public ActionResult<Guid> RegisterUser([FromBody] string value)
        {
            var addedUserId = Guid.NewGuid();
            return Ok(addedUserId);
        }

        // "api/users/login"
        [HttpPost("login")]
        public IActionResult LogIn([FromBody] LoginRequest request)
        {
            return Ok();
        }

        //[HttpGet(":id/userResponse")]
        //public ActionResult<UserResponse> GetRoleByUserId([FromRoute] Guid id)
        //{
        //    var role = new UserResponse();
        //    return Ok(role);
        //}

        // GET api/<UsersController>/5
        [HttpGet(":id/courses")]
        public ActionResult<List<UserWithCourseResponse>> GetCoursesByUserId([FromRoute] Guid id)
        {
            var course = new List<UserWithCourseResponse>();
            return course.ToList();
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public IActionResult UpdateUser([FromRoute] Guid id, [FromBody] UpdateUserRequest request)
        {
            return NoContent();
        }

        // PATCH api/<UsersController>/5
        [HttpPatch("{id}/deactivate")]
        public IActionResult DeactivateUser([FromRoute] Guid id)
        {
            return NoContent();
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteUser([FromRoute] Guid id)
        {
            return NoContent();
        }
    }
}