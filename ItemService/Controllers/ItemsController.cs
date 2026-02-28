using Microsoft.AspNetCore.Mvc;

namespace ItemService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "Items service working 🔥" });
        }

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Ok(new { received = value });
        }
    }
}