using Asp.Versioning;
using CititesManager.WebAPI.DatabaseContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CititesManager.WebAPI.Controllers.v2
{
    /// <summary>
    /// Cities Controller
    /// </summary>
    [ApiVersion(2.0)]
    public class CitiesController : CustomControllerBase
    {
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// Cities Constructor
        /// </summary>
        /// <param name="context"></param>
        public CitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Cities
        /// <summary>
        /// To get list of cities
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        //[Produces("application/xml")]
        public async Task<ActionResult<IEnumerable<string>>> GetCities()
        {
            return await _context.Cities.Select(c => c.CityName).ToListAsync();
        }
    }
}
