using Microsoft.AspNetCore.Mvc;
using dotNet_Versioning_opgave__30_10_2024.Models;
using Asp.Versioning;

namespace dotNet_Versioning_opgave__30_10_2024.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class AchievementsController : Controller
    {
        [HttpGet("{driverId}")]
        public ActionResult<DriverAchievementsV1Response> GetDriverAchievements([FromBody] Guid driverId)
        {
            var response = new DriverAchievementsV1Response
            {
                FastestLap = 120
            };
            return Ok(response);
        }
    }
}
