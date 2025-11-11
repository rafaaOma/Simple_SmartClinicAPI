using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartClinicAPI.Models;


namespace SmartClinicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
      _userService = userService;
    }
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }
        //return a single user by ID
        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = _userService.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            _userService.AddUser(user);
            return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var userDeleted = _userService.DeleteUser(id);
            if (!userDeleted)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
