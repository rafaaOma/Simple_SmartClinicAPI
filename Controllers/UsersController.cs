using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartClinicAPI.Models;


namespace SmartClinicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService; //user service dependency

    public UsersController(IUserService userService) //constructor to initialaize user service dependency
    {
      _userService = userService;
    }
        [HttpGet]
        public IActionResult GetAllUsers() //get all users
        {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }
        
        [HttpGet("{id}")] 
        public IActionResult GetUserById(int id) //get user by id
        {
            var user = _userService.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        [HttpPost]
        public IActionResult CreateUser([FromBody] User user) //post new user
        {
            _userService.AddUser(user);
            return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id) //deletd user by id
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
