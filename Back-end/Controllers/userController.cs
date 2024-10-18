using Microsoft.AspNetCore.Mvc;



namespace talentum.Controller
{
    [Route("api/[controller]")]
    public class userController : ControllerBase
    {
        public userController()
        {

        }
        [HttpGet]
        public IActionResult getAll()
        {
            return null;
        }
    }
}