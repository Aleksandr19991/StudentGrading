using GradeBook.Models.Requests;
using GradeBook.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GradeBook.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : Controller
    {
        // POST api/<UsersController>
        [HttpPost]
        public ActionResult<Guid> Register([FromBody] string value)
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

        // GET: api/<UsersController>
        [HttpGet]
        public ActionResult<List<UserResponse>> GetUsers()
        {
            return Ok();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public ActionResult<UserWithCourseResponse> GetUserById([FromRoute] Guid id)
        {
            var user = new UserWithCourseResponse();
            return Ok(user);
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