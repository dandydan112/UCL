using dotNet_Versioning_opgave__30_10_2024.Models;
using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;


namespace dotNet_Versioning_opgave__30_10_2024.Controllers.V3
{
    [ApiController]
    [ApiVersion("3.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class AchievementsControllerV3 : ControllerBase
    {
        [HttpGet]
        public ActionResult<DriverAchievementV3Response> GetDriverAchievements([FromBody] Guid driverId)
        {
            var response = new DriverAchievementV3Response
            {
                FastestLap = 120,      
                PolePosition = 5,       
                Wins = 3                
            };
            return Ok(response);
        }
    }
}
