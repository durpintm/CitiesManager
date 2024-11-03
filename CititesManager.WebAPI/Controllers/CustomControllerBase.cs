using Microsoft.AspNetCore.Mvc;

namespace CititesManager.WebAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")] // UrlSegmentApiVersionReader
    //[Route("api/[controller]")] // QueryStringApiVersionReader
    public class CustomControllerBase : ControllerBase
    {
    }
}