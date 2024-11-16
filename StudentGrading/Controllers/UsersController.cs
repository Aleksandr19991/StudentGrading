using GradeBook.Models.Requests;
using Microsoft.AspNetCore.Mvc;
using StudentGrading.Models;

namespace GradeBook.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
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

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public ActionResult<UserRole> GetRoleByUserId([FromRoute] Guid id)
        {
            var role = new UserRole();
            return Ok(role);
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