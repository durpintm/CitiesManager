using Microsoft.AspNetCore.Mvc;

namespace CititesManager.WebAPI.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class CustomControllerBase : ControllerBase
    {
    }
}