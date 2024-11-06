using dotNet_Versioning_opgave__30_10_2024.Models;
using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;


namespace dotNet_Versioning_opgave__30_10_2024.Controllers.V2
{
  
    public class AchievementsController : Controller
    {
        [ApiController]
        [ApiVersion("2.0")]
        [Route("api/v{apiVersion:apiVersion}/[controller]")]
        public class AchievementsControllerV2 : ControllerBase
        {
            [HttpGet("{driverId}")]
            public ActionResult<DriverAchievementV2Response> GetDriverAchievements([FromBody] Guid driverId)
            {
                var response = new DriverAchievementV2Response
                {
                    FastestLap = 120,       
                    PolePosition = 5,
                    GrandPrixWins = 3,
                    DriverName = "Max Verstappen"
                };
                return Ok(response);
            }
        }
    }
}
