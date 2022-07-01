using ASPNetCoreMastersToDoList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ASPNetCoreMastersToDoList.Controllers
{
    [Route("users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly Authentication _authentication;

        public UsersController(IOptions<Authentication> options)
        {
            _authentication = options.Value;
            var securityKey = _authentication.SecurityKey;
            var issuer = _authentication.Issuer;
            var audience = _authentication.Audience;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return Ok(_authentication.SecurityKey);
        }
    }
}
