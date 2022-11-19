using Microsoft.AspNetCore.Mvc;

namespace DevagramCSharp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {




        [HttpPost]
        [AllowAnonymous]
        public IActionResult EfetuarLogin([FromBody] LoginController loginrequisicao)
        {
            try
            {

            }
            catch (Exception)
            {

            }
        }
    }
}
