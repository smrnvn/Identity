using Identity.BLL.DTOs;
using Identity.BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace Identity.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public async Task<ActionResult<bool>> Login(UserDTO user)
        {
            return Ok(await _userService.Login(user));
        }

        [HttpPost("registrate")]
        public async Task<ActionResult<RegistrationResult>> Registrate(UserDTO user)
        {
            return Ok(await _userService.Registrate(user));
        }   
    }
}