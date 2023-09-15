using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ninjaflex.Application.Interfaces;
using ninjaflex.Application.ViewModels;

namespace ninjaflex.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpGet("GetLogin")]
        [AllowAnonymous]
        public async Task<IActionResult> GetLogin(string? email, string? password, string? barCode)
        {
            ResponseViewModel response = new ResponseViewModel();

            response = await _loginService.GetLogin(email, password, barCode);

            return Ok(response);

        }
    }
}
