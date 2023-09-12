using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ninjaflex.Application.Interfaces;
using ninjaflex.Application.Services;
using ninjaflex.Application.ViewModels;

namespace ninjaflex.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTypeController : ControllerBase
    {
        private readonly IUserTypeService _userTypeService;

        public UserTypeController(IUserTypeService userTypeService)
        {
            _userTypeService = userTypeService;
        }

        [HttpGet("GetUserTypes")]
        [Authorize]
        public async Task<IActionResult> GetUserTypes()
        {
            ResponseViewModel response = new ResponseViewModel();

            response = await _userTypeService.GetUserTypes();

            return Ok(response);

        }

        [HttpGet("GetUserTypeById/{id}")]
        [Authorize]
        public async Task<IActionResult> GetUserTypeById(int id)
        {
            ResponseViewModel response = new ResponseViewModel();

            if (id == 0)
                return Ok(new ResponseViewModel { Error = "Não foi possível encontrar o tipo do usuário!", Success = false });

            response = await _userTypeService.GetUserTypeById(id);

            return Ok(response);

        }

        [HttpPut("PutUserType")]
        [Authorize]
        public async Task<ActionResult<UserTypeViewModel>> PutUserType([FromBody] UserTypeViewModel useTyperViewModel)
        {
            ResponseViewModel response = new ResponseViewModel();

            if (useTyperViewModel == null)
                return Ok(new ResponseViewModel { Error = "Não foi possível encontrar o tipo do usuário!", Success = false });

            response = await _userTypeService.PutUserType(useTyperViewModel);

            return Ok(response);
        }

        [HttpPost("PostUserType")]
        [Authorize]
        public async Task<ActionResult<UserTypeViewModel>> PostUserType([FromBody] UserTypeViewModel useTyperViewModel)
        {
            ResponseViewModel response = new ResponseViewModel();

            if (useTyperViewModel == null)
                return Ok(new ResponseViewModel { Error = "Não foi possível encontrar o tipo do usuário!", Success = false });

            response = await _userTypeService.PostUserType(useTyperViewModel);

            return Ok(response);
        }
    }
}
