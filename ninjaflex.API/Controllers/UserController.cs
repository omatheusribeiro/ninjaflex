using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ninjaflex.Application.Interfaces;
using ninjaflex.Application.ViewModels;

namespace ninjaflex.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetUsers")]
        [Authorize]
        public async Task<IActionResult> GetUsers()
        {
            ResponseViewModel response = new ResponseViewModel();

            response = await _userService.GetUsers();

            return Ok(response);

        }

        [HttpGet("GetUserById/{id}")]
        [Authorize]
        public async Task<IActionResult> GetUserById(int id)
        {
            ResponseViewModel response = new ResponseViewModel();

            if (id == 0)
                return Ok(new ResponseViewModel { Error = "Não foi possível encontrar o usuário!", Success = false });

            response = await _userService.GetUserById(id);

            return Ok(response);

        }

        [HttpPut("PutUser")]
        [Authorize]
        public async Task<ActionResult<UserViewModel>> PutUser([FromBody] UserViewModel userViewModel)
        {
            ResponseViewModel response = new ResponseViewModel();

            if (userViewModel == null)
                return Ok(new ResponseViewModel { Error = "Não foi possível encontrar o usuário!", Success = false });

            response = await _userService.PutUser(userViewModel);

            return Ok(response);
        }

        [HttpPost("PostUser")]
        [Authorize]
        public async Task<ActionResult<UserViewModel>> PostUser([FromBody] UserViewModel userViewModel)
        {
            ResponseViewModel response = new ResponseViewModel();

            if (userViewModel == null)
                return Ok(new ResponseViewModel { Error = "Não foi possível encontrar o usuário!", Success = false });

            response = await _userService.PostUser(userViewModel);

            return Ok(response);
        }
    }
}
