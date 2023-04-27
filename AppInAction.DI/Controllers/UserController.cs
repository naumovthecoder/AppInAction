using AppInAction.DI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AppInAction.DI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IEmailSender _emailSender;

        public UserController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        [HttpPost("register")]
        public IActionResult RegisterUser([FromBody]User user)
        {
            _emailSender.SendEmail(user.Name);
            return Ok("Email sent!");
        }
    }
    
    public class User
    {
        public string Name { get; set; }
    }
}